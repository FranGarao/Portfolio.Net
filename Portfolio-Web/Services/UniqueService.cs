namespace Portfolio_Web.Services
{
    public class SingletonService
    {
        public SingletonService()
        {
            GetGuid = Guid.NewGuid();
        }
        public Guid GetGuid { get; private set; }
    }    

    public class ScopedService
    {
        public ScopedService()
        {
            GetGuid = Guid.NewGuid();
        }
        public Guid GetGuid { get; private set; }
    }    

    public class TransientService
    {
        public TransientService()
        {
            GetGuid = Guid.NewGuid();
        }
        public Guid GetGuid { get; private set; }
    }
}
