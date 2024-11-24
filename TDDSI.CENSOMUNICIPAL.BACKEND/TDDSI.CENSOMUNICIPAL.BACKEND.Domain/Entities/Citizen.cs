using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Entities;
public class Citizen 
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Document { get; set; }
    public string Occupation { get; set; }
}
