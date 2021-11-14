using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.Queries;
using Test.NotificationScheduling.Infrastructure.Contexts;

namespace Test.NotificationScheduling.Infrastructure.V1.Companies
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly NotificationSchedulingContext _context;

        public CompanyRepository(NotificationSchedulingContext context)
        {
            _context = context;
        }

        public async ValueTask<Guid> Create(Company company)
        {
            await _context.AddAsync(company);
            await _context.SaveChangesAsync();
            return company.Id;
        }

        public async ValueTask<CompanyResponse> GetByIdAsync(Guid requestId)
        {
            return await _context.Companies.AsNoTracking().Select(
                c => new CompanyResponse
                {
                    CompanyId = c.Id,
                    Notifications = c.Notifications.Select(n => n.SendingDate.Value.Date.ToString("dd/MM/yyyy"))
                }).FirstOrDefaultAsync(c => c.CompanyId == requestId);
        }
    }
}