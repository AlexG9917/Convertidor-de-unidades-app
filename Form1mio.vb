Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property TextBox1 As Object
        Public Property TextBox2 As Object

        Private Sub InitializeComponent()
            Throw New NotImplementedException()
        End Sub

    End Class

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Double = (Cantidad * 100)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad * 100000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad * 1000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad / 1000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad / 100)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad / 10)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad * 1000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad * 1000000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad / 100000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad / 1000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad / 1000)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim Distancia As Single = (Cantidad * 100)
        Me.TextBox2.Text = Distancia.ToString()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad * 1000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad * 100000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad * 1000000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad / 100)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad * 100)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad * 1000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad / 100000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad / 100)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad * 10)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad / 1000000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad / 1000)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Cantidad As Single = Single.Parse(Me.TextBox1.Text)
        Dim masa As Single = (Cantidad / 10)
        Me.TextBox2.Text = masa.ToString()
    End Sub

    Private Sub ButtonAyuda_Click(sender As Object, e As EventArgs) Handles ButtonAyuda.Click
        MessageBox.Show("Este programa convierte unidades de peso de la siguiente manera." &
             " 
             Ejemplo: 
             " &
             "
             Para convertir de kg a g, ingrese el valor en kg y haga clic en el botón (Kg) a (g). " &
             "
             Para convertir de g a kg, ingrese el valor en g y haga clic en el botón (g) a (Kg).",
             "
             El resultado se mostrara automaticamente en el Textbox inferior ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
