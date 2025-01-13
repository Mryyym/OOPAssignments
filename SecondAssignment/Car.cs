using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Car
    {
        #region Atrib
        private int id;
        private string model;
        private double speed;


        #endregion


        #region CTOR

        public Car(int id , string model , double speed)
        {
            Console.WriteLine("ctor 3");
            this.id = id;
            this.model = model;
            this.speed = speed;
        }
        public Car(int id, string model) : this(id, model, 290)
        {
            Console.WriteLine("ctor 2");

            //this.id = id;
            //this.model = model;
            //speed = 290;
        }

        public Car(int id):this(id , "BMW",290)
        {
            Console.WriteLine("ctor 1");
        }

        #endregion


        #region Propertis
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Car ID:{id}\nCar Model:{model}\nCar Speed:{speed}";
        }
        #endregion
    }
}
