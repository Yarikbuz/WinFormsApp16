namespace WinFormsApp16
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int pop = 10;
        int chis = 0;
        int i = 0;
        int x = 0;
        int y = 0;
        
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            pop++;
            label3.Text = pop.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pop--;
            label3.Text = pop.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox2.Text);
            y = int.Parse(textBox3.Text);
            i = 0;
            chis = rnd.Next(x, y);
            label4.Text = "����� � ��������� �� " + x.ToString() + " �� " + y.ToString();
            label3.Text = pop.ToString();
            label1.Text = "���� ��������";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ugad = int.Parse(textBox1.Text);
            textBox1.Text = "";
            
           
                if (ugad < chis)
                {
                    label1.Text = "��� ����� ������";
                    i++;
                    label3.Text = (pop - i).ToString();
            }
                if (ugad > chis)
                {
                    label1.Text = "��� ����� ������";
                    i++;
                    label3.Text = (pop - i).ToString();

            }
                if (ugad == chis)
                {
                    label1.Text = "�������, ������, ������ ������ � ����� � ����";
                    
                }
                
                if (i > pop)
                {
                    label1.Text = "�� ��������";
                    i = 0;
                
                    

                }

            

            
        }
    }
}
