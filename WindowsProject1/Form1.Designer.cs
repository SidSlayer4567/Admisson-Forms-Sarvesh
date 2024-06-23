namespace WindowsProject1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            BirthDate = new DateTimePicker();
            label10 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label11 = new Label();
            PhoneNum = new TextBox();
            label6 = new Label();
            Reset = new Button();
            Close = new Button();
            eMail = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            ListOption1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 43);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(149, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(632, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(297, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 23);
            textBox3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 67);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 11;
            label7.Text = "Birth Date";
            // 
            // BirthDate
            // 
            BirthDate.Location = new Point(5, 85);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new Size(200, 23);
            BirthDate.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 122);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 15;
            label10.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(5, 140);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(59, 140);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 173);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 18;
            label11.Text = "Phone Number";
            // 
            // PhoneNum
            // 
            PhoneNum.BorderStyle = BorderStyle.FixedSingle;
            PhoneNum.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PhoneNum.Location = new Point(6, 191);
            PhoneNum.Name = "PhoneNum";
            PhoneNum.Size = new Size(96, 23);
            PhoneNum.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 239);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 20;
            label6.Text = "E-Mail Address";
            // 
            // Reset
            // 
            Reset.FlatStyle = FlatStyle.Popup;
            Reset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reset.ForeColor = SystemColors.ActiveCaptionText;
            Reset.Location = new Point(713, 415);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 22;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += ClearInputFields;
            // 
            // Close
            // 
            Close.FlatStyle = FlatStyle.Popup;
            Close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.ForeColor = SystemColors.ActiveCaptionText;
            Close.Location = new Point(551, 415);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 23;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += closeForm;
            // 
            // eMail
            // 
            eMail.BorderStyle = BorderStyle.FixedSingle;
            eMail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            eMail.Location = new Point(6, 257);
            eMail.Name = "eMail";
            eMail.Size = new Size(96, 23);
            eMail.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(149, 32);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 25;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(297, 32);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 26;
            label5.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 305);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 27;
            label8.Text = "Majors";
            // 
            // ListOption1
            // 
            ListOption1.AutoCompleteCustomSource.AddRange(new string[] { "Accounting", "Actuarial Science", "Advertising Major", "Aerospace Engineering", "African Languages, Literatures, and Linguistics", "African Studies", "African-American Studies", "Agricultural Business and Management", "Agricultural Economics", "Agricultural Education", "Agricultural Journalism", "Agricultural Mechanization Major", "Agricultural Technology Management", "Agricultural/Biological Engineering and Bioengineering", "Agriculture", "Agronomy and Crop Science", "Air Traffic Control", "American History", "American Literature", "American Sign Language", "American Studies", "Anatomy", "Ancient Studies", "Animal Behavior and Ethology", "Animal Science", "Animation and Special Effects", "Anthropology", "Applied Mathematics", "Aquaculture", "Aquatic Biology", "Arabic", "Archeology", "Architectural Engineering", "Architectural History", "Architecture", "Art", "Art Education", "Art History", "Art Therapy", "Artificial Intelligence and Robotics", "Asian-American Studies", "Astronomy", "Astrophysics", "Athletic Training", "Atmospheric Science", "Automotive Engineering", "Aviation", "Bakery Science", "Biblical Studies", "Biochemistry", "Bioethics", "Biology", "Biomedical Engineering", "Biomedical Science", "Biopsychology", "Biotechnology", "Botany/Plant Biology", "Business Administration/Management", "Business Communications", "Business Education", "Canadian Studies", "Caribbean Studies", "Cell Biology Major", "Ceramic Engineering", "Ceramics", "Chemical Engineering Major", "Chemical Physics", "Chemistry Major", "Child Care", "Child Development", "Chinese", "Chiropractic", "Church Music", "Cinematography and Film/Video Production", "Circulation Technology", "Civil Engineering", "Classics", "Clinical Psychology", "Cognitive Psychology", "Communication Disorders", "Communications Studies/Speech Communication and Rhetoric", "Comparative Literature", "Computer and Information Science", "Computer Engineering", "Computer Graphics", "Computer Systems Analysis Major", "Construction Management", "Counseling", "Crafts", "Creative Writing", "Criminal Science", "Criminology", "Culinary Arts", "Dance", "Data Processing", "Dental Hygiene", "Developmental Psychology", "Diagnostic Medical Sonography", "Dietetics", "Digital Communications and Media/Multimedia", "Drawing", "Early Childhood Education", "East Asian Studies", "East European Studies", "Ecology", "Economics Major", "Education", "Education Administration", "Education of the Deaf", "Educational Psychology", "Electrical Engineering", "Elementary Education", "Engineering Mechanics", "Engineering Physics", "English", "English Composition", "English Literature Major", "Entomology", "Entrepreneurship Major", "Environmental Design/Architecture", "Environmental Science", "Environmental/Environmental Health Engineering", "Epidemiology", "Equine Studies", "Ethnic Studies", "European History", "Experimental Pathology", "Experimental Psychology", "Fashion Design", "Fashion Merchandising", "Feed Science", "Fiber, Textiles, and Weaving Arts", "Film", "Finance", "Floriculture", "Food Science", "Forensic Science", "Forestry", "French", "Furniture Design", "Game Design", "Gay and Lesbian Studies", "Genetics", "Geography", "Geological Engineering", "Geology", "Geophysics", "German", "Gerontology", "Government Major", "Graphic Design", "Health Administration", "Hebrew", "Hispanic-American, Puerto Rican, and Chicano Studies", "Historic Preservation", "History", "Home Economics", "Horticulture", "Hospitality", "Human Development", "Human Resources Management Major", "Illustration", "Industrial Design", "Industrial Engineering", "Industrial Management", "Industrial Psychology", "Information Technology", "Interior Architecture", "Interior Design", "International Agriculture", "International Business", "International Relations", "International Studies", "Islamic Studies", "Italian", "Japanese", "Jazz Studies", "Jewelry and Metalsmithing", "Jewish Studies", "Journalism", "Kinesiology", "Korean", "Land Use Planning and Management", "Landscape Architecture", "Landscape Horticulture", "Latin American Studies", "Library Science", "Linguistics", "Logistics Management", "Management Information Systems", "Managerial Economics", "Marine Biology Major", "Marine Science", "Marketing Major", "Mass Communication", "Massage Therapy", "Materials Science", "Mathematics", "Mechanical Engineering", "Medical Technology", "Medieval and Renaissance Studies", "Mental Health Services", "Merchandising and Buying Operations", "Metallurgical Engineering", "Microbiology", "Middle Eastern Studies", "Military Science", "Mineral Engineering", "Missions", "Modern Greek", "Molecular Biology", "Molecular Genetics", "Mortuary Science", "Museum Studies", "Music", "Music Education", "Music History Major", "Music Management", "Music Therapy", "Musical Theater", "Native American Studies", "Natural Resources Conservation", "Naval Architecture", "Neurobiology", "Neuroscience", "Nuclear Engineering", "Nursing Major", "Nutrition", "Occupational Therapy", "Ocean Engineering", "Oceanography", "Operations Management", "Organizational Behavior Studies", "Painting", "Paleontology", "Pastoral Studies", "Peace Studies", "Petroleum Engineering", "Pharmacology", "Pharmacy", "Philosophy", "Photography", "Photojournalism Major", "Physical Education", "Physical Therapy", "Physician Assistant", "Physics", "Physiological Psychology", "Piano", "Planetary Science", "Plant Pathology", "Playwriting and Screenwriting", "Political Communication", "Political Science Major", "Portuguese", "Pre-Dentistry", "Pre-Law", "Pre-Medicine", "Pre-Optometry", "Pre-Seminary", "Pre-Veterinary Medicine", "Printmaking", "Psychology", "Public Administration", "Public Health", "Public Policy Analysis", "Public Relations Major", "Radio and Television", "Radiologic Technology", "Range Science and Management", "Real Estate", "Recording Arts Technology", "Recreation Management", "Rehabilitation Services", "Religious Studies", "Respiratory Therapy", "Risk Management", "Rural Sociology", "Russian", "Scandinavian Studies", "Sculpture", "Slavic Languages and Literatures", "Social Psychology", "Social Work", "Sociology", "Soil Science", "Sound Engineering", "South Asian Studies", "Southeast Asia Studies", "Spanish Major", "Special Education", "Speech Pathology", "Sport and Leisure Studies", "Sports Management", "Statistics Major", "Surveying", "Sustainable Resource Management", "Teacher Education", "Teaching English as a Second Language", "Technical Writing", "Technology Education", "Textile Engineering", "Theatre", "Theology", "Tourism", "Toxicology", "Turfgrass Science", "Urban Planning", "Urban Studies", "Visual Communication", "Voice", "Web Design", "Webmaster and Web Management", "Welding Engineering", "Wildlife Management", "Women's Studies", "Youth Ministries", "Zoology" });
            ListOption1.FormattingEnabled = true;
            ListOption1.Items.AddRange(new object[] { "Accounting", "Actuarial Science", "Advertising Major", "Aerospace Engineering", "African Languages, Literatures, and Linguistics", "African Studies", "African-American Studies", "Agricultural Business and Management", "Agricultural Economics", "Agricultural Education", "Agricultural Journalism", "Agricultural Mechanization Major", "Agricultural Technology Management", "Agricultural/Biological Engineering and Bioengineering", "Agriculture", "Agronomy and Crop Science", "Air Traffic Control", "American History", "American Literature", "American Sign Language", "American Studies", "Anatomy", "Ancient Studies", "Animal Behavior and Ethology", "Animal Science", "Animation and Special Effects", "Anthropology", "Applied Mathematics", "Aquaculture", "Aquatic Biology", "Arabic", "Archeology", "Architectural Engineering", "Architectural History", "Architecture", "Art", "Art Education", "Art History", "Art Therapy", "Artificial Intelligence and Robotics", "Asian-American Studies", "Astronomy", "Astrophysics", "Athletic Training", "Atmospheric Science", "Automotive Engineering", "Aviation", "Bakery Science", "Biblical Studies", "Biochemistry", "Bioethics", "Biology", "Biomedical Engineering", "Biomedical Science", "Biopsychology", "Biotechnology", "Botany/Plant Biology", "Business Administration/Management", "Business Communications", "Business Education", "Canadian Studies", "Caribbean Studies", "Cell Biology Major", "Ceramic Engineering", "Ceramics", "Chemical Engineering Major", "Chemical Physics", "Chemistry Major", "Child Care", "Child Development", "Chinese", "Chiropractic", "Church Music", "Cinematography and Film/Video Production", "Circulation Technology", "Civil Engineering", "Classics", "Clinical Psychology", "Cognitive Psychology", "Communication Disorders", "Communications Studies/Speech Communication and Rhetoric", "Comparative Literature", "Computer and Information Science", "Computer Engineering", "Computer Graphics", "Computer Systems Analysis Major", "Construction Management", "Counseling", "Crafts", "Creative Writing", "Criminal Science", "Criminology", "Culinary Arts", "Dance", "Data Processing", "Dental Hygiene", "Developmental Psychology", "Diagnostic Medical Sonography", "Dietetics", "Digital Communications and Media/Multimedia", "Drawing", "Early Childhood Education", "East Asian Studies", "East European Studies", "Ecology", "Economics Major", "Education", "Education Administration", "Education of the Deaf", "Educational Psychology", "Electrical Engineering", "Elementary Education", "Engineering Mechanics", "Engineering Physics", "English", "English Composition", "English Literature Major", "Entomology", "Entrepreneurship Major", "Environmental Design/Architecture", "Environmental Science", "Environmental/Environmental Health Engineering", "Epidemiology", "Equine Studies", "Ethnic Studies", "European History", "Experimental Pathology", "Experimental Psychology", "Fashion Design", "Fashion Merchandising", "Feed Science", "Fiber, Textiles, and Weaving Arts", "Film", "Finance", "Floriculture", "Food Science", "Forensic Science", "Forestry", "French", "Furniture Design", "Game Design", "Gay and Lesbian Studies", "Genetics", "Geography", "Geological Engineering", "Geology", "Geophysics", "German", "Gerontology", "Government Major", "Graphic Design", "Health Administration", "Hebrew", "Hispanic-American, Puerto Rican, and Chicano Studies", "Historic Preservation", "History", "Home Economics", "Horticulture", "Hospitality", "Human Development", "Human Resources Management Major", "Illustration", "Industrial Design", "Industrial Engineering", "Industrial Management", "Industrial Psychology", "Information Technology", "Interior Architecture", "Interior Design", "International Agriculture", "International Business", "International Relations", "International Studies", "Islamic Studies", "Italian", "Japanese", "Jazz Studies", "Jewelry and Metalsmithing", "Jewish Studies", "Journalism", "Kinesiology", "Korean", "Land Use Planning and Management", "Landscape Architecture", "Landscape Horticulture", "Latin American Studies", "Library Science", "Linguistics", "Logistics Management", "Management Information Systems", "Managerial Economics", "Marine Biology Major", "Marine Science", "Marketing Major", "Mass Communication", "Massage Therapy", "Materials Science", "Mathematics", "Mechanical Engineering", "Medical Technology", "Medieval and Renaissance Studies", "Mental Health Services", "Merchandising and Buying Operations", "Metallurgical Engineering", "Microbiology", "Middle Eastern Studies", "Military Science", "Mineral Engineering", "Missions", "Modern Greek", "Molecular Biology", "Molecular Genetics", "Mortuary Science", "Museum Studies", "Music", "Music Education", "Music History Major", "Music Management", "Music Therapy", "Musical Theater", "Native American Studies", "Natural Resources Conservation", "Naval Architecture", "Neurobiology", "Neuroscience", "Nuclear Engineering", "Nursing Major", "Nutrition", "Occupational Therapy", "Ocean Engineering", "Oceanography", "Operations Management", "Organizational Behavior Studies", "Painting", "Paleontology", "Pastoral Studies", "Peace Studies", "Petroleum Engineering", "Pharmacology", "Pharmacy", "Philosophy", "Photography", "Photojournalism Major", "Physical Education", "Physical Therapy", "Physician Assistant", "Physics", "Physiological Psychology", "Piano", "Planetary Science", "Plant Pathology", "Playwriting and Screenwriting", "Political Communication", "Political Science Major", "Portuguese", "Pre-Dentistry", "Pre-Law", "Pre-Medicine", "Pre-Optometry", "Pre-Seminary", "Pre-Veterinary Medicine", "Printmaking", "Psychology", "Public Administration", "Public Health", "Public Policy Analysis", "Public Relations Major", "Radio and Television", "Radiologic Technology", "Range Science and Management", "Real Estate", "Recording Arts Technology", "Recreation Management", "Rehabilitation Services", "Religious Studies", "Respiratory Therapy", "Risk Management", "Rural Sociology", "Russian", "Scandinavian Studies", "Sculpture", "Slavic Languages and Literatures", "Social Psychology", "Social Work", "Sociology", "Soil Science", "Sound Engineering", "South Asian Studies", "Southeast Asia Studies", "Spanish Major", "Special Education", "Speech Pathology", "Sport and Leisure Studies", "Sports Management", "Statistics Major", "Surveying", "Sustainable Resource Management", "Teacher Education", "Teaching English as a Second Language", "Technical Writing", "Technology Education", "Textile Engineering", "Theatre", "Theology", "Tourism", "Toxicology", "Turfgrass Science", "Urban Planning", "Urban Studies", "Visual Communication", "Voice", "Web Design", "Webmaster and Web Management", "Welding Engineering", "Wildlife Management", "Women's Studies", "Youth Ministries", "Zoology" });
            ListOption1.Location = new Point(7, 323);
            ListOption1.Name = "ListOption1";
            ListOption1.Size = new Size(121, 23);
            ListOption1.TabIndex = 28;
            ListOption1.SelectedIndexChanged += majorList1_indexSelected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(ListOption1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Close);
            Controls.Add(Reset);
            Controls.Add(eMail);
            Controls.Add(label6);
            Controls.Add(PhoneNum);
            Controls.Add(label11);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label10);
            Controls.Add(BirthDate);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Admisson Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label7;
        private DateTimePicker BirthDate;
        private Label label10;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label11;
        private TextBox PhoneNum;
        private Label label6;
        private Button Reset;
        private Button Close;
        private TextBox eMail;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label8;
        private ComboBox ListOption1;
    }
}
