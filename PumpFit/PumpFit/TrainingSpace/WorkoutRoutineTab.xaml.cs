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
    public partial class WorkoutRoutineTab : ContentPage
    {
        public ObservableCollection<Routine> Routines { set; get; } = new ObservableCollection<Routine>();

        public WorkoutRoutineTab()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<AddExercisePage, Routine>(this, "FillRoutines", (messageSender, arg) =>
            {
                Routines.Add(new Routine(arg.Name, arg.ExerciseList));
                routineListView.ItemsSource = Routines;
            });

            Image emptynessImage = new Image { Source = "barbellIcon.png"};
            Label emptynessLabel = new Label { Text = "Your routines will display here", TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            if (Routines.Count == 0)
            {
                routineListView.IsVisible = false;
                routineStackLayout.Children.Insert(0, emptynessImage);
            }
            else
            {
                routineListView.IsVisible = true;
                emptynessImage.IsVisible = false;
            }
        }
        private async void AddRoutineButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExerciseBankTab() { Title = "" });
        }

        private async void RoutineListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedRoutine = e.Item as Routine;
            if(tappedRoutine != null)
            {
                await Navigation.PushAsync(new RoutineInfoPage(tappedRoutine) { Title = tappedRoutine.Name} );
            }
            
        }
    }
}