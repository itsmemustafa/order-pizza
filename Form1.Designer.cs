namespace Pizaa_APP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbsize = new System.Windows.Forms.GroupBox();
            this.rdmediam = new System.Windows.Forms.RadioButton();
            this.rdlarg = new System.Windows.Forms.RadioButton();
            this.rdsmall = new System.Windows.Forms.RadioButton();
            this.gbcrust = new System.Windows.Forms.GroupBox();
            this.rdthink = new System.Windows.Forms.RadioButton();
            this.rdthin = new System.Windows.Forms.RadioButton();
            this.gbtopping = new System.Windows.Forms.GroupBox();
            this.chbGreenpapper = new System.Windows.Forms.CheckBox();
            this.chbolives = new System.Windows.Forms.CheckBox();
            this.chbonion = new System.Windows.Forms.CheckBox();
            this.chbtomatoes = new System.Windows.Forms.CheckBox();
            this.chbmushrooms = new System.Windows.Forms.CheckBox();
            this.chbexratchees = new System.Windows.Forms.CheckBox();
            this.gbwheretoeat = new System.Windows.Forms.GroupBox();
            this.rdTakeaway = new System.Windows.Forms.RadioButton();
            this.rdeatin = new System.Windows.Forms.RadioButton();
            this.gpsummary = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblwheretoeat = new System.Windows.Forms.Label();
            this.lblcrusttype = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.wheretoeatll = new System.Windows.Forms.Label();
            this.Crusttypelbl = new System.Windows.Forms.Label();
            this.toppoinglbl = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.sizelb = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bconfirm = new System.Windows.Forms.Button();
            this.gbsize.SuspendLayout();
            this.gbcrust.SuspendLayout();
            this.gbtopping.SuspendLayout();
            this.gbwheretoeat.SuspendLayout();
            this.gpsummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsize
            // 
            this.gbsize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbsize.Controls.Add(this.rdmediam);
            this.gbsize.Controls.Add(this.rdlarg);
            this.gbsize.Controls.Add(this.rdsmall);
            this.gbsize.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsize.ForeColor = System.Drawing.Color.SkyBlue;
            this.gbsize.Location = new System.Drawing.Point(74, 164);
            this.gbsize.Margin = new System.Windows.Forms.Padding(4);
            this.gbsize.Name = "gbsize";
            this.gbsize.Padding = new System.Windows.Forms.Padding(4);
            this.gbsize.Size = new System.Drawing.Size(264, 296);
            this.gbsize.TabIndex = 0;
            this.gbsize.TabStop = false;
            this.gbsize.Text = "Size";
            // 
            // rdmediam
            // 
            this.rdmediam.AutoSize = true;
            this.rdmediam.Checked = true;
            this.rdmediam.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmediam.Location = new System.Drawing.Point(18, 148);
            this.rdmediam.Margin = new System.Windows.Forms.Padding(4);
            this.rdmediam.Name = "rdmediam";
            this.rdmediam.Size = new System.Drawing.Size(147, 42);
            this.rdmediam.TabIndex = 2;
            this.rdmediam.TabStop = true;
            this.rdmediam.Text = "Mediam";
            this.rdmediam.UseVisualStyleBackColor = true;
            this.rdmediam.Click += new System.EventHandler(this.rdmediam_Click);
            // 
            // rdlarg
            // 
            this.rdlarg.AutoSize = true;
            this.rdlarg.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlarg.Location = new System.Drawing.Point(18, 212);
            this.rdlarg.Margin = new System.Windows.Forms.Padding(4);
            this.rdlarg.Name = "rdlarg";
            this.rdlarg.Size = new System.Drawing.Size(105, 42);
            this.rdlarg.TabIndex = 1;
            this.rdlarg.Text = "Larg";
            this.rdlarg.UseVisualStyleBackColor = true;
            this.rdlarg.Click += new System.EventHandler(this.rdlarg_Click);
            // 
            // rdsmall
            // 
            this.rdsmall.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdsmall.AutoSize = true;
            this.rdsmall.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsmall.Location = new System.Drawing.Point(18, 90);
            this.rdsmall.Margin = new System.Windows.Forms.Padding(4);
            this.rdsmall.Name = "rdsmall";
            this.rdsmall.Size = new System.Drawing.Size(117, 42);
            this.rdsmall.TabIndex = 0;
            this.rdsmall.Tag = "20";
            this.rdsmall.Text = "Small";
            this.rdsmall.UseVisualStyleBackColor = true;
            this.rdsmall.Click += new System.EventHandler(this.rdsmall_Click);
            // 
            // gbcrust
            // 
            this.gbcrust.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbcrust.Controls.Add(this.rdthink);
            this.gbcrust.Controls.Add(this.rdthin);
            this.gbcrust.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrust.ForeColor = System.Drawing.Color.SkyBlue;
            this.gbcrust.Location = new System.Drawing.Point(74, 560);
            this.gbcrust.Margin = new System.Windows.Forms.Padding(4);
            this.gbcrust.Name = "gbcrust";
            this.gbcrust.Padding = new System.Windows.Forms.Padding(4);
            this.gbcrust.Size = new System.Drawing.Size(264, 222);
            this.gbcrust.TabIndex = 1;
            this.gbcrust.TabStop = false;
            this.gbcrust.Text = "Crust type ";
            // 
            // rdthink
            // 
            this.rdthink.AutoSize = true;
            this.rdthink.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdthink.Location = new System.Drawing.Point(18, 148);
            this.rdthink.Margin = new System.Windows.Forms.Padding(4);
            this.rdthink.Name = "rdthink";
            this.rdthink.Size = new System.Drawing.Size(211, 42);
            this.rdthink.TabIndex = 2;
            this.rdthink.Text = "Think crust ";
            this.rdthink.UseVisualStyleBackColor = true;
            this.rdthink.Click += new System.EventHandler(this.rdthink_Click);
            // 
            // rdthin
            // 
            this.rdthin.AutoSize = true;
            this.rdthin.Checked = true;
            this.rdthin.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdthin.Location = new System.Drawing.Point(18, 90);
            this.rdthin.Margin = new System.Windows.Forms.Padding(4);
            this.rdthin.Name = "rdthin";
            this.rdthin.Size = new System.Drawing.Size(196, 42);
            this.rdthin.TabIndex = 0;
            this.rdthin.TabStop = true;
            this.rdthin.Text = "Thin crust ";
            this.rdthin.UseVisualStyleBackColor = true;
            this.rdthin.Click += new System.EventHandler(this.rdthin_Click);
            // 
            // gbtopping
            // 
            this.gbtopping.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbtopping.Controls.Add(this.chbGreenpapper);
            this.gbtopping.Controls.Add(this.chbolives);
            this.gbtopping.Controls.Add(this.chbonion);
            this.gbtopping.Controls.Add(this.chbtomatoes);
            this.gbtopping.Controls.Add(this.chbmushrooms);
            this.gbtopping.Controls.Add(this.chbexratchees);
            this.gbtopping.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbtopping.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtopping.ForeColor = System.Drawing.Color.SkyBlue;
            this.gbtopping.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gbtopping.Location = new System.Drawing.Point(544, 212);
            this.gbtopping.Margin = new System.Windows.Forms.Padding(4);
            this.gbtopping.Name = "gbtopping";
            this.gbtopping.Padding = new System.Windows.Forms.Padding(4);
            this.gbtopping.Size = new System.Drawing.Size(532, 308);
            this.gbtopping.TabIndex = 2;
            this.gbtopping.TabStop = false;
            this.gbtopping.Text = "Topping ";
            // 
            // chbGreenpapper
            // 
            this.chbGreenpapper.AutoSize = true;
            this.chbGreenpapper.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGreenpapper.Location = new System.Drawing.Point(274, 220);
            this.chbGreenpapper.Margin = new System.Windows.Forms.Padding(4);
            this.chbGreenpapper.Name = "chbGreenpapper";
            this.chbGreenpapper.Size = new System.Drawing.Size(233, 42);
            this.chbGreenpapper.TabIndex = 5;
            this.chbGreenpapper.Tag = "5";
            this.chbGreenpapper.Text = "Green papper ";
            this.chbGreenpapper.UseVisualStyleBackColor = true;
            this.chbGreenpapper.Click += new System.EventHandler(this.chbGreenpapper_Click);
            // 
            // chbolives
            // 
            this.chbolives.AutoSize = true;
            this.chbolives.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbolives.Location = new System.Drawing.Point(274, 154);
            this.chbolives.Margin = new System.Windows.Forms.Padding(4);
            this.chbolives.Name = "chbolives";
            this.chbolives.Size = new System.Drawing.Size(147, 42);
            this.chbolives.TabIndex = 4;
            this.chbolives.Tag = "5";
            this.chbolives.Text = "OLives ";
            this.chbolives.UseVisualStyleBackColor = true;
            this.chbolives.Click += new System.EventHandler(this.chbolives_Click);
            // 
            // chbonion
            // 
            this.chbonion.AutoSize = true;
            this.chbonion.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbonion.Location = new System.Drawing.Point(274, 92);
            this.chbonion.Margin = new System.Windows.Forms.Padding(4);
            this.chbonion.Name = "chbonion";
            this.chbonion.Size = new System.Drawing.Size(133, 42);
            this.chbonion.TabIndex = 3;
            this.chbonion.Tag = "5";
            this.chbonion.Text = "Onoin ";
            this.chbonion.UseVisualStyleBackColor = true;
            this.chbonion.Click += new System.EventHandler(this.chbonion_Click);
            // 
            // chbtomatoes
            // 
            this.chbtomatoes.AutoSize = true;
            this.chbtomatoes.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbtomatoes.Location = new System.Drawing.Point(50, 220);
            this.chbtomatoes.Margin = new System.Windows.Forms.Padding(4);
            this.chbtomatoes.Name = "chbtomatoes";
            this.chbtomatoes.Size = new System.Drawing.Size(173, 42);
            this.chbtomatoes.TabIndex = 2;
            this.chbtomatoes.Tag = "5 ";
            this.chbtomatoes.Text = "Tomatoes";
            this.chbtomatoes.UseVisualStyleBackColor = true;
            this.chbtomatoes.Click += new System.EventHandler(this.chbtomatoes_Click);
            // 
            // chbmushrooms
            // 
            this.chbmushrooms.AutoSize = true;
            this.chbmushrooms.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbmushrooms.Location = new System.Drawing.Point(50, 154);
            this.chbmushrooms.Margin = new System.Windows.Forms.Padding(4);
            this.chbmushrooms.Name = "chbmushrooms";
            this.chbmushrooms.Size = new System.Drawing.Size(191, 42);
            this.chbmushrooms.TabIndex = 1;
            this.chbmushrooms.Tag = "5";
            this.chbmushrooms.Text = "Mushrooms";
            this.chbmushrooms.UseVisualStyleBackColor = true;
            this.chbmushrooms.Click += new System.EventHandler(this.chbmushrooms_Click);
            // 
            // chbexratchees
            // 
            this.chbexratchees.AutoSize = true;
            this.chbexratchees.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbexratchees.Location = new System.Drawing.Point(50, 92);
            this.chbexratchees.Margin = new System.Windows.Forms.Padding(4);
            this.chbexratchees.Name = "chbexratchees";
            this.chbexratchees.Size = new System.Drawing.Size(218, 42);
            this.chbexratchees.TabIndex = 0;
            this.chbexratchees.Tag = "5";
            this.chbexratchees.Text = "Extra chess ";
            this.chbexratchees.UseVisualStyleBackColor = true;
            this.chbexratchees.Click += new System.EventHandler(this.chbexratchees_Click);
            // 
            // gbwheretoeat
            // 
            this.gbwheretoeat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbwheretoeat.Controls.Add(this.rdTakeaway);
            this.gbwheretoeat.Controls.Add(this.rdeatin);
            this.gbwheretoeat.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbwheretoeat.ForeColor = System.Drawing.Color.SkyBlue;
            this.gbwheretoeat.Location = new System.Drawing.Point(580, 628);
            this.gbwheretoeat.Margin = new System.Windows.Forms.Padding(4);
            this.gbwheretoeat.Name = "gbwheretoeat";
            this.gbwheretoeat.Padding = new System.Windows.Forms.Padding(4);
            this.gbwheretoeat.Size = new System.Drawing.Size(392, 152);
            this.gbwheretoeat.TabIndex = 3;
            this.gbwheretoeat.TabStop = false;
            this.gbwheretoeat.Text = "Where to Eat ";
            // 
            // rdTakeaway
            // 
            this.rdTakeaway.AutoSize = true;
            this.rdTakeaway.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeaway.Location = new System.Drawing.Point(188, 90);
            this.rdTakeaway.Margin = new System.Windows.Forms.Padding(4);
            this.rdTakeaway.Name = "rdTakeaway";
            this.rdTakeaway.Size = new System.Drawing.Size(173, 42);
            this.rdTakeaway.TabIndex = 2;
            this.rdTakeaway.Text = "Take Out";
            this.rdTakeaway.UseVisualStyleBackColor = true;
            this.rdTakeaway.Click += new System.EventHandler(this.rdTakeaway_Click);
            // 
            // rdeatin
            // 
            this.rdeatin.AutoSize = true;
            this.rdeatin.Checked = true;
            this.rdeatin.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdeatin.Location = new System.Drawing.Point(48, 90);
            this.rdeatin.Margin = new System.Windows.Forms.Padding(4);
            this.rdeatin.Name = "rdeatin";
            this.rdeatin.Size = new System.Drawing.Size(139, 42);
            this.rdeatin.TabIndex = 0;
            this.rdeatin.TabStop = true;
            this.rdeatin.Text = "Eat in ";
            this.rdeatin.UseVisualStyleBackColor = true;
            this.rdeatin.Click += new System.EventHandler(this.rdeatin_Click);
            // 
            // gpsummary
            // 
            this.gpsummary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gpsummary.Controls.Add(this.label1);
            this.gpsummary.Controls.Add(this.lblprice);
            this.gpsummary.Controls.Add(this.lblTopping);
            this.gpsummary.Controls.Add(this.lblwheretoeat);
            this.gpsummary.Controls.Add(this.lblcrusttype);
            this.gpsummary.Controls.Add(this.lbltotalprice);
            this.gpsummary.Controls.Add(this.wheretoeatll);
            this.gpsummary.Controls.Add(this.Crusttypelbl);
            this.gpsummary.Controls.Add(this.toppoinglbl);
            this.gpsummary.Controls.Add(this.lblsize);
            this.gpsummary.Controls.Add(this.sizelb);
            this.gpsummary.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsummary.ForeColor = System.Drawing.Color.SkyBlue;
            this.gpsummary.Location = new System.Drawing.Point(1284, 164);
            this.gpsummary.Margin = new System.Windows.Forms.Padding(4);
            this.gpsummary.Name = "gpsummary";
            this.gpsummary.Padding = new System.Windows.Forms.Padding(4);
            this.gpsummary.Size = new System.Drawing.Size(430, 668);
            this.gpsummary.TabIndex = 4;
            this.gpsummary.TabStop = false;
            this.gpsummary.Text = "Oreder summary ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(209, 548);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 95);
            this.label1.TabIndex = 14;
            this.label1.Text = "$";
            // 
            // lblprice
            // 
            this.lblprice.Font = new System.Drawing.Font("Kristen ITC", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Green;
            this.lblprice.Location = new System.Drawing.Point(71, 548);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(150, 70);
            this.lblprice.TabIndex = 13;
            this.lblprice.Text = "0";
            this.lblprice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTopping
            // 
            this.lblTopping.Font = new System.Drawing.Font("Microsoft JhengHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(32, 218);
            this.lblTopping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(388, 124);
            this.lblTopping.TabIndex = 12;
            this.lblTopping.Text = " ";
            // 
            // lblwheretoeat
            // 
            this.lblwheretoeat.AutoSize = true;
            this.lblwheretoeat.Font = new System.Drawing.Font("Microsoft JhengHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwheretoeat.Location = new System.Drawing.Point(220, 411);
            this.lblwheretoeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwheretoeat.Name = "lblwheretoeat";
            this.lblwheretoeat.Size = new System.Drawing.Size(86, 35);
            this.lblwheretoeat.TabIndex = 11;
            this.lblwheretoeat.Text = "Eat in";
            // 
            // lblcrusttype
            // 
            this.lblcrusttype.AutoSize = true;
            this.lblcrusttype.Font = new System.Drawing.Font("Microsoft JhengHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrusttype.Location = new System.Drawing.Point(206, 342);
            this.lblcrusttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcrusttype.Name = "lblcrusttype";
            this.lblcrusttype.Size = new System.Drawing.Size(144, 35);
            this.lblcrusttype.TabIndex = 10;
            this.lblcrusttype.Text = "Thin crust";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.Location = new System.Drawing.Point(123, 486);
            this.lbltotalprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(173, 38);
            this.lbltotalprice.TabIndex = 8;
            this.lbltotalprice.Text = "Total price ";
            // 
            // wheretoeatll
            // 
            this.wheretoeatll.AutoSize = true;
            this.wheretoeatll.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheretoeatll.Location = new System.Drawing.Point(20, 409);
            this.wheretoeatll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wheretoeatll.Name = "wheretoeatll";
            this.wheretoeatll.Size = new System.Drawing.Size(212, 38);
            this.wheretoeatll.TabIndex = 6;
            this.wheretoeatll.Text = "where to eat :";
            // 
            // Crusttypelbl
            // 
            this.Crusttypelbl.AutoSize = true;
            this.Crusttypelbl.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crusttypelbl.Location = new System.Drawing.Point(20, 340);
            this.Crusttypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Crusttypelbl.Name = "Crusttypelbl";
            this.Crusttypelbl.Size = new System.Drawing.Size(180, 38);
            this.Crusttypelbl.TabIndex = 4;
            this.Crusttypelbl.Text = "Crust type :";
            // 
            // toppoinglbl
            // 
            this.toppoinglbl.AutoSize = true;
            this.toppoinglbl.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppoinglbl.Location = new System.Drawing.Point(20, 160);
            this.toppoinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toppoinglbl.Name = "toppoinglbl";
            this.toppoinglbl.Size = new System.Drawing.Size(138, 38);
            this.toppoinglbl.TabIndex = 3;
            this.toppoinglbl.Text = "Topping :";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.Location = new System.Drawing.Point(124, 88);
            this.lblsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(122, 35);
            this.lblsize.TabIndex = 1;
            this.lblsize.Text = "Mediam";
            // 
            // sizelb
            // 
            this.sizelb.AutoSize = true;
            this.sizelb.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizelb.Location = new System.Drawing.Point(20, 88);
            this.sizelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizelb.Name = "sizelb";
            this.sizelb.Size = new System.Drawing.Size(98, 38);
            this.sizelb.TabIndex = 0;
            this.sizelb.Text = "Size :";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitel.Font = new System.Drawing.Font("Comic Sans MS", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTitel.Location = new System.Drawing.Point(439, 21);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(801, 104);
            this.lblTitel.TabIndex = 5;
            this.lblTitel.Text = "Make your own pizza";
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(1558, 874);
            this.bReset.Margin = new System.Windows.Forms.Padding(4);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(144, 64);
            this.bReset.TabIndex = 6;
            this.bReset.Text = "Reset ";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bconfirm
            // 
            this.bconfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bconfirm.Location = new System.Drawing.Point(1284, 874);
            this.bconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.bconfirm.Name = "bconfirm";
            this.bconfirm.Size = new System.Drawing.Size(144, 64);
            this.bconfirm.TabIndex = 7;
            this.bconfirm.Text = "Order ";
            this.bconfirm.UseVisualStyleBackColor = false;
            this.bconfirm.Click += new System.EventHandler(this.bconfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Pizaa_APP.Properties.Resources.pizza;
            this.ClientSize = new System.Drawing.Size(1770, 956);
            this.Controls.Add(this.bconfirm);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.gpsummary);
            this.Controls.Add(this.gbwheretoeat);
            this.Controls.Add(this.gbtopping);
            this.Controls.Add(this.gbcrust);
            this.Controls.Add(this.gbsize);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Italian Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbsize.ResumeLayout(false);
            this.gbsize.PerformLayout();
            this.gbcrust.ResumeLayout(false);
            this.gbcrust.PerformLayout();
            this.gbtopping.ResumeLayout(false);
            this.gbtopping.PerformLayout();
            this.gbwheretoeat.ResumeLayout(false);
            this.gbwheretoeat.PerformLayout();
            this.gpsummary.ResumeLayout(false);
            this.gpsummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdmediam;
        private System.Windows.Forms.RadioButton rdlarg;
        private System.Windows.Forms.RadioButton rdsmall;
        private System.Windows.Forms.GroupBox gbsize;
        private System.Windows.Forms.GroupBox gbcrust;
        private System.Windows.Forms.RadioButton rdthink;
        private System.Windows.Forms.RadioButton rdthin;
        private System.Windows.Forms.GroupBox gbtopping;
        private System.Windows.Forms.CheckBox chbGreenpapper;
        private System.Windows.Forms.CheckBox chbolives;
        private System.Windows.Forms.CheckBox chbonion;
        private System.Windows.Forms.CheckBox chbtomatoes;
        private System.Windows.Forms.CheckBox chbmushrooms;
        private System.Windows.Forms.CheckBox chbexratchees;
        private System.Windows.Forms.GroupBox gbwheretoeat;
        private System.Windows.Forms.RadioButton rdTakeaway;
        private System.Windows.Forms.RadioButton rdeatin;
        private System.Windows.Forms.GroupBox gpsummary;
        private System.Windows.Forms.Label sizelb;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label toppoinglbl;
        private System.Windows.Forms.Label Crusttypelbl;
        private System.Windows.Forms.Label wheretoeatll;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bconfirm;
        private System.Windows.Forms.Label lblcrusttype;
        private System.Windows.Forms.Label lblwheretoeat;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprice;
    }
}

