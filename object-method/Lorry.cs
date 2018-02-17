using System;


namespace Vechile
{
    class Lorry : Vehicle
    {
        private double _LoadWeight;
        private double _consumptionKg;

        public Lorry(string type, string brand, int year, double price, double loadweight, double consumptionKg) : base(type, brand, year, price)
        {
            _LoadWeight = loadweight;
            _consumptionKg = consumptionKg;
        }

        public Lorry(string type, string brand, int year, double price, double engine, string model, int doors) : base(type, brand, year, price)
        {
        }

        public double LoadWeight
        {
            get { return _LoadWeight; }
            set   { _LoadWeight = value; }
        }

        public double ConsumptionKg
        {
            get { return _consumptionKg; }
            set { _consumptionKg = value; }
        }

        private double CountConsumption()
        {
            return LoadWeight * ConsumptionKg;
        }

        public new string PrintInformation()
        {
            return $"{base.PrintInformation()}\n" +
                   $"Kuorman paino:\t{LoadWeight} kg\n" +
                   $"Kulutus/Kg:\t{ConsumptionKg} l/kg\n" +
                   $"Kulutus:\t {CountConsumption()} l\n" +
                   $"*************************\n";
        }


    }
}

