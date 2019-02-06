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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.salesReceipt = New System.Windows.Forms.ListBox()
        Me.itemBox = New System.Windows.Forms.TextBox()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addItem = New System.Windows.Forms.Button()
        Me.endSale = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.resetButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salesReceipt
        '
        Me.salesReceipt.Font = New System.Drawing.Font("Courier New", 12.5!)
        Me.salesReceipt.FormattingEnabled = True
        Me.salesReceipt.ItemHeight = 23
        Me.salesReceipt.Location = New System.Drawing.Point(13, 61)
        Me.salesReceipt.Name = "salesReceipt"
        Me.salesReceipt.Size = New System.Drawing.Size(540, 671)
        Me.salesReceipt.TabIndex = 0
        '
        'itemBox
        '
        Me.itemBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.itemBox.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemBox.Location = New System.Drawing.Point(807, 228)
        Me.itemBox.Multiline = True
        Me.itemBox.Name = "itemBox"
        Me.itemBox.Size = New System.Drawing.Size(561, 83)
        Me.itemBox.TabIndex = 1
        '
        'priceBox
        '
        Me.priceBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.priceBox.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceBox.Location = New System.Drawing.Point(807, 330)
        Me.priceBox.Multiline = True
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(561, 83)
        Me.priceBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(592, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(664, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price:"
        '
        'addItem
        '
        Me.addItem.Location = New System.Drawing.Point(934, 437)
        Me.addItem.Name = "addItem"
        Me.addItem.Size = New System.Drawing.Size(322, 54)
        Me.addItem.TabIndex = 5
        Me.addItem.Text = "Add Item to Reciept"
        Me.addItem.UseVisualStyleBackColor = True
        '
        'endSale
        '
        Me.endSale.Location = New System.Drawing.Point(934, 510)
        Me.endSale.Name = "endSale"
        Me.endSale.Size = New System.Drawing.Size(322, 54)
        Me.endSale.TabIndex = 6
        Me.endSale.Text = "End Transaction"
        Me.endSale.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(1215, 679)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(153, 62)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 35)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sales Receipt:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Brianna_Drew_Assignment_3_.My.Resources.Resources._95f81b33_e762_4bbd_847f_0245c54e59eb
        Me.PictureBox1.Location = New System.Drawing.Point(670, -55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(797, 357)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Brianna_Drew_Assignment_3_.My.Resources.Resources.ba336b54e44ba2554b3aa272960585fc
        Me.PictureBox2.Location = New System.Drawing.Point(580, 442)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(618, 352)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(840, 679)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(153, 62)
        Me.resetButton.TabIndex = 12
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1419, 773)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.endSale)
        Me.Controls.Add(Me.addItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.itemBox)
        Me.Controls.Add(Me.salesReceipt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Brianna's Rockin' Records Transaction/Receipt Processor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salesReceipt As ListBox
    Friend WithEvents itemBox As TextBox
    Friend WithEvents priceBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addItem As Button
    Friend WithEvents endSale As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents resetButton As Button
End Class
