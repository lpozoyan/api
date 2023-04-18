using System.Net.Http.Json;

public partial class Program
{
    static HttpClient httpClient = new HttpClient();
    static async Task Main()
    {
        // отправляемый объект 
        Person tom = new Person();
        // отправляем запрос
        using var response = await httpClient.PostAsJsonAsync("http://192.168.49.180:81/swagger/index.html", tom);
        Person? person = await response.Content.ReadFromJsonAsync<Person>();
       
    }
}
class Person
{
    public string password { get; set; }
    public string name { get; set; } 
    public string login { get; set; }
}