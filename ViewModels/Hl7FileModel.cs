using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGeneratorHybrid.ViewModels
{
    internal class Hl7FileModel
    {
        public string FileName { get; set; }

        public string FilePath { get; set; }
        public List<SegmentModel> Segments { get; set; }

    }
}
