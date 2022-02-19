using PumpFit.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PumpFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutineInfoPage : ContentPage
    {
        public bool groupAlredyIn = false;
        public Routine currentRoutine;

        public RoutineInfoPage(Routine routine)
        {
            InitializeComponent();

            currentRoutine = routine;
            var routineExercises = new ObservableCollection<ExerciseGroupObservableCollection>();

            foreach(var exercise in routine.ExerciseList)
            {
                groupAlredyIn = false;
                foreach(var group in routineExercises)
                {
                    if(group.Title.Equals(exercise.MuscleGroup))
                    {
                        group.Add(exercise);
                        groupAlredyIn = true;
                    }
                }
                
                if(!groupAlredyIn)
                {
                    routineExercises.Add(new ExerciseGroupObservableCollection(exercise.MuscleGroup, exercise.MuscleGroup.Substring(0, 3).ToUpper()));

                    foreach(var group in routineExercises)
                    {
                        if(group.Title.Equals(exercise.MuscleGroup))
                        {
                            group.Add(exercise);
                        }
                    }
                }
            }
            
            routineExercisesListView.ItemsSource = routineExercises;
        }

        private async void AddExerciseButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExerciseBankTab(currentRoutine, true));
        }

        private async void RoutineExercisesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedExercise = e.Item as Exercise;
            if (tappedExercise != null)
            {
                await Navigation.PushAsync(new ExerciseInfoPage(tappedExercise, false, true) { Title = tappedExercise.Name });
            }
        }

        public RoutineInfoPage Copy()
        {
            return new RoutineInfoPage(currentRoutine);
        }
    }
}