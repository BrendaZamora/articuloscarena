﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Descripción = New System.Windows.Forms.Label
        Me.Código = New System.Windows.Forms.Label
        Me.Unidad = New System.Windows.Forms.Label
        Me.Stock = New System.Windows.Forms.Label
        Me.Costo = New System.Windows.Forms.Label
        Me.Iva = New System.Windows.Forms.Label
        Me.Utilidad = New System.Windows.Forms.Label
        Me.Venta = New System.Windows.Forms.Label
        Me.descripcion = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.stoc = New System.Windows.Forms.TextBox
        Me.codigo = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Descripción
        '
        Me.Descripción.AutoSize = True
        Me.Descripción.Location = New System.Drawing.Point(39, 56)
        Me.Descripción.Name = "Descripción"
        Me.Descripción.Size = New System.Drawing.Size(63, 13)
        Me.Descripción.TabIndex = 0
        Me.Descripción.Text = "Descripción"
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Location = New System.Drawing.Point(62, 93)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(40, 13)
        Me.Código.TabIndex = 1
        Me.Código.Text = "Código"
        '
        'Unidad
        '
        Me.Unidad.AutoSize = True
        Me.Unidad.Location = New System.Drawing.Point(61, 129)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Size = New System.Drawing.Size(41, 13)
        Me.Unidad.TabIndex = 2
        Me.Unidad.Text = "Unidad"
        '
        'Stock
        '
        Me.Stock.AutoSize = True
        Me.Stock.Location = New System.Drawing.Point(61, 199)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(35, 13)
        Me.Stock.TabIndex = 3
        Me.Stock.Text = "Stock"
        '
        'Costo
        '
        Me.Costo.AutoSize = True
        Me.Costo.Location = New System.Drawing.Point(61, 236)
        Me.Costo.Name = "Costo"
        Me.Costo.Size = New System.Drawing.Size(34, 13)
        Me.Costo.TabIndex = 4
        Me.Costo.Text = "Costo"
        '
        'Iva
        '
        Me.Iva.AutoSize = True
        Me.Iva.Location = New System.Drawing.Point(73, 282)
        Me.Iva.Name = "Iva"
        Me.Iva.Size = New System.Drawing.Size(22, 13)
        Me.Iva.TabIndex = 5
        Me.Iva.Text = "Iva"
        '
        'Utilidad
        '
        Me.Utilidad.AutoSize = True
        Me.Utilidad.Location = New System.Drawing.Point(54, 316)
        Me.Utilidad.Name = "Utilidad"
        Me.Utilidad.Size = New System.Drawing.Size(42, 13)
        Me.Utilidad.TabIndex = 6
        Me.Utilidad.Text = "Utilidad"
        '
        'Venta
        '
        Me.Venta.AutoSize = True
        Me.Venta.Location = New System.Drawing.Point(60, 349)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(35, 13)
        Me.Venta.TabIndex = 7
        Me.Venta.Text = "Venta"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(157, 53)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(207, 20)
        Me.descripcion.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 346)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(157, 313)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(207, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(157, 229)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(207, 20)
        Me.TextBox4.TabIndex = 11
        '
        'stoc
        '
        Me.stoc.Location = New System.Drawing.Point(157, 196)
        Me.stoc.Name = "stoc"
        Me.stoc.Size = New System.Drawing.Size(207, 20)
        Me.stoc.TabIndex = 12
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(157, 90)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(207, 20)
        Me.codigo.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(157, 279)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(137, 393)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 36)
        Me.Aceptar.TabIndex = 16
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(263, 393)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 36)
        Me.Cancelar.TabIndex = 17
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 441)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.stoc)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Venta)
        Me.Controls.Add(Me.Utilidad)
        Me.Controls.Add(Me.Iva)
        Me.Controls.Add(Me.Costo)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Unidad)
        Me.Controls.Add(Me.Código)
        Me.Controls.Add(Me.Descripción)
        Me.Name = "ArticulosForm"
        Me.Text = "ArticulosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Descripción As System.Windows.Forms.Label
    Friend WithEvents Código As System.Windows.Forms.Label
    Friend WithEvents Unidad As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.Label
    Friend WithEvents Costo As System.Windows.Forms.Label
    Friend WithEvents Iva As System.Windows.Forms.Label
    Friend WithEvents Utilidad As System.Windows.Forms.Label
    Friend WithEvents Venta As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents stoc As System.Windows.Forms.TextBox
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button

End Class
