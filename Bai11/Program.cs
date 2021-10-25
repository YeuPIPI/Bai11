using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    public abstract class Motor
    {
        private double Dien_Ap;
        private double Dong_Dien;

        public double Dien_Ap1 { get => Dien_Ap; set => Dien_Ap = value; }
        public double Dong_Dien1 { get => Dong_Dien; set => Dong_Dien = value; }


        public Motor(double Dien_Ap, double Dong_Dien)
        {
            this.Dien_Ap = Dien_Ap;
            this.Dong_Dien = Dong_Dien;
        }

        public abstract double CalculateRatedPower();
    }
    public class ACMotor : Motor
    {
        private double Cos_Phi;
        public ACMotor(double Dien_Ap, double Dong_Dien, double Cos_Phi) : base(Dien_Ap, Dong_Dien)
        {
            this.Cos_Phi = Cos_Phi;
        }

        public double COS_PHI
        {
            get
            {
                return this.Cos_Phi;
            }
            set
            {
                if (this.Cos_Phi <= 1 && this.Cos_Phi >= -1)
                {
                    this.Cos_Phi = value;
                }

            }
        }

        public override double CalculateRatedPower()
        {
            return Dien_Ap1 * Dong_Dien1 * COS_PHI;
        }
    }
    public class DCMotor : Motor
    {
       public DCMotor(double Dien_Ap, double Dong_Dien) : base(Dien_Ap, Dong_Dien) { }
       public override double CalculateRatedPower()
        {
            return Dien_Ap1 * Dong_Dien1;
        }

    }
    public class Program
    {
        public static void Main()
        {
            ACMotor a = new ACMotor(4.8, 2.5, 0.8);
            //double c = a.CalculateRatedPower();
            //Console.WriteLine(c);
            DCMotor b = new DCMotor(4.8, 2.5);
            double d = b.CalculateRatedPower();
            Console.WriteLine(d);
        }
    }
}
