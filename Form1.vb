Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim mySqlConnection As New MySqlConnection("host=127.0.0.1;user = root;database = schoolmanagementsystem")
    Dim query As MySqlCommand

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mySqlConnection.Open()
            MessageBox.Show("Successfully connected to Database")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim gender As String = ""
            If RadioButton1.Checked Then
                gender = "Male"


            End If
            If RadioButton2.Checked Then
                gender = "Female"
            End If
            Dim datavalid = True

            If TextBox1.Text = "" Then
                MsgBox("Please enter name!")
                datavalid = False

            End If
            If TextBox2.Text = "" Then
                MsgBox("Please enter phone number!")
                datavalid = False
            End If
            If TextBox6.Text = "" Then
                MsgBox("Please enter your email!")
                datavalid = False

            End If
            If datavalid = True Then
                query = New MySqlCommand("insert into registration values(' " & TextBox1.Text & "', '" & gender & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Value & "','" & ComboBox1.GetItemText(ComboBox1.SelectedItem) & "')", mySqlConnection)
                query.ExecuteNonQuery()

                MsgBox("Information Saved")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                RadioButton1.Checked = False
                RadioButton2.Checked = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
