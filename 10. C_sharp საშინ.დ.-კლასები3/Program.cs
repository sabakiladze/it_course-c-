namespace _10._C_sharp_საშინ.დ._კლასები3
{
    public abstract class Musical_instrument
    {
        private string _name;
        public Musical_instrument(string name)
        {
            _name = name;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }

        }

        public  void Sound()
        {
            Console.WriteLine($"{Name} sound");
        }

        public  void Show()
        {
            Console.WriteLine(Name);
        }
        
        public virtual void Desc()
        { }
        public virtual void History()
        { }
    }
    public class Violin : Musical_instrument
    {
       
            public Violin(string name) : base(name) { }

           

            public override void Desc()
            {
                Console.WriteLine("Violin is a string musical instrument played with a bow.");
            }

            public override void History()
            {
                Console.WriteLine("The violin originated in Italy during the 16th century.");
            }
    }


    public class Ukulele : Musical_instrument
    {
        public Ukulele(string name) : base(name) { }

       

        public override void Desc()
        {
            Console.WriteLine("Ukulele is a small string instrument from Hawaii.");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele became popular in Hawaii in the 19th century.");
        }
    }
    public class Cello : Musical_instrument
    {
        public Cello(string name) : base(name) { }

        

        public override void Desc()
        {
            Console.WriteLine("Cello is a large bowed string instrument.");
        }

        public override void History()
        {
            Console.WriteLine("The cello was developed in Europe during the 16th century.");
        }
    }
    public class Trombone : Musical_instrument
    {
        public Trombone(string name) : base(name) { }

        
        public override void Desc()
        {
            Console.WriteLine("Trombone is a brass wind instrument.");
        }

        public override void History()
        {
            Console.WriteLine("The trombone appeared in the 15th century and evolved from the sackbut.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Stradivarius");
            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();

            Cello cello = new Cello("Yamaha Cello");
            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();


        }

    }
}
