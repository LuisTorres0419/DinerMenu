<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DinerMenuForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MeatloafButton = New System.Windows.Forms.Button()
        Me.PizzaButton = New System.Windows.Forms.Button()
        Me.SteakButton = New System.Windows.Forms.Button()
        Me.item2Label = New System.Windows.Forms.Label()
        Me.item1Label = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.OrangeRed
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(908, 504)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(196, 135)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HomeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MeatloafButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PizzaButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SteakButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ExitButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item2Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item1Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1116, 833)
        Me.SplitContainer1.SplitterDistance = 177
        Me.SplitContainer1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KRONK'S DINNER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.OrangeRed
        Me.HomeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(708, 504)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(196, 135)
        Me.HomeButton.TabIndex = 6
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MeatloafButton
        '
        Me.MeatloafButton.BackColor = System.Drawing.Color.OrangeRed
        Me.MeatloafButton.BackgroundImage = CType(resources.GetObject("MeatloafButton.BackgroundImage"), System.Drawing.Image)
        Me.MeatloafButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MeatloafButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeatloafButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MeatloafButton.Location = New System.Drawing.Point(22, 504)
        Me.MeatloafButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MeatloafButton.Name = "MeatloafButton"
        Me.MeatloafButton.Size = New System.Drawing.Size(218, 135)
        Me.MeatloafButton.TabIndex = 0
        Me.MeatloafButton.Text = "Meatloaf"
        Me.MeatloafButton.UseVisualStyleBackColor = False
        '
        'PizzaButton
        '
        Me.PizzaButton.BackColor = System.Drawing.Color.OrangeRed
        Me.PizzaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PizzaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PizzaButton.ForeColor = System.Drawing.SystemColors.MenuText
        Me.PizzaButton.Location = New System.Drawing.Point(248, 504)
        Me.PizzaButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PizzaButton.Name = "PizzaButton"
        Me.PizzaButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PizzaButton.Size = New System.Drawing.Size(196, 135)
        Me.PizzaButton.TabIndex = 1
        Me.PizzaButton.Text = "Pizza"
        Me.PizzaButton.UseVisualStyleBackColor = False
        '
        'SteakButton
        '
        Me.SteakButton.BackColor = System.Drawing.Color.OrangeRed
        Me.SteakButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SteakButton.Location = New System.Drawing.Point(452, 504)
        Me.SteakButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SteakButton.Name = "SteakButton"
        Me.SteakButton.Size = New System.Drawing.Size(196, 135)
        Me.SteakButton.TabIndex = 2
        Me.SteakButton.Text = "Steak"
        Me.SteakButton.UseVisualStyleBackColor = False
        '
        'item2Label
        '
        Me.item2Label.BackColor = System.Drawing.Color.Gold
        Me.item2Label.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item2Label.Location = New System.Drawing.Point(394, 94)
        Me.item2Label.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.item2Label.Name = "item2Label"
        Me.item2Label.Size = New System.Drawing.Size(512, 298)
        Me.item2Label.TabIndex = 0
        Me.item2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'item1Label
        '
        Me.item1Label.BackColor = System.Drawing.Color.Gold
        Me.item1Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.item1Label.Font = New System.Drawing.Font("Ravie", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item1Label.Location = New System.Drawing.Point(392, 40)
        Me.item1Label.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.item1Label.Name = "item1Label"
        Me.item1Label.Size = New System.Drawing.Size(512, 352)
        Me.item1Label.TabIndex = 5
        Me.item1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Gold
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1116, 652)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.Location = New System.Drawing.Point(460, 259)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(196, 135)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Pizza"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1116, 833)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DinerMenuForm"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MeatloafButton As Button
    Friend WithEvents PizzaButton As Button
    Friend WithEvents SteakButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents item2Label As Label
    Friend WithEvents item1Label As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents Button1 As Button
End Class
