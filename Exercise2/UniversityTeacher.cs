namespace Exercise2
{
    public class UniversityTeacher: AbstractTeacher
    {
        public string UniversityCode { get; set; }
        
        public int EnglisLevel { get; set; }
        
        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 10,000", Name);
            }

            var salary = BaseSalary * Level + ((BaseSalary / 10) * EnglisLevel) + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecture gets less than 60000 salary", Name);

            }

            return salary;
        }

    }
}