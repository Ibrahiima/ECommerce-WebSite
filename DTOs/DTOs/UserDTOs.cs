using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace DTOs
{
    public class UserDTOs
    {
        public string UserName { get; set; }
        [ContainValidation]
        public string Email { get; set; }
    }
}
