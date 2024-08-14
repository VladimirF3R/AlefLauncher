namespace AlefLauncher
{
    partial class formMain
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
            components = new System.ComponentModel.Container();
            groupBoxState = new GroupBox();
            stateTextBox = new RichTextBox();
            groupBoxFooter = new GroupBox();
            saveSettingsButton = new Button();
            loadSettingsButton = new Button();
            groupBoxMain = new GroupBox();
            labelProfileDescription = new Label();
            labelAppDescription = new Label();
            buttonRun = new Button();
            label2 = new Label();
            comboBoxProfile = new ComboBox();
            label1 = new Label();
            comboBoxApp = new ComboBox();
            bindingSourceApp = new BindingSource(components);
            groupBoxState.SuspendLayout();
            groupBoxFooter.SuspendLayout();
            groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceApp).BeginInit();
            SuspendLayout();
            // 
            // groupBoxState
            // 
            groupBoxState.Controls.Add(stateTextBox);
            groupBoxState.Dock = DockStyle.Bottom;
            groupBoxState.Location = new Point(0, 253);
            groupBoxState.Name = "groupBoxState";
            groupBoxState.Size = new Size(1012, 180);
            groupBoxState.TabIndex = 2;
            groupBoxState.TabStop = false;
            groupBoxState.Text = "Состояние";
            // 
            // stateTextBox
            // 
            stateTextBox.BackColor = SystemColors.ButtonFace;
            stateTextBox.Dock = DockStyle.Fill;
            stateTextBox.ForeColor = SystemColors.Desktop;
            stateTextBox.Location = new Point(3, 23);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.ReadOnly = true;
            stateTextBox.Size = new Size(1006, 154);
            stateTextBox.TabIndex = 0;
            stateTextBox.Text = "Готов к работе.\n";
            // 
            // groupBoxFooter
            // 
            groupBoxFooter.Controls.Add(saveSettingsButton);
            groupBoxFooter.Controls.Add(loadSettingsButton);
            groupBoxFooter.Dock = DockStyle.Top;
            groupBoxFooter.Location = new Point(0, 0);
            groupBoxFooter.Name = "groupBoxFooter";
            groupBoxFooter.Size = new Size(1012, 71);
            groupBoxFooter.TabIndex = 3;
            groupBoxFooter.TabStop = false;
            // 
            // saveSettingsButton
            // 
            saveSettingsButton.ImageAlign = ContentAlignment.MiddleRight;
            saveSettingsButton.Location = new Point(817, 26);
            saveSettingsButton.Name = "saveSettingsButton";
            saveSettingsButton.Size = new Size(177, 28);
            saveSettingsButton.TabIndex = 2;
            saveSettingsButton.Text = "Сохранить настройки ...";
            saveSettingsButton.UseVisualStyleBackColor = true;
            saveSettingsButton.Click += saveSettingsButton_Click;
            // 
            // loadSettingsButton
            // 
            loadSettingsButton.ImageAlign = ContentAlignment.MiddleRight;
            loadSettingsButton.Location = new Point(632, 26);
            loadSettingsButton.Name = "loadSettingsButton";
            loadSettingsButton.Size = new Size(168, 28);
            loadSettingsButton.TabIndex = 1;
            loadSettingsButton.Text = "Загрузить настройки ";
            loadSettingsButton.UseVisualStyleBackColor = true;
            loadSettingsButton.Click += loadSettingsButton_Click;
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(labelProfileDescription);
            groupBoxMain.Controls.Add(labelAppDescription);
            groupBoxMain.Controls.Add(buttonRun);
            groupBoxMain.Controls.Add(label2);
            groupBoxMain.Controls.Add(comboBoxProfile);
            groupBoxMain.Controls.Add(label1);
            groupBoxMain.Controls.Add(comboBoxApp);
            groupBoxMain.Dock = DockStyle.Fill;
            groupBoxMain.Location = new Point(0, 71);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(1012, 182);
            groupBoxMain.TabIndex = 4;
            groupBoxMain.TabStop = false;
            // 
            // labelProfileDescription
            // 
            labelProfileDescription.AutoSize = true;
            labelProfileDescription.Location = new Point(462, 88);
            labelProfileDescription.Name = "labelProfileDescription";
            labelProfileDescription.Size = new Size(0, 20);
            labelProfileDescription.TabIndex = 11;
            // 
            // labelAppDescription
            // 
            labelAppDescription.AutoSize = true;
            labelAppDescription.Location = new Point(462, 29);
            labelAppDescription.Name = "labelAppDescription";
            labelAppDescription.Size = new Size(0, 20);
            labelAppDescription.TabIndex = 10;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(845, 131);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(149, 29);
            buttonRun.TabIndex = 9;
            buttonRun.Text = "Запустить";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 85);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 8;
            label2.Text = "Контур:";
            // 
            // comboBoxProfile
            // 
            comboBoxProfile.FormattingEnabled = true;
            comboBoxProfile.Location = new Point(123, 85);
            comboBoxProfile.Name = "comboBoxProfile";
            comboBoxProfile.Size = new Size(311, 28);
            comboBoxProfile.TabIndex = 7;
            comboBoxProfile.SelectedIndexChanged += comboBoxProfile_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 6;
            label1.Text = "Приложение:";
            // 
            // comboBoxApp
            // 
            comboBoxApp.FormattingEnabled = true;
            comboBoxApp.Location = new Point(123, 26);
            comboBoxApp.Name = "comboBoxApp";
            comboBoxApp.Size = new Size(311, 28);
            comboBoxApp.TabIndex = 5;
            comboBoxApp.SelectedIndexChanged += comboBoxApp_SelectedIndexChanged;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 433);
            Controls.Add(groupBoxMain);
            Controls.Add(groupBoxFooter);
            Controls.Add(groupBoxState);
            Name = "formMain";
            Text = "Запуск приложений (AlefLauncher v 1.0)";
            Load += formMain_Load;
            groupBoxState.ResumeLayout(false);
            groupBoxFooter.ResumeLayout(false);
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceApp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxState;
        private GroupBox groupBoxFooter;
        private Button loadSettingsButton;
        private GroupBox groupBoxMain;
        private Button buttonRun;
        private Label label2;
        private ComboBox comboBoxProfile;
        private Label label1;
        private ComboBox comboBoxApp;
        private RichTextBox stateTextBox;
        private BindingSource bindingSourceApp;
        private Label labelProfileDescription;
        private Label labelAppDescription;
        private Button saveSettingsButton;
    }
}
