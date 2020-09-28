<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListBoxForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListBoxForm))
        Me.ShowInvoiceButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.InvoiceComboBox = New System.Windows.Forms.ComboBox()
        Me.InvoiceListBox = New System.Windows.Forms.ListBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.UserDataTextBox = New System.Windows.Forms.TextBox()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShowInvoiceButton
        '
        Me.ShowInvoiceButton.Location = New System.Drawing.Point(314, 462)
        Me.ShowInvoiceButton.Name = "ShowInvoiceButton"
        Me.ShowInvoiceButton.Size = New System.Drawing.Size(302, 146)
        Me.ShowInvoiceButton.TabIndex = 0
        Me.ShowInvoiceButton.Text = "Show &Invoice"
        Me.ShowInvoiceButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewMenuItem, Me.PrintMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintPreviewMenuItem
        '
        Me.PrintPreviewMenuItem.Name = "PrintPreviewMenuItem"
        Me.PrintPreviewMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.PrintPreviewMenuItem.Text = "Print Preview"
        '
        'PrintMenuItem
        '
        Me.PrintMenuItem.Name = "PrintMenuItem"
        Me.PrintMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.PrintMenuItem.Text = "Print"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(632, 462)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(302, 146)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(940, 462)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(302, 146)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'InvoiceComboBox
        '
        Me.InvoiceComboBox.FormattingEnabled = True
        Me.InvoiceComboBox.Location = New System.Drawing.Point(18, 42)
        Me.InvoiceComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvoiceComboBox.Name = "InvoiceComboBox"
        Me.InvoiceComboBox.Size = New System.Drawing.Size(288, 28)
        Me.InvoiceComboBox.TabIndex = 4
        '
        'InvoiceListBox
        '
        Me.InvoiceListBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceListBox.FormattingEnabled = True
        Me.InvoiceListBox.ItemHeight = 28
        Me.InvoiceListBox.Location = New System.Drawing.Point(314, 42)
        Me.InvoiceListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvoiceListBox.Name = "InvoiceListBox"
        Me.InvoiceListBox.Size = New System.Drawing.Size(928, 396)
        Me.InvoiceListBox.TabIndex = 6
        '
        'UserDataTextBox
        '
        Me.UserDataTextBox.Location = New System.Drawing.Point(12, 428)
        Me.UserDataTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UserDataTextBox.Name = "UserDataTextBox"
        Me.UserDataTextBox.Size = New System.Drawing.Size(248, 26)
        Me.UserDataTextBox.TabIndex = 7
        '
        'AddItemButton
        '
        Me.AddItemButton.Location = New System.Drawing.Point(12, 462)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(248, 91)
        Me.AddItemButton.TabIndex = 8
        Me.AddItemButton.Text = "Add To List"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'ListBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 657)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.UserDataTextBox)
        Me.Controls.Add(Me.InvoiceListBox)
        Me.Controls.Add(Me.InvoiceComboBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ShowInvoiceButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ListBoxForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowInvoiceButton As Button
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewMenuItem As ToolStripMenuItem
    Friend WithEvents PrintMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents InvoiceComboBox As ComboBox
    Friend WithEvents InvoiceListBox As ListBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents UserDataTextBox As TextBox
    Friend WithEvents AddItemButton As Button
End Class
