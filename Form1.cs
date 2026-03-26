namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // [데이터 저장 변수]
        // (과제4) 정수형(int)의 한계를 넘기 위해 모든 계산 변수를 실수형(double)으로 선언
        double firstNumber = 0;       // 첫 번째 피연산자 저장
        double result = 0;            // 최종 계산 결과값 저장
        string currentOperator = ""; // 클릭된 연산자 기호 저장

        // [입력 제어 변수]
        // txtInput을 결과창으로만 쓰기 위해, 현재 타이핑 중인 숫자를 메모리에 임시 저장하는 변수
        string tempInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        // --- [숫자 버튼 클릭 이벤트] ---
        private void btnNumeber_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // 결과가 출력된 상태("= 36")에서 숫자를 누르면 모든 기록을 지우고 새로 시작 (UX 개선)
            if (txtInput.Text.Contains("="))
            {
                btnClear_Click(null, null);
            }

            // 입력된 숫자를 변수와 상단 식 창에 각각 누적 기록
            tempInput += btn.Text;
            txtFormular.Text += btn.Text;
        }

        // --- [연산자 버튼 클릭 이벤트] ---
        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 연속 계산 기능: 결과가 나온 상태에서 연산자를 누르면 결과값을 첫 번째 숫자로 승격
            if (txtInput.Text.Contains("="))
            {
                tempInput = result.ToString();
                txtFormular.Text = tempInput;
                txtInput.Clear();
            }

            // 예외 처리: 숫자가 입력되지 않은 상태에서 연산자 클릭 시 무시
            if (string.IsNullOrEmpty(tempInput)) return;
            if (sender is not Button btn) return;

            // (과제4) TryParse를 사용하여 입력값이 유효한 숫자인지 최종 검증 후 저장
            if (!double.TryParse(tempInput, out firstNumber)) return;

            currentOperator = btn.Text;
            txtFormular.Text += " " + currentOperator + " "; // 식 창에 "숫자 + " 형태 구현
            tempInput = ""; // 다음 숫자를 받기 위해 임시 변수 비우기
        }

        // --- [결과 확인 버튼 클릭 (=)] ---
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 1. 미입력 예외 처리: 아무것도 입력하지 않은 경우
            if (string.IsNullOrEmpty(tempInput))
            {
                MessageBox.Show("계산을 위해 숫자를 먼저 입력해 주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. 연산자 누락 예외 처리: 숫자만 쓰고 연산자를 안 누른 경우
            if (currentOperator == "")
            {
                MessageBox.Show("수행할 연산자(+, -, *, / 등)를 선택해 주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. (과제4 핵심) 유효성 검사: 직접 타이핑 시 문자가 섞인 경우(예: dddddd)를 필터링
            // TryParse는 실패 시 프로그램이 죽지 않고 false를 반환하여 안전한 예외 처리가 가능함
            if (!double.TryParse(tempInput, out double secondNumber))
            {
                MessageBox.Show("숫자와 연산자만을 입력해 주세요.\n(잘못된 문자가 포함되어 있습니다.)", "입력 오류",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tempInput = "";
                return;
            }

            // 4. 산술 연산 수행
            double doubleFirstNumber = Convert.ToDouble(firstNumber);
            double doubleResult = 0;

            if (currentOperator == "+") doubleResult = doubleFirstNumber + secondNumber;
            else if (currentOperator == "-") doubleResult = doubleFirstNumber - secondNumber;
            else if (currentOperator == "*" || currentOperator == "X") doubleResult = doubleFirstNumber * secondNumber;
            else if (currentOperator == "/")
            {
                // (과제4) 0으로 나누기 방어 로직: 분모가 0이면 계산 중단 및 안내
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

            // 결과값 전역 변수 저장 및 출력 전용 창(txtInput)에 표시
            result = doubleResult;
            txtInput.Text = "= " + result.ToString();

            // 계산 프로세스 종료 후 상태 정리
            tempInput = "";
            currentOperator = "";
        }

        // --- [지우기 및 초기화 기능] ---

        // 백스페이스: 마지막 한 글자만 제거 (Substring 활용)
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                tempInput = tempInput.Substring(0, tempInput.Length - 1);
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 1);
            }
        }

        // CE (Clear Entry): 현재 입력 중인 항목(tempInput)만 삭제
        private void btnCe_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - tempInput.Length);
                tempInput = "";
            }
        }

        // C (Clear): 모든 기록과 변수 완전 초기화
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtFormular.Clear();
            tempInput = "";
            firstNumber = 0;
            result = 0;
            currentOperator = "";
        }

        // --- [소수점 제어 기능] ---
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Contains("=")) btnClear_Click(null, null);

            // (과제4) 중복 방지: 이미 점(".")이 찍혀 있다면 추가 입력을 무시함
            if (!tempInput.Contains("."))
            {
                // 숫자 없이 점부터 누르면 자동으로 "0."으로 보정해주는 UX 로직
                if (string.IsNullOrEmpty(tempInput))
                {
                    tempInput = "0.";
                    txtFormular.Text += "0.";
                }
                else)
                {
                    tempInput += ".";
                    txtFormular.Text += ".";
                }
            }
        }
    }
}