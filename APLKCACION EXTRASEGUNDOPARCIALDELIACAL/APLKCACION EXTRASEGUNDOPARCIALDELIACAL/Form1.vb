Public Class Form1
    Public precio As Integer
    Public focos As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Coneccion con la base de datos


        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.costos' Puede moverla o quitarla según sea necesario.
        Me.CostosTableAdapter.Fill(Me.KWHDataSet.costos)
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.KWH' Puede moverla o quitarla según sea necesario.
        Me.KWHTableAdapter.Fill(Me.KWHDataSet.KWH)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub KWHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KWHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KWHDataSet)

    End Sub

    Private Sub KWHBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KWHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KWHDataSet)

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        Try
            'Asignacion de valores ingresados por el usuario a diversas variables
            Dim a As Integer = Txtunidades1.Text
            focos = Txtunidades1.Text
            Dim b As Integer = Txtunidades2.Text
            Dim c As Integer = Txtunidades3.Text
            Dim d As Integer = Txtunidades4.Text
            Dim j As Integer = Txtunidades5.Text
            Dim f As Integer = Txtunidades6.Text
            Dim h1 As Integer = Txth1.Text
            Dim h2 As Integer = Txth2.Text
            Dim h3 As Integer = Txth3.Text
            Dim h4 As Integer = Txth4.Text
            Dim h5 As Integer = Txth5.Text
            Dim h6 As Integer = Txth6.Text
            Dim d1 As Integer = txtd1.Text
            Dim d2 As Integer = Txtd2.Text
            Dim d3 As Integer = Txtd3.Text
            Dim d4 As Integer = Txtd4.Text
            Dim d5 As Integer = txtd5.Text
            Dim d6 As Integer = Txtd6.Text
            Dim totunidades, tothoras, totdias, CONMENSUAL As Integer

            'Calculo para generar el total de consumo del sistema electrico de un usuario por un mes
            totunidades = (a * 60) + (b * 300) + (c * 255) + (d * 270) + (j * 85) + (f * 115)
            tothoras = h1 + h2 + h3 + h4 + h5 + h6
            totdias = d1 + d2 + d3 + d4 + d5 + d6
            CONMENSUAL = (totunidades * totdias * tothoras * 4) / 1000
            'el calculo bimestral se calcula con el anterior calculo multiplicado por dos
            TXTCONBIM.Text = CONMENSUAL * 2
            TXTCONMENSUAL.Text = CONMENSUAL
            'Se asignan los valores y se obtienen datos de la cuenta para completar los resultados de la pagina
            Dim tipoTarifa = UsuariosTableAdapter.getCuota(Registro.user)
            Dim precioNormal = 0
            Dim precio1 = CostosTableAdapter.getPrecio1(tipoTarifa)
            Dim precio2 = CostosTableAdapter.getPrecio2(tipoTarifa)
            Dim precio3 = CostosTableAdapter.getPrecio3(tipoTarifa)
            Dim kwH = CONMENSUAL
            'Se calcula despues el Total a pagar con la cuota obtenida por el tipo de cuenta del usuario (01, 1a, 1b .. etc)
            If (CONMENSUAL >= 0 And CONMENSUAL <= 75) Then
                precioNormal = kwH * precio1
            ElseIf (CONMENSUAL > 75 And CONMENSUAL <= 140) Then
                precioNormal = ((kwH - 75) * precio2) + (precio1 * 75)
            Else
                precioNormal = ((65) * precio2) + (precio1 * 75) + (precio3 * (kwH - 140))
            End If
            'se imprimen los resultados de los calculos en la ventana y se actualiza en la tabla de access
            precio = precio1
            txtPrecioMensual.Text = "$" & precioNormal
            txtPrecioBimestral.Text = "$" & (precioNormal * 2)
            txtTarifa.Text = tipoTarifa
            UsuariosTableAdapter.updatePagoNormal(precioNormal, Registro.user)
            'se habilita el voton para ir a la siguiente pagina
            btnContinuar.Enabled = True
        Catch EXCEPTION As InvalidCastException
            MsgBox("ESCRIBA NÚMEROS ENTEROS")
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Me.Hide()
        Resultados.Show()
    End Sub
End Class
