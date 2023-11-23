using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12HM
{
    public abstract class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public delegate void FinishEventHandler(object sender, EventArgs e);

        public event FinishEventHandler Finish;
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public virtual void Drive()
        {
            Console.WriteLine($"{Model} двигается со скоростью {Speed} км/ч");
        }
        protected virtual void OnFinish()
        {
            Console.WriteLine($"{Model} пришел к финишу!");
            Finish?.Invoke(this, EventArgs.Empty);
        }
    }
}
