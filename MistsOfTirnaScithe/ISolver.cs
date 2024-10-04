using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MistsOfTirnaScithe
{
    public interface ISolver
    {
        public string Solution { get; set; }
        public string Solve(List<Input> inputs);
    }
}
