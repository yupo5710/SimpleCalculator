using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // [데이터 저장 변수]
        double result = 0;            // 최종 계산 결과값 저장
        string currentOperator = ""; // 클릭된 연산자 저장
        string tempInput = "";       // 현재 입력 중인 숫자 임시 저장
        string fullFormula = "";     // 전체 수식을 저장할 변수

        public Form1()
        {
            InitializeComponent();

            // 텍스트박스 폰트 설정
            txtInput.Font = new Font("맑은 고딕", 24F, FontStyle.Bold);
            txtFormular.Font = new Font("맑은 고딕", 16F, FontStyle.Regular);

            // 모든 버튼을 찾아 동그랗게 만들기 (과제4 UI 고도화)
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    SetRoundButton(btn);
                }
            }
        }

        // --- [숫자 버튼 클릭 이벤트] ---
        private void btnNumeber_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // 결과(=)가 출력된 상태에서 숫자를 누르면 초기화 후 새로 시작
            if (txtFormular.Text.Contains("="))
            {
                btnClear_Click(null, null);
            }

            tempInput += btn.Text;
            txtFormular.Text += btn.Text;
        }

        // --- [연산자 버튼 클릭 이벤트] ---
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // 1. 결과가 나온 상태에서 연산자를 누르면 결과값부터 다시 시작 (연속 계산)
            if (txtFormular.Text.Contains("="))
            {
                fullFormula = result.ToString() + " " + btn.Text + " ";
                txtFormular.Text = fullFormula;
                txtInput.Clear();
                tempInput = "";
                currentOperator = btn.Text;
                return;
            }

            // 2. 숫자 입력 후 연산자를 누를 때 (수식에 추가)
            if (!string.IsNullOrEmpty(tempInput) || txtFormular.Text.EndsWith(")"))
            {
                txtFormular.Text += " " + btn.Text + " ";
                currentOperator = btn.Text;
                tempInput = "";
            }
            // 3. 연산자만 교체하고 싶을 때
            else if (txtFormular.Text.Length > 3 && !txtFormular.Text.EndsWith(" "))
            {
                // 마지막 연산자 기호 교체 로직
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 3) + " " + btn.Text + " ";
                currentOperator = btn.Text;
            }
        }

        // --- [결과 확인 버튼 클릭 (=)] ---
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFormular.Text) && string.IsNullOrEmpty(tempInput)) return;

            try
            {
                // 1. 현재 입력 중인 내용까지 합치기
                string finalExpression = txtFormular.Text + tempInput;

                // 2. 자동 곱셈 보정 로직 (정규식 대신 단순 치환 활용)
                // 숫자(또는 닫는괄호)와 여는괄호 사이에 * 삽입
                for (int i = 0; i < 10; i++)
                {
                    finalExpression = finalExpression.Replace($"{i}(", $"{i}*("); // 예: 5( -> 5*(
                }
                finalExpression = finalExpression.Replace(")(", ")*("); // 예: )( -> )*(

                // 3. 컴퓨터용 연산자로 치환
                string mathExpression = finalExpression.Replace("X", "*").Replace("÷", "/");

                var table = new DataTable();
                var computeResult = table.Compute(mathExpression, "");

                result = Convert.ToDouble(computeResult);

                // 4. 무한대/NaN 체크
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "계산 오류");
                    btnClear_Click(null, null);
                    return;
                }

                // 결과 출력
                txtFormular.Text = finalExpression + " = " + result.ToString();
                txtInput.Text = result.ToString();

                tempInput = "";
            }
            catch (Exception)
            {
                MessageBox.Show("괄호 짝이 맞지 않거나 잘못된 수식입니다.", "계산 오류");
            }
        }

        // --- [괄호 기능 추가] ---
        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            if (txtFormular.Text.Contains("=")) btnClear_Click(null, null);
            txtFormular.Text += "(";
            tempInput = "";
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            if (txtFormular.Text.Contains("=")) return;
            txtFormular.Text += ")";
            tempInput = "";
        }

        // --- [초기화 및 지우기 기능] ---
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtFormular.Clear();
            tempInput = "";
            fullFormula = "";
            result = 0;
            currentOperator = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtFormular.Text.Length > 0 && !txtFormular.Text.Contains("="))
            {
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 1);
                if (tempInput.Length > 0)
                    tempInput = tempInput.Substring(0, tempInput.Length - 1);
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            if (tempInput.Length > 0)
            {
                txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - tempInput.Length);
                tempInput = "";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtFormular.Text.Contains("=")) btnClear_Click(null, null);

            if (!tempInput.Contains("."))
            {
                if (string.IsNullOrEmpty(tempInput))
                {
                    tempInput = "0.";
                    txtFormular.Text += "0.";
                }
                else
                {
                    tempInput += ".";
                    txtFormular.Text += ".";
                }
            }
        }

        // --- [UI 고도화: 버튼 디자인] ---
        private void SetRoundButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.UseVisualStyleBackColor = false;
        }
    }
}