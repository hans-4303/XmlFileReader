
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace XmlFileReader
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Major { get; set; }
    }

    /// <summary>
    /// <para>Form 생성 및 사용해보기</para>
    /// <para>1. 생성된 Form은 partial class임, 즉 완성될 클래스를 여러 맥락으로 나눌 수 있음.</para>
    /// <para>2. System.ComponentModel.IContainer: 아래 설명 참고 </para>
    /// <para>3. protected override void Dispose: 아래 설명 참고</para>
    /// <para>4. 가급적 UI 변경 등 로직은 디자이너 파일에 작성을 권장</para>
    /// <para>
    ///     메인 로직은 되도록 간결히, UI에 변경사항 없도록 해서 프로그램이 STA 모델을 보장하도록
    /// </para>
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// <para>
        ///     필수 디자이너 변수라고만 정리되어 있지만 해당 인터페이스 타입으로 만든 변수는 컨테이너 컴포넌트에 의해 구현됨.
        ///     디자인 타임에 컴포넌트의 컬렉션을 관리하는 역할을 하며 Windows Forms 디자이너에서 사용됨.
        ///     변수는 디자이너에서 디자인한 컨트롤들을 담고 있는 컨테이너 역할을 함, 디자이너에서 폼을 디자인할 때 폼에 추가된 컨트롤들은 해당 변수에 자동으로 추가 됨.
        /// </para>
        /// <para>
        ///     또한 Dispose 메서드에서 components를 해제하고 있음, 이는 폼이 소멸될 때 해당 폼에 속한 컨트롤들을 정리하기 위함.
        ///     components 컨테이너를 통해 컨트롤들의 자원을 관리하고 메모리 누수가 방지됨.
        /// </para>
        /// <para>
        ///     이 변수는 직접 어떤 값으로 초기화하는 게 아니라 디자이너에서 자동으로 생성되고, 주로 디자이너에서 자동 생성된 코드에서 찾을 수 있음.
        ///     사용자가 직접 코드에서 해당 변수에 값을 대입하는 경우는 드묾.
        /// </para>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// <para>
        ///     이 메서드는 System.ComponentModel.Component 클래스에서 상속 받았고 오버라이딩 되고 있음.
        /// </para>
        /// <para>
        ///     일반적으로 Windows Forms 디자이너에서 폼이나 컨트롤을 디자인하면 디자이너는 Dispose 메서드 등을 자동으로 생성된 코드에 추가함.
        ///     이 메서드는 해당 컨트롤이나 폼이 소멸될 때 관련된 리소스를 정리하기 위해 사용됨
        ///     == useEffect(() => { return ... }, []);
        /// </para>
        /// <para>
        ///     폼 또는 컨트롤이 Dispose 메서드를 오버라이드 하는 부분이라 볼 수 있음.
        ///     Form 또는 Control 등 클래스에서 해당 메서드를 정의, 추가적인 정리 로직을 구현하거나 부모 클래스의 Dispose 메서드를 호출하도록 하는 것이 일반적 사용 패턴.
        ///     이를 통해 관련 리소스들을 적절하게 해제하고 메모리 누수를 방지할 수 있음.
        /// </para>
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
        /// <para>디자이너 지원에 필요한 메서드입니다. 이 메서드의 내용을 코드 편집기로 수정하지 마세요.</para>
        /// <para>1. 현재 Form1 클래스에 접근하여 UI를 선언하고 있음.</para>
        /// <para>
        ///     인스턴스 형식으로 각 UI 컴포넌트를 만들고 있으며 클래스의 필드 값으로 만듦.
        ///     어떤 요소, 혹은 전체에 대해 컨트롤의 레이아웃 논리를 중단시켜줄 수도 있음.
        /// </para>
        /// <para>((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit(); 로직:</para>
        /// <para>
        ///     실제로 캐스팅을 하는 것은 아니며 System.ComponentModel.ISupportInitialize이 인터페이스를 나타냄.
        ///     BeginInit 메서드는 해당 컴포넌트가 초기화되기 시작했음을 나타냄. EndInit 메서드는 초기화가 완료되었음을 나타냄.
        ///     이러한 패턴은 복잡한 초기화 로직을 대비하고, 초기화 중 컨트롤이 여러 번 갱신되는 것을 방지하며 성능 향상.
        /// </para>
        /// <para>
        ///     해당 로직은 UI가 ISupportInitialize를 구현하고 있는지 확인하고 만약 그렇다면 초기화가 시작됨을 나타내는 메서드를 호출하는 것임.
        ///     디자이너에서 자동으로 생성된 코드에서 사용하는 패턴.
        /// </para>
        /// <para>2. 컨테이너 요소에 접근하여 UI를 추가하고 있음.</para>
        /// <para>
        ///     어떠한 컨테이너 요소를 지정하고, 해당 컨테이너 요소 안에 세부 요소를 배치할 때 나타나는 패턴임.
        ///     컨테이너 요소의 Controls에 접근하여 Add() 메서드 호출하고 요소들을 대입함.
        ///     컨테이너 요소에서 Dock 속성을 지정하면 컨테이너 요소와 창의 도킹 방식이 결정됨.
        /// </para>
        /// <para>3. 컨테이너 및 세부 요소는 여러 속성을 가질 수 있음.</para>
        /// <para>
        ///     Location prop 지정하면 new System.Drawing.Point("x좌표", "y좌표") 인스턴스를 대입: 생성될 위치 잡음.
        ///     Name prop 지정하면 해당 요소에 대한 이름이 됨.
        ///     Size prop 지정하면 new System.Drawing.Size("너비", "높이") 인스턴스를 대입: 크기 잡음.
        ///     TabIndex prop 지정하면 프로그램 실행 후 tab 키로 요소 넘겨볼 순서 지정됨.
        ///     Text prop 지정하면 UI에 들어갈 텍스트 값 지정됨.
        ///     대개 UI의 속성에서 조정할 수 있을 것으로 보임.
        /// </para>
        /// <para>4. 여러 개의 컨테이너 요소가 있다 가정한 시나리오</para>
        /// <para>
        ///     현재 컨테이너 요소의 TabIndex는 0으로 textBox1.TabIndex 값과 같음, 이때는 해당 컨테이너 내에서 순서에 따라 포커스가 이동함.
        ///     다만 컨테이너 및 요소 구분 없이 각 컨트롤의 TabIndex 값은 다른 것이 더 좋음.
        /// </para>
        /// <para>
        ///     this.panel1.TabIndex = 0; this.textBox1.TabIndex = 2;
        /// </para>
        /// <para>
        ///     this.panel2.TabIndex = 1; this.textBox2.TabIndex = 3;
        /// </para>
        /// <para>
        ///     와 같이 설계해볼 수도 있겠음, 실제로 작성한다면 두 컨테이너가 먼저 선택되고
        ///     보조 UI 끼리 왔다 갔다 하는 것처럼 보일 것임.
        /// </para>
        /// <para>5. 전체 Form1 클래스에 대한 정리</para>
        /// <para>
        ///     this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);로 디자인된 컨트롤 크기 가져오거나 조정
        /// </para>
        /// <para>
        ///     this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;로 컨트롤의 자동 크기 조정 모드 가져오거나 설정
        ///     AutoScaleMode의 prop들로 설정할 수 있으며 설정하지 않음, 글꼴, 해당도, 상위 클래스에 따름 중 선택 가능.
        /// </para>
        /// <para>
        ///     this.ClientSize = new System.Drawing.Size(800, 450);로 현재 Winform의 클라이언트 사이즈 선택 가능.
        /// </para>
        /// <para>
        ///     this.Controls.Add(this.panel1);로 현재 Winform 클래스에 컨테이너 요소를 추가함.
        ///     폼 내부에 컨테이너 요소를 추가하지 않으면 컨테이너 요소를 출력할 수 없음.
        /// </para>
        /// <para>
        ///     this.Text는 현재 프로그램의 상단 표시줄 내용을 뜻함
        ///     == html title
        /// </para>
        /// <para>
        ///     ResumeLayout(false); : 선택한 폼이나 컨트롤의 레이아웃을 일시적으로 중지,
        ///     선택 요소의 하위 레이아웃 로직이 수행될 때 다시 활성화하도록 함
        ///     
        ///     예컨대 useEffect(() => {}, [하위 레이아웃 상태]);를 갖춘다 연상할 수 있겠음.
        /// </para>
        /// <para>
        ///     PerformLayout(); : 선택한 컨트롤 및 자식 컨트롤들에 대한 레이아웃 로직을 다시 활성화하는 코드,
        ///     SuspendLayout(); 메서드를 호출한 이후에 발생시켜야 하며 선택한 컨트롤과 자식 컨트롤들 레이아웃 업데이트를 재시작
        /// </para>
        /// </summary>
        private void InitializeComponent()
        {
            this.containerPanel = new System.Windows.Forms.Panel();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.btnFileParser = new System.Windows.Forms.Button();
            this.btnFileLoader = new System.Windows.Forms.Button();
            this.fileNameContainer = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.mainDataGridView);
            this.containerPanel.Controls.Add(this.mainTreeView);
            this.containerPanel.Controls.Add(this.btnFileParser);
            this.containerPanel.Controls.Add(this.btnFileLoader);
            this.containerPanel.Controls.Add(this.fileNameContainer);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(831, 462);
            this.containerPanel.TabIndex = 0;
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(267, 93);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersWidth = 51;
            this.mainDataGridView.RowTemplate.Height = 27;
            this.mainDataGridView.Size = new System.Drawing.Size(495, 317);
            this.mainDataGridView.TabIndex = 4;
            // 
            // mainTreeView
            // 
            this.mainTreeView.Location = new System.Drawing.Point(35, 93);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(216, 317);
            this.mainTreeView.TabIndex = 3;
            // 
            // btnFileParser
            // 
            this.btnFileParser.Location = new System.Drawing.Point(652, 36);
            this.btnFileParser.Name = "btnFileParser";
            this.btnFileParser.Size = new System.Drawing.Size(110, 23);
            this.btnFileParser.TabIndex = 2;
            this.btnFileParser.Text = "파싱";
            this.btnFileParser.UseVisualStyleBackColor = true;
            // 
            // btnFileLoader
            // 
            this.btnFileLoader.Location = new System.Drawing.Point(504, 36);
            this.btnFileLoader.Name = "btnFileLoader";
            this.btnFileLoader.Size = new System.Drawing.Size(110, 23);
            this.btnFileLoader.TabIndex = 1;
            this.btnFileLoader.Text = "로딩";
            this.btnFileLoader.UseVisualStyleBackColor = true;
            // 
            // fileNameContainer
            // 
            this.fileNameContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameContainer.Location = new System.Drawing.Point(35, 36);
            this.fileNameContainer.Name = "fileNameContainer";
            this.fileNameContainer.Size = new System.Drawing.Size(428, 25);
            this.fileNameContainer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 462);
            this.Controls.Add(this.containerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// <para>도구 상자를 통해 실제 생성된 UI</para>
        /// </summary>
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.TextBox fileNameContainer;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.Button btnFileParser;
        private System.Windows.Forms.Button btnFileLoader;

        /// <summary>
        /// <para>이벤트 초기화 메서드, 메인 로직에서 호출됨</para>
        /// <para>
        ///     별도의 멤버를 만들지 않아도 작동과 호출을 보장하는 prop도 있음, 예) Load
        ///     해당 prop에서 함수를 호출해줄 수 있음
        /// </para>
        /// <para>
        ///     현재 클래스의 멤버인 UI에 이벤트를 정의하고 함수를 호출할 수 있음
        ///     == button onClick={handleLoaderClick}
        /// </para>
        /// </summary>
        private void InitEvent()
        {
            btnFileLoader.Click += HandleLoaderClick;
            btnFileParser.Click += HandleParserClick;
            mainTreeView.AfterSelect += HandleMainTreeView;
        }

        /// <summary>
        /// <para>UI 클릭을 만족할 때 호출될 함수, 파일 로드 함수 호출</para>
        /// <para>
        ///     파일 로드 함수에서는 OpenFileDialog 인스턴스 만들고 Filter와 Title prop 초기화
        ///     인스턴스의 ShowDialog()를 통해 대화상자 반환 값을 확인받고 파일 이름 텍스트 박스 값을 바꿈
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleLoaderClick(object sender, EventArgs e)
        {
            GetOpenFile();
        }

        private void GetOpenFile()
        {
            OpenFileDialog configedOpenFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Title = "XML 파일 예제창"
            };

            if (configedOpenFileDialog.ShowDialog() == DialogResult.OK) fileNameContainer.Text = configedOpenFileDialog.FileName;
        }

        /// <summary>
        /// <para>UI 클릭을 만족할 때 호출될 함수, 파일 파싱 함수 호출</para>
        /// <para>1. 파일 이름 텍스트 값을 반환 받음</para>
        /// <para>2. 파일 이름에 해당하는 파일이 있는지 확인하여 조건문 실행</para>
        /// <para>
        ///     신기한 점: 여기서 File은 현재 앱 전체의 파일을 뜻하나? 그렇지 않고서는 대조해서 결과 알아낼 수 없을텐데
        /// </para>
        /// <para>3. TreeView Set 함수 호출 혹은 예외 처리</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleParserClick(object sender, EventArgs e)
        {
            string filePath = fileNameContainer.Text;

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show("File does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SetTreeViewFromXml(filePath);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// <para>XML 파일에서 TreeView를 설정하는 함수</para>
        /// <para>1. TreeView 컴포넌트의 노드 비워주기</para>
        /// <para>2. XmlDocument(); 인스턴스 만들기 </para>
        /// <para>3. 인스턴스에서 Load 메서드 호출하고 파일 경로 인수에 해당하는 내용을 XML로 불러오기</para>
        /// <para>4. 현재 문서의 루트와 이름 조회하고 기초 노드를 TreeNode 형으로 반환하기</para>
        /// <para>5. TreeView 컴포넌트의 노드에 기초 노드 대입하기</para>
        /// <para>6. 노드 추가하는 함수 호출하기 </para>
        /// <para>
        ///     이때 인수는 현재 문서의 루트 및 반환된 기초 노드
        /// </para>
        /// </summary>
        /// <param name="filePath"></param>
        private void SetTreeViewFromXml(string filePath)
        {
            mainTreeView.Nodes.Clear();

            XmlDocument currentXmlDoc = new XmlDocument();
            currentXmlDoc.Load(filePath);

            TreeNode rootNode = new TreeNode(currentXmlDoc.DocumentElement.Name);
            mainTreeView.Nodes.Add(rootNode);

            AddNodes(currentXmlDoc.DocumentElement, rootNode);
        }

        /// <summary>
        /// <para>TreeView에 노드를 추가하는 함수</para>
        /// <para>1. 파라미터는 현재 Xml 문서와 기초 노드로 지정.</para>
        /// <para>2. 현재 XML 문서의 ChildNodes 배열에 접근하여 순회</para>
        /// <para>
        ///     자식 노드가 될 TreeNode 인스턴스를 생성, 이때 인수는 순회하던 ChildNode의 이름
        ///     이후 파라미터로 받아온 rootNode의 Nodes에 추가해줌
        /// </para>
        /// <para>3. 자식 노드의 자식 노드까지 생각해야 하므로 재귀 방식 호출함</para>
        /// <para>
        ///     순회중인 자식 노드를 현재 Xml 문서로 취급하고 자식의 기초 노드로 함수 진행
        /// </para>
        /// </summary>
        /// <param name="currentXmlDoc"></param>
        /// <param name="rootNode"></param>
        private void AddNodes(XmlNode currentXmlDoc, TreeNode rootNode)
        {
            foreach (XmlNode childNode in currentXmlDoc.ChildNodes)
            {
                TreeNode childTreeNode = new TreeNode(childNode.Name);
                rootNode.Nodes.Add(childTreeNode);

                AddNodes(childNode, childTreeNode);
            }
        }

        /// <summary>
        /// <para>TreeView를 클릭하면 호출될 함수</para>
        /// <para>1. TreeView에서 선택한 노드를 반환 받음</para>
        /// <para>2. 선택한 노드의 텍스트 값을 테이블 이름으로 함 </para>
        /// <para>3. 데이터 그리드 뷰 Set 함수 호출, 인수는 선택한 노드의 텍스트 값 == 테이블 이름 </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleMainTreeView(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = mainTreeView.SelectedNode;
            if (selectedNode != null)
            {
                string tableName = selectedNode.Text;
                SetDataGridView(tableName);
            }
        }

        /// <summary>
        /// <para>TreeView 클릭 시 연계하여 호출될 함수</para>
        /// <para>1. DataSet 인스턴스 생성, 이 인스턴스는 파일 전체 내용 받음</para>
        /// <para>2. TreeView에서 선택된 노드를 반환 받음 </para>
        /// <para>3. 선택된 노드가 있다면 조건문 수행</para>
        /// <para>
        ///     DataGridView의 칼럼 지우기,
        ///     선택된 노드에서 칼럼 받아오는 함수 호출,
        ///     현재 파일과 선택한 노드의 텍스트 값 == 테이블 이름을 인수로 데이터 테이블 가져오는 함수 호출하고
        ///     DataGridView의 DataSource 값으로 반환하기
        /// </para>
        /// </summary>
        /// <param name="tableName"></param>
        private void SetDataGridView(string tableName)
        {
            DataSet currentDataSet = new DataSet();

            try
            {
                currentDataSet.ReadXml(fileNameContainer.Text);

                TreeNode selectedNode = mainTreeView.SelectedNode;

                if (selectedNode != null)
                {
                    mainDataGridView.Columns.Clear();
                    GetColumnsFromNode(selectedNode);
                    mainDataGridView.DataSource = GetTableData(currentDataSet, tableName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// <para>노드에서 칼럼 받아오는 함수</para>
        /// <para>1. 파라미터는 TreeView에서 선택된 노드</para>
        /// <para>2. 선택된 노드의 Nodes 배열을 순회(자식 노드로 취급)</para>
        /// <para>3. DataGridView.Column.Add(); 메서드 호출 가능</para>
        /// <para>
        ///     참조될 열의 이름과 텍스트를 인수로 전달해줌
        ///     여기에서 뭔가 제어해준다면 자식 테이블에서 칼럼 중첩을 해결할 수 있지 않을까?
        /// </para>
        /// </summary>
        /// <param name="selectedNode"></param>
        private void GetColumnsFromNode(TreeNode selectedNode)
        {
            //foreach (TreeNode childNode in selectedNode.Nodes)
            //{
            //    mainDataGridView.Columns.Add(childNode.Text, childNode.Text);
            //}
            for (int i = 0; i < selectedNode.Nodes.Count - 1; i++)
            {
                string currentColumnName = selectedNode.Nodes[i].Text;
                string nextColumnName = selectedNode.Nodes[i + 1].Text;

                if (currentColumnName != nextColumnName) mainDataGridView.Columns.Add(currentColumnName, currentColumnName);
            }

            if (selectedNode.Nodes.Count > 0)
            {
                mainDataGridView.Columns.Add(selectedNode.Nodes[selectedNode.Nodes.Count - 1].Text,
                    selectedNode.Nodes[selectedNode.Nodes.Count - 1].Text);
            }
        }

        /// <summary>
        /// <para>테이블 데이터를 받는 함수</para>
        /// <para>1. 현재 데이터 셋과 선택한 테이블 이름을 파라미터로 받음</para>
        /// <para>2. 현재 데이터 셋이 있으며 Tables 내부에는 tableName에 해당하는 내용이 포함되어 있는지 확인</para>
        /// <para>3. 있다면 현재 데이터 셋의 Tables중 tableName에 해당하는 값 반환하고 없다면 null</para>
        /// </summary>
        /// <param name="currentDataSet"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private DataTable GetTableData(DataSet currentDataSet, string tableName)
        {
            if (currentDataSet != null && currentDataSet.Tables.Contains(tableName))
            {
                return currentDataSet.Tables[tableName];
            }
            return null;
        }
    }
}