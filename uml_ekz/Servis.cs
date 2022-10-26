using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace uml_ekz
{
    public class Menu
    {
        public Menu() 
        { GeneralMenu_Fasad(); }
        public void GeneralMenu_Fasad()
        {
            WriteLine("регистрация");
            WriteLine("вход");
            WriteLine("выход");

        }
        public void MenuRegistration_SubFasadA() // меню администратора
        {
            SubSystem();
            SubSystem1();
            SubSystem2();
            SubSystem3();
        }
        public void MenuRegistration_SubFasadU() // меню пользователя
        {
            SubSystem1();
            SubSystem2();
            SubSystem3();
        }

        public void SubSystem() // редактировать пользователей
        {
            WriteLine("редактируем пользователей");
        }
        public void SubSystem1() //создать базу адресатов
        {
            WriteLine("создаем базу адресов");
        }
        public void SubSystem2() //отправить рассылку
        {
            WriteLine("собираем пакет");
        }
        public void SubSystem3() //собрать пакет
        {
            WriteLine("отправляем рассылку");
        }

    }

    class Registration
    {
        void Main()
        {
            Builder_User builder = new ConcreteUser();
            Director director = new Director(builder);
            director.Construct();
            User product = builder.GetResult();
        }
    }
    class Director
    {
        Builder_User builder_user;
        public Director(Builder_User builder)
        {
            this.builder_user = builder;
        }
        public void Construct()
        {
            builder_user.BuildPartAdmin();
            builder_user.BuildPartUser();
          
        }
    }

    abstract class Builder_User
    {
        public abstract void BuildPartAdmin();
        public abstract void BuildPartUser();
       
        public abstract User GetResult();
    }

    class User
    {
        List<object> accessRights = new List<object>();
        public void Add(string part)
        {
            accessRights.Add(part);
        }
    }

    class ConcreteUser : Builder_User
    {
        User ConcretUser = new User();
        public override void BuildPartAdmin()
        {
            ConcretUser.Add("права администратора");
        }
        public override void BuildPartUser()
        {
            ConcretUser.Add("основные права");
        }
       
        public override User GetResult()
        {
            return ConcretUser;
        }
    }

    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
    class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;
        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update();
        }
    }

    interface IObserver
    {
        void Update();
    }
    class ConcreteObserver : IObserver
    {
        public void Update()
        {
        }
    }

    public class Database
    {
        List<string> address;
       
        Database()
        {
            address = new List<string>();
        }
    }



    internal class Servis
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

        }
    }
}
