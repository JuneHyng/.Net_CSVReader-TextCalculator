using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleWinform
{
    internal class CsvReader
    {
        private List<string> filePaths;
        private string[] ColumnNames;
        private List<string[]> checkColumn = new List<string[]>();
        private List<string[]> LineData = new List<string[]>();
        private List<ArrayList> DataList = new List<ArrayList>();
        private List<string[]> summaryList = new List<string[]>();

        public void setFilePaths(List<string> filePaths) {
            this.filePaths = filePaths;
        }

        public List<string[]> getLineData() {
            return LineData;
        }

        // 파일별 컬럼이름 확인
        public bool checkedColums()
        {
            bool isEqual = true;
            checkColumn.Clear();
            LineData.Clear();

            //파일별 컬럼정렬하여 리스트추가
            foreach (string filePath in filePaths)
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    string Columnline = sr.ReadLine();
                    ColumnNames = Columnline.Split(',');
                    checkColumn.Add(ColumnNames);
                }
            }

            //리스트안의 배열확인
            for (int i = 0; i < (checkColumn.Count - 1); i++)
            {
                string[] arr1 = checkColumn[i];
                string[] arr2 = checkColumn[i + 1];
                isEqual = arr1.SequenceEqual(arr2);
                if (!isEqual)
                {
                    return isEqual;
                }
            }

            return isEqual;
        }

        // 파일 컬럼별로 합치기
        public List<ArrayList> createDataList() {
            DataList.Clear();
            // 컬럼별 List 생성 및 컬럼이름 추가
            for (int i = 0; i < ColumnNames.Length; i++)
            {
                DataList.Add(new ArrayList());
                DataList[i].Add(ColumnNames[i]);
            }

            // 파일, 컬럼별 데이터 List에 추가
            foreach (string filePath in filePaths)
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    sr.ReadLine(); // 컬럼이름 건너뛰기
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        string[] data = line.Split(',');
                        LineData.Add(data);
                        if (ColumnNames.Length != data.Length) {
                            return null;
                        }
                        for (int i = 0; i < data.Length; i++)
                        {
                            DataList[i].Add(data[i]); // 컬럼별 데이터 추가
                        }
                    }
                }
            }
            return DataList;
        }

        // 컬럼별 데이터 요약하여 List로 반환
        public List<string[]> summaryDataList(List<ArrayList> dataList) {
            summaryList.Clear();
            foreach (ArrayList columnList in dataList) {
                string columnName = columnList[0] as string;
                int longType = 0;
                int doubleType = 0;
                int stringType = 0;
                int nullType = 0;
                double maxData = double.MinValue;
                double minData = double.MaxValue;
                double sumNumber = 0L;
                double AvgNumber = 0.0;

                //컬럼별 데이터 타입 및 합계,최소,최대값 연산
                foreach (string data in columnList) {

                    if (string.IsNullOrEmpty(data))
                    {
                        nullType++;
                    }
                    else if (long.TryParse(data, out long longResult))
                    {
                        longType++;
                        sumNumber += longResult;
                        if (longResult > maxData)
                        {
                            maxData = longResult;
                        }
                        if (longResult < minData)
                        {
                            minData = longResult;
                        }
                    }
                    else if (double.TryParse(data, out double doubleResult))
                    {
                        doubleType++;
                        sumNumber += doubleResult;
                        if (doubleResult > maxData)
                        {
                            maxData = doubleResult;
                        }
                        if (doubleResult < minData)
                        {
                            minData = doubleResult;
                        }
                    }
                    else
                    {
                        stringType++;
                    }
                }

                //연산이 불가능한 문자열만 있을경우 NaN처리
                if ((longType + doubleType) == 0)
                {
                    AvgNumber = double.NaN;
                    sumNumber= double.NaN;
                }
                else {
                    //숫자일 경우 소수점 2자리까지 반환
                    AvgNumber = (int)((sumNumber / (longType + doubleType))*100)/100.0;
                }

                //숫자가 아닌 문자열만 있을경우 NaN처리
                if (maxData == double.MinValue && minData == double.MaxValue) {
                    maxData = double.NaN;
                    minData = double.NaN;
                }

                string[] summaryArr = new string[9] {
                    columnName,
                    Convert.ToString(longType), 
                    Convert.ToString(doubleType),
                    Convert.ToString(stringType),
                    Convert.ToString(nullType),
                    Convert.ToString(sumNumber),
                    Convert.ToString(AvgNumber),
                    Convert.ToString(maxData),
                    Convert.ToString(minData)
                };

                summaryList.Add(summaryArr);
            
            }

            return summaryList;
        }
    }
}
