using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IT.Core.DTOs
{
    public class NoContentResponseDto
    {
        public List<String> Errors { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public static NoContentResponseDto Success(int statusCode)
        {
            return new NoContentResponseDto { StatusCode = statusCode };
        }
        public static NoContentResponseDto Fail(int statusCode, List<String> errors)
        {
            return new NoContentResponseDto { StatusCode = statusCode, Errors = errors };
        }
        public static NoContentResponseDto Fail(int statusCode, string error)
        {
            return new NoContentResponseDto { StatusCode = statusCode, Errors = new List<string> { error } };
        }
}
