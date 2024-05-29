namespace RecursiveFuncSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int fibbo(int n )
        {
            if ( n>=0&&n<=1 )
            {
                return 1;
            }
            else
            {
                return fibbo(n-2)+fibbo(n-1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int[] numbers = new int[number];
            void add_numbers(int lenght)
            {
                for (int i = 0; i < lenght; i++)
                {
                    numbers[i] = fibbo(i);
                }
            }
            void add_to_listbox(int[] numbers)
            {
                foreach (int number in numbers)
                {
                    listBox1.Items.Add(number.ToString());
                }
            }
            add_numbers(number);
            add_to_listbox(numbers);
        }
    }
}
