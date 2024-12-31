using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGeneratorHybrid.ViewModels
{
    public class SegmentModel
    {

        /// <summary>
        /// Für originale Reihenfolge, anscheinend gibt es Segmente mehrmals in einem File.
        /// </summary>
        public  int ID { get; set; }
        public string SegmentName { get; set; }
        public List<FieldModel> FieldList { get; set; } = new List<FieldModel>();


        public void addField(FieldModel fieldmodel)
        {
            FieldList.Add(fieldmodel);
        }

    }
}
