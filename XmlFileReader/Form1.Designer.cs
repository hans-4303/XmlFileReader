
namespace XmlFileReader
{
    /// <summary>
    /// <para>Form 생성 및 사용해보기</para>
    /// <para>1. 생성된 Form은 partial class임, 즉 완성될 클래스를 여러 맥락으로 나눌 수 있음.</para>
    /// <para>2. System.ComponentModel.IContainer: 아래 설명 참고 </para>
    /// <para>3. protected override void Dispose: 아래 설명 참고</para>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(35, 93);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(216, 317);
            this.treeView1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(495, 317);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

