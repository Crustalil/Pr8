using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр8
{
    /// <summary>
    /// Интерфейс корабль
    /// </summary>
    interface IShip
    { 
        // Свойство длины
        int Length { get;}
        //Свойство имени
        string Name { get; set; }
        //Свойство ширины
        int Width { get;}
        // Свойство высоты 
        int Height { get;}
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        /// <returns>Информация о корабле</returns>
        string GetInfo();
    }

    /// <summary>
    /// Интерфейс грузовой транспорт
    /// </summary>
    interface ICargoTransport
    {
        //Свойство длины
        int Length { get; }
        //Свойство имени
        string Name { get; set; }
        //Свойство ширины
        int Width { get; }
        //Свойство высоты
        int Height { get; }
        //Свойство грузоподъемности
        int LiftingCapacity { get;}
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        /// <returns>Информация о грузовом транспорте</returns>
        string GetInfo();
    }

    /// <summary>
    /// Класс грузовой корабль
    /// </summary>
    public class CargoShip : IComparable<CargoShip>, IShip, ICargoTransport, ICloneable
    {
        //Свойство длины
        public int Length { get;} 
        //Свойство имени
        public string Name { get; set; }
        //Свойство ширины
        public int Width { get;}
        //Свойство высоты
        public int Height { get;}
        //Свойство грузоподъемности
        public int LiftingCapacity { get;}
        /// <summary>
        /// Метод сравнения грузоподъемностей двух грузовых кораблей
        /// </summary>
        /// <param name="other">Второй корабль</param>
        /// <returns>Сравнение веса</returns>
        public int CompareTo(CargoShip other)
        {
            if (other == null) return 1;
            return LiftingCapacity.CompareTo(other.LiftingCapacity);
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="length">длина</param>
        /// <param name="width">ширина</param>
        /// <param name="height">высота</param>
        /// <param name="name">имя</param>
        /// <param name="lifting">грузоподъемность</param>
        public CargoShip (int length, int width, int height, string name, int lifting)
        {
            Length = length;
            Width = width;
            Height = height;
            Name = name;
            LiftingCapacity = lifting;
        }

        /// <summary>
        /// Метод вывода информации 
        /// </summary>
        /// <returns>Информация о грузовом корабле</returns>
        public string GetInfo()
        {
            return $"Корабль: {Name}, Грузоподъемность: {LiftingCapacity} тонн, Высота: {Height} метров, Длина: {Length} метров, Ширина: {Height} метров.";
        }

        /// <summary>
        /// Метод клонирования
        /// </summary>
        /// <returns>Клонированный корабль</returns>
        public object Clone()
        {
            return new CargoShip(this.Length, this.Width, this.Height, this.Name, this.LiftingCapacity );
        }
    }
}
