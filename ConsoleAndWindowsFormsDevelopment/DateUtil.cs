class DateUtil : Person, IGetPerson
{
    public static void TimeOfDay()
    {
        /* Create DateTime */
        DateTime dateTime = DateTime.Now;
        Console.WriteLine($"The Date and Time Today: { dateTime}.");
        _ = DateOnly.FromDateTime(dateTime);
        _ = TimeOnly.FromDateTime(dateTime);
    }

    public void SetAge(int age)
    {
        Age = age;
    }
    public int SetAge()
    {
        return Age;
    }
    
    // Calculated the users year of birth //
    public void BirthDate(int birthDay)
    {
        BirthDay = birthDay;
    }
    public int BirthDate()
    {
        var today = DateTime.Today;
        int year = today.Year - Age;

        return year;
    }

    public string PersonID()
    {
        return nameof(Names);
    }
}

