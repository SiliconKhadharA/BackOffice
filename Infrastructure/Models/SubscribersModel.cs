using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class SubscribersModel
{
    public string? Id { get; set; }
    public string Email { get; set; } = null!;
}
