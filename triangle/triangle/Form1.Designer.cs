// Form1.Designer.cs
namespace triangle
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbTriangle;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lbResults;

        private System.Windows.Forms.GroupBox gbVectors;
        private System.Windows.Forms.GroupBox gbA;
        private System.Windows.Forms.Label lblAX;
        private System.Windows.Forms.NumericUpDown nudAx;
        private System.Windows.Forms.Label lblAY;
        private System.Windows.Forms.NumericUpDown nudAy;

        private System.Windows.Forms.GroupBox gbB;
        private System.Windows.Forms.Label lblBX;
        private System.Windows.Forms.NumericUpDown nudBx;
        private System.Windows.Forms.Label lblBY;
        private System.Windows.Forms.NumericUpDown nudBy;

        private System.Windows.Forms.Label lblScalar;
        private System.Windows.Forms.NumericUpDown nudScalar;

        private System.Windows.Forms.TableLayoutPanel tlpOperations;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnLength;

        private System.Windows.Forms.Panel pnlOpResult;
        private System.Windows.Forms.Label lblOpResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // --- Triangle ---
            this.gbTriangle = new System.Windows.Forms.GroupBox();
            this.lblN = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();

            // --- Vectors ---
            this.gbVectors = new System.Windows.Forms.GroupBox();

            // Vector A
            this.gbA = new System.Windows.Forms.GroupBox();
            this.lblAX = new System.Windows.Forms.Label();
            this.nudAx = new System.Windows.Forms.NumericUpDown();
            this.lblAY = new System.Windows.Forms.Label();
            this.nudAy = new System.Windows.Forms.NumericUpDown();

            // Vector B
            this.gbB = new System.Windows.Forms.GroupBox();
            this.lblBX = new System.Windows.Forms.Label();
            this.nudBx = new System.Windows.Forms.NumericUpDown();
            this.lblBY = new System.Windows.Forms.Label();
            this.nudBy = new System.Windows.Forms.NumericUpDown();

            // Scalar
            this.lblScalar = new System.Windows.Forms.Label();
            this.nudScalar = new System.Windows.Forms.NumericUpDown();

            // Operations
            this.tlpOperations = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();

            // Result
            this.pnlOpResult = new System.Windows.Forms.Panel();
            this.lblOpResult = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScalar)).BeginInit();

            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Text = "Пошук та операції з векторами";
            // 
            // gbTriangle
            // 
            this.gbTriangle.Location = new System.Drawing.Point(10, 10);
            this.gbTriangle.Size = new System.Drawing.Size(580, 150);
            this.gbTriangle.Text = "Генерація трикутника";
            // lblN
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(20, 30);
            this.lblN.Text = "Кількість точок N:";
            // nudN
            this.nudN.Location = new System.Drawing.Point(160, 28);
            this.nudN.Size = new System.Drawing.Size(80, 22);
            this.nudN.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.nudN.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudN.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // btnGenerate
            this.btnGenerate.Location = new System.Drawing.Point(260, 25);
            this.btnGenerate.Size = new System.Drawing.Size(100, 28);
            this.btnGenerate.Text = "Генерувати";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // lbResults
            this.lbResults.Location = new System.Drawing.Point(20, 60);
            this.lbResults.Size = new System.Drawing.Size(540, 75);

            this.gbTriangle.Controls.Add(this.lblN);
            this.gbTriangle.Controls.Add(this.nudN);
            this.gbTriangle.Controls.Add(this.btnGenerate);
            this.gbTriangle.Controls.Add(this.lbResults);
            this.Controls.Add(this.gbTriangle);

            // 
            // gbVectors
            // 
            this.gbVectors.Location = new System.Drawing.Point(10, 170);
            this.gbVectors.Size = new System.Drawing.Size(580, 330);
            this.gbVectors.Text = "Операції над векторами";

            // 
            // gbA
            // 
            this.gbA.Location = new System.Drawing.Point(15, 20);
            this.gbA.Size = new System.Drawing.Size(180, 100);
            this.gbA.Text = "Вектор A";
            // lblAX
            this.lblAX.AutoSize = true;
            this.lblAX.Location = new System.Drawing.Point(10, 30);
            this.lblAX.Text = "X:";
            // nudAx
            this.nudAx.Location = new System.Drawing.Point(40, 28);
            this.nudAx.Size = new System.Drawing.Size(80, 22);
            // lblAY
            this.lblAY.AutoSize = true;
            this.lblAY.Location = new System.Drawing.Point(10, 65);
            this.lblAY.Text = "Y:";
            // nudAy
            this.nudAy.Location = new System.Drawing.Point(40, 63);
            this.nudAy.Size = new System.Drawing.Size(80, 22);

            this.gbA.Controls.Add(this.lblAX);
            this.gbA.Controls.Add(this.nudAx);
            this.gbA.Controls.Add(this.lblAY);
            this.gbA.Controls.Add(this.nudAy);
            this.gbVectors.Controls.Add(this.gbA);

            // 
            // gbB
            // 
            this.gbB.Location = new System.Drawing.Point(210, 20);
            this.gbB.Size = new System.Drawing.Size(180, 100);
            this.gbB.Text = "Вектор B";
            // lblBX
            this.lblBX.AutoSize = true;
            this.lblBX.Location = new System.Drawing.Point(10, 30);
            this.lblBX.Text = "X:";
            // nudBx
            this.nudBx.Location = new System.Drawing.Point(40, 28);
            this.nudBx.Size = new System.Drawing.Size(80, 22);
            // lblBY
            this.lblBY.AutoSize = true;
            this.lblBY.Location = new System.Drawing.Point(10, 65);
            this.lblBY.Text = "Y:";
            // nudBy
            this.nudBy.Location = new System.Drawing.Point(40, 63);
            this.nudBy.Size = new System.Drawing.Size(80, 22);

            this.gbB.Controls.Add(this.lblBX);
            this.gbB.Controls.Add(this.nudBx);
            this.gbB.Controls.Add(this.lblBY);
            this.gbB.Controls.Add(this.nudBy);
            this.gbVectors.Controls.Add(this.gbB);

            // 
            // lblScalar
            // 
            this.lblScalar.AutoSize = true;
            this.lblScalar.Location = new System.Drawing.Point(405, 30);
            this.lblScalar.Text = "Скаляр:";
            // nudScalar
            this.nudScalar.Location = new System.Drawing.Point(460, 28);
            this.nudScalar.Size = new System.Drawing.Size(80, 22);

            this.gbVectors.Controls.Add(this.lblScalar);
            this.gbVectors.Controls.Add(this.nudScalar);

            // 
            // tlpOperations
            // 
            this.tlpOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpOperations.AutoSize = true;
            this.tlpOperations.Padding = new System.Windows.Forms.Padding(15, 130, 15, 0);
            this.tlpOperations.ColumnCount = 5;
            this.tlpOperations.RowCount = 1;
            for (int i = 0; i < 5; i++)
                this.tlpOperations.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F)
                );

            this.btnAdd.Text = "Додати"; this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnSubtract.Text = "Відняти"; this.btnSubtract.Size = new System.Drawing.Size(100, 28);
            this.btnDot.Text = "Скалярне"; this.btnDot.Size = new System.Drawing.Size(100, 28);
            this.btnScale.Text = "Множення"; this.btnScale.Size = new System.Drawing.Size(100, 28);
            this.btnLength.Text = "Довжина"; this.btnLength.Size = new System.Drawing.Size(100, 28);

            this.tlpOperations.Controls.Add(this.btnAdd, 0, 0);
            this.tlpOperations.Controls.Add(this.btnSubtract, 1, 0);
            this.tlpOperations.Controls.Add(this.btnDot, 2, 0);
            this.tlpOperations.Controls.Add(this.btnScale, 3, 0);
            this.tlpOperations.Controls.Add(this.btnLength, 4, 0);

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);

            this.gbVectors.Controls.Add(this.tlpOperations);

            // 
            // pnlOpResult
            // 
            this.pnlOpResult.Location = new System.Drawing.Point(15, 220);
            this.pnlOpResult.Size = new System.Drawing.Size(550, 80);
            this.pnlOpResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpResult.Controls.Add(this.lblOpResult);

            this.lblOpResult.AutoSize = true;
            this.lblOpResult.Location = new System.Drawing.Point(10, 25);
            this.lblOpResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.gbVectors.Controls.Add(this.pnlOpResult);
            this.Controls.Add(this.gbVectors);

            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
