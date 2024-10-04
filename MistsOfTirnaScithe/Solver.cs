using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MistsOfTirnaScithe
{
    public class Solver : ISolver
    {
        public string Solution { get; set; }


        public string Solve(List<Input> inputs)
        {
            //The inputs list always conaints 4 elements.

            int NumberOfCircles = inputs.Count(x => x.Circle);
            int NumberOfColored = inputs.Count(x => x.Colored);

            if (NumberOfCircles == 1 || NumberOfCircles == 3)
            {
                if (NumberOfCircles == 1) 
                {
                    return "The solution is the one WITH the circle!";
                }
                else
                {
                    return "The solution is the one WITHOUT the Circle!";
                }
                
            }
            else if (NumberOfColored == 1 || NumberOfColored == 3)
            {
                if (NumberOfColored == 1) 
                {
                    return "The solution is the one which IS Colored!";
                }
                else
                {
                    return "The solution is the one which IS NOT Colored!";
                }
            }
            else
            {
                return FindShape(inputs);
            }

        }


        private string FindShape(List<Input> inputs)
        {
            int leaf = 0;
            int flower = 0;
            int k = 0;
            string[] temparray = new string[4];
            string solution = temparray[0];
            
            foreach (var input in inputs)
            {
                
                temparray[k] = input.Mainprop;
                k++;
            }
           

            for (int i = 1; i < temparray.Length; i++) 
            {
                if (temparray[i].Equals("leaf")) 
                {
                    leaf++;
                }
                else
                {
                    flower++;
                }
            }

            if (leaf < flower)
            {
                return "The solution is the leaf!";
            }
            else 
            {
                return "The solution is the flower!";
            }

        }
    }
}
