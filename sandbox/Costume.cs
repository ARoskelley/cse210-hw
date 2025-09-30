class Costume
{
    //attributes
    public string outfit = "";
    public string footwear = "";
    public string tools = "";
    public string size = "";

    //behaviors
    void Display()
    {
        Console.WriteLine($"outfit : {outfit}, size: {size}");
    }
}