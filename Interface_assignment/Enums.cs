using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignment
{
     
      public enum Dept { HR = 101,Admin,Sales,Devolopment,Testing};

        public class emlpoyee 
        {
            public string name;
            public int id;
            public double bs, hra, ta, da, pf, gs, total;
            private Dept Dept;
            public static int count;
            public emlpoyee(string name, int bs, Dept dept)
            {
                count++;
                this.name = name;
                this.bs = bs;
                this.id = count;
                Dept = dept;
            }
            public static int Getcount()
            {
                return count;
            }
            public virtual void CalculateSalary()

            {
                hra = bs * 0.40;

                ta = bs * 0.20;

                da = bs * 0.15;

                pf = bs * 0.12;

                total = (bs + hra + ta + da);

                gs = (total) - pf;

            }
            public override string ToString()
            {
                return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs} Dept id {Dept}";
            }

            
        }
    
}
