namespace DesignPattern.SingletonPattern
{
    public class HungrySingleton
    {
        private static HungrySingleton _Instance = new HungrySingleton();
        private HungrySingleton() { }
        public static HungrySingleton GetInstance()
        {
            return _Instance;
        } 
    }
}
