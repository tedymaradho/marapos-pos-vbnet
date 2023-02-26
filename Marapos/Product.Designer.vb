<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Product))
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        InputCogs = New TextBox()
        Label10 = New Label()
        InputStock = New TextBox()
        Label9 = New Label()
        InputPriceAfterDiscount = New TextBox()
        Label8 = New Label()
        InputDiscount = New TextBox()
        Label7 = New Label()
        InputPrice = New TextBox()
        Label6 = New Label()
        InputBarcode = New TextBox()
        InputUnitName = New ComboBox()
        InputVendor = New TextBox()
        InputProductName = New TextBox()
        InputIdProduct = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BtnDelete = New Button()
        BtnSave = New Button()
        BtnAdd = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(200, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(647, 596)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(InputCogs)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(InputStock)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(InputPriceAfterDiscount)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(InputDiscount)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(InputPrice)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(InputBarcode)
        Panel1.Controls.Add(InputUnitName)
        Panel1.Controls.Add(InputVendor)
        Panel1.Controls.Add(InputProductName)
        Panel1.Controls.Add(InputIdProduct)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 596)
        Panel1.TabIndex = 1
        ' 
        ' InputCogs
        ' 
        InputCogs.Location = New Point(12, 475)
        InputCogs.Name = "InputCogs"
        InputCogs.Size = New Size(173, 23)
        InputCogs.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 457)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 15)
        Label10.TabIndex = 20
        Label10.Text = "Cogs"' 
        ' InputStock
        ' 
        InputStock.Location = New Point(12, 426)
        InputStock.Name = "InputStock"
        InputStock.Size = New Size(173, 23)
        InputStock.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 408)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 15)
        Label9.TabIndex = 18
        Label9.Text = "Stock"' 
        ' InputPriceAfterDiscount
        ' 
        InputPriceAfterDiscount.Location = New Point(12, 376)
        InputPriceAfterDiscount.Name = "InputPriceAfterDiscount"
        InputPriceAfterDiscount.Size = New Size(173, 23)
        InputPriceAfterDiscount.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 358)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 15)
        Label8.TabIndex = 16
        Label8.Text = "Price After Discount"' 
        ' InputDiscount
        ' 
        InputDiscount.Location = New Point(12, 326)
        InputDiscount.Name = "InputDiscount"
        InputDiscount.Size = New Size(173, 23)
        InputDiscount.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 14
        Label7.Text = "Discount"' 
        ' InputPrice
        ' 
        InputPrice.Location = New Point(12, 276)
        InputPrice.Name = "InputPrice"
        InputPrice.Size = New Size(173, 23)
        InputPrice.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 258)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 15)
        Label6.TabIndex = 12
        Label6.Text = "Price"' 
        ' InputBarcode
        ' 
        InputBarcode.Location = New Point(12, 226)
        InputBarcode.Name = "InputBarcode"
        InputBarcode.Size = New Size(173, 23)
        InputBarcode.TabIndex = 8
        ' 
        ' InputUnitName
        ' 
        InputUnitName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        InputUnitName.FormattingEnabled = True
        InputUnitName.Location = New Point(12, 174)
        InputUnitName.Name = "InputUnitName"
        InputUnitName.Size = New Size(173, 25)
        InputUnitName.TabIndex = 10
        ' 
        ' InputVendor
        ' 
        InputVendor.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        InputVendor.Location = New Point(12, 124)
        InputVendor.Name = "InputVendor"
        InputVendor.Size = New Size(173, 23)
        InputVendor.TabIndex = 4
        ' 
        ' InputProductName
        ' 
        InputProductName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        InputProductName.Location = New Point(12, 74)
        InputProductName.Name = "InputProductName"
        InputProductName.Size = New Size(173, 23)
        InputProductName.TabIndex = 2
        ' 
        ' InputIdProduct
        ' 
        InputIdProduct.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        InputIdProduct.Location = New Point(12, 24)
        InputIdProduct.Name = "InputIdProduct"
        InputIdProduct.Size = New Size(173, 23)
        InputIdProduct.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 9
        Label5.Text = "Barcode"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 7
        Label4.Text = "Unit Name"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 5
        Label3.Text = "Vendor"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 3
        Label2.Text = "Product Name"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 1
        Label1.Text = "ID Product"' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnDelete)
        Panel2.Controls.Add(BtnSave)
        Panel2.Controls.Add(BtnAdd)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(847, 28)
        Panel2.TabIndex = 2
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(362, 3)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(281, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 1
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(200, 3)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(75, 23)
        BtnAdd.TabIndex = 0
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' Product
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 624)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Product"
        StartPosition = FormStartPosition.CenterParent
        Text = "Product"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents InputBarcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InputVendor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InputProductName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents InputIdProduct As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents InputUnitName As ComboBox
    Friend WithEvents InputPriceAfterDiscount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents InputDiscount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents InputPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents InputStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents InputCogs As TextBox
    Friend WithEvents Label10 As Label
End Class
