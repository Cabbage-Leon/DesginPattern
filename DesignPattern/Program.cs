using System;
using DesignPattern.AdapterPattern;
using DesignPattern.BuilderPattern;
using DesignPattern.CommandPattern;
using DesignPattern.CompositePattern;
using DesignPattern.DecoratorPatten;
using DesignPattern.FacadePattern;
using DesignPattern.FlyweightPattern;
using DesignPattern.ObserverPattern;
using DesignPattern.ProxyPattern;
using DesignPattern.ResponsibilityPattern;
using DesignPattern.SimpleFactoryPattern;
using DesignPattern.StatePattern;
using DesignPattern.StrategyPattern;
using DesignPattern.TemplateMethod;
using System.ComponentModel;
using DesignPattern.MediatorPattern;
using DesignPattern.IteratorPattern;
using DesignPattern.VisitorPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //创建型
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
            //结构型
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

                ////具体Decorator => Decorator => IPhone  里式替换原则
                ////买个苹果手机
                //IPhone phone = new ApplePhone();

                //// 现在想贴膜了
                //IPhone decorator = new Sticker(phone);
                //decorator.Photo();

                ////想挂件
                //IPhone decorator1 = new Accessories(phone);
                //decorator1.Photo();

                //// 现在我同时有贴膜和手机挂件了
                //IPhone sticker = new Sticker(phone);
                //IPhone applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
                //applePhoneWithAccessoriesAndSticker.Photo();

            }
            //外观者模式
            {
                //Facade f = new Facade();
                //f.Method();
            }
            //享元模式
            {
                //FlyweightFactory factory = new FlyweightFactory();
                //IFlyweight f01 = factory.GetFlyweight("a");
                //IFlyweight f02 = factory.GetFlyweight("a");
                //IFlyweight f03 = factory.GetFlyweight("a");
                //IFlyweight f11 = factory.GetFlyweight("b");
                //IFlyweight f12 = factory.GetFlyweight("b");
                //f01.Operation(new UnsharableFlyweight("第1次调用a。"));
                //f02.Operation(new UnsharableFlyweight("第2次调用a。"));
                //f03.Operation(new UnsharableFlyweight("第3次调用a。"));
                //f11.Operation(new UnsharableFlyweight("第1次调用b。"));
                //f12.Operation(new UnsharableFlyweight("第2次调用b。"));
            }
            //组合模式
            {
                ////叶子内部不维护集合，枝干内部维护一个集合
                //CompositePattern.IComponent c0 = new Composite();
                //CompositePattern.IComponent c1 = new Composite();
                //CompositePattern.IComponent leaf1 = new Leaf("1");
                //CompositePattern.IComponent leaf2 = new Leaf("2");
                //CompositePattern.IComponent leaf3 = new Leaf("3");
                //c0.Add(leaf1);
                //c0.Add(c1);
                //c1.Add(leaf2);
                //c1.Add(leaf3);
                //c0.Operation();
            }
            //行为型-子类，实现类更多的关注的是行为方法的实现
            //模板方法
            {
                //抽象类构建了架子，实现类填充具体的
                //AbsClass absClass = new ConcreteClass();
                //absClass.TemplateMethod();
            }
            //策略模式
            {
                //ConcreteStrategyA concreteStrategyA = new ConcreteStrategyA();
                //Context context = new Context(concreteStrategyA);
                //context.StrategyMethod();
                //context.StrategyMethod(new ConcreteStrategyB());
            }
            //命令模式
            {
                ////调用和实现解耦，总共包2层，A包B，B包了C， A的方法C具体实现，B处在中间
                ////外部传入receiver
                //Receiver receiverA = new Receiver();
                //ConcreteCommand commandA = new ConcreteCommand(receiverA);
                //Invoker invokerA = new Invoker(commandA);
                //invokerA.Call();

                ////内部实现receiver
                //ConcreteCommand command = new ConcreteCommand();
                //Invoker invoker = new Invoker(command);
                //invoker.Call();
            }
            //责任链模式
            {
                //和自己人玩
                //类似模板方法 Handler实现了架构和公共方法实现。 具体Handler只关注他具体的行为,包一层包的是自己的抽象
                //这个链模式是一种接龙上层指定，A-》B-》C 一直下去 ，状态模式更加灵活可以仍以顺序，内部指定
                //责任链没有上下文和自己玩。 状态模式有上下文，都和上下文玩。
                //Handler handler1 = new ConcreteHandler();
                //Handler handler2 = new ConcreteHandler2();
                //handler1.SetNext(handler2);
                //handler1.HandleRequest("two");
            }
            //状态模式
            {
                ////都和上下文玩
                ////状态模式的关键点：互相包含对方
                ////第一种构造方式，外部初始化
                ////ScoreContext scoreContext = new ScoreContext();
                ////State state = new ConcreteStateA(scoreContext);
                ////scoreContext.State = state;

                ////ScoreContext内部初始化
                //ScoreContext scoreContext = new ScoreContext();
                ////上下文进行变化， 内部实现了状态改变！外部完全看不见
                ////状态的改变，内部已经固定化，路线已经预先规划好 比如优秀-良好-不及格  也可以闭环
                ////一个状态处理完之后如果状态变化需要变更context中的state！
                //scoreContext.Add(10);
                //scoreContext.Add(15);
                //scoreContext.Add(20);
                //scoreContext.Add(30);
                //scoreContext.Add(13);
                //scoreContext.Add(10);

            }
            //观察者模式
            {
                ////被观察着 带着观察者玩
                ////一个动作，所有的观察者都做出了反应
                //Rate rate = new RMBrate();
                //rate.Add(new ExportCompany());
                //rate.Add(new ImportCompany());
                //rate.Change(10);
            }
            //中介者模式
            {
                //// 中介和客户互相玩
                ////中介 和 客户之间互相拥有对方
                //Colleague colleague1 = new ConcreteColleague(1);
                //Colleague colleague2 = new ConcreteColleague(2);
                //Colleague colleague3 = new ConcreteColleague(3);
                //Mediator mediator = new ConcreteMediator();
                //mediator.Register(colleague1);
                //mediator.Register(colleague2);
                //mediator.Register(colleague3);
                //colleague1.Send("2就是个弟弟");
            }
            //迭代器模式
            {
                ////内部集合是什么样子没有暴露出来，完全不知道里面是啥
                ////内部维护了一个集合
                //IAggregate<string> aggregate = new ConcreteAggregate<string>();
                //aggregate.Add("1");
                //aggregate.Add("2");
                //aggregate.Add("3");
                //aggregate.Add("4");
                //aggregate.Add("5");
                ////把内部集合传给了迭代器
                //ITerator<string> terator =  aggregate.GetIterator();
                //while (terator.HasNext())
                //{
                //    string ob = terator.Next();
                //    Console.WriteLine(ob);
                    
                //}
                //string  first = terator.First();
                //Console.WriteLine(first);
            }
            //访问者模式
            {
                //Structure structure = new Structure();
                //ConcreteElement elementA = new ConcreteElement();
                //ConcreteElementB elementB = new ConcreteElementB();
                //Visitor visitorA = new ConcreteVisitor();
                //Visitor visitorB = new ConcreteVisitorB();
                //structure.Add(elementA);
                //structure.Add(elementB);
                ////访问者主动访问
                //visitorA.Visit(elementA);
                //visitorB.Visit(elementB);
                //Console.WriteLine("=================");
                ////主动接受访问
                //elementA.Accept(visitorB);
                //elementB.Accept(visitorA);
                //Console.WriteLine("=================");
                ////架构访问 访问者逐个访问
                //structure.Accept(visitorA);
            }
            Console.ReadKey();
        }
    }
}
