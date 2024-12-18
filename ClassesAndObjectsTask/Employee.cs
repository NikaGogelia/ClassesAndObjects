namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname = string.Empty;
        private int age = 0;

        public Employee()
        {
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        private string ConvertAgeIntoString(int age = 0)
        {
            if (age < 0)
            {
                return string.Empty;
            }
            else
            {
                return age.ToString();
            }
        }

        public void ChangeSurname(string newSurname)
        {
            this.surname = newSurname;
        }

        public string GetEmployee()
        {
            return $"Surname: {this.surname}, Age: {this.age}";
        }
    }
}
