using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IBackgroudJobService
    {
        Task VerifyDeposits();
    }
}
