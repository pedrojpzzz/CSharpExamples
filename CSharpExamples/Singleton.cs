namespace CSharpExamples
{
    public class Singleton
    {
        private Singleton singletonInstance;

        private string mySingletonInfo;

        private Singleton()
        {
            mySingletonInfo = "my Singleton Instance";
        }

        public Singleton GetInstante()
        {
            if (singletonInstance.Equals(null))
            {
                singletonInstance = new Singleton();
            }

            return singletonInstance;
        }
    }
}
