using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр8
{
    interface IShip
    { 
        int Length { get;}
        string Name { get; set; }
        int Width { get;}
        int Height { get;}
        string GetInfo();
    }

    interface ICargoTransport
    {
        int Length { get; }
        string Name { get; set; }
        int Width { get; }
        int Height { get; }
        int LiftingCapacity { get;}
        string GetInfo();
    }

    public class CargoShip : IComparable<CargoShip>, IShip, ICargoTransport, ICloneable
    {
        public int Length { get;} 
        public string Name { get; set; }
        public int Width { get;}
        public int Height { get;}
        public int LiftingCapacity { get;}
        public int CompareTo(CargoShip other)
        {
            if (other == null) return 1;
            return LiftingCapacity.CompareTo(other.LiftingCapacity);
        }

        public CargoShip (int length, int width, int height, string name, int lifting)
        {
            Length = length;
            Width = width;
            Height = height;
            Name = name;
            LiftingCapacity = lifting;
        }

        public string GetInfo()
        {
            return $"Корабль: {Name}, Грузоподъемность: {LiftingCapacity} тонн, Высота: {Height} метров, Длина: {Length} метров, Ширина: {Height} метров.";
        }

        public object Clone()
        {
            return new CargoShip(this.Length, this.Width, this.Height, this.Name, this.LiftingCapacity );
        }
    }
}
