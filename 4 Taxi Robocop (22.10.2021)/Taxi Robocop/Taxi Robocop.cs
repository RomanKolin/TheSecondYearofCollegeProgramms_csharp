using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Robocop
{
    /// <summary>
    /// Перемещение робота по экрану
    /// </summary>
    public class Taxi_Robocop
    {
        //*******************Свойства
        public int X, Y; //Координаты
        public double PercentEnergy;

        //*******************Методы

        public void ChargeUp()
        {
            PercentEnergy = 100;
        }

        public void ChargeDown()
        {
            PercentEnergy = 0;
        }
        
        public void Walking(string direct)
        {
            
            if (PercentEnergy > 0)
            { 
                switch (direct) //Проверка направления движения
                {
                    case "Right":
                        X+=10;
                        break;
                    case "Left":
                        X-=10;
                        break;
                    case "Up":
                        Y-=10;
                        break;
                    case "Down":
                        Y+=10;
                        break;
                    default:
                        break;
                    case "Up-Right":
                        X+=10;
                        Y-=10;
                        break;
                    case "Up-Left":
                        Y-=10;
                        X-=10;
                        break;
                    case "Down-Left":
                        X-=10;
                        Y+=10;
                        break;
                    case "Down-Right":
                        X+=10;
                        Y+=10;
                        break;
                }
               PercentEnergy -= 1; //Уменьшение энергии
            }
        }
    }
}
