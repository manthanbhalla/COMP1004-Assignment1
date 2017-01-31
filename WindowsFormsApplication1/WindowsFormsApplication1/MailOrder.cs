using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Co-sales Mail Order - Sales Bonus	

// Name: Manthan Bhalla

// Student Id: 200331757

// Date : 29 January, 2017	


// A form to calculate total sales bonus that every employee receives on the basis of

// total monlthy sales and the percentage of hours worked by the employee


// CHANGELOG

// 11:00am 29/01/2017 - The project was and the elements were initialized

// 12:00pm 29/01/2017-  Designed the form elements such as Employee Id, Employee Name,

//                     Hours Worked, Total Sales, Print button etc.

// 1:00pm 29/01/2017 - Switching between languages  and next button was working

// 4:00pm 29/01/2017 - Typed code for calculation, printing and made the form working

// 5:00pm 29/01/2017 - Created the company logo and made sure everything is working fine

//                   - Commented the code 

// 11:00pm 29/01/2017 - Finalized and submitted

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>

        /// Made the changes that when clicked on Francais button the text written 
        
        /// changes from English to Francais

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nom de l'employé";
            label2.Text = "Identifiant de l'employé";
            label3.Text = "Heures travaillées";
            label4.Text = "Ventes totales";
            label5.Text = "Bonus de vente";
            button1.Text = "calculer";
            button2.Text = "imprimer";
            button3.Text = "prochaine";
            Languages.Text = "Traduction";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Employee Name";
            label2.Text = "Employee Id";
            label3.Text = "Hours Worked";
            label4.Text = "Total Sales";
            label5.Text = "Sales Bonus";
        }



        /// <summary>

        /// The next button will clear the text typed in the text boxes when we run
        
        /// the program

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>
        
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "0";
      
            textBox4.Text = "$0.00";
            textBox5.Text = "";
        }

       
        private bool Isnumber(string s)
        {
            double n;
            bool isNumeric = Double.TryParse(s, out n);
            if (isNumeric)
            {
                if (Convert.ToDouble(s) < 0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>

        /// This will calculate the Sales bonus earned by the employee by multiplying 
        
        /// the number of hours worked with total bonus amount

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(textBox1.Text=="")
            {
                MessageBox.Show("Enter Employee Name");
                flag = false ;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
                flag = false;
            }
            if (this.Isnumber(textBox2.Text))
            {
                if (Convert.ToDouble(textBox2.Text) > 160)
                {
                    MessageBox.Show("Hours cannot be more than 160");
                    flag = false;
                    textBox4.Text = string.Empty;

                }
            }
            if (textBox2.Text == "" || !this.Isnumber(textBox2.Text) )
            {
               
                MessageBox.Show("Invalid Hours Data");
                flag = false;
                textBox4.Text = string.Empty;
            }
            if (textBox3.Text == "" || !this.Isnumber(textBox3.Text))
            {
                MessageBox.Show("Enter Total Sales");
                flag = false;
                textBox4.Text = string.Empty;
            }
            if (flag)
            {
                double hours = (Convert.ToDouble(textBox2.Text)) / 160;
                double bonus = (Convert.ToDouble(textBox3.Text))*0.02;

                double calculate = hours * bonus;
                textBox4.Text = calculate.ToString();

            }
        }



        /// <summary>

        /// When clicked on Print button this will display a message box displaying
        
        /// Form sent to printer i.e. form is being printed

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>
       
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form sent to printer");
        }

        /// <summary>
        /// changes the langusge of the labels and the buttons to the spanish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nombre del empleado";
            label2.Text = "Id de empleado";
            label3.Text = "Horas trabajadas";
            label4.Text = "Total de las ventas";
            label5.Text = "Bono de ventas";
            button1.Text = "Calcular";
            button2.Text = "Imprimir";
            button3.Text = "Siguiente";
            Languages.Text = "Idiomas";
        }
    }
}
