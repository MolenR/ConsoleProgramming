//Derivate Class - SubClass
class Names : Person, IGetPerson
{
    public void SetFullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string PersonID()
    {
        return $"{FirstName} {LastName}";
    }

    public string PersonID(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}
