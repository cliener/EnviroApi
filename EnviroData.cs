using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace EnviroApi;

public class EnviroData
{
    public DateOnly Date { get; set; }

    public float Temperature { get; set; }

    public float Humidity { get; set; }

    public float Pressure { get; set; }
}