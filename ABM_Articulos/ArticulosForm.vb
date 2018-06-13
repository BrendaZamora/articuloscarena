Public Class ArticulosForm
    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass
    Dim indice_ As Byte
    Public Property operacion() As String
        Get
            Return operacion_

        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As String
        Get
            Return indice_

        End Get

        Set(ByVal value As String)
            indice_ = value
        End Set
    End Property
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        MiArticulo.Codigo = (codigo.Text)
        MiArticulo.Unidad = unida.SelectedItem
        MiArticulo.Descripcion = descripcion.Text
        MiArticulo.Stock = CInt(Stock.Text)
        MiArticulo.Iva = iv.SelectedIndex
        MiArticulo.Utilidad = CDec(Unidad.Text)
        MiArticulo.Costo = CDec(Costo.Text)

        Select Case operacion_
            Case "NUEVO"
                lst.Add(MiArticulo)

            Case "ELIMINA"
                If lst.Count = 0 Then Exit Sub

                lst.RemoveAt(indice_)

            Case "MODIFICA"
                If lst.Count = 0 Then Exit Sub

                lst.Item(indice_) = MiArticulo

                ArticulosGrid.DataGridView1.Refresh()
        End Select
        Me.Close()

    End Sub

    
    Private Sub descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles descripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else

            e.Handled = True
        End If
    End Sub



    Private Sub codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not codigo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub cost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cost.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Costo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub utilida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles utilida.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Utilidad.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub vent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vent.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Venta.Text.IndexOf(".") Then
            '    e.Handled = True
            'ElseIf e.KeyChar = "." Then
            '    e.Handled = False
            'Else
            e.Handled = True
        End If

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub


    Private Sub ArticulosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iv.DataSource = listaiva_


    End Sub
End Class
