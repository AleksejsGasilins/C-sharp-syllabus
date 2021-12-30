using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public class Lada : ICar
    {
        private int _currentSpeed = 0;
        public void SpeedUp()
        {
            _currentSpeed += 50;
        }

        public void SlowDown()
        {
            _currentSpeed -= 50;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("--- rum rum rum ---");
        }
    }
}
