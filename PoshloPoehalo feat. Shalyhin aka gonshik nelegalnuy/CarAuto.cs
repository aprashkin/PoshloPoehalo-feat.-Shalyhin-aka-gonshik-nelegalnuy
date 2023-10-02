using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyMetody
{
    internal class CarAuto
    {
        private string number;
        private float fuel;
        private float flow;

        public void info(string number, float fuel, float flow)
        {
            this.number = number;
            this.fuel = fuel;
            this.flow = flow;
        }
        public void outinfo()
        {
            Console.WriteLine($"Номер: {this.number}\nТопливо: {this.fuel} \nРасход: {this.flow}");
        }

        public void zaprawka(float top)
        {
            this.fuel += top;
        }
        public void move(int km)
        {

            float ostatok = this.fuel - (km * (this.flow) / 100);
            if (ostatok > 0)
            {
                Console.WriteLine($"Мы смогли доехать до кабинета, нас отметили, как пропавшими без вести, зато в баке осталось {ostatok} л.");
            }
            if (ostatok < 0)
            {
                Console.WriteLine("Не докатимся, толкать сам дальше будешь? Сколько еще литров зальем?");
                zaprawka(float.Parse(Console.ReadLine()));
                if (ostatok > 0)
                {
                    Console.WriteLine($"Мы смогли доехать до кабинета, нас отметили, как пропавшими без вести, зато в баке осталось {ostatok} л." );
                }
                if (ostatok < 0)
                {
                    float for_ostatok = (ostatok * -1);
                    Console.WriteLine($"Нам не хватило топлива до кабинета. Нужно было залить ещё {for_ostatok:F1} литра(ов). По пути нас съел javascript...");
                }
            }


        }
    }
}
