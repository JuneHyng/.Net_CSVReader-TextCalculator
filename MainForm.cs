using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleWinform
{
    public partial class MainForm : Form
    {
        private CsvReader csvReader = new CsvReader();
        private List<string> filePaths = new List<string>();
        private List<string[]> LineData;
        private List<ArrayList> DataList;
        private List<string[]> summaryList;
        private string savePath = "C:\\";
        private Calculator calculator = new Calculator();

        public MainForm()
        {
            InitializeComponent();
        }

        // 다중 CSV 파일 선택
        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect= true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    try
                    {
                        clbSelectFiles.Items.Add(fileName,true);
                        lbDragDrop.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // 파일 데이터 및 요약본 출력
        private void btnFilesUpload_Click(object sender, EventArgs e)
        {
            // 여러번 클릭시 값 초기화
            lvSummary.Items.Clear();
            filePaths.Clear();

            if (clbSelectFiles.CheckedItems.Count == 0)
            {
                MessageBox.Show("파일을 선택해주세요");
                btnSelectSave.Enabled = false;
                return;
            }

            // 파일경로 가져오기
            foreach (string filePath in clbSelectFiles.CheckedItems)
            {
                filePaths.Add(filePath);
            }
            int savePathIndex = filePaths[0].LastIndexOf('\\');
            savePath= filePaths[0].Substring(0,savePathIndex+1);

            // 파일경로 설정
            csvReader.setFilePaths(filePaths);

            //컬럼명 일치 확인
            if (!csvReader.checkedColums()) {
                MessageBox.Show("다른 컬럼을 가지는 파일이 포함되어 있습니다.");
                return;
            }

            //행별 데이터 리스트 반환
            LineData = csvReader.getLineData();
            //컬럼별 데이터 리스트 반환
            DataList = csvReader.createDataList();
            if (DataList == null) {
                MessageBox.Show("컬럼명이 없는 파일이 있습니다");
                return;
            }
            //컬럼별 요약데이터 리스트 반환
            summaryList = csvReader.summaryDataList(DataList);
            //요약데이터 출력
            foreach (string[] smmaryArr in summaryList) {
                ListViewItem lvi = new ListViewItem(smmaryArr);
                lvSummary.Items.Add(lvi);
            }
            btnSelectSave.Enabled = true;
        }

        // 파일 드랍
        private void clbSelectFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0) {
                    try {
                        foreach (string file in files)
                        {
                            if (file.EndsWith("csv"))
                            {
                                clbSelectFiles.Items.Add(file, true);
                                lbDragDrop.Visible = false;
                            }
                            else {
                                MessageBox.Show("csv 파일만 지원합니다");
                            }
                        }
                        
                    }
                    catch (Exception ee) {
                        Console.WriteLine(ee.Message);
                    }
                }
            }
        }

        // 파일 드래그
        private void clbSelectFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // 업로드 파일경로 모두 삭제
        private void btnClear_Click(object sender, EventArgs e)
        {
            clbSelectFiles.Items.Clear();
            lbDragDrop.Visible = true;
        }

        // 파일 저장 경로 설정
        private void btnSelectSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = savePath;
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 2;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter saveFile = new StreamWriter(saveFileDialog.FileName,true, Encoding.Default))
                    {
                        // 요약 데이터 csv 파일로 쓰기
                        saveFile.WriteLine("요약 데이터");
                        saveFile.WriteLine("컬럼명,정수(개),실수(개),문자열(개),Null(개),합계,평균,최대값,최소값");
                        foreach (string[] line in summaryList)
                        {
                            for (int i = 0; i < line.Length; i++)
                            {
                                saveFile.Write(line[i]);
                                if (i == line.Length - 1)
                                {
                                    saveFile.WriteLine();
                                }
                                else
                                {
                                    saveFile.Write(',');
                                }
                            }
                        }

                        // 원본 데이터 csv 파일로 쓰기
                        saveFile.WriteLine();
                        saveFile.WriteLine("원본 데이터");
                        foreach (string[] line in LineData)
                        {
                            for (int i = 0; i < line.Length; i++)
                            {
                                saveFile.Write(line[i]);
                                if (i == line.Length - 1)
                                {
                                    saveFile.WriteLine();
                                }
                                else
                                {
                                    saveFile.Write(',');
                                }
                            }
                        }
                    }
                }
                catch ( Exception ex ) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // 연산 하기
        private void btnResult_Click(object sender, EventArgs e)
        {
            string calFormula=tbCalFormula.Text;
            string[] result = calculator.calculate(calFormula);

            // 기존 Parser 계산기
            //DataTable dt=new DataTable();
            //object result = dt.Compute(calFormula, "");
            
            if (result[0] == "오류")
            {
                lbCalResult.Font = new Font("굴림", 10);
                lbCalResult.Text = $"{result[0]} : {result[1]}";
            }
            else
            {
                lbCalResult.Font = new Font("굴림", 20, FontStyle.Bold);
                lbCalResult.Text = result[1];
                dgCalResult.Rows.Add(DateTime.Now.ToString("hh:mm"), result[0], result[1]);
            }
            
        }

        private void btnCalResultClear_Click(object sender, EventArgs e)
        {
            dgCalResult.Rows.Clear();
        }
    }
}
