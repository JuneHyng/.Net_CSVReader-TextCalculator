using System;

namespace SimpleWinform
{
    
    internal class Calculator
    {
        private string calFormula;
        private string errorMsg;
        private string calResult;
        private string[] result=new string[2];

        // 연산하기 Main Method
        public string[] calculate(string calFormula) {
            result[0]="오류";

            // space bar(32) 및 new line(10,13) 제거
            string lineSpaceRemove =null;
            foreach (char c in calFormula) {
                if ((byte)c != 13 && (byte)c != 10 && (byte)c !=32)
                {
                    lineSpaceRemove += c;
                }
            }
            calFormula = lineSpaceRemove;

            // null 체크
            if (calFormula==null) {
                result[0] = "";
                result[1] = "";
                return result;
            }

            // 연산이 불가능한 문자가 포함되있는지 체크
            errorMsg = checkForm(calFormula);
            if (errorMsg.Length != 0)
            {
                result[1] = $"연산 불가능한 문자 포함 ({errorMsg})";
                return result;
            }

            // () 소괄호 순서,갯수 체크
            errorMsg = checkRoundBracket(calFormula);
            if (errorMsg.Length != 0)
            {
                result[1] = errorMsg;
                return result;
            }
            // 연산식 저장
            this.calFormula = calFormula;

            // 연산 시작
            try
            {
                // 연산결과 저장 <- 연산식
                this.calResult= this.calFormula;
                string resultMsg = null;

                // () 우선 연산 인덱스 체크
                int indexRbLast = calResult.IndexOf(')');
                int indexRbfirst;
                if (indexRbLast == -1)
                {
                    indexRbfirst = -1;
                }
                else {
                    indexRbfirst = calResult.LastIndexOf('(', indexRbLast);
                }

                int multydivideIndex = -1;
                int addMinusIndex = -1;
                int numStartIndex = -1;
                int numLastIndex = -1;
                // () 소괄호 우선 연산
                while (indexRbLast != -1 && indexRbfirst != -1) {
                    // '*', '/' 연산
                    multydivideIndex = calResult.IndexOfAny(new char[] { '*', '/' }, indexRbfirst, indexRbLast - indexRbfirst);
                    while (multydivideIndex != -1) {
                        numStartIndex = calResult.LastIndexOfAny(new char[] { '+', '-', '(' }, multydivideIndex) + 1;
                        numLastIndex = calResult.IndexOfAny(new char[] { '+', '-', '/', '*', ')' }, multydivideIndex + 1) - 1;
                        // 숫자 및 연산자 인덱스 주입
                        resultMsg=checkCal(numStartIndex, numLastIndex, multydivideIndex);
                        if (resultMsg == errorMsg) {
                            result[1] = errorMsg;
                            return result;
                        }
                        // () 소괄호 및 연산자 인덱스 재설정
                        indexRbLast = calResult.IndexOf(')');
                        indexRbfirst = calResult.LastIndexOf('(', indexRbLast);
                        multydivideIndex = calResult.IndexOfAny(new char[] { '*', '/' }, indexRbfirst, indexRbLast - indexRbfirst);
                    }

                    // '+', '-' 연산
                    addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, indexRbfirst, indexRbLast - indexRbfirst);
                    while (addMinusIndex != -1)
                    {
                        // '-' 연산자가 '(' 앞 위치할 경우 음수로 판단, 다음 연산자 재설정
                        if (calResult[addMinusIndex] == '-' && addMinusIndex == indexRbfirst + 1)
                        {
                            addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, indexRbfirst + 2, indexRbLast - indexRbfirst - 1);
                            // '-'연산자가 '--'로 겹칠 경우 제거하여 양수로 변환, 다음 연산자 재설정
                            if (addMinusIndex == -1)
                            {
                                continue;
                            }
                            else if (calResult[addMinusIndex] == '-' && addMinusIndex == indexRbfirst +2)
                            {
                                calResult = calResult.Remove(addMinusIndex - 1, 2);
                                indexRbLast = calResult.IndexOf(')');
                                indexRbfirst = calResult.LastIndexOf('(', indexRbLast);
                                addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, indexRbfirst, indexRbLast - indexRbfirst);
                                continue;
                            }
                            else if (calResult[addMinusIndex] == '+' && addMinusIndex == indexRbfirst + 2)
                            {
                                result[1] = "'-+' 연산 불가";
                                return result;
                            }
                        }
                        numStartIndex = calResult.LastIndexOfAny(new char[] { '(' }, addMinusIndex) + 1;
                        numLastIndex = calResult.IndexOfAny(new char[] { '+', '-', ')' }, addMinusIndex + 1) - 1;
                        // 숫자 및 연산자 인덱스 주입
                        resultMsg = checkCal(numStartIndex, numLastIndex, addMinusIndex);
                        if (resultMsg == errorMsg)
                        {
                            result[1] = errorMsg;
                            return result;
                        }
                        // () 소괄호 및 연산자 인덱스 재설정
                        indexRbLast = calResult.IndexOf(')');
                        indexRbfirst = calResult.LastIndexOf('(', indexRbLast);
                        addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, indexRbfirst, indexRbLast - indexRbfirst);
                    }

                    // 연산 완료된 () 소괄호 제거
                    calResult = calResult.Remove(indexRbfirst, 1);
                    calResult = calResult.Remove(indexRbLast - 1, 1);

                    // ')'연산자가 -1일경우 LastIndexOf 인덱스에 주입불가 하므로 재설정
                    indexRbLast = calResult.IndexOf(')');
                    if (indexRbLast == -1)
                    {
                        indexRbfirst = -1;
                    }
                    else
                    {
                        indexRbfirst = calResult.LastIndexOf('(', indexRbLast);
                    }
                }

                // 나머지 연산
                // '*', '/' 연산
                multydivideIndex = calResult.IndexOfAny(new char[] { '*', '/' }, 0, calResult.Length);
                while (multydivideIndex != -1)
                {
                    numStartIndex = calResult.LastIndexOfAny(new char[] { '+', '-'}, multydivideIndex) + 1;
                    // 연산자가 마지막에 위치할 경우[ex) 1*2-, 1/2*]
                    if (multydivideIndex == calResult.Length -1) {
                        result[1] = "연산자 마지막 위치 불가능";
                        return result;
                    }
                    numLastIndex = calResult.IndexOfAny(new char[] { '+', '-', '/', '*'}, multydivideIndex + 1) - 1;
                    // 뒤 연산자가 없을경우
                    if (numLastIndex == -2) {
                        numLastIndex = calResult.Length -1;
                    }
                    // '*', '/' 연산
                    resultMsg=checkCal(numStartIndex, numLastIndex, multydivideIndex);
                    if (resultMsg == errorMsg)
                    {
                        result[1] = errorMsg;
                        return result;
                    }
                    multydivideIndex = calResult.IndexOfAny(new char[] { '*', '/' }, 0, calResult.Length);
                }

                // '+', '-' 연산
                addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, 0, calResult.Length);
                while (addMinusIndex != -1)
                {
                    // '-'연산자가 처음 위치할 경우, 음수로 계산
                    if (calResult[addMinusIndex] == '-' && addMinusIndex == 0)
                    {
                        // 다음 연산자 재설정
                        addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' },1, calResult.Length - 1);
                        // -- 연산자 일경우 양수로 변환, 다음 연산자 재설정
                        if (addMinusIndex == -1)
                        {
                            continue;
                        }
                        else if (calResult[addMinusIndex] == '-' && addMinusIndex == 1)
                        {
                            calResult = calResult.Remove(0, 2);
                            addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, 0, calResult.Length);
                            continue;
                        }
                        else if (calResult[addMinusIndex] == '+' && addMinusIndex == 1)
                        {
                            result[1] = "'-+' 연산 불가";
                            return result;
                        }
                    }
                    numStartIndex = 0;
                    // 연산자가 마지막에 위치할 경우[ex) 1*2-, 1/2*]
                    if (addMinusIndex == calResult.Length - 1)
                    {
                        result[1] = "연산자 마지막 위치 불가능";
                        return result;
                    }
                    numLastIndex = calResult.IndexOfAny(new char[] { '+', '-' }, addMinusIndex + 1) - 1;
                    // 뒤 연산자가 없을경우
                    if (numLastIndex == -2)
                    {
                        numLastIndex = calResult.Length - 1;
                    }
                    // '+', '-' 연산
                    resultMsg = checkCal(numStartIndex, numLastIndex, addMinusIndex);
                    if (resultMsg == errorMsg)
                    {
                        result[1] = errorMsg;
                        return result;
                    }
                    addMinusIndex = calResult.IndexOfAny(new char[] { '+', '-' }, 0, calResult.Length);
                }

                // 연산 오류 없이 종료시 연산식 및 연산결과 저장하여 반환
                result[0] = this.calFormula;
                result[1] = this.calResult;
                return result;
            }
            catch (Exception e) {
                result[1] = e.Message;
                return result;
            }
        }

        // 연산이 불가능한 문자가 포함되있는지 체크
        public string checkForm(string calFormCheck) {
            char[] possibleForm = new char[] { 
                '(', ')', '+', '-', '*', '/', 
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' 
            };

            // 연산 가능한 문자 전부 제거
            while (calFormCheck.IndexOfAny(possibleForm) != -1)
            {
                calFormCheck = calFormCheck.Remove(calFormCheck.IndexOfAny(possibleForm), 1);
            }

            return calFormCheck;
        }

        // () 소괄호 체크
        public string checkRoundBracket(string calFormCheck) {
            string checkForm = null ;
            int indexRb = calFormCheck.IndexOfAny(new char[] { '(', ')' });
            int checkRb = 0;
            // chekForm에 () 소괄호만 순서대로 주입
            while (indexRb != -1) {
                checkForm += calFormCheck[indexRb];
                calFormCheck = calFormCheck.Remove(indexRb, 1);
                indexRb = calFormCheck.IndexOfAny(new char[] { '(', ')' });
            }

            // checkForm 검사
            // checkRb 음수일경우 '(' 부족, 양수일경우 ')' 부족 
            if (checkForm != null) {
                foreach (char c in checkForm)
                {
                    if (c == '('){ checkRb++; }
                    else{ checkRb--; }

                    if (checkRb < 0) { return "'(' 소괄호가 없습니다"; }
                }

                if (checkRb > 0) { return "')' 소괄호가 없습니다"; }
            }
            // checkRb 0 일경우 () 순서 및 갯수 적합
            return "";
        }

        // 연산자 순서 및 '-'연산자 음수로 반환
        public string checkCal(int numStartIndex, int numLastIndex, int operatorIndex) {
            // 연산자로 시작 또는 종료할 경우 [ex)*1+2 or 1+2-] or 연산자가 중복될 경우 [ex) 1**2 or 1/+2] 오류메시지 반환
            if (numStartIndex == operatorIndex || numLastIndex == operatorIndex)
            {
                // 연산자 뒤 음수일경우 [ex) 1*-2] 2번째 숫자 인덱스 재설정
                if (calResult[numLastIndex + 1] == '-')
                {
                    // 연산자 뒤 음수가 마지막 인덱스일 경우 [ex)1+2*-] 오류메시지 반환
                    if (numLastIndex+1 == calResult.Length-1) {
                        errorMsg = "'-' 연산자 마지막 위치 불가";
                        return errorMsg;
                    }
                    numLastIndex = calResult.IndexOfAny(new char[] { '+', '-', '/', '*', ')' }, operatorIndex + 2) - 1;
                    // 뒤 연산자가 없을 경우 [ex) 1+-2]
                    if (numLastIndex == -2) {
                        numLastIndex = calResult.Length- 1;
                    }
                    return numberCal(numStartIndex, numLastIndex, operatorIndex);
                }
                else {
                    errorMsg = "연산자가 중복되거나 처음 또는 마지막에 위치할 수 없습니다";
                    return errorMsg;
                }
            }
            else
            {
                return numberCal(numStartIndex, numLastIndex, operatorIndex);
            }
        }

        // 숫자 연산
        public string numberCal(int numStartIndex,int numLastIndex, int operatorIndex) {
            string beforeNum = calResult.Substring(numStartIndex, operatorIndex - numStartIndex);
            string afterNum = calResult.Substring(operatorIndex + 1, numLastIndex - operatorIndex);
            string calSubResult = null;

            // ()안 마지막 인덱스 연산자가 '-'일경우 [ex)(1+2-)] 오류메시지 반환
            if (afterNum == "-") {
                errorMsg = "'-' 연산자 마지막 위치 불가";
                return errorMsg;
            }

            // 숫자의 시작과 끝이 '.'일 경우 오류메시지 반환
            if (beforeNum[0] == '.' || beforeNum[beforeNum.Length - 1] == '.' || afterNum[0] == '.' || afterNum[afterNum.Length - 1] == '.')
            {
                errorMsg = "잘못된 (.)연산식 포함";
                return errorMsg;
            }
            else
            {
                if (calResult[operatorIndex] == '*') {
                    calSubResult = (double.Parse(beforeNum) * double.Parse(afterNum)).ToString();
                } else if (calResult[operatorIndex] == '/') {
                    calSubResult = (double.Parse(beforeNum) / double.Parse(afterNum)).ToString();
                } else if (calResult[operatorIndex] == '+') {
                    calSubResult = (double.Parse(beforeNum) + double.Parse(afterNum)).ToString();
                } else if (calResult[operatorIndex] == '-') {
                    calSubResult = (double.Parse(beforeNum) - double.Parse(afterNum)).ToString();
                }
                // 연산 후 연산식 제거 및 연산결과 주입
                calResult = calResult.Remove(numStartIndex, numLastIndex - numStartIndex + 1);
                calResult = calResult.Insert(numStartIndex, calSubResult);
                return calResult;
            }
        }
    }
}
