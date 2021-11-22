using Hangfire;
using Investment.Core.Interfaces;
using System.Threading.Tasks;

namespace Investment.Api.Service
{
    public class BackgroudJobs
    {
        private readonly IBackgroudJobService _backgroudJobService;

        public BackgroudJobs(IBackgroudJobService backgroudJobService)
        {
            _backgroudJobService = backgroudJobService;
        }
        public void StartJobs()
        {
            RecurringJob.AddOrUpdate(() => VerifyDeposit(), "*/30 * * * * *");
        }

        public async Task VerifyDeposit()
        {
            await _backgroudJobService.VerifyDeposits();
        }
    }
}
