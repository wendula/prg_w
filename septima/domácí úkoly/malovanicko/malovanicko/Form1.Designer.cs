namespace malovanicko
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPaint = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_save = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_triangle = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_erase = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_currcolor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_colors = new System.Windows.Forms.Button();
            this.button_color4 = new System.Windows.Forms.Button();
            this.button_color3 = new System.Windows.Forms.Button();
            this.button_color2 = new System.Windows.Forms.Button();
            this.button_color1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPaint
            // 
            this.panelPaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaint.Controls.Add(this.picture);
            this.panelPaint.Location = new System.Drawing.Point(15, 168);
            this.panelPaint.Margin = new System.Windows.Forms.Padding(6);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(1215, 520);
            this.panelPaint.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(-4, -4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1221, 533);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseClick);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_line);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_triangle);
            this.panel1.Controls.Add(this.button_rectangle);
            this.panel1.Controls.Add(this.button_ellipse);
            this.panel1.Controls.Add(this.button_erase);
            this.panel1.Controls.Add(this.button_pencil);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 147);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(608, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "size";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(524, 36);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 69);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button_save
            // 
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save.Location = new System.Drawing.Point(350, 16);
            this.button_save.Margin = new System.Windows.Forms.Padding(0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(88, 88);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_line
            // 
            this.button_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_line.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_line.ForeColor = System.Drawing.Color.White;
            this.button_line.Image = ((System.Drawing.Image)(resources.GetObject("button_line.Image")));
            this.button_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_line.Location = new System.Drawing.Point(1116, 16);
            this.button_line.Margin = new System.Windows.Forms.Padding(0);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(88, 88);
            this.button_line.TabIndex = 9;
            this.button_line.Text = "line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(976, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "shapes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(213, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "basics";
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_clear.Location = new System.Drawing.Point(247, 16);
            this.button_clear.Margin = new System.Windows.Forms.Padding(0);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(88, 88);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_triangle
            // 
            this.button_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_triangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_triangle.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_triangle.ForeColor = System.Drawing.Color.White;
            this.button_triangle.Image = ((System.Drawing.Image)(resources.GetObject("button_triangle.Image")));
            this.button_triangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_triangle.Location = new System.Drawing.Point(1012, 16);
            this.button_triangle.Margin = new System.Windows.Forms.Padding(0);
            this.button_triangle.Name = "button_triangle";
            this.button_triangle.Size = new System.Drawing.Size(88, 88);
            this.button_triangle.TabIndex = 5;
            this.button_triangle.Text = "triangle";
            this.button_triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_triangle.UseVisualStyleBackColor = true;
            this.button_triangle.Click += new System.EventHandler(this.button_triangle_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rectangle.Font = new System.Drawing.Font("Trebuchet MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rectangle.ForeColor = System.Drawing.Color.White;
            this.button_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("button_rectangle.Image")));
            this.button_rectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_rectangle.Location = new System.Drawing.Point(907, 16);
            this.button_rectangle.Margin = new System.Windows.Forms.Padding(0);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(88, 88);
            this.button_rectangle.TabIndex = 4;
            this.button_rectangle.Text = "rectangle";
            this.button_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_ellipse
            // 
            this.button_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ellipse.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ellipse.ForeColor = System.Drawing.Color.White;
            this.button_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("button_ellipse.Image")));
            this.button_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ellipse.Location = new System.Drawing.Point(804, 16);
            this.button_ellipse.Margin = new System.Windows.Forms.Padding(0);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(88, 88);
            this.button_ellipse.TabIndex = 3;
            this.button_ellipse.Text = "elipse";
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ellipse.UseVisualStyleBackColor = true;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
            // 
            // button_erase
            // 
            this.button_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_erase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_erase.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_erase.ForeColor = System.Drawing.Color.White;
            this.button_erase.Image = ((System.Drawing.Image)(resources.GetObject("button_erase.Image")));
            this.button_erase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_erase.Location = new System.Drawing.Point(145, 16);
            this.button_erase.Margin = new System.Windows.Forms.Padding(0);
            this.button_erase.Name = "button_erase";
            this.button_erase.Size = new System.Drawing.Size(88, 88);
            this.button_erase.TabIndex = 2;
            this.button_erase.Text = "erase";
            this.button_erase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_erase.UseVisualStyleBackColor = true;
            this.button_erase.Click += new System.EventHandler(this.button_erase_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pencil.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pencil.ForeColor = System.Drawing.Color.White;
            this.button_pencil.Image = ((System.Drawing.Image)(resources.GetObject("button_pencil.Image")));
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_pencil.Location = new System.Drawing.Point(41, 16);
            this.button_pencil.Margin = new System.Windows.Forms.Padding(0);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(88, 88);
            this.button_pencil.TabIndex = 0;
            this.button_pencil.Text = "pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_pencil.UseVisualStyleBackColor = true;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button_currcolor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_colors);
            this.panel2.Controls.Add(this.button_color4);
            this.panel2.Controls.Add(this.button_color3);
            this.panel2.Controls.Add(this.button_color2);
            this.panel2.Controls.Add(this.button_color1);
            this.panel2.Location = new System.Drawing.Point(1239, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 519);
            this.panel2.TabIndex = 2;
            // 
            // button_currcolor
            // 
            this.button_currcolor.BackColor = System.Drawing.Color.Transparent;
            this.button_currcolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_currcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_currcolor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_currcolor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_currcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_currcolor.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_currcolor.ForeColor = System.Drawing.Color.White;
            this.button_currcolor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_currcolor.Location = new System.Drawing.Point(17, 289);
            this.button_currcolor.Margin = new System.Windows.Forms.Padding(0);
            this.button_currcolor.Name = "button_currcolor";
            this.button_currcolor.Size = new System.Drawing.Size(93, 40);
            this.button_currcolor.TabIndex = 12;
            this.button_currcolor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_currcolor.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(37, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "colors";
            // 
            // button_colors
            // 
            this.button_colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_colors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_colors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_colors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_colors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_colors.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_colors.ForeColor = System.Drawing.Color.White;
            this.button_colors.Image = ((System.Drawing.Image)(resources.GetObject("button_colors.Image")));
            this.button_colors.Location = new System.Drawing.Point(17, 159);
            this.button_colors.Margin = new System.Windows.Forms.Padding(0);
            this.button_colors.Name = "button_colors";
            this.button_colors.Size = new System.Drawing.Size(93, 115);
            this.button_colors.TabIndex = 10;
            this.button_colors.Text = "▼";
            this.button_colors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_colors.UseVisualStyleBackColor = true;
            this.button_colors.Click += new System.EventHandler(this.button_colors_Click);
            // 
            // button_color4
            // 
            this.button_color4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_color4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_color4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_color4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color4.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_color4.ForeColor = System.Drawing.Color.White;
            this.button_color4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_color4.Location = new System.Drawing.Point(70, 102);
            this.button_color4.Margin = new System.Windows.Forms.Padding(0);
            this.button_color4.Name = "button_color4";
            this.button_color4.Size = new System.Drawing.Size(40, 40);
            this.button_color4.TabIndex = 7;
            this.button_color4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_color4.UseVisualStyleBackColor = false;
            this.button_color4.Click += new System.EventHandler(this.button_color4_Click);
            // 
            // button_color3
            // 
            this.button_color3.BackColor = System.Drawing.Color.Blue;
            this.button_color3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_color3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_color3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color3.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_color3.ForeColor = System.Drawing.Color.White;
            this.button_color3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_color3.Location = new System.Drawing.Point(17, 102);
            this.button_color3.Margin = new System.Windows.Forms.Padding(0);
            this.button_color3.Name = "button_color3";
            this.button_color3.Size = new System.Drawing.Size(40, 40);
            this.button_color3.TabIndex = 6;
            this.button_color3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_color3.UseVisualStyleBackColor = false;
            this.button_color3.Click += new System.EventHandler(this.button_color3_Click);
            // 
            // button_color2
            // 
            this.button_color2.BackColor = System.Drawing.Color.Yellow;
            this.button_color2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_color2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_color2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color2.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_color2.ForeColor = System.Drawing.Color.White;
            this.button_color2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_color2.Location = new System.Drawing.Point(70, 46);
            this.button_color2.Margin = new System.Windows.Forms.Padding(0);
            this.button_color2.Name = "button_color2";
            this.button_color2.Size = new System.Drawing.Size(40, 40);
            this.button_color2.TabIndex = 5;
            this.button_color2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_color2.UseVisualStyleBackColor = false;
            this.button_color2.Click += new System.EventHandler(this.button_color2_Click);
            // 
            // button_color1
            // 
            this.button_color1.BackColor = System.Drawing.Color.Red;
            this.button_color1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_color1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button_color1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button_color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_color1.ForeColor = System.Drawing.Color.White;
            this.button_color1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_color1.Location = new System.Drawing.Point(17, 46);
            this.button_color1.Margin = new System.Windows.Forms.Padding(0);
            this.button_color1.Name = "button_color1";
            this.button_color1.Size = new System.Drawing.Size(40, 40);
            this.button_color1.TabIndex = 4;
            this.button_color1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_color1.UseVisualStyleBackColor = false;
            this.button_color1.Click += new System.EventHandler(this.button_color1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1378, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Button button_triangle;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_ellipse;
        private System.Windows.Forms.Button button_erase;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_color4;
        private System.Windows.Forms.Button button_color3;
        private System.Windows.Forms.Button button_color2;
        private System.Windows.Forms.Button button_color1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_colors;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button_currcolor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

