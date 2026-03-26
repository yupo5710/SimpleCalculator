# SimpleCaculator
- C# 프로그래밍 학습
- 1줄 소개: double 타입 변환과 TryParse를 활용한 예외 처리를 통해 데이터 정밀도와 프로그램 안정성을 확보한 계산기입니다.
- 사용한 플랫폼:
    -  C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
    - TextBox(수식 표시 및 결과 출력), Button(숫자, 연산자, 기능 버튼), MessageBox(예외 알림 팝업)
- 사용한 기술과 구현한 기능:
    - double 타입을 이용한 실수 연산 구현 및 나눗셈 정밀도 향상
    - double.TryParse를 활용하여 숫자가 아닌 문자 입력 시 프로그램 강제 종료 방지 및 사용자 안내 로직 적용
    - 0으로 나누기 시도 시 에러 메시지 출력 및 상태 초기화 기능
    - Contains() 메서드를 이용한 소수점(.) 중복 입력 방지 및 자동 보정 기능
    - Substring을 활용한 백스페이스(한 글자 지우기) 및 CE/C 초기화 기능
    - 결과값 출력 후 연산자 클릭 시 기존 결과값을 피연산자로 승격시켜 계산을 이어가는 연속 계산 로직

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷

![과제1 실행화면](img/screenshot-1.png)
![과제1 실행화면](img/screenshot-2.png)

- 과제 내용
  - 컨트롤 배치와 기본적인 속성 설정합니다.
  - 입력 내용을 2가지 방법으로 표시하는 기능 구현합니다.
  - 계산기의 더하기 기능 구현합니다.

- 구현 내용과 기능 설명
  - 숫자 버튼 클릭 시 데이터를 누적하고 실시간으로 수식을 표시한다.     
    사용한 코드:      
    `tempInput += btn.Text;`
    `txtFormular.Text += btn.Text;`
  - 입력된 문자열을 실수형으로 변환하여 더하기 계산을 수행한다.    
    사용한 코드:   
    `if (!double.TryParse(tempInput, out firstNumber)) return;`
  - 계산된 결과값을 문자열로 변환하여 화면에 출력한다.   
    사용한 코드:   
    `txtInput.Text = "= " + result.ToString();`
## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷

![과제2 실행화면](img/screenshot-3.png)
![과제2 실행화면](img/screenshot-4.png)

- 과제 내용
  - 사칙연산(+, -, *, /) 버튼을 모두 배치하고 이벤트를 연결합니다.
  - 연산자 버튼 클릭 시 현재까지 입력된 숫자를 첫 번째 피연산자로 저장합니다.
  - 사칙연산 우선순위와 상관없이 입력 순서에 따른 연산 기초를 다집니다.

- 구현 내용과 기능 설명
  - 각 연산자 버튼 클릭 시 해당 기호를 변수에 저장하고 수식 창에 표시한다.    
    사용한 코드:    
    `currentOperator = btn.Text;`     
    `txtFormular.Text += " " + currentOperator + " ";`
  - 뺄셈, 곱셈, 나눗셈에 대한 조건문 로직을 추가하여 연산을 수행한다.    
    사용한 코드:    
    `if (currentOperator == "-") doubleResult = doubleFirstNumber - secondNumber;`     
    `else if (currentOperator == "*" || currentOperator == "X") doubleResult = doubleFirstNumber * secondNumber;`    
  - 연산자 클릭 시 다음 숫자를 입력받기 위해 입력 임시 변수를 초기화한다.    
    사용한 코드:    
    `tempInput = "";`    
    `txtInput.Clear();`    
## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷

![과제3 실행화면](img/screenshot-5.png)
![과제3 실행화면](img/screenshot-6.png)
![과제3 실행화면](img/screenshot-7.png)
![과제3 실행화면](img/screenshot-8.png)
![과제3 실행화면](img/screenshot-9.png)
![과제3 실행화면](img/screenshot-10.png)

- 과제 내용
  - C(Clear), CE(Clear Entry), Backspace(del) 기능을 구현합니다.
  - 잘못 입력한 숫자나 전체 기록을 지우는 편의 기능을 추가합니다.
  - 문자열 처리를 통해 입력된 데이터의 마지막 글자를 제거하는 로직을 작성합니다.

- 구현 내용과 기능 설명
  - 백스페이스 기능을 통해 마지막에 입력된 한 글자만 제거한다.   
    사용한 코드:    
    `tempInput = tempInput.Substring(0, tempInput.Length - 1);`   
    `txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - 1);`  
  - CE 버튼 클릭 시 현재 입력 중인 숫자를 0으로 초기화하고 화면을 갱신한다.    
    사용한 코드:   
    `tempInput = "0";`   
    `txtFormular.Text = txtFormular.Text.Substring(0, txtFormular.Text.Length - tempInput.Length) + "0";`   
  - C 버튼 클릭 시 모든 변수와 텍스트박스를 초기화하여 새 계산 상태로 만든다.   
    사용한 코드:   
    `txtInput.Clear(); txtFormular.Clear();`   
    `tempInput = ""; firstNumber = 0; currentOperator = "";`   
