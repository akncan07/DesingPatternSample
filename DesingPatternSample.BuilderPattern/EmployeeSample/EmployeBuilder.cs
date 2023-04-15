namespace DesingPatternSample.BuilderPattern.EmployeeSample
{
    public abstract class EmployeBuilder : IEmployeBuilder
    {

        protected Employee employee { get; set; }

        public EmployeBuilder()
        {
            employee = new Employee();
        }

        public abstract EmployeBuilder SetFullName(string fullName);
        public abstract EmployeBuilder SetUserName(string usernName);
        public abstract EmployeBuilder SetEmailAddress(string emailAddress);
        public Employee BuildEmployee() => employee;



    }
}
