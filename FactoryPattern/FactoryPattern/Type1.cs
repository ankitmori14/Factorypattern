namespace FactoryPattern
{
    /// <summary>
    /// Mobile abstract
    /// </summary>
    abstract class Mobile
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract int Qauntity { get; set; }
    }

    /// <summary>
    /// Mobile Implementation
    /// </summary>
    class MobileType : Mobile
    {
        private string _name;
        private string _type;
        private int _qauntity;

        public MobileType()
        {
            _name = "Samsung";
            _type = "Samsung J7-6";
            _qauntity = 2;
        }

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override int Qauntity
        {
            get { return _qauntity; }
            set { _qauntity = value; }
        }


    }

    /// <summary>
    /// Television abstract
    /// </summary>
    abstract class Television
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract int ScreenSize { get; set; }
    }

    /// <summary>
    /// television implementation
    /// </summary>
    class TelevisionType : Television
    {
        private string _name;
        private string _type;
        private int _screenSize;

        public TelevisionType()
        {
            _name = "Sammsung";
            _type = "Television";
            _screenSize = 42;
        }

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override int ScreenSize
        {
            get { return _screenSize; }
            set { _screenSize = value; }
        }


    }

    /// <summary>
    /// electronic abstract factory
    /// </summary>
    abstract class ElectronicsFactoryAbstract
    {
        public abstract Mobile GetMobile();

        public abstract Television GetTelevision();
    }

    /// <summary>
    /// electronic factory
    /// </summary>
    class ElectronicsFactory : ElectronicsFactoryAbstract
    {
        public override Mobile GetMobile()
        {
            return new MobileType();
        }

        public override Television GetTelevision()
        {
            return new TelevisionType();
        }
    }
}
