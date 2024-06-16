namespace CoffeeShopRegistration.Models;
public class User
{
    public string first_name {  get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public Gender gender { get; set; }

    public enum Gender
    {
        male,female,other
    }

}
