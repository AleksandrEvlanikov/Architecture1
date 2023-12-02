using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Architecture3
{
    internal abstract class Car
    {
        //endregion

        //region Поля

        private IRefueling refueling;

        // Марка автомобиля
        public string Make { get; set; }

        // Модель
        public string Model { get; set; }

        // Цвет
        protected Color Color { get; set; }

        // Тип
        protected CarType Type;

        // Число колес
        protected int WheelsCount = 4;

        // Тип топлива
        protected FuelType fuelType = FuelType.Diesel;

        // Тип коробки передач
        private GearboxType gearboxType;

        // Объем двигателя
        private double engineCapacity;

        protected Car(string make, string model, Color color)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
        }


        public void SetRefuelingStation(IRefueling refuelingStation, FuelType fuelType)
        {
            this.fuelType = fuelType;
            this.refueling = refuelingStation;
        }

        public void Fuel()
        {
            if (refueling != null)
            {
                refueling.Fuel(fuelType);
            }
        }
        public int GetWheelsCount()
        {
            return WheelsCount;
        }
        // Движение
        public abstract void Movement(string point);
        // Обслуживание
        public abstract void Maintenance();

        // Переключение передач
        public abstract bool GearShifting();
        // Включение фар
        public abstract bool SwitchHeadlights();
        // Включение дворников
        public abstract bool SwitchWipers();

        // Состояние противотуманных фар
        private bool fogLights = false;
        public bool SwitchFogLights()
        {
            fogLights = !fogLights;
            return fogLights;
        }





        //endregion


    }
}
