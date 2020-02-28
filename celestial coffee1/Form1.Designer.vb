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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grpDecaf = New System.Windows.Forms.GroupBox()
        Me.radDecafPound = New System.Windows.Forms.RadioButton()
        Me.radDecafHalf = New System.Windows.Forms.RadioButton()
        Me.radDecafQuarter = New System.Windows.Forms.RadioButton()
        Me.grpReg = New System.Windows.Forms.GroupBox()
        Me.radRegPound = New System.Windows.Forms.RadioButton()
        Me.radRegHalf = New System.Windows.Forms.RadioButton()
        Me.radRegQuarter = New System.Windows.Forms.RadioButton()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpDecaf.SuspendLayout()
        Me.grpReg.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.Aquamarine
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.Black
        Me.btnPlaceOrder.Location = New System.Drawing.Point(1242, 277)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(207, 152)
        Me.btnPlaceOrder.TabIndex = 0
        Me.btnPlaceOrder.Text = "Place Order Here"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(0, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(449, 49)
        Me.txtName.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'grpDecaf
        '
        Me.grpDecaf.BackColor = System.Drawing.Color.Coral
        Me.grpDecaf.Controls.Add(Me.radDecafPound)
        Me.grpDecaf.Controls.Add(Me.radDecafHalf)
        Me.grpDecaf.Controls.Add(Me.radDecafQuarter)
        Me.grpDecaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDecaf.Location = New System.Drawing.Point(68, 83)
        Me.grpDecaf.Name = "grpDecaf"
        Me.grpDecaf.Size = New System.Drawing.Size(401, 239)
        Me.grpDecaf.TabIndex = 3
        Me.grpDecaf.TabStop = False
        Me.grpDecaf.Text = "Decaf Coffee"
        '
        'radDecafPound
        '
        Me.radDecafPound.AutoSize = True
        Me.radDecafPound.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDecafPound.Location = New System.Drawing.Point(0, 120)
        Me.radDecafPound.Name = "radDecafPound"
        Me.radDecafPound.Size = New System.Drawing.Size(277, 40)
        Me.radDecafPound.TabIndex = 2
        Me.radDecafPound.TabStop = True
        Me.radDecafPound.Text = "1 Pound + $13.52"
        Me.radDecafPound.UseVisualStyleBackColor = True
        '
        'radDecafHalf
        '
        Me.radDecafHalf.AutoSize = True
        Me.radDecafHalf.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDecafHalf.Location = New System.Drawing.Point(0, 79)
        Me.radDecafHalf.Name = "radDecafHalf"
        Me.radDecafHalf.Size = New System.Drawing.Size(275, 40)
        Me.radDecafHalf.TabIndex = 1
        Me.radDecafHalf.TabStop = True
        Me.radDecafHalf.Text = "1/2 Pound +$7.02"
        Me.radDecafHalf.UseVisualStyleBackColor = True
        '
        'radDecafQuarter
        '
        Me.radDecafQuarter.AutoSize = True
        Me.radDecafQuarter.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDecafQuarter.Location = New System.Drawing.Point(0, 40)
        Me.radDecafQuarter.Name = "radDecafQuarter"
        Me.radDecafQuarter.Size = New System.Drawing.Size(275, 40)
        Me.radDecafQuarter.TabIndex = 0
        Me.radDecafQuarter.TabStop = True
        Me.radDecafQuarter.Text = "1/4 Pound +$3.25"
        Me.radDecafQuarter.UseVisualStyleBackColor = True
        '
        'grpReg
        '
        Me.grpReg.BackColor = System.Drawing.Color.Coral
        Me.grpReg.Controls.Add(Me.radRegPound)
        Me.grpReg.Controls.Add(Me.radRegHalf)
        Me.grpReg.Controls.Add(Me.radRegQuarter)
        Me.grpReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReg.Location = New System.Drawing.Point(68, 342)
        Me.grpReg.Name = "grpReg"
        Me.grpReg.Size = New System.Drawing.Size(411, 265)
        Me.grpReg.TabIndex = 4
        Me.grpReg.TabStop = False
        Me.grpReg.Text = "Regular Coffee"
        '
        'radRegPound
        '
        Me.radRegPound.AutoSize = True
        Me.radRegPound.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRegPound.Location = New System.Drawing.Point(29, 134)
        Me.radRegPound.Name = "radRegPound"
        Me.radRegPound.Size = New System.Drawing.Size(268, 40)
        Me.radRegPound.TabIndex = 2
        Me.radRegPound.TabStop = True
        Me.radRegPound.Text = "1 Pound +$13.52"
        Me.radRegPound.UseVisualStyleBackColor = True
        '
        'radRegHalf
        '
        Me.radRegHalf.AutoSize = True
        Me.radRegHalf.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRegHalf.Location = New System.Drawing.Point(29, 89)
        Me.radRegHalf.Name = "radRegHalf"
        Me.radRegHalf.Size = New System.Drawing.Size(275, 40)
        Me.radRegHalf.TabIndex = 1
        Me.radRegHalf.TabStop = True
        Me.radRegHalf.Text = "1/2 Pound +$7.02"
        Me.radRegHalf.UseVisualStyleBackColor = True
        '
        'radRegQuarter
        '
        Me.radRegQuarter.AutoSize = True
        Me.radRegQuarter.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRegQuarter.Location = New System.Drawing.Point(29, 46)
        Me.radRegQuarter.Name = "radRegQuarter"
        Me.radRegQuarter.Size = New System.Drawing.Size(275, 40)
        Me.radRegQuarter.TabIndex = 0
        Me.radRegQuarter.TabStop = True
        Me.radRegQuarter.Text = "1/4 Pound +$3.25"
        Me.radRegQuarter.UseVisualStyleBackColor = True
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.PowderBlue
        Me.grpInfo.Controls.Add(Me.lblAddress)
        Me.grpInfo.Controls.Add(Me.lblName)
        Me.grpInfo.Controls.Add(Me.txtAddress)
        Me.grpInfo.Controls.Add(Me.txtName)
        Me.grpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(633, 203)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(603, 338)
        Me.grpInfo.TabIndex = 5
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Customer Information"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(8, 161)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(163, 42)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(306, 38)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name (Last,First)"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(0, 206)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(449, 49)
        Me.txtAddress.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(646, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 820)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpReg)
        Me.Controls.Add(Me.grpDecaf)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpDecaf.ResumeLayout(False)
        Me.grpDecaf.PerformLayout()
        Me.grpReg.ResumeLayout(False)
        Me.grpReg.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents grpDecaf As GroupBox
    Friend WithEvents radDecafPound As RadioButton
    Friend WithEvents radDecafHalf As RadioButton
    Friend WithEvents radDecafQuarter As RadioButton
    Friend WithEvents grpReg As GroupBox
    Friend WithEvents radRegPound As RadioButton
    Friend WithEvents radRegHalf As RadioButton
    Friend WithEvents radRegQuarter As RadioButton
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
