﻿Public Class ArticulosGrid

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()

    End Sub

    Private Sub ArticulosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        ArticulosForm.operacion = "NUEVO"
        ArticulosForm.Text = "NUEVO ARTICULO"
        ArticulosForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        ArticulosForm.operacion = "ELIMINA"
        ArticulosForm.Text = "ELIMINA ARTICULO"
        ArticulosForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ArticulosForm.Show()

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        ArticulosForm.operacion = "MODIFICAR"
        ArticulosForm.Text = "MODIFICA ARTICULO"
        ArticulosForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ArticulosForm.Show()

    End Sub

    Private Sub llenarform()
        ArticulosForm.codigo.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        ArticulosForm.descripcion.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ArticulosForm.unidad.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ArticulosForm.Stock.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        ArticulosForm.Costo.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        ArticulosForm.iva.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        ArticulosForm.utilidad.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        ArticulosForm.venta.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
    End Sub
End Class