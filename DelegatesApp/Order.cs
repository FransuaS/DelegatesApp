using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesApp
{
    class Order
    {
        private string name;
        private int coffee;
        private int donuts;

        public Order(string name, int coffee, int donuts)
        {
            this.name = name;
            this.coffee = coffee;
            this.donuts = donuts;
        }

        public string Name { get => name; set => name = value; }
        public int Coffee { get => coffee; set => coffee = value; }
        public int Donuts { get => donuts; set => donuts = value; }

        public double calculated()
        {
            return (this.donuts * 12) + (this.coffee * 15);
        }
    }
}