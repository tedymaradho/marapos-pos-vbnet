Imports System.Data.SqlClient

Public Class Product
    Sub ResetForm()
        InputIdProduct.Clear()
        InputProductName.Clear()
        InputPrice.Clear()
        InputDiscount.Clear()
        InputPriceAfterDiscount.Clear()
        InputVendor.Clear()
        InputStock.Clear()
        InputBarcode.Clear()
        InputCogs.Clear()
        InputUnitName.Text = "Choose one"
        InputIdProduct.Focus()
    End Sub

    Sub Find()
        InputIdProduct.Text = Dr.Item("IdProduct")
        InputProductName.Text = Dr.Item("ProductName")
        InputVendor.Text = Dr.Item("Vendor")
        InputPrice.Text = Dr.Item("Price")
        InputDiscount.Text = Dr.Item("Discount")
        InputPriceAfterDiscount.Text = Dr.Item("PriceAfterDisc")
        InputStock.Text = Dr.Item("Stock")
        InputUnitName.Text = Dr.Item("UnitName")
        InputBarcode.Text = Dr.Item("Barcode")
        InputCogs.Text = Dr.Item("Cogs")
        InputProductName.Focus()
    End Sub

    Sub ShowUnitName()
        Connection()
        Cmd = New SqlCommand("SELECT DISTINCT UnitName FROM TbProduct", Conn)
        Dr = Cmd.ExecuteReader
        InputUnitName.Items.Clear()
        Do While Dr.Read
            InputUnitName.Items.Add(Dr.Item("UnitName"))
        Loop
        Conn.Close()
    End Sub

    Sub ShowGrid()
        Connection()
        Da = New SqlDataAdapter("SELECT * FROM TbProduct", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        Conn.Close()
    End Sub

    Sub FindById()
        Connection()
        Cmd = New SqlCommand("SELECT * FROM TbProduct WHERE IdProduct='" & InputIdProduct.Text & "'", Conn)
        Dr = Cmd.ExecuteReader
        Dr.Read()
    End Sub

    Sub Initial()
        ResetForm()
        ShowGrid()
        ShowUnitName()
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles Me.Load
        MdiParent = Main
        Initial()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Initial()
    End Sub

    Private Sub InputIdProduct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputIdProduct.KeyPress
        If e.KeyChar = Chr(13) Then
            FindById()
            If Dr.HasRows Then
                Find()
                Conn.Close()
                InputIdProduct.Focus()
            Else
                InputProductName.Clear()
                InputPrice.Clear()
                InputDiscount.Clear()
                InputPriceAfterDiscount.Clear()
                InputVendor.Clear()
                InputStock.Clear()
                InputBarcode.Clear()
                InputCogs.Clear()
                InputUnitName.Text = "Choose one"
                InputProductName.Focus()
            End If
        End If
    End Sub

    Private Sub InputIdProduct_LostFocus(sender As Object, e As EventArgs) Handles InputIdProduct.LostFocus
        FindById()
        If Dr.HasRows Then
            Find()
            Conn.Close()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        FindById()
        Connection()
        If Not Dr.HasRows Then
            Dim addProduct As String = "INSERT INTO TbProduct (IdProduct, ProductName) VALUES('" & InputIdProduct.Text & "', '" & InputProductName.Text & "')"
            Cmd = New SqlCommand(addProduct, Conn)

        Else
            Dim updateProduct As String = "UPDATE TbProduct SET ProductName='" & InputProductName.Text & "', Vendor='" & InputVendor.Text & "' WHERE IdProduct='" & InputIdProduct.Text & "'"
            Cmd = New SqlCommand(updateProduct, Conn)
        End If
        Cmd.ExecuteNonQuery()
        Conn.Close()
        Initial()
    End Sub
End Class
