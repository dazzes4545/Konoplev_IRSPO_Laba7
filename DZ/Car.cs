using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Car
    {
        public string Model;
        public int Speed;
        public int MaxSpeed;

        public Car(string model, int maxSpeed)
        {
            this.Model = model;
            this.MaxSpeed = maxSpeed;
            this.Speed = 0;  
        }

        public void Accelerate(int delta)
        {
            if (this.Speed + delta <= this.MaxSpeed)
            {
                this.Speed += delta;
            }
            else
            {
                this.Speed = this.MaxSpeed;
            }
            Console.WriteLine($"Модель: {this.Model}, Текущая скорость: {this.Speed} км/ч");
        }

        public void Brake()
        {
            this.Speed = 0;
            Console.WriteLine($"После торможения: {this.Speed} км/ч");
        }
    }
}
