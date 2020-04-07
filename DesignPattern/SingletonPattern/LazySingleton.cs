namespace DesignPattern.SingletonPattern
{
    public class LazySingleton
    {
        private static volatile LazySingleton _Instance = null;
        private LazySingleton() { }

        public static LazySingleton GetInstance()
        {
            if (_Instance == null)
                _Instance = new LazySingleton();
            return _Instance;
        }
    }
}
