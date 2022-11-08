using System.Text.Json.Serialization;

namespace Reimbursment_App.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum employeeRole
    {
        Associate = 1,
        Manager = 2
    }
}