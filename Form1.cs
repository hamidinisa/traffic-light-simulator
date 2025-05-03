namespace trafficlamb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox newpicturebox = new PictureBox();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int counter1 = 0;
        int counter11 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                pictureBox1.Visible = true;
                counter1 = 10;
                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "2")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                counter1 = 15;
                label1.Text = counter1.ToString();
            }
            else if (comboBox1.Text == "")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter1 = counter1 - 1;
            counter11 = counter11 + 1;
            label1.Text = counter1.ToString();

            if (counter11 >= 1 && counter11 <= 2)
            {
                this.pictureBox6.BackColor = Color.Yellow;
            }
            else if (counter11 > 2 && counter1 >= 2)
            {
                this.pictureBox6.BackColor = Color.Green;
            }

            if (pictureBox1.Visible == true)
            {
                if (pictureBox1.Left < 404)
                {
                    pictureBox1.Left += 50;
                }
                if (pictureBox1.Left >= 404)
                {
                    Bitmap currentImage = new Bitmap(pictureBox1.Image);
                    Bitmap rotatedImage = RotateImage(currentImage, 270);
                    newpicturebox.Location = new Point(425, 120);
                    newpicturebox.Image = rotatedImage;
                    newpicturebox.Size = new Size(41, 130);
                    newpicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Visible = false;
                    this.Controls.Add(newpicturebox);




                }
            }
            if (newpicturebox.Visible == true)
            {
                newpicturebox.Top -= 60;
            }

            if (pictureBox2.Visible == true)
            {
                pictureBox2.Left += 50;
            }

            if (counter1 <= 0)
            {
                this.pictureBox6.BackColor = Color.Red;
                timer1.Stop();
                timer3.Start();
                timer2.Start();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(comboBox2.Text) ||
                string.IsNullOrEmpty(comboBox3.Text) ||
                string.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("Please make a selection in all ComboBoxes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            timer1.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();
        }

        private Bitmap RotateImage(Bitmap image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Height, image.Width); 
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                
                g.TranslateTransform(image.Height / 2, image.Width / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }
            return rotatedImage;
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            // if (pictureBox1.Left >= 310)
            // {
            //
            //    pictureBox1.Left += 60;
            // }
            if (pictureBox2.Left >= 310)
            {
                pictureBox2.Left += 60;
            }





        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text == "1")
            {
                pictureBox5.Visible = true;
                counter2 = 10;
                label2.Text = counter1.ToString();
            }


            else if (comboBox3.Text == "")
            {
                pictureBox5.Visible = false;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2 -= 1;
            label2.Text = counter2.ToString();

            if (counter2 <= 0)
            {
                this.pictureBox9.BackColor = Color.Red;
                counter11 = 0;
                timer2.Stop();
                timer4.Start();

            }
            else if (counter2 <= 1)
            {
                this.pictureBox9.BackColor = Color.Yellow;
            }
            else if (counter2 > 1)
            {
                this.pictureBox9.BackColor = Color.Green;

                if (pictureBox5.Visible)
                {
                    pictureBox5.Top += 60;
                }
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Top >= 182)
            {

                pictureBox5.Top = pictureBox5.Top + 60;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1")
            {
                pictureBox8.Visible = true;
                counter3 = 10;
                label3.Text = counter3.ToString();
            }


            else if (comboBox2.Text == "")
            {
                pictureBox8.Visible = false;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3 -= 1;
            label3.Text = counter3.ToString();

            if (counter3 <= 0)
            {
                this.pictureBox7.BackColor = Color.Red;
                timer3.Stop();
                counter11 = 0;
                timer4.Start();
            }
            else if (counter3 <= 1)
            {
                this.pictureBox7.BackColor = Color.Yellow;
            }
            else if (counter3 > 1)
            {
                this.pictureBox7.BackColor = Color.Green;

                if (pictureBox8.Visible)
                {
                    pictureBox8.Top -= 60;
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (pictureBox8.Top >= 334)
            {

                pictureBox8.Top = pictureBox5.Top - 70;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "1")
            {
                pictureBox3.Visible = true;
                counter4 = 10;
                label4.Text = counter4.ToString();
            }
            else if (comboBox4.Text == "2")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                counter4 = 15;
                label4.Text = counter4.ToString();
            }
            else if (comboBox4.Text == "")
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4 -= 1;
            label4.Text = counter4.ToString();

            if (counter4 <= 0)
            {
                this.pictureBox10.BackColor = Color.Red;
                timer4.Stop();



            }
            else if (counter4 <= 1)
            {
                this.pictureBox10.BackColor = Color.Yellow;
            }
            else if (counter4 > 1)
            {
                this.pictureBox10.BackColor = Color.Green;

                if (pictureBox3.Visible)
                {
                    pictureBox3.Left -= 30;
                }

                if (pictureBox4.Visible)
                {
                    pictureBox4.Left -= 30;
                }
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left <= 650)
            {

                pictureBox3.Left -= 60;
            }
            if (pictureBox4.Left <= 650)
            {
                pictureBox4.Left -= 60;
            }

        }

       
    }

}