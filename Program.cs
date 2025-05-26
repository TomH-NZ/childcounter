// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Net.Http;


var data = await Api.GetChildDataAsync();

Console.WriteLine(data.Id.ToString());
Console.WriteLine(data.ChildCount.ToString());
Console.WriteLine(data.Eliminate.ToString());
public class Data
{
    public int Id { get; set; }
    public int ChildCount { get; set; }
    public int Eliminate { get; set; }
}

public class Api
{
    public static async Task<Data> GetChildDataAsync()
    {
        const string apiUrl = "https://7annld7mde.execute-api.ap-southeast2.amazonaws.com/main/game";
        
        using HttpClient apiClient = new();
        var jsonResponse = await apiClient.GetStringAsync(apiUrl);

        return JsonSerializer.Deserialize<Data>(jsonResponse);
    }
}

// https://7annld7mde.execute-api.ap-southeast2.amazonaws.com/main/game