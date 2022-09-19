using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int typeId, string make, string model, string typeName, int cCM, string color, int tyres)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            CCM = cCM;
            Color = color;
            Tyres = tyres;
        }
    }
}
