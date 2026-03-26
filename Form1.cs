namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // [데이터 저장 변수]
        double firstNumber = 0;       // 첫 번째 피연산자 저장
        double result = 0;            // 계산 결과값 저장
        string currentOperator = ""; // 선택된 사칙연산자 저장 (과제2)

        // [입력 제어 변수] (과제3 고도화)
        // txtInput을 출력 전용으로 쓰기 위해 현재 입력 중인 숫자를 메모리에 임시 저장
        string tempInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 버튼 클릭 이벤트 (0~9)
        private void btnNumeber_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // (과제3) 계산 완료 상태에서 숫자를 누르면 모든 기록을 지우고 새로 시작
            if (txtInput.Text.Contains("="))
            {
                btnClear_Click(null, null);
            }

            // (과제1) 입력된 숫자를 메모리(tempInput)와 상단 창(txtFormular)에 실시간 반영
            tempInput += btn.Text;
            txtFormular.Text += btn.Text;
        }

        // 사칙연산 버튼 클릭 이벤트 (+, -, *, /, %)
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Contains("="))
            {
                tempInput = result.ToString();
                txtFormular.Text = tempInput;
                txtInput.Clear();
            }

            if (string.IsNullOrEmpty(tempInput)) return;
            if (sender is not Button btn) return;
            if (!double.TryParse(tempInput, out firstNumber)) return;

            currentOperator = btn.Text;
            txtFormular.Text += " " + currentOperator + " ";
            tempInput = "";
        }

        // 결과 확인 버튼 클릭 (=)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 1. 아예 텅 비어있는 경우 (완전 미입력 상태)
            if (string.IsNullOrEmpty(tempInput))
            {
                MessageBox.Show("계산을 위해 숫자를 먼저 입력해 주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. 연산자를 선택하지 않은 경우
            if (currentOperator == "")
            {
                MessageBox.Show("수행할 연산자(+, -, *, / 등)를 선택해 주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. 무언가 입력됐지만 숫자가 아닌 경우 (예: dddddd)
            // [과제 4 핵심 예외 처리]
            if (!double.TryParse(tempInput, out double secondNumber))
            {
                // 텍스트가 있는데 숫자로 변환이 안 될 때 이 메시지가 뜹니다.
                MessageBox.Show("숫자와 연산자만을 입력해 주세요.\n(잘못된 문자가 포함되어 있습니다.)", "입력 오류",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                // 잘못된 문자열을 지워주면 사용자가 다시 입력하기 편함
                tempInput = "";
                // 상단 식에서도 방금 쓴 글자만큼 지워주는 로직을 넣으면 더 완벽함
                return;
            }

            //4 정수형인 firstNumber를 계산을 위해 double로 안전하게 변환
            double doubleFirstNumber = Convert.ToDouble(firstNumber);
            double doubleResult = 0;

            // (과제4) 사칙연산 처리 (double 타입 적용)
            if (currentOperator == "+") doubleResult = doubleFirstNumber + secondNumber;
            else if (currentOperator == "-") doubleResult = doubleFirstNumber - secondNumber;
            else if (currentOperator == "*" || currentOperator == "X") doubleResult = doubleFirstNumber * secondNumber;
            else if (currentOperator == "/")
            {
                if (secondNumber != 0)
                    doubleResult = doubleFirstNumber / secondNumber;
                else
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "계산 오류",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnClear_Click(null, null);
                    return;
                }
            }
            else if (currentOperator == "%") doubleResult = doubleFirstNumber % secondNumber;

            // 결과 출력
            result = doubleResult;
            txtInput.Text = "= " + result.ToString();

            // 다음 계산을 위해 상태 정리
            tempInput = "";
            currentOperator = "";
        }

        // (과제3) 백스페이스: 입력 중인 마지막 한 글자만 지우기
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                // Substring을 이용해 마지막 문자를 제외한 나머지 문자열 추출
                tempInput = tempInput.Substring(0, tempInput.Length - 1);
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 1);
            }
        }

        // (과제3) CE (Clear Entry): 현재 입력 중인 숫자 항목만 지우기
        private void btnCe_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                // 상단 창에서 현재 입력한 숫자의 길이만큼 뒤에서 잘라냄
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - tempInput.Length);
                tempInput = ""; // 메모리 초기화
            }
        }

        // (과제3) C (Clear): 계산기 전체 초기화
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();    // 결과창 비우기
            txtFormular.Clear(); // 식 창 비우기
            tempInput = "";      // 임시 입력 변수 비우기
            firstNumber = 0;     // 저장된 숫자 리셋
            result = 0;          // 결과값 리셋
            currentOperator = ""; // 연산자 리셋
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            // 결과가 출력된 상태("= 36")에서 점을 누르면 "0."으로 새로 시작
    if (txtInput.Text.Contains("="))
    {
        btnClear_Click(null, null);
    }

    // (과제4) 소수점 중복 입력 방지 로직
    // 현재 입력 중인 숫자(tempInput)에 이미 점(".")이 포함되어 있는지 확인
    if (!tempInput.Contains("."))
    {
        // 만약 아무 숫자도 없는 상태에서 점을 먼저 누르면 "0."이 되도록 처리
        if (string.IsNullOrEmpty(tempInput))
        {
            tempInput = "0.";
            txtFormular.Text += "0.";
        }
        else
        {
            // 이미 숫자가 있다면 뒤에 점만 추가
            tempInput += ".";
            txtFormular.Text += ".";
        }
    }
    // 이미 점이 있다면 아무 동작도 하지 않음 (중복 방지)
}
        }
    }