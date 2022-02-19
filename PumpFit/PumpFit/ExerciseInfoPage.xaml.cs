using PumpFit.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PumpFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseInfoPage : ContentPage
    {
        public bool isForCurrentRoutine;
        public Routine currentRoutine;
        public Exercise selectedExercise;
        public Label setsLabel;
        public Label repsLabel;
        public Label restTimeLabel;
        public StackLayout setsStackLayout;
        public StackLayout repsStackLayout;
        public StackLayout restTimeStackLayout;
        public StackLayout stepsStackLayout;
        public Button editButton;
        public Button confirmButton;
        public Entry setsEntry;
        public Entry repsEntry;
        public Picker restTimePicker;
        public ExerciseInfoPage(bool isForCurrentRoutine, Routine currentRoutine, bool isForNewRoutine, Exercise tappedExercise)
        {
            InitializeComponent();

            this.isForCurrentRoutine = isForCurrentRoutine;
            this.currentRoutine = currentRoutine;
            selectedExercise = Exercise.Copy(tappedExercise);

            Color difficultyColor = new Color();
            if(tappedExercise.ExerciseDifficulty == Difficulty.Easy)
            {
                difficultyColor = Color.Green;
            }
            else if(tappedExercise.ExerciseDifficulty == Difficulty.Medium)
            {
                difficultyColor = Color.Yellow;
            }
            else if(tappedExercise.ExerciseDifficulty == Difficulty.Hard)
            {
                difficultyColor = Color.Red;
            }

            StackLayout muscleStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Muscle Targeted:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    new Label { Text = tappedExercise.MuscleGroup, TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center }
                }
            };
            subGrid.Children.Add(muscleStackLayout, 0, 0);

            StackLayout difficultyStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Difficulty:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    new Label { Text = tappedExercise.ExerciseDifficulty.ToString(), TextColor = difficultyColor, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center }
                }
            };
            subGrid.Children.Add(difficultyStackLayout, 1, 0);

            StackLayout equipmentStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Equipment:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    new Label { Text = tappedExercise.Equipment, TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center }
                }
            };
            subGrid.Children.Add(equipmentStackLayout, 0, 1);

            /*
            Label muscleLabel = new Label { VerticalOptions = LayoutOptions.Center, Text = string.Concat("Muscle Targeted: ", tappedExercise.MuscleGroup), TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            

            Label difficultyLabel = new Label { VerticalOptions = LayoutOptions.Center, Text = string.Concat("Difficulty: ", tappedExercise.ExerciseDifficulty.ToString()), TextColor = difficultyColor, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            subGrid.Children.Add(difficultyLabel, 1, 0);

            Label equipmentLabel = new Label { VerticalOptions = LayoutOptions.Center, Text = string.Concat("Equipment: ", tappedExercise.Equipment), TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            subGrid.Children.Add(equipmentLabel, 0, 1);*/

            StackLayout stepsStackLayout = new StackLayout 
            { 
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                Children = 
                {
                    new Label { VerticalOptions = LayoutOptions.Center, Text = "Steps: ", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    new Label { VerticalOptions = LayoutOptions.Center, Text = tappedExercise.Description, TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu" }
                }
            };
            subGrid.Children.Add(stepsStackLayout, 0, 2);
            Grid.SetColumnSpan(stepsStackLayout, 2);

            if (isForNewRoutine)
            {
                Button addExerciseButton = new Button { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, WidthRequest = 150, HeightRequest = 50, Text = "Add to routine", TextColor = Color.FromHex("#87BC72"), BackgroundColor = Color.FromHex("#2C2C2C"), BorderWidth = 1, BorderColor = Color.FromHex("#87BC72") };
                subGrid.Children.Add(addExerciseButton, 1, 1);

                addExerciseButton.Clicked += AddExerciseButton_Clicked; //DE ESTA FORMA SE LLAMA EL EVENTO EN LA MISMA FILE .cs (SIN XAML)
            }
        }

        public ExerciseInfoPage(Exercise tappedExercise, bool isForNewRoutine, bool isRoutineBelonging)
        {
            InitializeComponent();

            //selectedExercise = Exercise.Copy(tappedExercise);
            selectedExercise = tappedExercise;

            Label setsLabel = new Label { Text = tappedExercise.Sets.ToString(), TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            this.setsLabel = setsLabel;
            StackLayout setsStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Sets:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    setsLabel
                }
            };
            subGrid.Children.Add(setsStackLayout, 0, 0);
            this.setsStackLayout = setsStackLayout;

            Label repsLabel = new Label { Text = tappedExercise.Reps.ToString(), TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            this.repsLabel = repsLabel;
            StackLayout repsStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Reps:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    repsLabel
                }
            };
            subGrid.Children.Add(repsStackLayout, 1, 0);
            this.repsStackLayout = repsStackLayout;

            Label restTimeLabel = new Label { Text = tappedExercise.RestTime, TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center };
            this.restTimeLabel = restTimeLabel;
            StackLayout restTimeStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Rest time:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    restTimeLabel
                }
            };
            subGrid.Children.Add(restTimeStackLayout, 0, 1);
            this.restTimeStackLayout = restTimeStackLayout;

            StackLayout muscleStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { Text = "Muscle Targeted:", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    new Label { Text = tappedExercise.MuscleGroup, TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center }
                }
            };
            subGrid.Children.Add(muscleStackLayout, 1, 1);

            StackLayout stepsStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label { VerticalOptions = LayoutOptions.Center, Text = "Steps: ", TextColor = Color.White, FontSize = 20, FontFamily = "Ubuntu", HorizontalTextAlignment = TextAlignment.Center },
                    new Label { VerticalOptions = LayoutOptions.Center, Text = tappedExercise.Description, TextColor = Color.FromHex("#9F9F9F"), FontSize = 20, FontFamily = "Ubuntu" }
                }
            };
            subGrid.Children.Add(stepsStackLayout, 0, 2);
            Grid.SetColumnSpan(stepsStackLayout, 2);

            this.stepsStackLayout = stepsStackLayout;

            Button editButton = new Button { Margin = 10, WidthRequest = 120, Text = "Edit", TextColor = Color.FromHex("#87BC72"), BackgroundColor = Color.FromHex("#2C2C2C"), BorderWidth = 1, BorderColor = Color.FromHex("#87BC72") };
            this.editButton = editButton;
            editButton.Clicked += EditButton_Clicked; 

            Button confirmButton = new Button { Margin = 10, WidthRequest = 120, Text = "Confirm", TextColor = Color.FromHex("#87BC72"), BackgroundColor = Color.FromHex("#2C2C2C"), BorderWidth = 1, BorderColor = Color.FromHex("#87BC72") };
            this.confirmButton = confirmButton;
            confirmButton.Clicked += ConfirmButton_Clicked;

            stepsStackLayout.Children.Insert(0, editButton);
            stepsStackLayout.Children.Insert(1, confirmButton);
            confirmButton.IsVisible = false;

        }

        private async void AddExerciseButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExercisePage(selectedExercise, currentRoutine, isForCurrentRoutine));
        }

        private void EditButton_Clicked(object sender, EventArgs e)
        {
            Entry setsEntry = new Entry { MaxLength = 2, WidthRequest = 5 , Text = setsLabel.Text, HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.FromHex("#9F9F9F"), FontFamily = "Ubuntu", Keyboard = Keyboard.Numeric };
            this.setsEntry = setsEntry;
            Entry repsEntry = new Entry { MaxLength = 2, WidthRequest = 5, Text = repsLabel.Text, HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.FromHex("#9F9F9F"), FontFamily = "Ubuntu", Keyboard = Keyboard.Numeric };
            this.repsEntry = repsEntry;
            Picker restTimePicker = new Picker { HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.FromHex("#9F9F9F"), FontFamily = "Ubuntu", ItemsSource = new List<string> { "30s", "45s", "1min", "1min15s", "1min30s" }, SelectedItem = restTimeLabel.Text };
            this.restTimePicker = restTimePicker;
            
            setsLabel.IsVisible = false;
            setsStackLayout.Children.Add(setsEntry);
            setsEntry.TextChanged += Any_ValueChanged;

            repsLabel.IsVisible = false;
            repsStackLayout.Children.Add(repsEntry);
            repsEntry.TextChanged += Any_ValueChanged;

            restTimeLabel.IsVisible = false;
            restTimeStackLayout.Children.Add(restTimePicker);
            restTimePicker.Focused += Any_ValueChanged;

            editButton.IsVisible = false;
        }

        private void Any_ValueChanged(object sender, EventArgs e)
        {
            editButton.IsVisible = false;
            confirmButton.IsVisible = true;
        }

        private void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            if (ValidateEntryValues())
            {
                int.TryParse(setsEntry.Text, out int sets);
                int.TryParse(repsEntry.Text, out int reps);

                selectedExercise.Sets = sets;
                selectedExercise.Reps = reps;
                selectedExercise.RestTime = restTimePicker.SelectedItem.ToString();
                var forDelete = (RoutineInfoPage)Navigation.NavigationStack[Navigation.NavigationStack.Count - 2];
                Navigation.InsertPageBefore(forDelete.Copy(), Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                Navigation.RemovePage(forDelete);

                setsEntry.IsVisible = false;
                repsEntry.IsVisible = false;
                restTimePicker.IsVisible = false;
                setsLabel.IsVisible = true;
                repsLabel.IsVisible = true;
                restTimeLabel.IsVisible = true;

                setsLabel.Text = sets.ToString();
                repsLabel.Text = reps.ToString();
                restTimeLabel.Text = restTimePicker.SelectedItem.ToString();

                confirmButton.IsVisible = false;
                editButton.IsVisible = true;
            }
        }

        private bool ValidateEntryValues()
        {
            Regex regex = new Regex(@"-|\.|,");
            if (setsEntry != null && repsEntry != null && restTimePicker.SelectedItem != null)
            {
                if (!setsEntry.Text.Equals("0") && !repsEntry.Text.Equals("0") && !regex.IsMatch(setsEntry.Text) && !regex.IsMatch(repsEntry.Text))
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
                DisplayAlert("ERROR", "All fields must be set in order to confirm", "OK");
                return false;
            }  
        }
    }
}