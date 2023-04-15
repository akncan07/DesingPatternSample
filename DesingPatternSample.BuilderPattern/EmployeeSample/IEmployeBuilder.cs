namespace DesingPatternSample.BuilderPattern.EmployeeSample
{
    public interface IEmployeBuilder
    {
        Employee BuildEmployee();
        EmployeBuilder SetEmailAddress(string emailAddress);
        EmployeBuilder SetFullName(string fullName);
        EmployeBuilder SetUserName(string usernName);
    }
}