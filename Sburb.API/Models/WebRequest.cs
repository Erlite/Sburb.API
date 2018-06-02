namespace Sburb.API.Models
{
    public abstract class BaseRequest
    {
        string Type { get; set; }

        short RequestID { get; set; }
    }
}