

Public Class frmEspacioVectorial
    ' Declaración de variables
    Dim miGrafico As Graphics

    ' AL CARGAR EL FORMULARIO
    Private Sub frmEspacioVectorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    ' Procedimiento Limpiar
    Private Sub Limpiar()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        miGrafico = Me.CreateGraphics
        miGrafico.Clear(Color.Gray)


        ' Create pen.
        Dim blackPen As New Pen(Color.Black, 3)

        'al punto central del área cliente del formulario
        'Aquí movemos el eje de coordenadas
        'al punto central del área cliente del formulario
        miGrafico.TranslateTransform(Me.ClientSize.Width / 2, Me.ClientSize.Height / 2)


        miGrafico.DrawLine(blackPen, 0, -200, 0, 200)
        miGrafico.DrawLine(blackPen, -200, 0, 200, 0)


        miGrafico.DrawLine(blackPen, CInt(-1600 * 0.07071), CInt(800 * 0.07071), CInt(150 * 0.7071), CInt(-800 * 0.07071))


        ' Declaración de variables
        Dim oPunto As New clsPuntoEspacial(0, 0, 0)

        miGrafico.FillEllipse(Brushes.Blue, oPunto.CoordenadaX, oPunto.CoordenadaY, 5, 5)
    End Sub
End Class
