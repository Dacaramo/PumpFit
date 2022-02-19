using System;
using System.Collections.Generic;
using System.Text;

namespace PumpFit.Entity
{
    public class Exercise
    {
        public String Name { get; set; }
        public String MuscleGroup { get; set; }
        public Difficulty ExerciseDifficulty { get; set; }
        public String Equipment { get; set; }
        public String Description { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public String RestTime { get; set; }

        public Exercise(string name, string muscleGroup, Difficulty exerciseDifficulty, string equipment, string description)
        {
            Name = name;
            MuscleGroup = muscleGroup;
            ExerciseDifficulty = exerciseDifficulty;
            Equipment = equipment;
            Description = description;
        }

        public Exercise(string name, string muscleGroup, Difficulty exerciseDifficulty, string equipment, string description, int sets, int reps, string restTime) : this(name, muscleGroup, exerciseDifficulty, equipment, description)
        {
            Sets = sets;
            Reps = reps;
            RestTime = restTime;
        }

        public static Exercise Copy(Exercise exerciseToCopy)
        {
            return new Exercise(exerciseToCopy.Name, exerciseToCopy.MuscleGroup, exerciseToCopy.ExerciseDifficulty, exerciseToCopy.Equipment, exerciseToCopy.Description);
        }
    }
}
