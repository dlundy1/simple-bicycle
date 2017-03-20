<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bicycle_btn = New System.Windows.Forms.RadioButton()
        Me.train_btn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.train_box = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bicycle_box = New System.Windows.Forms.PictureBox()
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.start_btn = New System.Windows.Forms.Button()
        CType(Me.train_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bicycle_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'bicycle_btn
        '
        Me.bicycle_btn.AutoSize = True
        Me.bicycle_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bicycle_btn.Location = New System.Drawing.Point(122, 55)
        Me.bicycle_btn.Name = "bicycle_btn"
        Me.bicycle_btn.Size = New System.Drawing.Size(70, 20)
        Me.bicycle_btn.TabIndex = 5
        Me.bicycle_btn.TabStop = True
        Me.bicycle_btn.Text = "Bicycle"
        Me.bicycle_btn.UseVisualStyleBackColor = True
        '
        'train_btn
        '
        Me.train_btn.AutoSize = True
        Me.train_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.train_btn.Location = New System.Drawing.Point(198, 55)
        Me.train_btn.Name = "train_btn"
        Me.train_btn.Size = New System.Drawing.Size(57, 20)
        Me.train_btn.TabIndex = 6
        Me.train_btn.TabStop = True
        Me.train_btn.Text = "Train"
        Me.train_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Transportation"
        '
        'train_box
        '
        Me.train_box.Image = Global.Bicycle.My.Resources.Resources.SteamEngine
        Me.train_box.Location = New System.Drawing.Point(284, 116)
        Me.train_box.Name = "train_box"
        Me.train_box.Size = New System.Drawing.Size(108, 70)
        Me.train_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.train_box.TabIndex = 14
        Me.train_box.TabStop = False
        Me.train_box.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Bicycle.My.Resources.Resources.red_graph
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(401, 10)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Bicycle.My.Resources.Resources.red_graph
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 192)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(401, 10)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'bicycle_box
        '
        Me.bicycle_box.Image = Global.Bicycle.My.Resources.Resources.Bicycle
        Me.bicycle_box.Location = New System.Drawing.Point(284, 116)
        Me.bicycle_box.Name = "bicycle_box"
        Me.bicycle_box.Size = New System.Drawing.Size(108, 70)
        Me.bicycle_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bicycle_box.TabIndex = 11
        Me.bicycle_box.TabStop = False
        '
        'stop_btn
        '
        Me.stop_btn.Location = New System.Drawing.Point(197, 208)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(92, 32)
        Me.stop_btn.TabIndex = 10
        Me.stop_btn.Text = "STOP"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'start_btn
        '
        Me.start_btn.Location = New System.Drawing.Point(99, 208)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(92, 32)
        Me.start_btn.TabIndex = 9
        Me.start_btn.Text = "START"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 248)
        Me.Controls.Add(Me.train_box)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bicycle_box)
        Me.Controls.Add(Me.stop_btn)
        Me.Controls.Add(Me.start_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.train_btn)
        Me.Controls.Add(Me.bicycle_btn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bicycle App"
        CType(Me.train_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bicycle_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bicycle_btn As RadioButton
    Friend WithEvents train_btn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents start_btn As Button
    Friend WithEvents stop_btn As Button
    Friend WithEvents bicycle_box As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents train_box As PictureBox
End Class
