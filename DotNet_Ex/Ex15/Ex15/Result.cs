using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class Result
    {
        public int SemesterName { get; set; }
        public float AvgScore { get; set; }
        public Result()
        {

        }
        public Result(int semestername, float avgscore)
        {
            SemesterName = semestername;
            AvgScore = avgscore;
        }
        public Result(Result re)
        {
            SemesterName = re.SemesterName;
            AvgScore = re.AvgScore;
        }
    }
}
