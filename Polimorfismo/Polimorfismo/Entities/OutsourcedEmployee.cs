
namespace Polimorfismo.Entities
{
    class OutsourcedEmployee: Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharge):base(name, hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1* AdditionalCharge;
        }

        public override bool Equals(object obj)
        {
            return obj is OutsourcedEmployee employee &&
                   Name == employee.Name &&
                   Hours == employee.Hours &&
                   ValuePerHour == employee.ValuePerHour &&
                   AdditionalCharge == employee.AdditionalCharge;
        }
    }
}
