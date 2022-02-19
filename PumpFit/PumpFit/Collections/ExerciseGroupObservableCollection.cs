using PumpFit.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PumpFit
{
    class ExerciseGroupObservableCollection : ObservableCollection<Exercise>
    {
        public String Title { get; set; }
        public String ShortName { get; set; }
        public String SubTitle { get; set; }

        public ExerciseGroupObservableCollection(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
