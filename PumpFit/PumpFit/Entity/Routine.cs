using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PumpFit.Entity
{
    public class Routine
    {
        public String Name { get; set; }
        public int TimesDone { get; set; }
        public DateTime CreationDate { get; set; }
        public String CreationDisplayDate { get; set; }
        public List<Exercise> ExerciseList { get; set; }

        public Routine(string name, List<Exercise> exerciseList)
        {
            Name = name;
            TimesDone = 0;
            CreationDate = DateTime.Now;
            CreationDisplayDate = CreationDate.ToShortDateString();
            ExerciseList = exerciseList;
        }
    }
}
