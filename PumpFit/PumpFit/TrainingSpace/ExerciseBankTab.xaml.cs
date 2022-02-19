using PumpFit.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PumpFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseBankTab : ContentPage
    {
        public Routine currentRoutine;
        public bool isForCurrentRoutine;

        public ExerciseBankTab()
        {
            InitializeComponent();
        }

        public ExerciseBankTab(Routine currentRoutine, bool isForCurrentRoutine)
        {
            InitializeComponent();

            this.currentRoutine = currentRoutine;
            this.isForCurrentRoutine = isForCurrentRoutine;
        }

        private async void ForearmsButton_Clicked(object sender, EventArgs e)
        {
            if(Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Forearms", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Forearms", true, isForCurrentRoutine, currentRoutine));
            }  
        }

        private async void Glutes_adductors_abductorsButton_Clicked(object sender, EventArgs e)
        {
            if(Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Glutes_adductors_abductors", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Glutes_adductors_abductors", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void HamstringsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Hamstrings", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Hamstrings", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void CalvesButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Calves", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Calves", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void TricepsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Triceps", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Triceps", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void PecsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Pecs", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Pecs", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void AbsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Abs", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Abs", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void QuadricepsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Quadriceps", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Quadriceps", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void TrapsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Traps", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Traps", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void DeltsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Delts", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Delts", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void BicepsButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Biceps", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Biceps", true, isForCurrentRoutine, currentRoutine));
            }
            
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            if (Parent.GetType().IsSubclassOf(typeof(TabbedPage)))
            {
                await Navigation.PushAsync(new ExcerciseListPage("Back", false, isForCurrentRoutine, currentRoutine));
            }
            else
            {
                await Navigation.PushAsync(new ExcerciseListPage("Back", true, isForCurrentRoutine, currentRoutine));
            } 
        }
    }
}