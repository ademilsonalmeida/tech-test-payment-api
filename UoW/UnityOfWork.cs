using tech_test_payment.Contexts;
using tech_test_payment.UoW.Interfaces;

namespace tech_test_payment.UoW
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly DataContext _context;

        public UnityOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            var success = (await _context.SaveChangesAsync()) > 0;

            // Possibility to dispatch domain events, etc

            return success;
        }        

        public Task Roolback()
        {   
            // Rollback anything, if necessary

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}