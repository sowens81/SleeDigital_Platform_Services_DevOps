namespace Example.Solution.Models;
public class Product
{
    public string Id { get; set;}

    public string Password { get; set; }

    public Product()
    {
        Id = Guid.NewGuid().ToString();
        Password = "ABC123";
    }

}
