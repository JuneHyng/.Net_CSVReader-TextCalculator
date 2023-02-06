using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinform
{
    internal class CalculatorAlpa
    {
        // 연산식
        private string calFormula;
        private char[] formula;

        // () 배열 
        private List<char> Parenthesis = new List<char>();
        private List<int> ParenthesisIndex = new List<int>();

        // 연산자 배열
        private List<char> Operator = new List<char>();
        private List<int> OperatorIndex = new List<int>();

        // 숫자 배열
        private List<string> number = new List<string>();
        private List<int> numberIndex = new List<int>();

        // 숫자 재배열
        private List<double> numberList = new List<double>();
        private List<int> numberListIndex = new List<int>();
        private List<int> numberListLength = new List<int>();

        public CalculatorAlpa(string calFormula)
        {
            this.calFormula = calFormula;
        }

        public void sortFormula() {
            formula =calFormula.ToCharArray();
            // 공백 제거
            formula=formula.Where(x => x !=' ').ToArray();

            // 연산식 구분
            int formLength = formula.Length;
            for (int i=0 ; i < formLength ;i++) {
                char c=formula[i];
                if (c == '(' || c ==')')
                {
                    Parenthesis.Add(c);
                    ParenthesisIndex.Add(i);
                } else if (c == '*' || c == '/' || c == '+' || c == '-') {
                    Operator.Add(c);
                    OperatorIndex.Add(i);
                } else if (c >= 48 && c <= 57 || c == '.')
                {
                    number.Add(c.ToString());
                    numberIndex.Add(i);
                }else {
                    MessageBox.Show("잘못된 연산자 또는 피연산자가 포함되어있습니다");
                    return;
                }
            }
        }

        // 연속되는 숫자합치기, 숫자별 인덱스 및 길이 추가
        public bool makeNumberList() {
            try {
                string numberResult = number[0];
                numberListIndex.Add(numberIndex[0]);

                for (int i=0; i<number.Count-1 ;i++ ) {
                    if (numberIndex[i] + 1 == numberIndex[i + 1])
                    {
                    numberResult += number[i + 1];
                    }
                    else {
                        if (numberResult.Length - 1 == numberResult.LastIndexOf(".") || 0 == numberResult.IndexOf("."))
                        {
                            return false;
                        }
                        numberList.Add(double.Parse(numberResult));
                        numberListIndex.Add(numberIndex[i + 1]);
                        numberListLength.Add(numberResult.Length);
                        numberResult = number[i + 1];
                    }
                }
                if (numberResult.Length - 1 == numberResult.LastIndexOf(".") || 0 == numberResult.IndexOf("."))
                {
                    return false;
                }
                numberList.Add(double.Parse(numberResult));
                numberListLength.Add(numberResult.Length);
            }
            catch(Exception e) {
                return false;
            }
            return true;
        }

        // 연산자 앞,뒤 피연산자 확인, '-' 연산자 앞 or '('뒤 위치시 숫자 음수변환
        public bool checkOperator() {
            try {

                // 연산자 0인덱스 위치시 오류, '-'일때 뒤 숫자위치시 음수변환
                if (OperatorIndex[0] == 0)
                {
                    if (Operator[0] == '-' && numberListIndex.Contains(1))
                    {
                        numberList[0] = numberList[0] * -1;
                        Operator.RemoveAt(0);
                        OperatorIndex.RemoveAt(0);
                    }
                    return false;
                }

                for (int i = 0; i < Operator.Count; i++)
                {
                    
                }
                foreach (double d in numberList) {
                    Console.WriteLine(d);
                }
            }
            catch(Exception e) {
                return false; 
            }
            return true;
        }

        // '(',')' 순서 및 갯수 확인, 
        // '(' = +1, ')' = -1로 갯수확인[전체 총합 0]
        // -음수 나타날씨 괄호순서 오류[ '('뒤에는 무조건 ')'이 와야함]
        public bool checkParenthesis() {
            int checkNum = 0;
            try { 
                foreach (char p in Parenthesis) {
                    if (p == '(') {
                        checkNum++;
                    }
                    else {
                        checkNum--;
                    }

                    // 음수 순서 오류
                    if (checkNum < 0) {
                        return false;
                    }
                }
                // 전체 갯수 오류
                if (checkNum != 0) {
                    return false;
                }

            }
            catch (Exception e) {
                return false; 
            }
            return true;
        }

    }
}
