namespace DesingPatternSample.BuilderPattern.EmployeeSample
{
    public class CompanyEmployee : EmployeBuilder
    {

        private const string companyMailDomain = "@codderkush.com";

        public override CompanyEmployee SetEmailAddress(string emailAddress)
        {
            var arr = emailAddress.Split('@');
            employee.Email = string.Concat(arr[0], companyMailDomain);

            return this;
        }

        public override CompanyEmployee SetFullName(string fullName)
        {
            var arr = fullName.Split(' ');
            employee.FirstName = arr[0];
            employee.LastName = arr[1];
            return this;
        }

        public override CompanyEmployee SetUserName(string usernName)
        {
            var id = new Random().Next(1000, 2000);
            employee.UserName = usernName + id;

            return this;

        }

    }
}
