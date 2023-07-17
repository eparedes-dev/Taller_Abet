﻿using DesignPatterns.Models;
using System.Runtime.CompilerServices;

namespace DesignPatterns.ModelBuilder
{
    public class CarBuilder
    {
        public string Brand = "Ford";
        public string Model = "Mustang";
        public string Color = "Red";

        public CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }


        public Car Build()
        {
            return new Car(Color, Brand, Model);
        }
    }
}
