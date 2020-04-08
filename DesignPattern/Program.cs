using DesignPattern.AdapterPattern;
using DesignPattern.BuilderPattern;
using DesignPattern.DecoratorPatten;
using DesignPattern.FacadePattern;
using DesignPattern.ProxyPattern;
using DesignPattern.SimpleFactoryPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //单例
            {
                //HungrySingleton hungrySingleton = HungrySingleton.GetInstance();
                //LazySingleton lazySingleton = LazySingleton.GetInstance();
            }
            //原型
            {
                //Realizetype realizetype = new Realizetype();
                //var clone = realizetype.Clone();
            }
            //简单方法
            {
                //AbstractFactory concreteFactory1 = new ConcreteFactory1();
                //concreteFactory1.CreateProduct();
                //AbstractFactory concreteFactory2 = new ConcreteFactory2();
                //concreteFactory2.CreateProduct();
            }
            //抽象工厂
            {

                //AbstractFactory1 concreteFactory1 = new ConcreteFactory11();
                //concreteFactory1.CreateProduct1();
                //concreteFactory1.CreateProduct2();
                //AbstractFactory1 concreteFactory2 = new ConcreteFactory12();
                //concreteFactory2.CreateProduct1();
                //concreteFactory2.CreateProduct2();

            }
            //建造者模式
            {
                //Director director = new Director(new GoodBulider());
                //ComplexHouse house = director.Construct();

                ////简单的情况可以不用Director 直接自己build
                //BadBulider bulider = new BadBulider();
                //bulider.One();
                //bulider.Two();
                //bulider.Three();
                //bulider.GetComplexHouse();
            }
            //简单工厂
            {
                //SimpleFactory.GetInstance();
            }
            //代理模式
            {
                //    RealSubject realSubject = new RealSubject();
                //    Proxy proxy = new Proxy(realSubject);
                //    proxy.Request();

            } 
            //适配器模式
            {
                //    ITarget adapter = new Adapter();
                //    adapter.Request();
                //    //adapter.SepcialRequest();

                //内置构造
                //ITarget target = new ObjectAdater();
                //target.Request();

                //构造函数构造
                //ITarget target = new ObjectAdater(new Adaptee());
                //target.Request();

                //属性构造，容易出错
                //ITarget target = new ObjectAdater() {
                //    Adaptee = new Adaptee()
                //};
                //target.Request();
            }
            //装饰者模式
            {
                ////买个苹果手机
                //IPhone phone = new ApplePhone();

                //// 现在想贴膜了
                //Decorator decorator = new Sticker(phone);
                //decorator.Photo();

                ////想挂件
                //Decorator decorator1 = new Accessories(phone);
                //decorator1.Photo();

                //// 现在我同时有贴膜和手机挂件了
                //Decorator sticker = new Sticker(phone);
                //Decorator applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
                //applePhoneWithAccessoriesAndSticker.Photo();

            }
            //外观者模式
            {
                //Facade f = new Facade();
                //f.Method();
            }
            //享元模式
            {
                
            }
            Console.ReadKey();
        }
    }
}
