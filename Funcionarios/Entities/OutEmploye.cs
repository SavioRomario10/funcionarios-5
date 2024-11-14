using System;

namespace Funcionarios.Entities
{
    class OutEmploye : Employe
    {
        public double AddCharge { get; set; }

        public OutEmploye(){}
        public OutEmploye(string name, int hours, double valuePerHour, double addCharge):base(name, hours, valuePerHour)
        {
            AddCharge = addCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1*AddCharge;
        }
    }
}