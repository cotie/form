namespace form
{
    public partial class Form1 : Form
    {
        List<Student> studenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            try
            {
                using (StreamReader sr = new StreamReader("studenti.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(',');
                        Student st = new Student(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]));
                        studenti.Add(st);
                        cb1.Items.Add(st.Jmeno + " " + st.Prijmeni);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student(tb1.Text, tb2.Text, int.Parse(tb3.Text), int.Parse(tb4.Text));
            studenti.Add(st);

            cb1.Items.Add(tb1.Text + " " + tb2.Text);
            MessageBox.Show("Student vytvoøen");
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();

            try
            {
                using (StreamWriter sw = new StreamWriter("studenti.txt", true))
                {
                    sw.WriteLine(st.Jmeno + "," + st.Prijmeni + "," + st.Vek + "," + st.Cislo_tridy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vypis_Click(object sender, EventArgs e)
        {
            int index = cb1.SelectedIndex;
            tb5.Text = studenti[index].Jmeno;
            tb6.Text = studenti[index].Prijmeni;
            tb7.Text = studenti[index].Vek.ToString();
            tb8.Text = studenti[index].Cislo_tridy.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class Student
    {
        public string Jmeno;
        public string Prijmeni;
        public int Vek;
        public int Cislo_tridy;

        public Student(string jmeno, string prijmeni, int vek, int cislo_tridy)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Cislo_tridy = cislo_tridy;
        }
    }
}