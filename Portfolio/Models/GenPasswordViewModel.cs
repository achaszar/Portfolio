using Microsoft.AspNetCore.Identity;

namespace Portfolio.Models
{
    public class GenPasswordViewModel
    {
        public int Length { get; set; }
        public bool WantUpper { get; set; }  
        public bool WantSymbols { get; set; } 
        public string PasswordResult { get; set; } = "DefaultPassword";
    }
}
