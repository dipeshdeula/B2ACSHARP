namespace fullStackOops.Destructor
{
    public class MyResource : IDisposable
    {
        private bool disposed = false; // To detect redudant class

        //Example of unmanaged resource
        private IntPtr unmanagedResource;

        //constructor
        public MyResource()
        {
            //Allocate unmanaged resource
            unmanagedResource = IntPtr.Zero; //Assume some unmanaged resources is allocated here
            Console.WriteLine("Resource allocated");
        }
        //Implement IDiposabel
        public void Dispose()
        {
            Dispose(true);
            //suppose finalization since the resources are already disposes
            GC.SuppressFinalize(this);
        }

        //protected implementation of Dispose pattern
        protected virtual void Dispose(bool disposing)
        {
            //check if Dispose has already been called
            if (!disposed)
            {
                if (disposing)
                {
                    //free any managed objects here if necessary

                }
                //free unmanaged resources here
                if (unmanagedResource != IntPtr.Zero)
                {
                    //Relase the unmanaged resource
                    unmanagedResource = IntPtr.Zero;
                    Console.WriteLine("Unmanaged resource received");
                }

                disposed = true;
            }

        }
        //Destructor
        ~MyResource()
        {
            //Finalizer calls Dispose(false)
            Dispose(false);

        }

    }
}
