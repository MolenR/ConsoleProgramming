abstract class Hobbies
{
    public string Hobby { get; set; }

    public void SetHobby(string hobby)
    {
        Hobby = hobby;
    }

    public string SetHobby()
    {
        return Hobby;
    }
}