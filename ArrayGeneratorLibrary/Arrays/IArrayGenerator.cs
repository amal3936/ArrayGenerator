using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGeneratorLibrary.Arrays
{
    /// <summary>
    /// Interface to change what kind of array we generate doing runtime
    /// </summary>
    public interface IArrayGenerator
    {
        int[] GetArray(int n, int seed);
    }
}
