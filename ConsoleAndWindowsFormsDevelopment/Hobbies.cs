class Hobbies : Person, IGetPerson
{
    public void SetHobby(string hobby)
    {
        Hobby = hobby;
    }

    public string SetHobby()
    {
        return Hobby;
    }

    public string PersonID()
    {
        return nameof(Names);
    }
}