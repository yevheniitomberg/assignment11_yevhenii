using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace assignment11_yevhenii
{
    public partial class Form1 : Form
    {

        List<Pet> pets = new List<Pet>();

        public Form1()
        {

            InitializeComponent();
            loadTypes();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            PetType petType;
            if (Enum.TryParse<PetType>(this.select_type.Text, out petType))
            {
                pets.Add(new Pet(this.input_name.Text, int.Parse(this.input_age.Value.ToString()), petType));
                displayPets();
            }
            else
            {
                MessageBox.Show("Wrong input", "Wrong input", MessageBoxButtons.OK);
            }

        }

        private void loadTypes() 
        { 
            foreach (PetType type in Enum.GetValues(typeof(PetType)))
            {
                this.select_type.Items.Add(type);
            }
        }
        
        private void displayPets()
        {
            this.label_list.Text = "";
            foreach (Pet pet in pets)
            {
                this.label_list.Text += pet.ToString() + "\n";
            }
        }
    }
}
