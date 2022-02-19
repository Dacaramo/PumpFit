using PumpFit.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PumpFit
{
    class ExerciseGroupList : List<Exercise>
    {
        public String Title { get; set; }
        public String ShortName { get; set; }
        public String SubTitle { get; set; }

        public ExerciseGroupList(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
