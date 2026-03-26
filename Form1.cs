namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string currentOperator = "";
        string tempInput = "";
        // 복수 연산을 위해 이전까지의 수식을 저장할 변수 추가
        string fullFormula = "";

        public Form1()
        {
            InitializeComponent();
            txtInput.Font = new Font("맑은 고딕", 24F, FontStyle.Bold);
            txtFormular.Font = new Font("맑은 고딕", 16F, FontStyle.Regular);
        }

        private void btnNumeber_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // 결과가 나온 상태에서 숫자를 누르면 초기화 후 새로 시작
            if (txtFormular.Text.Contains("="))
            {
                btnClear_Click(null, null);
            }

            tempInput += btn.Text;
            txtFormular.Text += btn.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // 1. 이미 결과가 나온 상태에서 연산자를 누르면 그 결과값부터 다시 시작
            if (txtFormular.Text.Contains("="))
            {
                fullFormula = result.ToString() + " " + btn.Text + " ";
                txtFormular.Text = fullFormula;
                txtInput.Clear();
                tempInput = "";
                currentOperator = btn.Text;
                return;
            }

            // 2. 숫자 입력 후 연산자를 누를 때 (계산은 하지 않고 수식만 추가)
            if (!string.IsNullOrEmpty(tempInput))
            {
                // 현재까지의 입력을 전체 수식에 합침
                fullFormula += tempInput + " " + btn.Text + " ";
                txtFormular.Text = fullFormula;

                currentOperator = btn.Text; // 마지막 연산자 기억
                txtInput.Clear();
                tempInput = "";
            }
            // 3. 연산자만 교체하고 싶을 때
            else if (!string.IsNullOrEmpty(fullFormula))
            {
                // 마지막 연산자 기호만 교체 (뒤의 공백 포함 3글자 제거 후 새 연산자 삽입)
                fullFormula = fullFormula.Substring(0, fullFormula.Length - 3) + " " + btn.Text + " ";
                txtFormular.Text = fullFormula;
                currentOperator = btn.Text;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tempInput) || string.IsNullOrEmpty(fullFormula)) return;

            // DataTable의 Compute 메서드를 활용하면 복잡한 문자열 수식을 한 번에 계산할 수 있습니다.
            try
            {
                string finalExpression = fullFormula + tempInput;
                // 'X'나 '÷' 기호를 컴퓨터가 인식하는 '*'와 '/'로 치환
                string mathExpression = finalExpression.Replace("X", "*").Replace("÷", "/");

                var table = new System.Data.DataTable();
                var computeResult = table.Compute(mathExpression, "");

                result = Convert.ToDouble(computeResult);

                // 결과 출력
                txtFormular.Text = finalExpression + " = " + result.ToString();
                txtInput.Text = result.ToString();

                // 상태 초기화
                tempInput = "";
                fullFormula = "";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("0으로 나눌 수 없습니다.", "계산 오류");
                btnClear_Click(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("계산할 수 없는 수식입니다.", "오류");
                btnClear_Click(null, null);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtFormular.Clear();
            tempInput = "";
            fullFormula = "";
            result = 0;
            currentOperator = "";
        }

        // --- 나머지 기능(Back, CE, Point)은 이전과 동일하게 유지 ---
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                tempInput = tempInput.Substring(0, tempInput.Length - 1);
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 1);
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - tempInput.Length);
                tempInput = "0";
                txtFormular.Text += tempInput;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtFormular.Text.Contains("=")) btnClear_Click(null, null);
            if (!tempInput.Contains("."))
            {
                if (string.IsNullOrEmpty(tempInput)) { tempInput = "0."; txtFormular.Text += "0."; }
                else { tempInput += "."; txtFormular.Text += "."; }
            }
        }
    }
}