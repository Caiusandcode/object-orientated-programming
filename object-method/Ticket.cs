using System;
using System.Collections.Generic;
using System.Text;

namespace Task_lippu
{
    class Ticket
    {
        public double Basicprice = 16;

        private string _name = null;
        private int _age = 0;
        public bool Student = false;
        public bool Conscript = false;
        public bool Mtkmember = false;

        public Ticket(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool IsStudent
        {
            get { return Student; }
            set { Student = value; }
        }

        public bool IsConscript
        {
            get { return Conscript; }
            set { Conscript = value; }
        }

        public bool IsMtkmember
        {
            get { return Mtkmember; }
            set { Mtkmember = value; }
        }

        public double Whatprice()
        {
            double price = Basicprice;

            if (Age < 7)
            {
                price = 0.00f;
            }
            else if (IsMtkmember && IsStudent)
            {
                price *= 0.40f;
            }
            else if (Age >= 65)
            {
                price *= 0.50f;
            }
            else if (Age <= 15)
            {
                price *= 0.50f;
            }
            else if (IsConscript)
            {
                price *= 0.50f;
            }
            else if (IsStudent)
            {
                price *= 0.55f;
            }
            else if (IsConscript)
            {
                price *= 0.85f;
            }

            else
            {

            }

            return price;

        }
    }
}
