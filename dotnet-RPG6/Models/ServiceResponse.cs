namespace Dotnet_RPG6.Models
{
    public class ServiceResponse<T> //T is type of data we want to return
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
