using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGeneratorHybrid.ViewModels
{
    public class FieldModel

    {
        public int FieldNumber { get; set; }

        public string FieldDescription { get; set; }

        public string Value { get; set; }


        public SegmentModel Segment { get; private set; }



    }
}
