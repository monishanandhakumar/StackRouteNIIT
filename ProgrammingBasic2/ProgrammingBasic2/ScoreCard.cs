using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasic2
{
   public enum AssessmentType
    {
        UIZ = 50,
     KBA = 100,
     CALIBRATION = 150,
     HACKATHON = 200

    }
  public  struct AssessmentCard
    {
       public AssessmentType assessmentType;
       public int score;
       public DateTime datetime;
    }
    class ScoreCard
    {
        // this method accepts assessment cards and calculates total percentage
      /*  public static int GetOverallScore(AssessmentCard[] assessmentCard)
        {
          //  assessmentCard.assessmentType =AssessmentType.CALIBRATION;
           // assessmentCard.score = 100;
            // the logic put here should use foreach loop to read 
            // card data and calculate percentage as mentioned.
            // the maximum score value for each assessment type can be retrieve
            // from enum constant
            // 
            
        }*/

        public static void Main()
        {

        }
    }
}
