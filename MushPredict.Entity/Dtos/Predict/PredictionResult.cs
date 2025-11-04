using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Entity.Dtos.Predict
{
    public class PredictionResult
    {
        public string Prediction { get; set; }
        public string Confidence { get; set; }
    }
}
