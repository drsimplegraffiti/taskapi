using System.Text.Json.Serialization;

namespace TasksApi.Responses
{
    public abstract class BaseResponse
    {
        [JsonIgnore()]
        public bool Success { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //this will not serialize the property if it is null
        public string ErrorCode { get; set; } = String.Empty;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Error { get; set; } = String.Empty;
    }

}
