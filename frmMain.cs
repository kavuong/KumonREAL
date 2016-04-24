using System;
using System.Windows.Forms;

public class frmMain:Form
{
    private Label lblSignIn;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button btnGoIn;
    private Button btnGoOut;
    private Label lblSignOut;
    private ListView lsvTable;
    private ColumnHeader clmName;
    private ColumnHeader clmInTime;
    private ColumnHeader clmTotalTime;
    private Button button1;
    private Button button2;
    private PictureBox pictureBox1;
    #region Windows Code
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGoIn = new System.Windows.Forms.Button();
            this.btnGoOut = new System.Windows.Forms.Button();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.lsvTable = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSignIn.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(455, 22);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(138, 35);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "SIGN IN";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(614, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(614, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnGoIn
            // 
            this.btnGoIn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoIn.Location = new System.Drawing.Point(868, 20);
            this.btnGoIn.Name = "btnGoIn";
            this.btnGoIn.Size = new System.Drawing.Size(75, 37);
            this.btnGoIn.TabIndex = 5;
            this.btnGoIn.Text = "GO!";
            this.btnGoIn.UseVisualStyleBackColor = true;
            // 
            // btnGoOut
            // 
            this.btnGoOut.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoOut.Location = new System.Drawing.Point(868, 78);
            this.btnGoOut.Name = "btnGoOut";
            this.btnGoOut.Size = new System.Drawing.Size(75, 35);
            this.btnGoOut.TabIndex = 6;
            this.btnGoOut.Text = "GO!";
            this.btnGoOut.UseVisualStyleBackColor = true;
            // 
            // lblSignOut
            // 
            this.lblSignOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSignOut.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.Location = new System.Drawing.Point(455, 78);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(138, 35);
            this.lblSignOut.TabIndex = 7;
            this.lblSignOut.Text = "SIGN OUT";
            this.lblSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvTable
            // 
            this.lsvTable.AutoArrange = false;
            this.lsvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmInTime,
            this.clmTotalTime});
            this.lsvTable.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTable.Location = new System.Drawing.Point(45, 182);
            this.lsvTable.Name = "lsvTable";
            this.lsvTable.Size = new System.Drawing.Size(898, 263);
            this.lsvTable.TabIndex = 12;
            this.lsvTable.UseCompatibleStateImageBehavior = false;
            this.lsvTable.View = System.Windows.Forms.View.Details;
            this.lsvTable.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "STUDENT NAME";
            this.clmName.Width = 500;
            // 
            // clmInTime
            // 
            this.clmInTime.Text = "SIGN-IN TIME";
            this.clmInTime.Width = 189;
            // 
            // clmTotalTime
            // 
            this.clmTotalTime.Text = "TOTAL TIME";
            this.clmTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTotalTime.Width = 189;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "button for dummies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add new student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(994, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvTable);
            this.Controls.Add(this.lblSignOut);
            this.Controls.Add(this.btnGoOut);
            this.Controls.Add(this.btnGoIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion
    public frmMain()
    {
        InitializeComponent();
    }
    [STAThread]
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        String dummyString = "Srinath";
        String dummyTime = "9:59";
        String dummytotalTime = "31";

        String testString = "Kevin";
        String testStringTime = "5:02";
        String testStringTotalTime = "5";

        String testString2 = "Anthony";
        String testString2Time = "3:01";
        String testString2TotalTime = "26";

        ListViewItem Srinath;
        ListViewItem Kevin;
        ListViewItem Anthony;

        Srinath = new ListViewItem(dummyString);
        Srinath.SubItems.Add(dummyTime);
        Srinath.SubItems.Add(dummytotalTime);
        lsvTable.Items.Add(Srinath);
        Srinath.BackColor = System.Drawing.Color.Red;

        Kevin = new ListViewItem(testString);
        Kevin.SubItems.Add(testStringTime);
        Kevin.SubItems.Add(testStringTotalTime);
        lsvTable.Items.Add(Kevin);

        Anthony = new ListViewItem(testString2);
        Anthony.SubItems.Add(testString2Time);
        Anthony.SubItems.Add(testString2TotalTime);
        lsvTable.Items.Add(Anthony);
        Anthony.BackColor = System.Drawing.Color.Yellow;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        frmAdd add = new frmAdd();
        add.Show();
    }
}