//using Interface_assignment;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Interface_assignment
//{
//    public interface Interface_assi_1
//    {
//        string PrintDetails();
//    }
//    public class emlpoyee : Interface_assi_1
//    {
//        public string name;
//        public int id;
//        public double bs, hra, ta, da, pf, gs, total;
//        public static int count;
//        public emlpoyee(string name, int bs)
//        {
//            count++;
//            this.name = name;
//            this.bs = bs;
//            this.id = count;
//        }
//        public static int Getcount()
//        {
//            return count;
//        }
//        public virtual void CalculateSalary()

//        {
//            hra = bs * 0.40;

//            ta = bs * 0.20;

//            da = bs * 0.15;

//            pf = bs * 0.12;

//            total = (bs + hra + ta + da);

//            gs = (total) - pf;

//        }
//        public override string ToString()
//        {
//            return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs}";
//        }

//        public string PrintDetails()
//        {

//            return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs}";
//        }
//    }
//    public class Sales_maneger : emlpoyee, Interface_assi_1
//    {
//        private double cumm;
//        public Sales_maneger(double cumm, int bs, string name) : base(name, bs)
//        {
//            this.cumm = cumm;
//        }
//        public override void CalculateSalary()

//        {
//            hra = bs * 0.40;

//            ta = bs * 0.20;

//            da = bs * 0.15;

//            pf = bs * 0.12;

//            total = (bs + hra + ta + da + cumm);

//            gs = (total) - pf;
//        }

//        public override string ToString()
//        {
//            return $"name is {name} \n id is {id}\ntotal salary is {total}\n gross salary is {gs}";
//        }
//        public string PrintDetails()
//        {

//            return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs}";
//        }
//    }
//    public class CEO : emlpoyee, Interface_assi_1
//    {
//        double bonus;
//        public CEO(double bonus, int bs, string name) : base(name, bs)
//        {
//            this.bonus = bonus;
//        }
//        public override void CalculateSalary()
//        {

//            hra = bs * 0.40;

//            ta = bs * 0.20;

//            da = bs * 0.15;

//            pf = bs * 0.12;

//            total = (bs + hra + ta + da + bonus);

//            gs = (total) - pf;
//        }
//        public override string ToString()
//        {
//            return $"name is {name},\n id is {id},\ntotal salary is {total},\ngross salary is {gs}";
//        }
//        public string PrintDetails()
//        {

//            return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs}";
//        }
//    }
//}
