using System;
using System.Collections.Generic;
using System.Text;

namespace Vechile
{
     class Car : Vehicle
    {
        private double _Engine;
        private string _model;
        private double _Doors;

        public Car(string type, string brand, int year, double price, double engine, string model, double doors) : base(type, brand, year, price)
        {
            _Engine = engine;
            _model = model;
            _Doors = doors;
        }

        public double Engine
        {
            get {return _Engine;}
            set {_Engine = value;}
        }
        
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public double Doors
        {
            get { return _Doors; }
            set { _Doors = value; }
        }
        public new string PrintInformation()
        {
            return $"{base.PrintInformation()}\n" +
                   $"Engine {_Engine}\n" +
                   $"Model {_model} \n" +
                   $"Doors {_Doors}\n" +
                   $"____________________\n";
        }
        
    }
}
