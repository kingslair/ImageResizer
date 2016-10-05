Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim diag_abrir As New OpenFileDialog

            Dim img As Bitmap

            With diag_abrir

                .DefaultExt = "*.jpg"

                .Filter = "*.jpg | *.jpg"

                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures

                .Multiselect = False

                .ShowDialog()

                img = Bitmap.FromFile(.FileName)

            End With

            Dim a As Integer
            Dim b As Integer
            a = Val(TextBox1.Text)
            b = Val(TextBox2.Text)

            Dim bmp As Bitmap = New Bitmap(img, a, b)

            Dim g As Graphics = Graphics.FromImage(bmp)

            PictureBox1.Image = bmp
        Catch ex As Exception
            MsgBox("Please Fill the Length and Height")

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim file_name As String = Application.ExecutablePath
        file_name = file_name.Substring(0, _
            file_name.LastIndexOf("\bin")) & _
            "\output."
        Dim bm As Bitmap = PictureBox1.Image()

        ' Save the picture as a bitmap, JPEG, and GIF.
        bm.Save(file_name & "bmp", _
            System.Drawing.Imaging.ImageFormat.Bmp)
        bm.Save(file_name & "jpg", _
            System.Drawing.Imaging.ImageFormat.Jpeg)
        bm.Save(file_name & "gif", _
            System.Drawing.Imaging.ImageFormat.Gif)
        bm.Save(file_name & "png", _
            System.Drawing.Imaging.ImageFormat.Png)
        bm.Save(file_name & "gif", _
            System.Drawing.Imaging.ImageFormat.Gif)
        bm.Save(file_name & "icon", _
            System.Drawing.Imaging.ImageFormat.Icon)
        bm.Save(file_name & "tiff", _
            System.Drawing.Imaging.ImageFormat.Tiff)

        MsgBox("Image Has been Saved and converted.")
    End Sub
End Class
