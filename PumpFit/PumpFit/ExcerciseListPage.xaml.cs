using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PumpFit.Entity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PumpFit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExcerciseListPage : ContentPage
    {
        public bool isForNewRoutine;
        public bool isForCurrentRoutine;
        public Routine currentRoutine;

        public ExcerciseListPage(String muscleGroup, bool isForNewRoutine, bool isForCurrentRoutine, Routine currentRoutine)
        {
            InitializeComponent();

            this.isForNewRoutine = isForNewRoutine;
            this.isForCurrentRoutine = isForCurrentRoutine;
            this.currentRoutine = currentRoutine;

            switch (muscleGroup)
            {
                case "Forearms":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Curls", "C")
                        {
                            new Exercise("Palms-Up Dumbbell Wrist Curl", "Forearms", Difficulty.Easy, "Dumbbells", "-Let your forearms lay in your legs or a bench (your palms should be facing up) \n\n" +
                            "-Start to curl"),
                            new Exercise("Palms-Down Dumbbell Wrist Curl", "Forearms", Difficulty.Easy, "Dumbbells", "-Let your forearms lay in your legs or a bench (your palms should be facing down) \n\n" +
                            "-Start to curl"),
                            new Exercise("Palms-Up Barbell Wrist Curl", "Forearms", Difficulty.Easy, "Barbell", "-Let your forearms lay in your legs or a bench (your palms should be facing up) \n\n" +
                            "-Start to curl"),
                            new Exercise("Palms-Down Barbell Wrist Curl", "Forearms", Difficulty.Easy, "Barbell", "-Let your forearms lay in your legs or a bench (your palms should be facing down) \n\n" +
                            "-Start to curl")
                        },

                        new ExerciseGroupList("Other", "O")
                        {
                            new Exercise("Wrist Roller", "Forearms", Difficulty.Easy, "Wrist Roller tool", "-Grab the handle with an inverted grip on each hand \n\n" +
                            "-Start to roll the handle until the plate reaches the handle"),
                            new Exercise("Weighted Plate squeeze", "Forearms", Difficulty.Medium, "Plate", "-Grab the plate, lift it and start to squeeze \n\n" +
                            "-The longer you last squeezing them the better")
                        }
                    };
                    break;

                case "Glutes_adductors_abductors":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Glutes", "G")
                        {
                            new Exercise("Glute Bridge", "Glutes", Difficulty.Easy, "Bodyweight", "-Lay down upwards while keeping your legs bended \n\n" +
                            "-Move your hips upwards until your torso is perfectly aligned with your legs and hold position for a while, go back to the starting position and repeat \n\n" +
                            "-When performing the  strength keep your hands sticked to the ground \n\n" +
                            "-Always do the strength with your glutes"),
                            new Exercise("Barbell Glute Bridge", "Glutes", Difficulty.Easy, "Barbell", "-Lay down upwards while keeping your legs bended \n\n" +
                            "-Put a barbell on your lower abs and hold it tight while performing the exercise \n\n" +
                            "-Move your hips upwards until your torso is perfectly aligned with your legs and hold position for a while, go back to the starting position and repeat \n\n" +
                            "-Always do the strength with your glutes"),
                            new Exercise("Single-Legged Glute Bridge", "Glutes", Difficulty.Hard, "Bodyweight", "-Lay down upwards while keeping one of your legs bended and the other one straight in the air \n\n" +
                            "-Move your hips upwards until your torso is perfectly aligned with your legs and hold position for a while, go back to the starting position and repeat \n\n" +
                            "-When performing the strength keep your hands sticked to the ground \n\n" +
                            "-Always do the strength with your glutes"),
                            new Exercise("Glute KickBack", "Glutes", Difficulty.Easy, "Bodyweight", "-Get on all fours and without unbending your legs move one of your legs up \n\n" +
                            "-Stop when your upper leg align perfectly with your torso, return to the start position and continue with the other leg"),
                            new Exercise("Flutter Kicks", "Glutes", Difficulty.Easy, "Bodyweight", "-Lay down downwards on a bench (only your torso should be on the bench) \n\n" +
                            "-Move one leg up and the other leg down continuously but not too fast"),
                            new Exercise("Pull Through", "Glutes", Difficulty.Easy, "Cable", "-Stand up with your back to the cable machine and open your legs enough \n\n" +
                            "-Bend down and grab the rope grip keeping it always within your legs \n\n" +
                            "-Pull the rope without using arm strength, only hip and glutes \n\n" +
                            "-Go back to the start position and repeat"),
                            new Exercise("Barbell Hip Thrust", "Glutes", Difficulty.Easy, "Barbell", "-Support your scapula on a bench \n\n" +
                            "-Your legs should be bended and your feet must be touching the ground \n\n" +
                            "-Place a barbell on your lower abs, move up your hips, go back to the start position and repeat"),
                            new Exercise("Single-Legged Cable Hip Extension", "Glutes", Difficulty.Easy, "Cable", "-Stand up in front of the cable machine but don't support yourself in the machine \n\n" +
                            "-Send your leg back enough but don't bend your knees \n\n" +
                            "-Go back to the start Position and repeat")
                        },
                        new ExerciseGroupList("Adductors", "AD")
                        {
                            new Exercise("Machine Hip Adduction", "Adductors", Difficulty.Easy, "Machine", "-Seat and perform the exercise"),
                            new Exercise("Cable Hip Adduction", "Adductors", Difficulty.Easy, "Cable", "-Stand up next to the machine, your shoulder should be almost touching the cable \n\n" +
                            "-The closest leg to the machine should perform the exercise \n\n" +
                            "-Move your leg in front of the other one, just like if you were kicking a soccer ball \n\n" +
                            "-For better positioning support your hand in the machine frame \n\n" +
                            "-Go back to the start position and repeat until fulfill your reps and start latter with the other leg"),
                            new Exercise("Groiners", "Adductors", Difficulty.Medium, "Bodyweight", "-Adopt a push-up position \n\n" +
                            "-Send both legs frontwards until they touch your triceps \n\n" +
                            "-Return to the start position ans start again"),
                            new Exercise("Single-Legged Groiners", "Adductors", Difficulty.Easy, "Bodyweight", "-Adopt a push-up position \n\n" +
                            "-Send one leg to the front until you touch your triceps \n\n" +
                            "-Return to the start position and alternate with the other leg")
                        },
                        new ExerciseGroupList("Abductors", "AB")
                        {
                            new Exercise("Machine Hip Abduction", "Abductors", Difficulty.Easy, "Machine", "-Seat an perform the exercise \n\n" +
                            "-Start to curl"),
                            new Exercise("Cable Hip Abduction", "Abductors", Difficulty.Easy, "Cable", "-Stand up next to the machine, your shoulder should be almost touching the cable \n\n" +
                            "-The farthest leg to the machine should perform the exercise \n\n" +
                            "-Move your leg away from the other one \n\n" +
                            "-For better positioning support your hand in the machine frame \n\n" +
                            "-Go back to the start position and repeat until fulfill your reps and start latter with the other leg"),
                            new Exercise("Clam", "Abductors", Difficulty.Easy, "Bodyweight", "-Lie on your side bending your legs \n\n" +
                            "-Your torso and your upper legs should be forming a 90 degree angle \n\n" +
                            "-Always keep your feet together \n\n" +
                            "-While keeping one leg steady move down the other until you can't go further"),
                            new Exercise("Fire Hydrant", "Abductors", Difficulty.Easy, "Bodyweight", "-Get on all four \n\n" +
                            "-Move one leg to that side keeping your knee bended, finish those leg reps and start again withe the other leg")
                        }
                    };
                    break;

                case "Hamstrings":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("DeadLifts", "D")
                        {
                            new Exercise("Clean DeadLift", "Hamstrings", Difficulty.Medium, "Barbell", "-Align your feet and separate them enough \n\n" +
                            "-Keep your back straight and your chest forward as you perform the exercise \n\n" +
                            "-Keep your knees between your arms \n\n" +
                            "-Go down until you reach 90 degrees or until you touch the ground"),
                            new Exercise("Sumo Deadlift", "Hamstrings", Difficulty.Medium, "Barbell", "-Align your feet and separate them enough \n\n" +
                            "-Keep your back straight and your chest forward as you perform the exercise \n\n" +
                            "-Open your legs enough that knees are constantly outside your arms \n\n" +
                            "-Go down until you reach 90 degrees or until you touch the ground"),
                            new Exercise("Stiff Leg Deadlift", "Hamstrings", Difficulty.Easy, "Barbell", "-Align your feet and separate them enough \n\n" +
                            "-Keep your back straight and your chest forward as you perform the exercise \n\n" +
                            "-Keep your legs stiff, don't bend your knees" +
                            "-Go down and touch the ground if possible"),
                            new Exercise("Romanian Deadlift", "Hamstrings", Difficulty.Easy, "Barbell", "-Align your feet and separate them enough \n\n" +
                            "-Keep your back straight and your chest forward as you perform the exercise \n\n" +
                            "-Slightly bend your knees to permit your glutes to back off a little\n\n" +
                            "-Go down keeping a good range of motion, but without touching the ground"),
                            new Exercise("Dumbbell Deadlift", "Hamstrings", Difficulty.Easy, "Dumbbells", "-Align your feet and separate them enough \n\n" +
                            "-Keep your back straight and your chest forward as you perform the exercise \n\n" +
                            "-Slightly bend your knees to permit your glutes to back off a little\n\n" +
                            "-Go down keeping a good range of motion, but without touching the ground"),
                            new Exercise("Kettlebell One-Legged Deadlift", "Hamstrings", Difficulty.Medium, "Kettlebell", "-Align your feet and separate them enough \n\n" +
                            "-Keep your back straight and your chest forward as you perform the exercise \n\n" +
                            "-Slightly bend your working knee to permit your glutes and your other leg to back off \n\n" +
                            "-Go down and touch the ground with the Kettlebell"),
                        },
                        new ExerciseGroupList("Leg Curls", "L")
                        {
                            new Exercise("Lying Machine Leg Curl", "Hamstrings", Difficulty.Easy, "Machine", "-Lay down on the machine and start to curl"),
                            new Exercise("Seated Machine Leg Curl", "Hamstrings", Difficulty.Easy, "Machine", "-Seat down on the machine chair and start to curl"),
                            new Exercise("Standing One-Legged Machine Leg Curl", "Hamstrings", Difficulty.Easy, "Machine", "-Alternate legs when completing the number of desired reps for each leg"),
                            new Exercise("Dumbbell Leg Curl", "Hamstrings", Difficulty.Easy, "Dumbbell", "-Lay down in a bench \n\n" +
                            "-Let someone help you when placing the dumbbell at your feet \n\n" +
                            "-Let the plant of your feet hold the dumbbell \n\n" +
                            "-Start curling"),
                            new Exercise("Stability Ball Leg Curl", "Hamstrings", Difficulty.Easy, "Bodyweight", "-Place your heels in the ball \n\n" +
                            "-Keep your glutes and abs up and tight \n\n" +
                            "-Keep in mind that only your shoulders should be touching the ground \n\n" +
                            "-Start to roll the ball to your glutes and return to the start position"),
                        },
                        new ExerciseGroupList("Other", "O")
                        {
                            new Exercise("Box Jump", "Hamstrings", Difficulty.Easy, "Bodyweight", "-Adopt a squat position and jump \n\n" +
                            "-Land carefully on the box \n\n" +
                            "-Jump back to the start position")
                        }
                    };
                    break;
                case "Calves":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Calf Raises", "C")
                        {
                            new Exercise("Smith Machine Calf Raise", "Calves", Difficulty.Easy, "Smith Machine", "-Raise your calves, stand on ends and repeat"),
                            new Exercise("Seated Machine Calf Raise", "Calves", Difficulty.Medium, "Machine", "-Seat down, raise your calves and repeat")
                        },
                        new ExerciseGroupList("Other", "O")
                        {
                            new Exercise("Calf Press", "Calves", Difficulty.Easy, "Machine", "-Seat down on the Leg Press machine, raise your calves and repeat"),
                        }
                    };
                    break;
                case "Triceps":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Dips", "D")
                        {
                            new Exercise("Bodyweight dip", "Triceps", Difficulty.Hard, "Bodyweight", "-Keep your body completely straight \n\n" +
                            "-Go down until you reach 90 degrees"),
                            new Exercise("Machine dip", "Triceps", Difficulty.Easy, "Machine", "-Seat down on the machine chair \n\n" +
                            "-Go down until you reach 90 degrees"),
                            new Exercise("Bench dip", "Triceps", Difficulty.Easy, "Bodyweight", "-Support your hands on the corner of the bench \n\n" +
                            "-Go down until you reach 90 degrees \n\n" +
                            "-Don't help your self with your legs keep the tension in the triceps")
                        },
                        new ExerciseGroupList("Extensions", "E")
                        {
                            new Exercise("Barbell SkullCrusher", "Triceps", Difficulty.Medium, "Barbell", "-Lay down upwards on a bench and take the barbell with a medium-close grip \n\n" +
                            "-Go down until you reach 90 degrees or until you reach your nose, always keep the bar within the range of your face when going down \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Incline Barbell SkullCrusher", "Triceps", Difficulty.Medium, "Barbell", "-Lay down upwards on an incline bench and take the barbell with a medium-close grip \n\n" +
                            "-Go down until you reach 45 degrees or until you reach your nose, always keep the bar within the range of your face when going down \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Decline Barbell SkullCrusher", "Triceps", Difficulty.Medium, "Barbell", "-Lay down upwards on a decline bench and take the barbell with a medium-close grip \n\n" +
                            "-Go down until you reach 45 degrees or until you reach your nose, always keep the bar within the range of your face when going down \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Barbell Triceps Extension", "Triceps", Difficulty.Easy, "Barbell", "-Lay down upwards on a bench and take the barbell with a medium-close grip \n\n" +
                            "-Go down until you reach 45 degrees or  more, always keep the bar outside the range of your face when going down \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Dumbbell Triceps Extension", "Triceps", Difficulty.Easy, "Dumbbells", "-Lay down upwards on a bench and take the dumbbells with a vertical orientation \n\n" +
                            "-Go down until you reach 45 degrees or  more, always keep the bar outside the range of your face when going down \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Overhead Cable Triceps Extension", "Triceps", Difficulty.Easy, "Cable", "-Extend your triceps until your arms are completely straight \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Overhead One Arm Cable Triceps Extension", "Triceps", Difficulty.Easy, "Cable", "-Extend your triceps until your arms are completely straight \n\n" +
                            "-Work with the other arm after finish the current arm reps \n\n" +
                            "-Always keep your shoulder in the same position"),
                            new Exercise("Cable Push-down", "Triceps", Difficulty.Easy, "Cable", "-Extend your triceps until your arms are completely straight \n\n" +
                            "-Always keep your shoulders in the same position"),
                            new Exercise("Tate Press", "Triceps", Difficulty.Easy, "Dumbbells", "-Lay down upwards on a bench and take the dumbbells with an horizontal orientation \n\n" +
                            "-Go down bending your arms perpendicularly to your torso until pecs are reached"),
                            new Exercise("Standing Triceps Kickback", "Triceps", Difficulty.Medium, "Dumbbells", "-Back off your glutes, keep your back straight and your pecs forward adopting an incline position \n\n" +
                            "-Place your arms at the same level than your torso while keeping them bended \n\n" +
                            "-Send your forearms back and stop when your arm and forearm align perfectly"),
                            new Exercise("Seated Triceps Kickback", "Triceps", Difficulty.Medium, "Dumbbells", "-Keep your back straight and your pecs forward adopting an incline position \n\n" +
                            "-Place your arms at the same level than your torso while keeping them bended \n\n" +
                            "-Send your forearms back and stop when your arm and forearm align perfectly")
                        },
                        new ExerciseGroupList("Presses", "P")
                        {
                            new Exercise("Narrow Grip Press", "Triceps", Difficulty.Easy, "Barbell", "-Lay down upwards on a bench and take the barbell with a considerately narrow grip \n\n" +
                            "-Go down until the barbell touches beside your chest"),
                            new Exercise("Close Push-ups", "Triceps", Difficulty.Hard, "Bodyweight", "-Keep your arms completely sticked to your torso and proceed"),
                            new Exercise("Diamond Push-ups", "Triceps", Difficulty.Hard, "Bodyweight", "-Gather the palm of your hands in a way that they form a tear or a diamond \n\n" +
                            "-Keep your hands slightly above your pecs and proceed"),
                            new Exercise("Body-ups", "Triceps", Difficulty.Hard, "Bodyweight", "-Keep your arms completely sticked to your torso and proceed"),
                        }
                    };
                    break;
                case "Pecs":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Chest Presses","CP")
                        {
                            new Exercise("Bench Press", "Pecs", Difficulty.Hard, "Barbell", "-Lay down on the bench press an lift \n\n" +
                            "-While keeping your arms bended, go down until you reach just below your nipples \n\n" +
                            "-Breath when going down and release when going up"),
                            new Exercise("Incline Bench Press", "Pecs", Difficulty.Easy, "Barbell", "-Lay down on the incline bench press an lift \n\n" +
                            "-While keeping your arms bended, go down until you reach your upper chest \n\n" +
                            "-Breathe when going down and release when going up"),
                            new Exercise("Decline Bench Press", "Pecs", Difficulty.Easy, "Barbell", "-Lay down on the decline bench press an lift \n\n" +
                            "-While keeping your arms bended, go down until you reach your lower chest \n\n" +
                            "-Breathe when going down and release when going up"),
                            new Exercise("Dumbbell Bench Press", "Pecs", Difficulty.Medium, "Dumbbells", "-Lay down on the bench press an lift \n\n" +
                            "-While keeping your arms bended, go down until you reach your nipples \n\n" +
                            "-Breathe when going down and release when going up"),
                            new Exercise("Incline Dumbbell Bench Press", "Pecs", Difficulty.Medium, "Dumbbells", "-Lay down on the incline bench press an lift \n\n" +
                            "-While keeping your arms bended, go down until you reach your upper chest \n\n" +
                            "-Breathe when going down and release when going up"),
                            new Exercise("Decline Dumbbell Bench Press", "Pecs", Difficulty.Medium, "Dumbbells", "-Lay down on the decline bench press an lift \n\n" +
                            "-While keeping your arms bended, go down until you reach your lower chest \n\n" +
                            "-Breathe when going down and release when going up"),
                            new Exercise("Plate Press", "Pecs", Difficulty.Medium, "Plate", "-Lay down on the bench press an lift \n\n" +
                            "-Always go down until you reach just between your pecs \n\n" +
                            "-Breathe when going down and release when going up"),
                            new Exercise("Svend Press", "Pecs", Difficulty.Medium, "Plate", "-Stand up, grab a plate, squeeze it only with the palm of your hands, keeping it in front of your chest \n\n" +
                            "-While squeezing it move it forward and backward until finish the reps \n\n" +
                            "-Don't go to fast performing the exercise"),
                            new Exercise("Machine Press", "Pecs", Difficulty.Easy, "Machine",  "-Lay down on the machine's bench an lift"),
                            new Exercise("Standing Cable Press", "Pecs", Difficulty.Easy, "Cable", "-Stand up handing the cable handles with your desired weight on each side \n\n" +
                            "-Always keep your arms slightly below your shoulder level \n\n" +
                            "-Perform the Press exercise always adopting a steady position"),
                            new Exercise("Cross-Over X", "Pecs", Difficulty.Easy, "Cable", "-Stand up handing the cable handles with your desired weight on each side \n\n" +
                            "-Always keep your arms bended, slightly below your shoulder level and with your fists pointing down \n\n" +
                            "-Press until you cross both hands, return to the start position and repeat"),
                        },
                        new ExerciseGroupList("Flyes","F")
                        {
                            new Exercise("Flyes", "Pecs", Difficulty.Easy, "Machine", "-Lay down on the bench \n\n" +
                            "-Always keep your arms stretched and slightly below your shoulder level"),
                            new Exercise("Incline Flyes", "Pecs", Difficulty.Easy, "Machine", "-Lay down on the incline bench \n\n" +
                            "-Always keep your arms stretched and slightly below your shoulder level"),
                            new Exercise("Decline Flyes", "Pecs", Difficulty.Easy, "Machine", "-Lay down on the decline bench \n\n" +
                            "-Always keep your arms stretched and slightly below your shoulder level"),
                            new Exercise("Around The Worlds", "Pecs", Difficulty.Medium, "Machine", "-Lay down on the bench \n\n" +
                            "-Always keep your arms stretched \n\n" +
                            "-Start to move your arms from when the dumbbells are touching the side of your legs until they met just above your head \n\n" +
                            "-Try to keep your arms always at the same level"),
                            new Exercise("Cable Flyes", "Pecs", Difficulty.Easy, "Cable", "-Stand up handing the cable handles with your desired weight on each side \n\n" +
                            "-Always keep your arms stretched and slightly below your shoulder level \n\n" +
                            "-Perform the Fly until both fist met, return to the start position and repeat"),
                            new Exercise("Cable Chest Raises", "Pecs", Difficulty.Easy, "Cable", "-Stand up handing the cable handles with your desired weight on each side \n\n" +
                            "-At the start position you must handle the handles next to each leg \n\n" +
                            "-Perform the raise until both fist met side to side and you reach the level of your shoulders"),
                            new Exercise("Standing Cable Top-Down Flyes", "Pecs", Difficulty.Easy, "Cable", "-Stand up handing the cable handles with your desired weight on each side \n\n" +
                            "-At the start position you must handle the handles at the same level of your shoulders \n\n" +
                            "-Perform the raise until both fist met below your hips")
                        },
                        new ExerciseGroupList("Push-Ups","P")
                        {
                            new Exercise("Push-ups", "Pecs", Difficulty.Easy, "Bodyweight", "-Keep your glutes steady and push"),
                            new Exercise("Archer Push-ups", "Pecs", Difficulty.Easy, "Bodyweight", "-Keep your glutes steady and push one side at a time \n\n" +
                            "-Alternate the arm that you use to push after 1 rep and repeat"),
                            new Exercise("One Arm Push-ups", "Pecs", Difficulty.Medium, "Bodyweight", "-Keep your glutes steady and both legs open enough to give some stability while performing the exercise \n\n" +
                            "-Keep your torso slightly rotated to the opposite arm with which you will start to push, after finishing the desired reps continue with the other arm and repeat"),
                            new Exercise("Thumbs Up Push-ups", "Pecs", Difficulty.Medium, "Bodyweight", "-Keep your glutes steady, push while keeping your arms considerably away from each other and... keep your thumbs up"),
                            new Exercise("Isometrical Wipers", "Pecs", Difficulty.Easy, "Bodyweight", "-Keep your glutes steady and keep your arms considerably away from each other \n\n" +
                            "-Move to one side only using your arms, the arm in that side should be bended and the arm on the other side should be really stretched")
                        },
                        new ExerciseGroupList("Other","O")
                        {
                            new Exercise("Chest Plate Raises", "Pecs", Difficulty.Easy, "Plate","-Stand up, grab a plate, squeeze it only with the palm of your hands, keeping it down \n\n" +
                            "-While squeezing it move it upwards until the level of your shoulders \n\n" +
                            "-Slowly go down to the start position and repeat"),
                            new Exercise("Chest Dip", "Pecs", Difficulty.Easy, "Bodyweight", "-Bend your body considerably so that your glutes can back off a little \n\n" +
                            "-Go down until you reach 90 degrees")
                        }
                    };
                    break;
                case "Abs":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Leg Raises","L")
                        {
                            new Exercise("Lying Leg Raises", "Abs", Difficulty.Hard, "Bodyweight", "-Lay down and raise your legs until reaching 90 degrees \n\n" +
                            "-Go down until you reach 90 degrees"),
                            new Exercise("Hanging Leg Raises", "Abs", Difficulty.Easy, "Bodyweight", "-Hang up in a pull-up bar and raise your legs until reaching 90 degrees \n\n" +
                            "-Go down until you reach 90 degrees")
                        },
                        new ExerciseGroupList("Crunches","C")
                        {
                            new Exercise("Crunches", "Abs", Difficulty.Easy, "Bodyweight", "-Lay down while keeping your legs bended \n\n" +
                            "-Slightly move your torso upwards until your back just left the ground"),
                            new Exercise("Decline Crunches", "Abs", Difficulty.Medium, "Bodyweight", "-Lay down on a decline bench \n\n" +
                            "-Slightly move your torso upwards until your back just left the bench"),
                            new Exercise("Oblique Crunches", "Abs", Difficulty.Medium, "Bodyweight", "-Lie on your side and bend your body in that same position allowing your feet and torso to go up a little \n\n" +
                            "-Finish those side reps, start again with the other side and repeat"),
                            new Exercise("Elbow To Knee Crunches", "Abs", Difficulty.Medium, "Bodyweight", "-Lay down while keeping your legs bended \n\n" +
                            "-Slightly move your torso upwards one side a time \n\n" +
                            "-When the knee that is opposite to your working arm is touched by the elbow return to the start position and repeat"),
                            new Exercise("Hanging Feet Crunches", "Abs", Difficulty.Easy, "Bodyweight", "-Lay down while keeping your legs straight and up, forming a 45-60 degree angle with the floor \n\n" +
                            "-Slightly move your torso, touch your feet if possible and repeat"),
                            new Exercise("Reverse Crunch", "Abs", Difficulty.Easy, "Bodyweight", "-Lay down while keeping your legs bended and your arms sticked to the ground \n\n" +
                            "-Without taking off your arms and your upper torso from the ground move your legs and waist up until your glutes just left the ground \n\n" +
                            "-touch your nose with your knees if possible"),
                            new Exercise("V-up", "Abs", Difficulty.Easy, "Bodyweight", "-Lay down while keeping your legs straight and your arms above your head \n\n" +
                            "-Put your legs up and your torso up until you form a v-shape with your body \n\n" +
                            "-Try to touch your feet with your hands"),
                            new Exercise("Cocoons", "Abs", Difficulty.Easy, "Bodyweight", "-Lay down while keeping your legs straight and your hands behind your head \n\n" +
                            "-Bring your legs towards your chest and move slightly your torso upwards until you form like a cocoon shape"),
                            new Exercise("Ab Bicycle", "Abs", Difficulty.Easy, "Bodyweight", "-Do elbow to knee crunches but altering knee and elbow on each rep")
                        },
                        new ExerciseGroupList("Plank Type Exercises","P")
                        {
                            new Exercise("Plank", "Abs", Difficulty.Medium, "Dumbbells", "-Lay down downwards supporting your elbows and forearms in the ground \n\n" +
                            "-Keep your glutes steady maintaining all of your body straight \n\n" +
                            "-Hold position for at least 30 seconds"),
                            new Exercise("Plate Loaded Plank", "Abs", Difficulty.Medium, "Dumbbells", "-Lay down downwards supporting your elbows and forearms in the ground \n\n" +
                            "-Keep your glutes steady maintaining all of your body straight \n\n" +
                            "-May you ask someone for help for put the weighted plate on your lower back \n\n" +
                            "-Hold position for at least 30 seconds"),
                            new Exercise("One-Legged Plank", "Abs", Difficulty.Medium, "Dumbbells", "-Lay down downwards supporting your elbows and forearms in the ground \n\n" +
                            "-Keep your glutes steady maintaining all of your body straight \n\n" +
                            "-Hold position for at least 30 seconds and don't forget to lift one of your legs during this time"),
                            new Exercise("Dragon Flag", "Abs", Difficulty.Hard, "Dumbbells", "-Lay down while handing in something heavy or something that is sticked to the ground \n\n" +
                            "-Use momentum to get your legs and your lower torso up in the air, the upper, the better, you should be supporting all the weight only in your scapula and upper torso, only those body parts should be touching the ground \n\n" +
                            "-Hold your position and start to go down your legs and lower torso really slowly until your heels touch the ground \n\n" +
                            "-Your body should be straight all the time"),
                            new Exercise("L-sits", "Abs", Difficulty.Medium, "Dumbbells", "-Handle in the parallel bars and keep your torso thigh and steady \n\n" +
                            "-Raise your legs until reaching 90 degrees and hold position for a minimum of 30 seconds \n\n" +
                            "-Don't bend your knees")
                        },
                        new ExerciseGroupList("Isolated Obliques Exercises","I")
                        {
                            new Exercise("Russian Twist", "Abs", Difficulty.Easy, "Bodyweight", "-Lay down while keeping your legs bended but without touching the ground with your feet \n\n" +
                            "-With a dumbbell or a plate start to rotate your torso without moving your legs until the plate reach the ground \n\n" +
                            "-rotate the opposite side and repeat"),
                            new Exercise("Plate Side Bend", "Abs", Difficulty.Medium, "Plate", "-Stand up and bend your torso left or right handing a weighted plate or a dumbbell \n\n" +
                            "-Once you finish with one side start with the other until the desired number of reps is fulfilled"),
                            new Exercise("Altering Heel Touch", "Abs", Difficulty.Medium, "Dumbbells", "-Lay down while keeping your legs bended \n\n" +
                            "-Bend your torso until you reach one of your heels, reach the other heel and repeat"),
                            new Exercise("Full Moon", "Abs", Difficulty.Medium, "Dumbbells", "-Seat down on the ground, only your glutes should be touching the ground \n\n" +
                            "-While having your torso back and near to the ground start to move both legs from one side to another moving up your legs when reaching the start position \n\n" +
                            "-The difficulty of the exercise can be raised if two dumbbells are putted one above the other and performing the exercise without touching any of them")
                        },
                        new ExerciseGroupList("Other","O")
                        {
                            new Exercise("Leg Cross", "Abs", Difficulty.Easy, "Bodyweight", "-Seat down on the ground, only your glutes should be touching the ground \n\n" +
                            "-While having your torso back and near to the ground start to cross your legs one above the other and repeat"),
                            new Exercise("Ab Roll-out", "Abs", Difficulty.Medium, "Dumbbells", "-Get on your knees and take the roll-out tool \n\n" +
                            "-Start to roll forwards until all your body is straight \n\n" +
                            "-Don't let your toes leave the ground, they should always be touching it"),
                            new Exercise("Frog Sit-ups", "Abs", Difficulty.Medium, "Dumbbells", "-Open your"),
                            new Exercise("Spider Crawl", "Abs", Difficulty.Medium, "Dumbbells", "-From a push up position, raise one foot off the floor and bring your knee up towards your elbow \n\n" +
                            "-Hold position then return to the starting position and repeat on the other side")
                        }
                    };
                    break;
                case "Quadriceps":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Squats","S")
                        {
                            new Exercise("Classic Squat", "Quadriceps", Difficulty.Hard, "Barbell", "-Let the barbell rest on your neck and shoulders when performing the exercise \n\n" +
                            "-Go down without letting your knees trespass your toes \n\n" +
                            "-Keep your back always straight and your chest forward"),
                            new Exercise("Smith Machine Squat", "Quadriceps", Difficulty.Easy, "Machine", "-Let the bar rest on your neck and shoulders when performing the exercise \n\n" +
                            "-Go down without letting your knees trespass your toes \n\n" +
                            "-Keep your back always straight and your chest forward"),
                            new Exercise("Hack Squat", "Quadriceps", Difficulty.Medium, "Machine", "-keep always your lower back well sticked to machine when performing the exercise \n\n" +
                            "-Go down without letting your knees trespass your toes"),
                            new Exercise("Machine Squat", "Quadriceps", Difficulty.Medium, "Machine", "-Go down without letting your knees trespass your toes \n\n" +
                            "-Keep your back always straight and your chest forward"),
                            new Exercise("Jefferson Squat", "Quadriceps", Difficulty.Hard, "Barbell", "-Seat down on the machine chair \n\n" +
                            "-Go down until you reach 90 degrees"),
                            new Exercise("Dumbbell Sumo Squat", "Quadriceps", Difficulty.Easy, "Dumbbells", "-Open your legs and feet well enough and hold the dumbbell within your legs  when performing the exercise \n\n" +
                            "-Go down without letting your knees trespass your toes \n\n" +
                            "-Stand on a step if you want a better range of motion"),
                            new Exercise("Bodyweight Squat", "Quadriceps", Difficulty.Easy, "Dumbbells","-Go down without letting your knees trespass your toes"),
                            new Exercise("Alien Squat", "Quadriceps", Difficulty.Hard, "Bodyweight", "-Open your legs and feet well enough and squat down \n\n" +
                            "-Jump when going up and stretch your legs in the air"),
                            new Exercise("Bench Squat", "Quadriceps", Difficulty.Medium, "Barbell", "-Let the barbell rest on your neck and shoulders when performing the exercise \n\n" +
                            "-Go down until you sit \n\n" +
                            "-Keep your back always straight and your chest forward"),
                            new Exercise("Pistol Squat", "Quadriceps", Difficulty.Hard, "Bodyweight", "-Keep both arms in front of you for better stability \n\n" +
                            "-Go down without letting your working knee trespass your toe \n\n" +
                            "-Stop going down when 90 degrees or slightly less are reached \n\n" +
                            "-Finish those leg reps and start again with the other one"),
                            new Exercise("Explosive Jumps", "Quadriceps", Difficulty.Medium, "Bodyweight", "-Squat down and jump above a bench the higher you can \n\n" +
                            "-Repeat at the other side of the bench until reps are fulfilled")
                        },
                        new ExerciseGroupList("Lunge Type Exercises","L")
                        {
                            new Exercise("Scissor Jumps", "Quadriceps", Difficulty.Easy, "Bodyweight", "-Squat down with just one leg keeping the other one as support in the back \n\n" +
                            "-Jump for going up and change your working leg in the air and repeat"),
                            new Exercise("Walking Lunges", "Quadriceps", Difficulty.Easy, "Barbell", "-Squat down with just one leg keeping the other one as support in the back \n\n" +
                            "-Start to walk and alternate legs during the trajectory"),
                            new Exercise("Dumbbell Lunges", "Quadriceps", Difficulty.Easy, "Dumbbells", "-Squat down with just one leg keeping the other one as support in the back \n\n" +
                            "-Start to walk and alternate legs during the trajectory \n\n" +
                            "-Keep the dumbbells at each side of your hips, not on your shoulders")
                        },
                        new ExerciseGroupList("Machine Exercises","M")
                        {
                            new Exercise("Leg Extension", "Quadriceps", Difficulty.Easy, "Machine", "-Slightly bend your torso letting your glutes back-off a little \n\n" +
                            "-Go down until you reach 90 degrees"),
                            new Exercise("Leg Press", "Quadriceps", Difficulty.Medium, "Machine", "-Press the platform until your legs are perfectly stretched \n\n" +
                            "-When going down stop when your upper legs touch your chest"),
                            new Exercise("Single-Legged Leg Press", "Quadriceps", Difficulty.Medium, "Machine", "-Press the platform until your working leg is perfectly stretched \n\n" +
                            "-When going down stop when your working upper leg touch your chest")
                        }
                    };
                    break;
                case "Traps":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Shoulder Shrugs","S")
                        {
                            new Exercise("Smith Machine Shrug", "Traps", Difficulty.Hard, "Machine", "-Shrug your shoulders handing the bar \n\n" +
                            "-Don't help yourself with your biceps, try to isolate the exercise"),
                            new Exercise("Dumbbell Shrug", "Traps", Difficulty.Easy, "Dumbbells", "-Shrug your shoulders handing the dumbbells \n\n" +
                            "-Don't help yourself with your biceps, try to isolate the exercise"),
                            new Exercise("Barbell Shrug", "Traps", Difficulty.Easy, "Barbell", "-Shrug your shoulders handing the barbell \n\n" +
                            "-Don't help yourself with your biceps, try to isolate the exercise"),
                            new Exercise("Cable Shrug", "Traps", Difficulty.Medium, "Cable", "-Shrug your shoulders handing the handle \n\n" +
                            "-Don't help yourself with your biceps, try to isolate the exercise"),
                            new Exercise("Plate Shrug", "Traps", Difficulty.Medium, "Plate", "-Shrug your shoulders handing the plates (One plate for each arm) \n\n" +
                            "-Don't help yourself with your biceps, try to isolate the exercise")
                        },
                        new ExerciseGroupList("Upright Rows","U")
                        {
                            new Exercise("Smith Machine Upright Row", "Traps", Difficulty.Medium, "Machine", "-Start shrugging your shoulders \n\n" +
                            "-When they are completely shrugged bring the bar to your neck without curling but pushing your arms upwards \n\n" +
                            "-The adopted grip should be very narrow"),
                            new Exercise("Dumbbell Upright Row", "Traps", Difficulty.Easy, "Dumbbells", "-Start shrugging your shoulders \n\n" +
                            "-When they are completely shrugged bring the dumbbells to the neck level without curling but instead pushing your arms upwards"),
                            new Exercise("Barbell Upright Row", "Traps", Difficulty.Easy, "Barbell", "-Start shrugging your shoulders \n\n" +
                            "-When they are completely shrugged bring the barbell to your neck without curling but instead pushing your arms upwards \n\n" +
                            "-The adopted grip should be very narrow"),
                            new Exercise("Cable Upright Row", "Traps", Difficulty.Easy, "Cable", "-Start shrugging your shoulders \n\n" +
                            "-When they are completely shrugged bring the cable handle to your neck without curling but instead pushing your arms upwards \n\n" +
                            "-The adopted grip should be very narrow")
                        },
                        new ExerciseGroupList("Other","O")
                        {
                            new Exercise("Anti-Gravity Press", "Traps", Difficulty.Hard, "Dumbbells", "-Lay downwards on an incline bench \n\n" +
                            "-Take your dumbbells or barbell and keep it slightly below the level of your neck with your arms bended \n\n" +
                            "-The bench should not interfere with the range of motion \n\n" +
                            "-Press the weight in the same direction that your head is pointing at"),
                            new Exercise("Overhead plate Raises", "Traps", Difficulty.Easy, "Plate", "-Hold the plate in front of you forming a 90 degree angle \n\n" +
                            "-Raise the plate until it is just above your head \n\n" +
                            "-Return to the start position an repeat")
                        }
                    };
                    break;
                case "Delts":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Raises","R")
                        {
                            new Exercise("Frontal Dumbbell Raises", "Delts", Difficulty.Hard, "Bodyweight", "-Stand up keeping one leg slightly forward than the other one for better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Raise the dumbbells forward until they reach the level of your shoulders, return to the start position and repeat"),
                            new Exercise("Lateral Dumbbell Raises", "Delts", Difficulty.Easy, "Machine", "-Stand up keeping one leg slightly forward than the other one for better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Raise the dumbbells forward until they reach the level of your shoulders, return to the start position and repeat"),
                            new Exercise("Frontal Plate Raises", "Delts", Difficulty.Easy, "Bodyweight", "-Stand up keeping one leg slightly forward than the other one for better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Raise the plate forward until it reaches the level of your shoulders, return to the start position and repeat"),
                            new Exercise("Single-arm Lateral Cable Raises", "Delts", Difficulty.Medium, "Barbell", "-Stand up keeping opening your legs enough to keep better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Raise the cable handle to your side until it reaches the level of your shoulder, return to the start position and repeat \n\n" +
                            "-After finishing the desired reps for the working arm continue with the other one"),
                            new Exercise("Single-arm Frontal Cable Raises", "Delts", Difficulty.Medium, "Barbell", "-Stand up with the back to the machine and grab the handle \n\n" +
                            "-Keep one leg slightly forward than the other one for better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Raise the handle forward until it reaches the level of your shoulders, return to the start position and repeat"),
                            new Exercise("Single-arm Incline Bench Lateral Raises", "Delts", Difficulty.Medium, "Dumbbells", "-Lie on your side on an incline bench \n\n" +
                            "-Raise the dumbbell until it's perfectly aligned with your shoulder"),
                            new Exercise("Reverse Fly", "Delts", Difficulty.Medium, "Barbell", "-Sit on the corner of a bench and let your chest rest on your legs \n\n" +
                            "-Raise the dumbbells sideways until they are at the same scapula level \n\n" +
                            "-The higher the better"),
                            new Exercise("Incline Reverse Fly", "Delts", Difficulty.Easy, "Barbell", "-Lay down on an incline bench \n\n" +
                            "-Raise the dumbbells sideways until they are at the same scapula level \n\n" +
                            "-The higher the better")
                        },
                        new ExerciseGroupList("Presses","P")
                        {
                            new Exercise("Cuban Press", "Delts", Difficulty.Easy, "Dumbbells", "-Stand up keeping one leg slightly forward than the other one for better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Take both dumbbells and keep your arms bended sideways \n\n" +
                            "-Your upper arms should be forming a straight line with your shoulders and the start of your neck \n\n" +
                            "-Your fists should be facing down in the start position \n\n" +
                            "-Rotate your shoulders upwards until your fists are facing up and press the weight upwards until both dumbbells met at the top of your head \n\n" +
                            "-Go down, rotate your shoulders downwards until the start position is reached and start again until the desired number of reps are fulfilled \n\n" +
                            "-The weight should be pretty low to avoid injury"),
                            new Exercise("Military Press", "Delts", Difficulty.Easy, "Bodyweight", "-Stand up holding the barbell at the level of your chin \n\n" +
                            "-Press the weight up until your arms are completely straight \n\n" +
                            "-Return to the start position and start again"),
                            new Exercise("Dumbbell Military Press", "Delts", Difficulty.Medium, "Dumbbells", "-Stand up holding both dumbbells sideways at the same level of your head \n\n" +
                            "-Press the weight up until both dumbbells met at the top of your head \n\n" +
                            "-Return to the start position and start again"),
                            new Exercise("Arnold Press", "Delts", Difficulty.Medium, "Dumbbells", "-Stand up holding both dumbbells in front of you with your arms bended and your palms facing in \n\n" +
                            "-Press the dumbbells up rotating your shoulders progressively until both dumbbells met at the top of your head and your palms are now facing out \n\n" +
                            "-Return to the start position and start again"),
                            new Exercise("Smith Machine Shoulder Press", "Delts", Difficulty.Medium, "Dumbbells", "-Seat down on the Leg Press machine, raise your calves and repeat"),
                            new Exercise("Seated Dumbbell Shoulder Press", "Delts", Difficulty.Medium, "Dumbbells", "-Seat down holding both dumbbells sideways at the same level of your head \n\n" +
                            "-Press the weight up until both dumbbells met at the top of your head \n\n" +
                            "-Return to the start position and start again"),
                            new Exercise("Seated Barbell Shoulder Press", "Delts", Difficulty.Medium, "Dumbbells", "-Seat down holding the barbell at the level of your chin \n\n" +
                            "-Press the weight up until your arms are completely straight \n\n" +
                            "-Return to the start position and start again"),
                            new Exercise("Machine Shoulder Press", "Delts", Difficulty.Medium, "Dumbbells", "-Seat down on the shoulder press machine and grab the handles \n\n" +
                            "-Press the weight up until your arms are completely straight"),
                            new Exercise("Landmine Press", "Delts", Difficulty.Medium, "Dumbbells", "-Stand up holding the bar fairly close to the weighted plates \n\n" +
                            "-Bend your knees slightly, keep your back straight and your chest forward \n\n" +
                            "-Press the weight up until your arms are completely straight \n\n" +
                            "-Go down until the bar touches your inner chest and start again until the desired number of reps is fulfilled"),
                            new Exercise("Compound Press", "Delts", Difficulty.Medium, "Dumbbells", "-Seat down holding both dumbbells sideways at the same level of your head \n\n" +
                            "-Press the one arm's dumbbell up until the arm is completely straight \n\n" +
                            "-Bring down the dumbbell to the start position and continue with the other arm \n\n" +
                            "-Keep alternating your arms until the amount of desired reps is fulfilled")
                        },
                        new ExerciseGroupList("Rotation Based Exercises","RBE")
                        {
                            new Exercise("Car Driver", "Delts", Difficulty.Easy, "Dumbbells", "-Stand up keeping one leg slightly forward than the other one for better stability \n\n" +
                            "-Keep your body straight and your chest forward \n\n" +
                            "-Take a plate and hold it in front of you at your shoulders level \n\n" +
                            "-Rotate the plate One side to the other keeping your arms completely straight \n\n" +
                            "-Only your shoulders should move"),
                            new Exercise("External Cable Rotation", "Delts", Difficulty.Easy, "Machine", "-Kneel down and hold the cable handle \n\n" +
                            "-Your working shoulder should be at the opposite side of the machine \n\n" +
                            "-Rotate the handle outwards and away from your body \n\n" +
                            "-The farthest the better"),
                            new Exercise("Internal Cable Rotation", "Delts", Difficulty.Easy, "Machine", "-Kneel down and hold the cable handle \n\n" +
                            "-Your working shoulder should be next to the machine \n\n" +
                            "-Rotate the handle outwards and close to your body \n\n" +
                            "-Return to the start position when your upper abs are reached with the handle")
                        }  
                    };
                    break;
                case "Biceps":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Barbell Curls","BC")
                        {
                            new Exercise("Narrow Grip Curl", "Biceps", Difficulty.Hard, "Barbell", "-Keep a narrow grip while doing the curl, your forearms should be further inside your upper arms \n\n" +
                            "-Go up until the barbell reaches the same level of your neck \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Wide Grip Curl", "Biceps", Difficulty.Easy, "Barbell", "-Keep a wide grip while doing the curl, your forearms should be further outside your upper arms \n\n" +
                            "-Go up until the barbell reaches the same level of your neck \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Barbell Curl", "Biceps", Difficulty.Easy, "Barbell", "-Keep a normal grip while doing the curl, your forearms shouldn't be further inside or further outside your upper arms, they should be aligned with them \n\n" +
                            "-Go up until the barbell reaches the same level of your neck \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Spider Curl", "Biceps", Difficulty.Medium, "Barbell", "-Lay down downwards on an incline bench and take the barbell \n\n" +
                            "-Go up until your arms are completely bended \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Barbell Preacher Curl", "Biceps", Difficulty.Easy, "Barbell", "-Grab the barbell, let your triceps support on the pad and curl \n\n" +
                            "-Your arms should be completely straight at the start position and your back should be straight when performing the curl \n\n" +
                            "-Go up until your arms are completely bended"),
                            new Exercise("Barbell Reverse Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Grab the barbell and curl \n\n" +
                            "-But instead of starting and keeping your palms facing inwards (supinated grip), keep them facing outwards (pronated grip)")
                        },
                        new ExerciseGroupList("Dumbbell Curls","DC")
                        {
                            new Exercise("Dumbbell Curl", "Biceps", Difficulty.Medium, "Barbell", "-While holding the dumbbells your palms should be facing towards you at the start position \n\n" +
                            "-Go up until the dumbbells reach the same level of your neck (both arms at the same time) \n\n" +
                            "-When going up, rotate your forearms so that at the top your palms are facing in \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Alternate Dumbbell Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-While holding the dumbbells your palms should be facing towards you at the start position \n\n" +
                            "-Go up until the dumbbells reach the same level of your neck (one arm at a time) \n\n" +
                            "-When going up, rotate your forearm so that at the top your palm is facing in \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Standing Hammer Curl", "Biceps", Difficulty.Easy, "Barbell", "-Stand up and grab both dumbbells sideways keeping your palms facing towards you and curl (both arms at the same time) \n\n" +
                            "-Go up until your arms are completely bended \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Incline Bench Hammer Curl", "Biceps", Difficulty.Easy, "Dumbbells", "-Lay down on an incline bench and grab both dumbbells sideways keeping your palms facing towards you and curl \n\n" +
                            "-Go up until your arms are completely bended \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Alternate Hammer Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Stand up and grab both dumbbells sideways keeping your palms facing towards you and curl (one arm at a time) \n\n" +
                            "-Go up until your arms are completely bended \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Incline Bench Curl", "Biceps", Difficulty.Easy, "Machine", "-Lay down on an incline bench and grab both dumbbells sideways and curl (both arms at the same time) \n\n" +
                            "-Go up until your arms are completely bended \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Incline Bench Alternate Curl", "Biceps", Difficulty.Easy, "Machine", "-Lay down on an incline bench and grab both dumbbells sideways and curl (one arm at a time) \n\n" +
                            "-Go up until your arms are completely bended \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Preacher Curl", "Biceps", Difficulty.Easy, "Dumbbells", "-Grab the dumbbell, let your triceps support on the pad and curl until you complete the desired number of reps for each arm \n\n" +
                            "-Your arm should be completely straight at the start position and your back should be straight when performing the curl \n\n" +
                            "-Go up until your arm is completely bended"),
                            new Exercise("Zottman Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Grab the dumbbells sideways \n\n" +
                            "-At the top of the rep, rotate your forearms so that your palms are facing downwards \n\n" +
                            "-Bring the dumbbells back really slow"),
                            new Exercise("Concentration Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Seat down at the corner of a bench, grab a dumbbell and curl while letting your triceps rest on the inner part of your leg \n\n" +
                            "-Send your torso down enough so that the elbow of your working arm is below your upper leg"),
                            new Exercise("Dumbbell Reverse Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Grab your dumbbells sideways and curl \n\n" +
                            "-But when curling, instead of inner-rotating your forearms when going up, outer-rotate them so that at the top your palms are facing downwards"),
                            new Exercise("From Curl To Military Press", "Biceps", Difficulty.Medium, "Dumbbells", "-Stand up and curl \n\n" +
                            "-When reaching your upper chest rotate your shoulders to adopt a shoulder press position \n\n" +
                            "-Press the dumbbells up until they meet each other at the top of your head and send them back to the shoulder press starting position \n\n" +
                            "-Rotate your shoulders and send the dumbbells down to your hips until the overall starting position of the exercise is reached")
                        },
                        new ExerciseGroupList("Cable Curls and Other Type of Curls","CC")
                        {
                            new Exercise("Rope Grip Cable Curl", "Biceps", Difficulty.Easy, "Dumbbells", "-Curl handing the rope grip \n\n" +
                            "-Open the rope at the top and close it at the bottom"),
                            new Exercise("Overhead Cable Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Place yourself at the center of the both cable stations and grab both side handles, the right side and the left side \n\n" +
                            "-The cable should be at one of it's highest levels so that you can hold both handles easy keeping your arms bended and keeping both hands over your head \n\n" +
                            "-Curl until you almost reach your hears, go back to the start position and start again until the desired number of reps is fulfilled"),
                            new Exercise("Lying Cable Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Lay down on a bench, grab the cable handle and curl all the way up until the handle reaches the upper chest \n\n" +
                            "-Go down until your arms are completely straight \n\n" +
                            "-Don't use your shoulders at all when performing the exercise, just your biceps (if your shoulders/forearms are moving, you're doing it wrong)"),
                            new Exercise("Cable Reverse Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Grab the cable handle and curl \n\n" +
                            "-But instead of starting and keeping your palms facing inwards (supinated grip), keep them facing outwards (pronated grip)"),
                            new Exercise("Swiss Bar Curl", "Biceps", Difficulty.Easy, "Bodyweight", "-Curl handing the swiss bar by your desired grip \n\n" +
                            "-Go up until your arms are completely bended"),
                            new Exercise("Machine Preacher Curl", "Biceps", Difficulty.Medium, "Dumbbells", "-Grab the handles, let your triceps support on the pad and curl \n\n" +
                            "-Your arms should be completely straight at the start position and your back should be straight when performing the curl \n\n" +
                            "-Go up until your arms are completely bended"),
                            new Exercise("21", "Biceps", Difficulty.Medium, "Dumbbells", "-Handing your desired equipment (barbell, dumbbells, cable handle) start to curl \n\n" +
                            "-The first 7 reps are half range from the bottom to the middle \n\n" +
                            "-The next 7 reps are half range from the middle to the top \n\n" +
                            "-The last 7 reps are full range from the bottom to the top")
                        }
                    };
                    break;
                case "Back":
                    exercises.ItemsSource = new List<ExerciseGroupList>()
                    {
                        new ExerciseGroupList("Rows","R")
                        {
                            new Exercise("Single-arm Dumbbell Row", "Back", Difficulty.Hard, "Bodyweight", "-Support your not working arm and leg on the bench \n\n" +
                            "-Your other leg should be well supported on the ground and slightly bended \n\n" +
                            "-Your other arm should be holding the dumbbell \n\n" +
                            "-Keep your back straight and your chest forward when performing the exercise \n\n" +
                            "-Bring the dumbbell up until it touch your chest if possible \n\n" +
                            "-Bring the dumbbell down, repeat until the desired number of reps for the working arm are fulfilled and start again with the other arm"),
                            new Exercise("Standing Barbell Row", "Back", Difficulty.Easy, "Machine", "-Open your legs enough so they can give a good support when performing the exercise \n\n" +
                            "-Stick your glutes out, keep the back straight and the chest forward \n\n" +
                            "-Bring the barbell to your lower chest and repeat until the desired number of reps is fulfilled"),
                            new Exercise("Cable Row", "Back", Difficulty.Medium, "Barbell", "-Hold the cable V-handle and bring it to your chest while keeping your back straight and your chest forward"),
                            new Exercise("Single-arm Seated Cable Row", "Back", Difficulty.Easy, "Bodyweight", "-Hold the cable handle and bring it to your chest while keeping your back straight and your chest forward \n\n" +
                            "-Change your working arm when finishing the desired number of reps for that side"),
                            new Exercise("Shotgun Row", "Back", Difficulty.Medium, "Barbell", "-Bend one leg and let your torso supported on it \n\n" +
                            "-Keep the other leg well straight and perpendicular to your other leg \n\n" +
                            "-Bring the cable handle to your chest \n\n" +
                            "-Take it back to the start position, in which your arm should be straight and perfectly align with your torso"),
                            new Exercise("Incline Bench Dumbbell Row", "Back", Difficulty.Medium, "Barbell", "-Lay down downwards on an incline bench and bring the dumbbells up to your chest until you can't bring them closer"),
                            new Exercise("Incline Bench Barbell Row", "Back", Difficulty.Easy, "Dumbbells","-Lay down downwards on an incline bench and bring the barbell up to your chest until you can't bring them closer"),
                            new Exercise("T-Bar Row With Handle", "Back", Difficulty.Easy, "Barbell", "-Open your legs enough so they can give a good support when performing the exercise \n\n" +
                            "-Stick your glutes out, keep the back straight and the chest forward \n\n" +
                            "-Bring the bar to your inner chest and repeat until the desired number of reps is fulfilled"),
                            new Exercise("Inverted Row", "Back", Difficulty.Easy, "Dumbbells", "-Hold yourself from a smith machine bar keeping your body completely straight \n\n" +
                            "-Pull and bring your body up until your chest touch the bar without leaving your feet off the ground \n\n" +
                            "-Go down and start again until the desired number of reps is fulfilled"),
                            new Exercise("Machine Row", "Back", Difficulty.Easy, "Dumbbells", "-Seat down and bring the machine handles to your chest, repeat until finish your reps")
                        },

                        new ExerciseGroupList("Pull-Ups And Pull-Downs","P")
                        {
                            new Exercise("Pull-up", "Back", Difficulty.Hard, "Machine", "-Hold yourself from the pull-up bar and bring yourself up until you touch the bar with your chest \n\n" +
                            "-You must hold the bar with a wide outward grip (pronated grip) \n\n" +
                            "-Go down and start again"),
                            new Exercise("Assisted Pull-up", "Back", Difficulty.Easy, "Machine", "-Hold yourself from the pull-up bar and bring yourself up until you touch the bar with your chest \n\n" +
                            "-You must hold the bar with a outward grip (pronated grip) \n\n" +
                            "-Go down always keeping your knees on the pad and start again"),
                            new Exercise("Lat Pull-down", "Back", Difficulty.Easy, "Dumbbells", "-Seat down, hold yourself from the cable bar and bring it down until you touch your chest with the bar \n\n" +
                            "-You must hold the bar with a wide outward grip (pronated grip) \n\n" +
                            "-Keep your back straight and your chest forward when performing the exercise"),
                            new Exercise("V-handle Lat Pull-down", "Back", Difficulty.Easy, "Bodyweight", "-Seat down, hold yourself from the cable V-handle and bring it down until you touch your chest with it \n\n" +
                            "-Keep your back straight and your chest forward when performing the exercise"),
                            new Exercise("Behind The Neck Pull-down", "Back", Difficulty.Medium, "Dumbbells", "-Seat down, hold yourself from the cable bar and bring it down behind your neck until you touch the bas of your neck \n\n" +
                            "-You must hold the bar with a wide outward grip (pronated grip)"),
                            new Exercise("Straight Arm Pull-down", "Back", Difficulty.Medium, "Dumbbells", "-You can stand either completely straight or considerably bending your body letting your glutes back-off \n\n" +
                            "-Pull-down the cable handle keeping your arms always straight until you touch your hips with the handle"),
                            new Exercise("Chin-up", "Back", Difficulty.Medium, "Dumbbells", "-Hold yourself from the pull-up bar and bring yourself up until your chin is above the bar \n\n" +
                            "-You must hold the bar with a medium narrow inward grip (supinated grip) \n\n" +
                            "-Go down and start again"),
                            new Exercise("Pullover", "Back", Difficulty.Medium, "Dumbbells", "-Lay down upwards on a bench holding a dumbbell behind your head \n\n" +
                            "-Pull the dumbbell over your head and start bringing it down to your chest"),
                            new Exercise("Incline Bench Pullover", "Back", Difficulty.Medium, "Dumbbells", "-Lay down upwards on an incline bench holding a dumbbell behind your head \n\n" +
                            "-Pull the dumbbell over your head and start bringing it down to your chest")
                        },
                        new ExerciseGroupList("Lower Back Exercises","L")
                        {
                            new Exercise("Skydiver", "Back", Difficulty.Medium, "Dumbbells", "-Lay down downwards on the ground and stretch both arms in front of you \n\n" +
                            "-Lift your chest, arms and legs off the ground straining the lower back and hold position for at least 30 seconds"),
                            new Exercise("Superman", "Back", Difficulty.Medium, "Dumbbells", "-Lay down downwards on the ground and stretch both arms in front of you \n\n" +
                            "-Lift your chest, arms and legs off the ground straining the lower back hold position form maximum 3 seconds and repeat until the desired number of reps is fulfilled"),
                            new Exercise("Back Extension", "Back", Difficulty.Medium, "Dumbbells", "-Support your hips and upper legs on the pad \n\n" +
                            "-Go down until you can't go further \n\n" +
                            "-Go down extending your body until it is completely straight \n\n" +
                            "-Hold weighted plates in your chest for progression \n\n"),
                            new Exercise("Machine Seated Back Extension", "Back", Difficulty.Medium, "Dumbbells", "-Seat down on the back extension machine, put your feet on the ground platforms and extend your torso all the way back until you can't back off more \n\n" +
                            "-Return to the start position and repeat to complete the desired amount of reps"),
                            new Exercise("Lower Back Raises", "Back", Difficulty.Medium, "Dumbbells", "-Lay down downwards on the ground and keep your hands behind your head \n\n" +
                            "-Lift your chest and upper torso off the ground straining the lower back and hold position for at least 3 seconds \n\n" +
                            "-Go down and repeat until the desired number of reps is fulfilled"),
                            new Exercise("Seated Good Morning", "Back", Difficulty.Medium, "Dumbbells", "-Seat down on a bench, put the barbell behind your neck and open your legs all you possibly can \n\n" +
                            "-Bring your torso down until your abs touch the bench \n\n" +
                            "-Return to the start position and repeat until the desired number of reps is fulfilled")
                        },
                    };
                    break;
                default:
                    Console.WriteLine("[Error]: muscleGroup parameter is unknown");
                    break;
            }
        }

        private async void Exercises_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedExercise = e.Item as Exercise;
            if(tappedExercise != null)
            {
                await Navigation.PushAsync(new ExerciseInfoPage(isForCurrentRoutine, currentRoutine, isForNewRoutine, tappedExercise) { Title = tappedExercise.Name });
            }
        }
    }
}