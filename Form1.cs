namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // [데이터 저장 변수]
        int firstNumber = 0;       // 첫 번째 피연산자 저장
        int result = 0;            // 계산 결과값 저장
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
            // (과제3) 결과값(= 36) 상태에서 연산자를 누르면 결과값을 이어서 계산 (연속 계산)
            if (txtInput.Text.Contains("="))
            {
                tempInput = result.ToString();
                txtFormular.Text = tempInput;
                txtInput.Clear();
            }

            // 입력된 숫자가 없으면 연산자 클릭 무시 (예외 처리)
            if (string.IsNullOrEmpty(tempInput)) return;
            if (sender is not Button btn) return;

            // (과제1) 첫 번째 숫자를 정수로 변환하여 저장
            firstNumber = int.Parse(tempInput);

            // (과제2) 클릭된 버튼의 연산자 기호를 변수에 저장
            currentOperator = btn.Text;

            // (과제1) 상단 창에 현재까지의 식과 연산자 표시
            txtFormular.Text += " " + currentOperator + " ";

            // 다음 숫자 입력을 위해 입력 변수 비우기
            tempInput = "";
        }

        // 결과 확인 버튼 클릭 (=)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 연산에 필요한 최소 조건 체크
            if (string.IsNullOrEmpty(tempInput) || currentOperator == "") return;

            // (과제1) 두 번째 숫자를 정수로 변환
            int secondNumber = int.Parse(tempInput);

            // (과제2) 산술 연산 수행 (분기 처리)
            if (currentOperator == "+") result = firstNumber + secondNumber;
            else if (currentOperator == "-") result = firstNumber - secondNumber;
            else if (currentOperator == "*" || currentOperator == "X") result = firstNumber * secondNumber;
            else if (currentOperator == "/")
            {
                // (과제2) 0으로 나누기 예외 처리 및 정수 나눗셈 규칙 적용
                if (secondNumber != 0) result = firstNumber / secondNumber;
                else result = 0;
            }
            else if (currentOperator == "%") result = firstNumber % secondNumber;

            // (과제3) 상단 창에는 식만 남기고 '='은 하단에만 표시하여 UI 가독성 확보
            // (과제1) 하단 txtInput에만 최종 결과값 출력
            txtInput.Text = "= " + result.ToString();

            // 계산 종료 후 다음 입력을 위해 상태 초기화
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
    }
}