using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gable_Post_Designer
{
    public class CalculationHelper
    {
        public static double GetPlanLoadArea(double frameCentres, double postCentres)
        {
            return (frameCentres / 2) + postCentres;
        }
        public static double CalculateFactoredVertical(double planArea, double dlFactor, double llFactor, double wlFactor, double deadLoad, double serviceLoad, double liveLoad)
        {
            return planArea * ((dlFactor * deadLoad) + (dlFactor * serviceLoad) + (llFactor * liveLoad));
        }
    }
}
