using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C5_StaticMembers
    {
        //Circle Class

        static float PI = 3.142F;
        public float Raidus;
        static int TotalObjectCreated;

        public C5_StaticMembers(float mRadius)
        {
            this.Raidus = mRadius;
            C5_StaticMembers.TotalObjectCreated++;
        }

        public float CalculateArea()
        {
            return C5_StaticMembers.PI * this.Raidus * this.Raidus;
        }

        static public int GetTotalObjects()
        {
            return C5_StaticMembers.TotalObjectCreated;
        }

    }
}
