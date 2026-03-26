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
            if (sender is not Button btn) return;
            // (과제1) 기존 텍스트에 클릭된 버튼의 숫자를 이어붙임 (문자열 결합)
            txtInput.Text += btn.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// (과제1) 빈 칸일 때 변환하면 에러가 나니까 체크해줌
            if (string.IsNullOrEmpty(txtInput.Text)) return;

            // (과제1) 입력창의 글자를 정수(int)로 변환해서 저장
            firstNumber = int.Parse(txtInput.Text);

            // (과제1) 상단 txtFormular에 "숫자 + " 표시
            txtFormular.Text = txtInput.Text + " + ";

            // (과제1) 다음 숫자를 써야 하니까 입력창은 비워줌
            txtInput.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // (과제1) 두 번째 숫자가 없으면 계산 안 함
            if (string.IsNullOrEmpty(txtInput.Text)) return;

            // (과제1) 두 번째 입력된 글자를 숫자로 변환
            int secondNumber = int.Parse(txtInput.Text);

            // (과제1) 실제 더하기 계산 수행
            result = firstNumber + secondNumber;

            // (과제1) 상단창(txtFormular)에 "첫번째숫자 + 두번째숫자 =" 완성
            txtFormular.Text = txtFormular.Text + secondNumber.ToString();

            // (과제1) 메인창(txtInput)에 "= 결과값" 형태로 출력
            // 문자열 "="과 숫자를 문자로 바꾼 값을 합쳐서 보여줌
            txtInput.Text = "= " + result.ToString();
        }
    }
}
