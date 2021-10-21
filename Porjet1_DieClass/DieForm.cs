using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Couldnt change the name yourNameProject1
I started the project before the instructions where posted. 
Re-naming the project became is not fun :(
 * */
namespace Porjet1_DieClass  
{
    public partial class DieForm : Form
    {
        private aDie die_obj_1;                                     // Declaring Die objects, d1 and d2
        private aDie die_obj_2;                                     // First value initializes the results array
        private int[] temp_results = new int[7];                    // Temp results are used to plot the histogram
        private int[] temp_results_d2 = new int[7];                 // Temp results for d2
        private int[] temp_results2 = new int[13];
        private int histo_die_rolls;                                // # of rolls, used in Statistics and Sum of 2 Dice
                                                                    // Images are included in the resource path of the project
        /// <summary>
        /// Initilaizes the default values for all the elements in the app
        /// </summary>
        public DieForm() 
        {
            InitializeComponent();                                  // Form Initialize Component Function
            default_image();                                        // Call default_image() & default_list_Box()
            default_list_Box();                       
            listBox_Stats.SelectedIndex = 0;                        // Select the first option of the 
            this.chartHistogram.Titles.Add(" ");                    // Insert an emtpy title so default_chart() can modify it
            chartHistogram.ChartAreas[0].AxisX.Title = "Die Sides"; // Adding default axis titles for the Chart 
            chartHistogram.ChartAreas[0].AxisY.Title = "Frecuency of Sides";
            default_chart();                                        // Call default_chart()
            labelSeed_d1.Text = ("Current Seed: " + 999.ToString());                    // Change Seed to default seed, not really needed
        }
        private void DieForm_Load(object sender, EventArgs e){
            die_obj_1 = new aDie(0, 999);                  // Initializing Die objects, d1 and d2
            die_obj_2 = new aDie(0, 999);
    }

        /// <summary>
        /// Default Chart Function. Creates an empty chart with 2 series filled with 0 as the values
        /// </summary>
        private void default_chart(){
            chartHistogram.Series.Clear();                          // Clear the Series to redraw the Chart
            chartHistogram.Titles[0].Text = "Die Histogram";        // Add the default title
            chartHistogram.Series.Add("Die 1 Rolls");               // Add the 2 default series
            chartHistogram.Series.Add("Die 2 Rolls");

            for (int i = 1; i < 7; i++){                            // Add 6 XY points, all with 0 as their value
                this.chartHistogram.Series["Die 1 Rolls"].Points.AddXY(i.ToString(), 0);
                this.chartHistogram.Series["Die 2 Rolls"].Points.AddXY(i.ToString(), 0);
            }
            chartHistogram.ChartAreas[0].RecalculateAxesScale();    // Rescale the axes
        }

        /// <summary>
        /// This method loads a default image up for all picture boxes
        /// </summary>
        public void default_image() 
        {
            // Note: This is done to all picture boxes  
            die1.Image = Properties.Resources.d0;                   // Load the image to the picture box from the resource
            die1.SizeMode = PictureBoxSizeMode.StretchImage;        // Stretch the image to the picture box dimensions

            die2.Image = Properties.Resources.d0;
            die2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die_1_max.Image = Properties.Resources.d0;
            pictureBox_die_1_max.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die_1_min.Image = Properties.Resources.d0;
            pictureBox_die_1_min.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die_2_max.Image = Properties.Resources.d0;
            pictureBox_die_2_max.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die_2_min.Image = Properties.Resources.d0;
            pictureBox_die_2_min.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die_sum_max.Image = Properties.Resources.d0;
            pictureBox_die_sum_max.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_die_sum_min.Image = Properties.Resources.d0;
            pictureBox_die_sum_min.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// This method loads up the default value for the all the labels in the program
        /// </summary>
        public void default_label_box() {
            label_die1_max.Text = "f = 0";
            label_die2_max.Text = "f = 0";
            label_die1_min.Text = "f = 0";
            label_die2_min.Text = "f = 0";
            label_mean_d1.Text = "Die 1 Mean: 0";
            label_mean_d2.Text = "Die 2 Mean: 0";
            label_die_sum_max.Text = "f = 0";
            label_die_sum_min.Text = "f = 0";
            label_die_sum_mean.Text = "Mean: 0";
        }

        /// <summary>
        /// This method initializsed the values of the List Box: 60, 600...
        /// </summary>
        public void default_list_Box() {
            listBox_Stats.Items.Add("60");
            listBox_Stats.Items.Add("600");
            listBox_Stats.Items.Add("6000");
            listBox_Stats.Items.Add("60000");
        }

        /// <summary>
        /// This function calculates the mean, max and min of the Statistics.
        /// After the values are calculated, they are inserted into their 
        /// correpsonding pictureboxes and labes
        /// </summary>
        void calculate_stats_roll()
        {
            int sum_d1 = 0;                     // declaring the initial values
            int sum_d2 = 0;
            int rolls_d1 = 0;
            int rolls_d2 = 0;
            int[] fixed_arr_d1 = new int[6];    // The fixed arrays are used to calculate the mean 
            int[] fixed_arr_d2 = new int[6];    

            for (int i = 1; i < 7; i++)         // Copying the values from the object
                fixed_arr_d1[i - 1] = die_obj_1.ret_results()[i];

            for (int j = 1; j < 7; j++) {       // calculating #of rolls and sum
                rolls_d1 += fixed_arr_d1[j - 1];
                sum_d1 += fixed_arr_d1[j - 1] * j;
            }

            for (int i = 1; i < 7; i++)         // Copying the values from the object
                fixed_arr_d2[i - 1] = die_obj_2.ret_results()[i];

            for (int j = 1; j < 7; j++) {       // calculating #of rolls and sum
                rolls_d2 += fixed_arr_d2[j - 1];
                sum_d2 += fixed_arr_d2[j - 1] * j;
            }
                
            // avg = mean, Limited to 2 decimal points
            double avgd1 = Math.Round(Convert.ToDouble(sum_d1) / rolls_d1, 2);
            double avgd2 = Math.Round(Convert.ToDouble(sum_d2) / rolls_d2, 2);

            // Finding theMax frecuency and index for both dice
            int max_d1 = fixed_arr_d1.Max();
            int max_index_d1 = fixed_arr_d1.ToList().IndexOf(max_d1) + 1;
            int min_d1 = fixed_arr_d1.Min();
            int min_index_d1 = fixed_arr_d1.ToList().IndexOf(min_d1) + 1;

            int max_d2 = fixed_arr_d2.Max();
            int max_index_d2 = fixed_arr_d2.ToList().IndexOf(max_d2) + 1;
            int min_d2 = fixed_arr_d2.Min();
            int min_index_d2 = fixed_arr_d2.ToList().IndexOf(min_d2) + 1;

            // Inserting the values into their respective picture boxes and labels.
            label_mean_d1.Text = "Die 1 Mean: " + avgd1.ToString();
            label_mean_d2.Text = "Die 2 Mean: " + avgd2.ToString();

            pictureBox_die_1_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + max_index_d1.ToString());
            pictureBox_die_1_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_max.Text = "f = " + max_d1.ToString();

            pictureBox_die_1_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + min_index_d1.ToString());
            pictureBox_die_1_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_min.Text = "f = " + min_d1.ToString();


            pictureBox_die_2_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + max_index_d2.ToString());
            pictureBox_die_2_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_max.Text = "f = " + max_d2.ToString();

            pictureBox_die_2_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + min_index_d2.ToString());
            pictureBox_die_2_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_min.Text = "f = " + min_d2.ToString();
        }

        /// <summary>
        /// Changes the seed for both dies. Since the random generator is staitc, 
        /// you only need to change the die for 1 die object. 
        /// </summary>
        /// <param name="new_seed"> self-descriptive </param>
        public void changeSeed_d1(int new_seed) 
        {
            // Calls set seed, pass the new seed and updates the Label for the GUI
            die_obj_1.set_seed(new_seed);    
            labelSeed_d1.Text = ("Current Seed: " + die_obj_1.ret_seed().ToString());
        }

        /// <summary>
        /// Resets everything to a default value. Picture boxes, results... parameters not used in the function
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBox_Stats.SelectedIndex = 0;    // Select the first index of the listbox aka '60'
            default_image();                    // Call all the default functions
            default_chart();                    // image, chart, and labelbox
            default_label_box();
            die_obj_1 = new aDie(0);            // Resets the results from die, sets the seed to the default seed --> (999)
            die_obj_2 = new aDie(0);
            changeSeed_d1(999);                 // changes the sed for both dice  
        }

        /// <summary>
        /// Updates the histogram based on dice rolls
        /// </summary>
        /// <param name="die_index_d1"> self-descriptive </param>
        /// <param name="die_index_d2"> self-descriptive </param>
        private void update_histogram(int die_index_d1, int die_index_d2) {

            die_obj_1.increment_results(die_index_d1);      // Call the increment_results for both dice
            die_obj_2.increment_results(die_index_d2);

            chartHistogram.Series.Clear();                  // Clear the series 

            chartHistogram.Series.Add("Die 1 Rolls");       // Add the 2 Dice series
            chartHistogram.Series.Add("Die 2 Rolls");

            for (int i = 1; i < 7; i++)                     // Add the series values from object results
                this.chartHistogram.Series["Die 1 Rolls"].Points.AddXY(i.ToString(), die_obj_1.ret_results_index(i));

            for (int i = 1; i < 7; i++)
                this.chartHistogram.Series["Die 2 Rolls"].Points.AddXY(i.ToString(), die_obj_2.ret_results_index(i));

            chartHistogram.ChartAreas[0].RecalculateAxesScale();
        }

        /// <summary>
        /// Sets the Seed from the textbox, parameters not used in the function
        /// </summary>
        private void buttonSetSeed_Click(object sender, EventArgs e)
        {
            try
            {   // try and cath block for input validation
                // if the seed is not a number it will clear the textbox and ignore the input
                int new_seed = Int32.Parse(textSeedInput_d1.Text);
                changeSeed_d1(new_seed);
                textSeedInput_d1.Text = "";
                die_obj_1.reset_results();      // reset results since the seed was changed
                die_obj_2.reset_results();      // ^
                default_chart();                // Also Reset the chart
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                textSeedInput_d1.Text = "";
            }
        }

        /// <summary>
        /// Rolls the 2 dice. Changes the seed if the textbox has a seed, parameters not used in the function
        /// </summary>
        private void buttonRoll_Click(object sender, EventArgs e)
        {
            try
            {   // try and cath block for input validation
                // if the seed is not a number it will clear the textbox and ignore the input
                if (textSeedInput_d1.Text == "")
                {
                }
                else {
                    int new_seed = Int32.Parse(textSeedInput_d1.Text);
                    changeSeed_d1(new_seed);
                    textSeedInput_d1.Text = "";
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                textSeedInput_d1.Text = "";
            }
            // Set the Title 
            chartHistogram.Titles[0].Text = "ROLL! Die Histogram";
            int d1_roll = die_obj_1.roll();
            int d2_roll = die_obj_2.roll();

            // loads the new image for both dice picture boxes
            die1.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + d1_roll.ToString());
            die1.SizeMode = PictureBoxSizeMode.StretchImage;

            die2.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + d2_roll.ToString());
            die2.SizeMode = PictureBoxSizeMode.StretchImage;

            update_histogram(d1_roll, d2_roll); // update the rollsed die face
            calculate_stats_roll();             // updates the stats, mean, max, min
        }

        /// <summary>
        /// Clear The histogram, redraw the new histogram in real time depending on the roll #
        /// The histogram will update 
        /// Parameters not used in the function
        /// </summary>
        private void buttonStats_Click(object sender, EventArgs e) // could have included more data member as part of the class to split this function in two
        {
            // Re-draw the graph with the appropiate axis titles and series
            chartHistogram.Titles[0].Text = "Die Histogram of " + histo_die_rolls.ToString() + " Rolls";
            chartHistogram.Series.Clear();
            chartHistogram.Series.Add("Die 1 Rolls");
            chartHistogram.Series.Add("Die 2 Rolls");
            // 0 values for all the series
            for (int j = 1; j < 7; j++) {
                this.chartHistogram.Series["Die 1 Rolls"].Points.AddXY(j.ToString(), 0);
                this.chartHistogram.Series["Die 2 Rolls"].Points.AddXY(j.ToString(), 0);
            }
            // Recalculate axis scale and update
            chartHistogram.ChartAreas[0].RecalculateAxesScale();
            chartHistogram.Update();
            // Declaring all the variables
            histo_die_rolls = Int32.Parse(listBox_Stats.GetItemText(listBox_Stats.SelectedItem));
            double new_limit = histo_die_rolls * 0.1;
            int count = 0;
            int limit = 6;
            int sum_d1 = 0;
            int sum_d2 = 0;
            int[] fixed_arr_d1 = new int[6];
            int[] fixed_arr_d2 = new int[6];
            // storing the new limit
            limit = Convert.ToInt32(new_limit);
            // Reseting the temp arrays
            for (int i = 1; i < 7; i++) { 
                temp_results[i] = 0;
                temp_results_d2[i] = 0;
            }

            // This loop updates the graph in real-time
            for (int i = 0; i < histo_die_rolls; i++) {
                int rolld1 = die_obj_1.roll();
                int rolld2 = die_obj_2.roll();
                // Increasing the results
                temp_results[rolld1]++;
                temp_results_d2[rolld2]++;
                // count keeps track of when to update the graph
                if (count == limit || i == (histo_die_rolls - 1))
                {   // this section updates the graph in realtime by redrawing the graph each (#rolls * 0.1) times
                    chartHistogram.Titles[0].Text = "Die Histogram of " + histo_die_rolls.ToString() + " Rolls";
                    chartHistogram.Series.Clear();
                    chartHistogram.Series.Add("Die 1 Rolls");
                    chartHistogram.Series.Add("Die 2 Rolls");

                    for (int j = 1; j < 7; j++)
                        this.chartHistogram.Series["Die 1 Rolls"].Points.AddXY(j.ToString(), temp_results[j]);

                    for (int j = 1; j< 7; j++)
                        this.chartHistogram.Series["Die 2 Rolls"].Points.AddXY(j.ToString(), temp_results_d2[j]);
                    // Finally add a 0.1 second delay when updating the graph
                    chartHistogram.ChartAreas[0].RecalculateAxesScale();
                    chartHistogram.Update();
                    System.Threading.Thread.Sleep(100);
                    count = 0;
                }
                else
                    count++;    // if count = limit, dont update the chart and increment count
            }

            for (int j = 1; j < 7; j++)         // copping results
                fixed_arr_d1[j - 1] = temp_results[j];

            for (int j = 1; j < 7; j++)         // calculating sum for d1 
                sum_d1 += fixed_arr_d1[j - 1]*j;

            for (int j = 1; j < 7; j++)         // copping results
                fixed_arr_d2[j - 1] = temp_results_d2[j];

            for (int j = 1; j < 7; j++)         // calculating sum for d2 
                sum_d2 += fixed_arr_d2[j-1]*j;
            
            // Calculate the mean for the 2 dice
            double avgd1 = Math.Round(Convert.ToDouble(sum_d1) / histo_die_rolls, 4);
            double avgd2 = Math.Round(Convert.ToDouble(sum_d2) / histo_die_rolls, 4);
            // Calculate Max/min dice face & frecuency of Die 1
            int max_d1 = fixed_arr_d1.Max();
            int max_index_d1 = fixed_arr_d1.ToList().IndexOf(max_d1) + 1;
            int min_d1 = fixed_arr_d1.Min();
            int min_index_d1 = fixed_arr_d1.ToList().IndexOf(min_d1) + 1;
            // Calculate Max/min dice face & frecuency of Die 2
            int max_d2 = fixed_arr_d2.Max();
            int max_index_d2 = fixed_arr_d2.ToList().IndexOf(max_d2) + 1;
            int min_d2 = fixed_arr_d2.Min();
            int min_index_d2 = fixed_arr_d2.ToList().IndexOf(min_d2) + 1;

            // Update the labes and picture boxes for the mean, max and min of the 2 dice
            label_mean_d1.Text = "Die 1 Mean: " + avgd1.ToString();
            label_mean_d2.Text = "Die 2 Mean: " + avgd2.ToString();

            pictureBox_die_1_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + max_index_d1.ToString());
            pictureBox_die_1_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_max.Text = "f = " + max_d1.ToString();

            pictureBox_die_1_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + min_index_d1.ToString());
            pictureBox_die_1_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die1_min.Text = "f = " + min_d1.ToString();
            
            pictureBox_die_2_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + max_index_d2.ToString());
            pictureBox_die_2_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_max.Text = "f = " + max_d2.ToString();

            pictureBox_die_2_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + min_index_d2.ToString());
            pictureBox_die_2_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die2_min.Text = "f = " + min_d2.ToString();
        }

        /// <summary>
        /// Clear The histogram, redraw the new histogram in real time depending on the roll #
        /// The histogram will update 
        /// Parameters not used in the function
        /// </summary>

        private void button_sum_of_2_dice_Click(object sender, EventArgs e)
        {
            // Re-draw the graph with the appropiate axis titles and series
            chartHistogram.Titles[0].Text = "Sum of 2 Dice Histogram of " + histo_die_rolls.ToString() + " Rolls";
            chartHistogram.Series.Clear();
            chartHistogram.Series.Add("2 Dice Sum");
            for (int j = 1; j < 13; j++)
                this.chartHistogram.Series["2 Dice Sum"].Points.AddXY(j.ToString(), 0);
            // Recalculate axis scale and update
            chartHistogram.ChartAreas[0].RecalculateAxesScale();
            chartHistogram.Update();
            // Declaring all the variables
            histo_die_rolls = Int32.Parse(listBox_Stats.GetItemText(listBox_Stats.SelectedItem));
            double new_limit = histo_die_rolls * 0.1;
            int count = 0;
            int limit = 6;
            int sum = 0;
            int[] fixed_arr = new int[11];
            // storing the new limit
            limit = Convert.ToInt32(new_limit);
            // Reseting the temp array
            for (int i = 0; i < 13; i++)
                temp_results2[i] = 0;

            // This loop updates the graph in real-time
            for (int i = 0; i < histo_die_rolls; i++)
            {
                // Increasing the results
                int roll_d1 = die_obj_1.roll();
                int roll_d2 = die_obj_2.roll();
                temp_results2[roll_d1 + roll_d2]++;
                // count keeps track of when to update the graph
                if (count == limit || i == (histo_die_rolls - 1))
                {
                    // this section updates the graph in realtime by redrawing the graph each (#rolls * 0.1) times
                    chartHistogram.Titles[0].Text = "Sum of 2 Dice Histogram of " + histo_die_rolls.ToString() + " Rolls";
                    chartHistogram.Series.Clear();
                    chartHistogram.Series.Add("2 Dice Sum");

                    for (int j = 1; j < 13; j++)
                        this.chartHistogram.Series["2 Dice Sum"].Points.AddXY(j.ToString(), temp_results2[j]);

                    // Finally add a 0.1 second delay when updating the graph
                    chartHistogram.ChartAreas[0].RecalculateAxesScale();
                    chartHistogram.Update();
                    System.Threading.Thread.Sleep(100);
                    count = 0;
                }
                else
                    count++;    // if count = limit, dont update the chart and increment count
            }

            for (int j = 2; j < 13; j++)     // copping results
                fixed_arr[j - 2] = temp_results2[j];

            for(int j = 2; j < 13; j++)     // calculating sum for d2 
                sum += fixed_arr[j - 2] * j;

            // Calculating the mean 
            double avg = Math.Round(Convert.ToDouble(sum) / histo_die_rolls, 4);
            // Calculate Max/min dice face & frecuency
            int max = fixed_arr.Max();
            int max_index = fixed_arr.ToList().IndexOf(max) + 2;
            int min = fixed_arr.Min();
            int min_index = fixed_arr.ToList().IndexOf(min) + 2;

            // Update the labes and picture boxes for the mean, max and min
            label_die_sum_mean.Text = "Mean: " + avg.ToString();

            pictureBox_die_sum_max.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + max_index.ToString());
            pictureBox_die_sum_max.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die_sum_max.Text = "f = " + max.ToString();

            pictureBox_die_sum_min.Image = (Image)Properties.Resources.ResourceManager.GetObject("d" + min_index.ToString());
            pictureBox_die_sum_min.SizeMode = PictureBoxSizeMode.StretchImage;
            label_die_sum_min.Text = "f = " + min.ToString();
        }

        private void label_Input_Click(object sender, EventArgs e) { }            // dont need this, made by accident
        private void chartHistogram_Click(object sender, EventArgs e) { }         // dont need this, made by accident
        private void textSeedInput_d1_TextChanged(object sender, EventArgs e) { } // dont need this, made by accident
    }

    public partial class aRandomVariable : Random {
        private static Random gen = new Random(999);    // Default Value
        private static int seed = 999;                  // Keep track of the seed separately

        /// <summary>
        /// Set new seed for the random number gen, and the seed variable
        /// </summary>
        /// <param name="new_seed"> self-descriptive </param>
        public void set_seed(int new_seed) { 
            gen = new Random(new_seed);
            seed = new_seed;
        }

        /// <summary> Returns a random number between 1 and 6 </summary>
        /// <returns> self-descriptive </returns>
        public int roll() { return gen.Next(1, 7); }

        /// <summary> Seed value getter </summary>
        /// <returns> self-descriptive </returns>
        public int ret_seed() { return seed; }
    }

    public partial class aDie : aRandomVariable
    {
        private int[] results = new int[7];     // Private member to hold results. Results are used to plot the histogram

        /// <summary> Initial;izses results and chages the seed </summary>
        /// <param name="a"> a is the value all elements in results will be replaced with</param>
        /// <param name="new_seed"> self-descriptive </param>
        public aDie(int a, int new_seed)
        { 
            for (int i = 0; i < 7; i++)
                results[i] = a;
            this.set_seed(new_seed);
        }
        /// <summary> This constructor initializes results, Does not change the seed </summary>
        /// <param name="a"> a is the reset value </param>
        public aDie(int a) {
            for (int i = 0; i < 7; i++)
                results[i] = a;
        }
        /// <summary> Resets results </summary>
        public void reset_results() {
            for (int i = 0; i < 7; i++)
                results[i] = 0;
        }
        /// <summary>result getter</summary>
        /// <returns>returns results, arr of 6 numbers(all die faces frecuencies) </returns>
        public int[] ret_results() { return results; }
        public void increment_results(int index) {
            results[index]++; 
        }
        /// <summary> Getter for value of results[index] </summary>
        /// <param name="index"> self-descriptive </param>
        /// <returns> self-descriptive </returns>
        public int ret_results_index(int index) {
            return results[index];
        }
    }
}