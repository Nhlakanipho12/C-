using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxCalculate_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Age = Convert.ToInt32(txtAge.Text);
            double Weight = Convert.ToDouble(txtWeight.Text);
            double Height = Convert.ToDouble(txtHeight.Text);
            int ExerciseLevelPercentage = Convert.ToInt32(comboLevel.SelectedItem.ToString());
            int shuttles = Convert.ToInt32(comboShuttle.SelectedItem.ToString());

            string time = txtTime.Text;
            string HeightConvertion = comboHeight.SelectedItem.ToString();
            string WeightConvertion = comboBox1.SelectedItem.ToString();
            string level = comboCurrentLevel.SelectedItem.ToString();
            string gender = comboSex.SelectedItem.ToString();

            //formula workings
            double heartRate = calcHeartRateNormal(Age, ExerciseLevelPercentage);
            int Displacement = distance(shuttles);
            double BMI = BMICalculation(WeightConvertion, HeightConvertion, Weight, Height);
            int sex = GenderNum(gender);
            double timeLap = convertToSeconds(time);

            //VO2 Max calculation
            double vo2Max = calculateVo2Max(Weight, Age, sex, timeLap, heartRate);
        }

        //HeartRate
        public double calcHeartRateNormal(int age, double level)
        {
            double convertTopercentage;
            int constant = 220;

            convertTopercentage = level / 100.00;



            return convertTopercentage * (constant - age);
        }

        //Total Time
        public double TotalLevelTime(int shuttles, double TimePerShuttle)
        {
            double total = shuttles * TimePerShuttle;

            return total;
        }

        //gender index for vo2max calculation
        public int GenderNum(string gender)
        {
            int genderNum = 0;

            if (gender.Equals("Male"))
            {
                genderNum = 1;
            }
            else
            {
                genderNum = 0;
            }
            return genderNum;
        }

        //convert time
        public double convertToSeconds(string time)
        {
            double seconds = TimeSpan.Parse(time).TotalSeconds;
            return seconds;

        }

        //speed or paces of that person
        public double calcSpeed(double distance, string timeForLap)
        {
            double displacement = distance / 1000;
            double pace = 0;
            double time = TimeSpan.Parse(timeForLap).TotalHours;
            pace = (displacement / time);
    
        return pace;

        }

        //distance
        public int distance(int shuttles)
        {
            int displacement = 0;

            displacement = 20 * shuttles;

            return displacement;
        }

        //VO2 Max
        public double calculateVo2Max(double weight, int age, int gender, double timeForLap, double heartRate)
        {
            double VO2max = 0;

            VO2max = 132.853 - (((0.0769 * weight) - (0.3877 * age)) + ((3.2649 * timeForLap) - (0.1565 * heartRate)));

            return VO2max;
        }

        //BMI
        public double BMICalculation(string weightMeasurement,string measurement, double weight, double height)
        {
            double BMI = 0;
            double ConvertedMeasurement = 0;
            //convert height to meter
            if (measurement.Equals("cm") && weightMeasurement.Equals("Kg"))
            {
                ConvertedMeasurement = height / 100;
                BMI = (weight / (ConvertedMeasurement * ConvertedMeasurement));
            }
            else if (measurement.Equals("M") && weightMeasurement.Equals("Kg"))
            {
                BMI = (weight / (height * height));
            }
            else if(measurement.Equals("Feet") && weightMeasurement.Equals("Kg"))
            {
                int total;
                ConvertedMeasurement = height * 0.3048;
                BMI = (weight / (ConvertedMeasurement * ConvertedMeasurement));
            }
            return BMI;
        }
    }
}
