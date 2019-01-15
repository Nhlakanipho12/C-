using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.Athlete
{
    public partial class HeartRate : Form
    {
        public int age;
        public Int32 Checklanguage;

        public HeartRate()
        {
            InitializeComponent();
        }

        

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        private void HeartRate_Load(object sender, EventArgs e)
        {
            Classes.LanguageHeartRate myLingo = new Classes.LanguageHeartRate();

            myLingo.setLingo(Checklanguage);

            labelTitle.Text = myLingo.getCalcHeartRate();
            lblAge.Text = myLingo.getAge();
            lblExerciseLevel.Text = myLingo.getExcercise();
            buttonCalculate.Text = myLingo.getCalculate();
            btnReset.Text = myLingo.getReset();
            buttonBack.Text = myLingo.getBack();




        }

        private void ComboExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            age = Convert.ToInt32(txtAge.Text);
            double level = (Convert.ToInt32(ComboExercise.SelectedItem.ToString()));
            double calculation = calcHeartRateNormal(age, level);
            string rslt = Convert.ToString(calculation);
            txtResults.AppendText(rslt);

        }

        public double calcHeartRateNormal(int age, double level)
        {
            double convertTopercentage;
            int constant = 220;

            convertTopercentage = level / 100.00;



            return convertTopercentage * (constant - age);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtAge.Clear();
            ComboExercise.ResetText();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Calculation calc = new Calculation();
            calc.setLanguage(Checklanguage);
            calc.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation();
            calc.setLanguage(Checklanguage);
            calc.Show();
            this.Hide();
        }

       
    }
}
