using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos;

public class User
{
    public string UserName { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
}
