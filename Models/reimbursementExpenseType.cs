using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Reimbursment_App.Models
{

    //Allows you to see actuall enum names instead of enum values
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum reimbursementExpenseType
    {
        Travel = 1,
        Food = 2,
        Education = 3,
        Supplies = 4,

        Miscellaneous = 5
    }
}