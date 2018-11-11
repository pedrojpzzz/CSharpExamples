namespace CSharpExamples
{
    public class Singleton
    {
        private Singleton singleton;

        private string mySingletonInfo;

        private Singleton()
        {
            mySingletonInfo = "my Singleton Instance";
        }

        public Singleton GetInstante()
        {
            if (singleton.Equals(null))
            {
                singleton = new Singleton();
            }

            return singleton;
        }
    }
}
