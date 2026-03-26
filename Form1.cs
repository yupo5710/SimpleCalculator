namespace SimpleCalculator
{


    public partial class Form1 : Form
    {

        int firstNumber = 0;
        int result = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeber_Click(object sender, EventArgs e)
        {
            // (과제1) 클릭된 버튼 객체를 가져와서 Button 타입으로 인식함
            Button btn = (Button)sender;


            // 예: "1"이 있는 상태에서 "2"를 누르면 "12"가 됨
            txtInput.Text = txtInput.Text + btn.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

        }
    }
}
