namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        int result = 0;
        string currentOperator = "";
        // 현재 입력 중인 숫자를 임시 저장하는 변수 (txtInput 대신 사용)
        string tempInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeber_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // 결과가 출력된 상태에서 숫자를 누르면 전체 초기화 후 새로 시작
            if (txtInput.Text.Contains("="))
            {
                btnClear_Click(null, null);
            }

            // (과제1) 숫자를 누르면 상단 식 창에만 표시하고, 변수에 숫자를 쌓음
            tempInput += btn.Text;
            txtFormular.Text += btn.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 결과값 상태에서 연산자를 누르면 결과값을 이어서 계산함
            if (txtInput.Text.Contains("="))
            {
                tempInput = result.ToString();
                txtFormular.Text = tempInput;
                txtInput.Clear();
            }

            if (string.IsNullOrEmpty(tempInput)) return;
            if (sender is not Button btn) return;

            // 첫 번째 숫자 저장 및 연산자 설정
            firstNumber = int.Parse(tempInput);
            currentOperator = btn.Text;

            // 상단 식 창에 연산자 추가 (예: "125 + ")
            txtFormular.Text += " " + currentOperator + " ";

            // 다음 숫자를 위해 임시 입력 변수 비우기 (txtInput은 계속 비어있음)
            tempInput = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tempInput) || currentOperator == "") return;

            int secondNumber = int.Parse(tempInput);

            if (currentOperator == "+") result = firstNumber + secondNumber;
            else if (currentOperator == "-") result = firstNumber - secondNumber;
            else if (currentOperator == "*" || currentOperator == "X") result = firstNumber * secondNumber;
            else if (currentOperator == "/")
            {
                if (secondNumber != 0) result = firstNumber / secondNumber;
                else result = 0;
            }
            else if (currentOperator == "%") result = firstNumber % secondNumber;

            

            // (과제1) txtInput은 오직 결과 출력용으로만 사용함
            txtInput.Text = "= " + result.ToString();

            // 계산 종료 후 변수 정리
            tempInput = "";
            currentOperator = "";
        }

        // (과제3) 백스페이스: 상단 식과 임시 변수에서 지움
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                tempInput = tempInput.Substring(0, tempInput.Length - 1);
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 1);
            }
        }

        // (과제3) CE: 현재 입력 중인 숫자만 상단 식에서 제거
        private void btnCe_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - tempInput.Length);
                tempInput = "";
            }
        }

        // (과제3) C: 전체 초기화 (txtInput도 비움)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtFormular.Clear();
            tempInput = "";
            firstNumber = 0;
            result = 0;
            currentOperator = "";
        }
    }
}