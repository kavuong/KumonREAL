using System;
using System.Windows.Forms;

public class frmMain:Form
{
    private Label lblSignIn;
    private TextBox txtSignIn;
    private TextBox txtSignOut;
    private Button btnGoIn;
    private Button btnGoOut;
    private Label lblSignOut;
    private ListView lsvTable;
    private ColumnHeader clmName;
    private ColumnHeader clmInTime;
    private ColumnHeader clmTotalTime;
    private Button btnNewStudent;
    private PictureBox picKumon;
    #region Windows Code
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picKumon = new System.Windows.Forms.PictureBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.txtSignIn = new System.Windows.Forms.TextBox();
            this.txtSignOut = new System.Windows.Forms.TextBox();
            this.btnGoIn = new System.Windows.Forms.Button();
            this.btnGoOut = new System.Windows.Forms.Button();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.lsvTable = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picKumon)).BeginInit();
            this.SuspendLayout();
            // 
            // picKumon
            // 
            this.picKumon.Image = ((System.Drawing.Image)(resources.GetObject("picKumon.Image")));
            this.picKumon.Location = new System.Drawing.Point(45, 12);
            this.picKumon.Name = "picKumon";
            this.picKumon.Size = new System.Drawing.Size(392, 125);
            this.picKumon.TabIndex = 0;
            this.picKumon.TabStop = false;
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
            // txtSignIn
            // 
            this.txtSignIn.Location = new System.Drawing.Point(614, 29);
            this.txtSignIn.Name = "txtSignIn";
            this.txtSignIn.Size = new System.Drawing.Size(198, 20);
            this.txtSignIn.TabIndex = 3;
            this.txtSignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtSignOut
            // 
            this.txtSignOut.Location = new System.Drawing.Point(614, 87);
            this.txtSignOut.Name = "txtSignOut";
            this.txtSignOut.Size = new System.Drawing.Size(198, 20);
            this.txtSignOut.TabIndex = 4;
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
            this.btnGoIn.Click += new System.EventHandler(this.btnGoIn_Click);
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
            // btnNewStudent
            // 
            this.btnNewStudent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.Location = new System.Drawing.Point(593, 124);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(99, 52);
            this.btnNewStudent.TabIndex = 14;
            this.btnNewStudent.Text = "Add new student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(994, 457);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.lsvTable);
            this.Controls.Add(this.lblSignOut);
            this.Controls.Add(this.btnGoOut);
            this.Controls.Add(this.btnGoIn);
            this.Controls.Add(this.txtSignOut);
            this.Controls.Add(this.txtSignIn);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.picKumon);
            this.Name = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picKumon)).EndInit();
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

    private void displayTableData()
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

        txtSignIn.Clear();
        txtSignIn.Focus();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        frmAdd add = new frmAdd();
        add.Show();
    }


    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Return)
        {
            displayTableData();
        }
    }

    private void btnGoIn_Click(object sender, EventArgs e)
    {
        displayTableData();
    }
}