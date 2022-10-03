namespace tech_test_payment.UoW.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        Task<bool> Commit();
        Task Roolback();
    }
}