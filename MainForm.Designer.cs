namespace SimpleWinform
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "항목"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "연산자",
            "\'+\'  \'-\'  \'*\'  \'/\'"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "피연산자",
            "정수  실수  음수"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "괄호",
            "\'(\'  \')\'"}, -1);
            this.gbCSV = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectSave = new System.Windows.Forms.Button();
            this.lbSaveFile = new System.Windows.Forms.Label();
            this.lvSummary = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Int = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Double = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.String = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Null = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFilesUpload = new System.Windows.Forms.Button();
            this.lbFilesUpload = new System.Windows.Forms.Label();
            this.clbSelectFiles = new System.Windows.Forms.CheckedListBox();
            this.lbSelectFile = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.gbCal = new System.Windows.Forms.GroupBox();
            this.btnCalResultClear = new System.Windows.Forms.Button();
            this.dgCalResult = new System.Windows.Forms.DataGridView();
            this.CalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lvHelp = new System.Windows.Forms.ListView();
            this.Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbCalResultHelp = new System.Windows.Forms.Label();
            this.lbCalResult = new System.Windows.Forms.Label();
            this.lbCalHelp = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbCalFormula = new System.Windows.Forms.TextBox();
            this.lbDragDrop = new System.Windows.Forms.Label();
            this.gbCSV.SuspendLayout();
            this.gbCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCSV
            // 
            this.gbCSV.Controls.Add(this.lbDragDrop);
            this.gbCSV.Controls.Add(this.btnClear);
            this.gbCSV.Controls.Add(this.btnSelectSave);
            this.gbCSV.Controls.Add(this.lbSaveFile);
            this.gbCSV.Controls.Add(this.lvSummary);
            this.gbCSV.Controls.Add(this.btnFilesUpload);
            this.gbCSV.Controls.Add(this.lbFilesUpload);
            this.gbCSV.Controls.Add(this.clbSelectFiles);
            this.gbCSV.Controls.Add(this.lbSelectFile);
            this.gbCSV.Controls.Add(this.btnSelectFiles);
            this.gbCSV.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCSV.Location = new System.Drawing.Point(12, 12);
            this.gbCSV.Name = "gbCSV";
            this.gbCSV.Size = new System.Drawing.Size(547, 528);
            this.gbCSV.TabIndex = 0;
            this.gbCSV.TabStop = false;
            this.gbCSV.Text = "CSV Reader";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(439, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 28);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "목록 제거";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelectSave
            // 
            this.btnSelectSave.AutoSize = true;
            this.btnSelectSave.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSelectSave.Enabled = false;
            this.btnSelectSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSelectSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSelectSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelectSave.Location = new System.Drawing.Point(439, 483);
            this.btnSelectSave.Name = "btnSelectSave";
            this.btnSelectSave.Size = new System.Drawing.Size(88, 28);
            this.btnSelectSave.TabIndex = 8;
            this.btnSelectSave.Text = "파일 저장";
            this.btnSelectSave.UseVisualStyleBackColor = false;
            this.btnSelectSave.Click += new System.EventHandler(this.btnSelectSave_Click);
            // 
            // lbSaveFile
            // 
            this.lbSaveFile.AutoSize = true;
            this.lbSaveFile.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSaveFile.Location = new System.Drawing.Point(312, 492);
            this.lbSaveFile.Name = "lbSaveFile";
            this.lbSaveFile.Size = new System.Drawing.Size(123, 16);
            this.lbSaveFile.TabIndex = 6;
            this.lbSaveFile.Text = "요약 파일저장 : ";
            // 
            // lvSummary
            // 
            this.lvSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.Int,
            this.Double,
            this.String,
            this.Null,
            this.Sum,
            this.Avg,
            this.Max,
            this.Min});
            this.lvSummary.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvSummary.HideSelection = false;
            this.lvSummary.Location = new System.Drawing.Point(15, 295);
            this.lvSummary.Name = "lvSummary";
            this.lvSummary.Size = new System.Drawing.Size(512, 179);
            this.lvSummary.TabIndex = 5;
            this.lvSummary.UseCompatibleStateImageBehavior = false;
            this.lvSummary.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "컬럼명";
            // 
            // Int
            // 
            this.Int.Text = "정수";
            this.Int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Int.Width = 50;
            // 
            // Double
            // 
            this.Double.Text = "실수";
            this.Double.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Double.Width = 50;
            // 
            // String
            // 
            this.String.Text = "문자열";
            this.String.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.String.Width = 55;
            // 
            // Null
            // 
            this.Null.Text = "Null";
            this.Null.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Null.Width = 50;
            // 
            // Sum
            // 
            this.Sum.Text = "합계";
            this.Sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Avg
            // 
            this.Avg.Text = "평균";
            this.Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Max
            // 
            this.Max.Text = "최대값";
            this.Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Min
            // 
            this.Min.Text = "최소값";
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFilesUpload
            // 
            this.btnFilesUpload.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnFilesUpload.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFilesUpload.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilesUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnFilesUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilesUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilesUpload.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFilesUpload.Location = new System.Drawing.Point(424, 266);
            this.btnFilesUpload.Name = "btnFilesUpload";
            this.btnFilesUpload.Size = new System.Drawing.Size(103, 27);
            this.btnFilesUpload.TabIndex = 4;
            this.btnFilesUpload.Text = "파일 업로드";
            this.btnFilesUpload.UseVisualStyleBackColor = false;
            this.btnFilesUpload.Click += new System.EventHandler(this.btnFilesUpload_Click);
            // 
            // lbFilesUpload
            // 
            this.lbFilesUpload.AutoSize = true;
            this.lbFilesUpload.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFilesUpload.Location = new System.Drawing.Point(164, 268);
            this.lbFilesUpload.Name = "lbFilesUpload";
            this.lbFilesUpload.Size = new System.Drawing.Size(165, 16);
            this.lbFilesUpload.TabIndex = 3;
            this.lbFilesUpload.Text = "CSV 파일 요약본 보기";
            // 
            // clbSelectFiles
            // 
            this.clbSelectFiles.AllowDrop = true;
            this.clbSelectFiles.CheckOnClick = true;
            this.clbSelectFiles.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clbSelectFiles.FormattingEnabled = true;
            this.clbSelectFiles.HorizontalScrollbar = true;
            this.clbSelectFiles.Location = new System.Drawing.Point(15, 84);
            this.clbSelectFiles.Name = "clbSelectFiles";
            this.clbSelectFiles.Size = new System.Drawing.Size(512, 157);
            this.clbSelectFiles.TabIndex = 2;
            this.clbSelectFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.clbSelectFiles_DragDrop);
            this.clbSelectFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.clbSelectFiles_DragEnter);
            // 
            // lbSelectFile
            // 
            this.lbSelectFile.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSelectFile.Location = new System.Drawing.Point(21, 43);
            this.lbSelectFile.Name = "lbSelectFile";
            this.lbSelectFile.Size = new System.Drawing.Size(320, 36);
            this.lbSelectFile.TabIndex = 1;
            this.lbSelectFile.Text = "CSV 파일을 선택해주세요\r\n(다중 파일은 컬럼명칭 및 순서가 동일)";
            this.lbSelectFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.AutoSize = true;
            this.btnSelectFiles.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSelectFiles.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSelectFiles.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSelectFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFiles.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelectFiles.Location = new System.Drawing.Point(347, 55);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(88, 28);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "파일 선택";
            this.btnSelectFiles.UseVisualStyleBackColor = false;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // gbCal
            // 
            this.gbCal.Controls.Add(this.btnCalResultClear);
            this.gbCal.Controls.Add(this.dgCalResult);
            this.gbCal.Controls.Add(this.label1);
            this.gbCal.Controls.Add(this.lvHelp);
            this.gbCal.Controls.Add(this.lbCalResultHelp);
            this.gbCal.Controls.Add(this.lbCalResult);
            this.gbCal.Controls.Add(this.lbCalHelp);
            this.gbCal.Controls.Add(this.btnResult);
            this.gbCal.Controls.Add(this.tbCalFormula);
            this.gbCal.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCal.Location = new System.Drawing.Point(579, 12);
            this.gbCal.Name = "gbCal";
            this.gbCal.Size = new System.Drawing.Size(425, 528);
            this.gbCal.TabIndex = 1;
            this.gbCal.TabStop = false;
            this.gbCal.Text = "Text Calulator";
            // 
            // btnCalResultClear
            // 
            this.btnCalResultClear.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCalResultClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCalResultClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalResultClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCalResultClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalResultClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalResultClear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalResultClear.Location = new System.Drawing.Point(311, 178);
            this.btnCalResultClear.Name = "btnCalResultClear";
            this.btnCalResultClear.Size = new System.Drawing.Size(88, 27);
            this.btnCalResultClear.TabIndex = 11;
            this.btnCalResultClear.Text = "전체 삭제";
            this.btnCalResultClear.UseVisualStyleBackColor = false;
            this.btnCalResultClear.Click += new System.EventHandler(this.btnCalResultClear_Click);
            // 
            // dgCalResult
            // 
            this.dgCalResult.AllowUserToAddRows = false;
            this.dgCalResult.AllowUserToResizeRows = false;
            this.dgCalResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgCalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCalResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCalResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgCalResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCalResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCalResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCalResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalTime,
            this.CalFormula,
            this.Result});
            this.dgCalResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgCalResult.Location = new System.Drawing.Point(24, 206);
            this.dgCalResult.MultiSelect = false;
            this.dgCalResult.Name = "dgCalResult";
            this.dgCalResult.ReadOnly = true;
            this.dgCalResult.RowHeadersVisible = false;
            this.dgCalResult.RowTemplate.Height = 23;
            this.dgCalResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCalResult.Size = new System.Drawing.Size(375, 191);
            this.dgCalResult.TabIndex = 10;
            // 
            // CalTime
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.CalTime.Frozen = true;
            this.CalTime.HeaderText = "시간";
            this.CalTime.Name = "CalTime";
            this.CalTime.ReadOnly = true;
            this.CalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CalTime.Width = 72;
            // 
            // CalFormula
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalFormula.DefaultCellStyle = dataGridViewCellStyle7;
            this.CalFormula.HeaderText = "연산식";
            this.CalFormula.Name = "CalFormula";
            this.CalFormula.ReadOnly = true;
            this.CalFormula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CalFormula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CalFormula.Width = 200;
            // 
            // Result
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result.DefaultCellStyle = dataGridViewCellStyle8;
            this.Result.HeaderText = "결과";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(160, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "지원하는 포맷";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvHelp
            // 
            this.lvHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.lvHelp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header,
            this.list});
            this.lvHelp.Enabled = false;
            this.lvHelp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvHelp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvHelp.HideSelection = false;
            listViewItem7.Tag = "";
            this.lvHelp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvHelp.Location = new System.Drawing.Point(24, 427);
            this.lvHelp.MultiSelect = false;
            this.lvHelp.Name = "lvHelp";
            this.lvHelp.Size = new System.Drawing.Size(375, 90);
            this.lvHelp.TabIndex = 8;
            this.lvHelp.UseCompatibleStateImageBehavior = false;
            this.lvHelp.View = System.Windows.Forms.View.Details;
            // 
            // Header
            // 
            this.Header.Text = "";
            this.Header.Width = 80;
            // 
            // list
            // 
            this.list.Text = "항목";
            this.list.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list.Width = 290;
            // 
            // lbCalResultHelp
            // 
            this.lbCalResultHelp.AutoSize = true;
            this.lbCalResultHelp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCalResultHelp.Location = new System.Drawing.Point(160, 184);
            this.lbCalResultHelp.Name = "lbCalResultHelp";
            this.lbCalResultHelp.Size = new System.Drawing.Size(81, 16);
            this.lbCalResultHelp.TabIndex = 7;
            this.lbCalResultHelp.Text = "연산 결과";
            this.lbCalResultHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCalResult
            // 
            this.lbCalResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbCalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCalResult.Location = new System.Drawing.Point(24, 84);
            this.lbCalResult.Name = "lbCalResult";
            this.lbCalResult.Size = new System.Drawing.Size(375, 38);
            this.lbCalResult.TabIndex = 6;
            this.lbCalResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCalHelp
            // 
            this.lbCalHelp.AutoSize = true;
            this.lbCalHelp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCalHelp.Location = new System.Drawing.Point(51, 44);
            this.lbCalHelp.Name = "lbCalHelp";
            this.lbCalHelp.Size = new System.Drawing.Size(334, 32);
            this.lbCalHelp.TabIndex = 4;
            this.lbCalHelp.Text = "텍스트 입력 계산기 입니다\r\n\"  ( , ) , * . / , + , - \" 연산자만 사용가능합니다";
            this.lbCalHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.Control;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResult.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.Location = new System.Drawing.Point(345, 133);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(54, 33);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbCalFormula
            // 
            this.tbCalFormula.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCalFormula.Location = new System.Drawing.Point(24, 133);
            this.tbCalFormula.Multiline = true;
            this.tbCalFormula.Name = "tbCalFormula";
            this.tbCalFormula.Size = new System.Drawing.Size(315, 33);
            this.tbCalFormula.TabIndex = 1;
            // 
            // lbDragDrop
            // 
            this.lbDragDrop.AutoSize = true;
            this.lbDragDrop.BackColor = System.Drawing.SystemColors.Window;
            this.lbDragDrop.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDragDrop.Location = new System.Drawing.Point(173, 152);
            this.lbDragDrop.Name = "lbDragDrop";
            this.lbDragDrop.Size = new System.Drawing.Size(185, 19);
            this.lbDragDrop.TabIndex = 11;
            this.lbDragDrop.Text = "Drag && Drop Available";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1025, 549);
            this.Controls.Add(this.gbCal);
            this.Controls.Add(this.gbCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CsvReader & TextCalculator";
            this.gbCSV.ResumeLayout(false);
            this.gbCSV.PerformLayout();
            this.gbCal.ResumeLayout(false);
            this.gbCal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCSV;
        private System.Windows.Forms.GroupBox gbCal;
        private System.Windows.Forms.Label lbSelectFile;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.CheckedListBox clbSelectFiles;
        private System.Windows.Forms.Button btnSelectSave;
        private System.Windows.Forms.Label lbSaveFile;
        private System.Windows.Forms.ListView lvSummary;
        private System.Windows.Forms.Button btnFilesUpload;
        private System.Windows.Forms.Label lbFilesUpload;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader Int;
        private System.Windows.Forms.ColumnHeader Double;
        private System.Windows.Forms.ColumnHeader String;
        private System.Windows.Forms.ColumnHeader Null;
        private System.Windows.Forms.ColumnHeader Sum;
        private System.Windows.Forms.ColumnHeader Avg;
        private System.Windows.Forms.ColumnHeader Max;
        private System.Windows.Forms.ColumnHeader Min;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbCalFormula;
        private System.Windows.Forms.Label lbCalHelp;
        private System.Windows.Forms.Label lbCalResult;
        private System.Windows.Forms.Label lbCalResultHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHelp;
        private System.Windows.Forms.ColumnHeader Header;
        private System.Windows.Forms.ColumnHeader list;
        private System.Windows.Forms.DataGridView dgCalResult;
        private System.Windows.Forms.Button btnCalResultClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Label lbDragDrop;
    }
}

