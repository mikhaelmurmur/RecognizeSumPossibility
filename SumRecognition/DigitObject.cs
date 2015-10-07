using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRecognition
{
    class DigitObject
    {
        List<DigitMark> marks = new List<DigitMark>();
        List<DigitObject> neighbours = new List<DigitObject>();
    }
}
