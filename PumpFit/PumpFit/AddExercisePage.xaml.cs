using PumpFit.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PumpFit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace PumpFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExercisePage : ContentPage
    {
        public Exercise newExercise;
        public Routine currentRoutine;
        public bool isForCurrentRoutine;

        public AddExercisePage(Exercise selectedExercise, Routine currentRoutine, bool isForCurrentRoutine)
        {
            InitializeComponent();

            newExercise = selectedExercise; 
            nameLabel.Text = newExercise.Name;
            this.currentRoutine = currentRoutine;
            this.isForCurrentRoutine = isForCurrentRoutine;

            if(isForCurrentRoutine)
            {
                routineNameLabel.IsVisible = false;
                routineNameEntry.IsVisible = false;
            }
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            if (ValidateEntryValues())
            {
                int.TryParse(setsEntry.Text, out int sets);
                int.TryParse(repsEntry.Text, out int reps);

                if (isForCurrentRoutine)
                {
                    currentRoutine.ExerciseList.Add(new Exercise(newExercise.Name, newExercise.MuscleGroup, newExercise.ExerciseDifficulty, newExercise.Equipment, newExercise.Description, sets, reps, restTimePicker.SelectedItem.ToString()));
                    ClearPathToRoutineInfoPage();
                    Navigation.InsertPageBefore(new RoutineInfoPage(new Routine(currentRoutine.Name, currentRoutine.ExerciseList)) { Title = currentRoutine.Name }, Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                    await Navigation.PopAsync();
                }
                else
                {
                    List<Exercise> newExerciseList = new List<Exercise>()
                    {
                        new Exercise(newExercise.Name, newExercise.MuscleGroup, newExercise.ExerciseDifficulty, newExercise.Equipment, newExercise.Description, sets, reps, restTimePicker.SelectedItem.ToString())
                    };

                    MessagingCenter.Send<AddExercisePage, Routine>(this, "FillRoutines", new Routine(routineNameEntry.Text, newExerciseList));
                    ClearPathToRoutineInfoPage();
                    Navigation.InsertPageBefore(new RoutineInfoPage(new Routine(routineNameEntry.Text, newExerciseList)) { Title = routineNameEntry.Text }, Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                    await Navigation.PopAsync();
                }
            }
        }

        public void ClearPathToRoutineInfoPage()
        {
            int add = 0;

            if (isForCurrentRoutine)
                add++;

            for (int i = 0; i < 3+add; i++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            }
        }

        public bool ValidateEntryValues()
        {
            Regex regex = new Regex(@"-|\.|,");
            if (isForCurrentRoutine ? (setsEntry.Text != null && repsEntry.Text != null && restTimePicker.SelectedItem != null) : (setsEntry.Text != null && repsEntry.Text != null && restTimePicker.SelectedItem != null && routineNameEntry.Text != null))
            {
                if(!setsEntry.Text.Equals("0") && !repsEntry.Text.Equals("0") && !regex.IsMatch(setsEntry.Text) && !regex.IsMatch(repsEntry.Text))
                {
                    return true;
                }
                else
                {
                    DisplayAlert("ERROR", "You must only enter positive numbers", "OK");
                    return false;
                }  
            }
            else
            {
                DisplayAlert("ERROR", "All fields must be set to add the exercise to the routine", "OK");
                return false;
            }
        }
    }
}