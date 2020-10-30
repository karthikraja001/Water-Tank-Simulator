Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startFlow.Click, tank.Tick
        tank.Start()
        tankCapacity.Text = tankPercent.Value
        tankPercent.Value -= 1
        PictureBox2.Height = 200 - tankPercent.Value * 2
        If tankPercent.Value <= 0 Then
            MessageBox.Show("Turn On Motor. Tank is Empty")
        End If
        If tankPercent.Value = 25 Then
            MessageBox.Show("Tank Used Upto 75%")
        End If
        If tankPercent.Value = 50 Then
            MessageBox.Show("Tank Used Upto 50%")
        End If
        If tankPercent.Value < 50 Then
            tank.Start()
            PictureBox1.BackColor = Color.Yellow
            tankPercent.BackColor = Color.YellowGreen
        End If
        If tankPercent.Value < 25 Then
            tank.Start()
            PictureBox1.BackColor = Color.Orange
            tankPercent.BackColor = Color.Orange
        End If
        If tankPercent.Value < 10 Then
            PictureBox1.BackColor = Color.Red
            tankPercent.BackColor = Color.Red
            tank.Stop()
            MessageBox.Show("Tank Used upto 90%. Water Flow is Stopped")
        End If
    End Sub

    Private Sub stopFlow_Click(sender As Object, e As EventArgs) Handles stopFlow.Click
        tank.Stop()
    End Sub

    Private Sub startMotor_Click(sender As Object, e As EventArgs) Handles startMotor.Click, motor.Tick
        motor.Start()
        tankPercent.Increment(1)
        tankCapacity.Text = tankPercent.Value
        PictureBox2.Height -= 2
        If tankPercent.Value > 25 Then
            PictureBox1.BackColor = Color.Yellow
        End If
        If tankPercent.Value > 10 Then
            PictureBox1.BackColor = Color.Orange
        End If
        If tankPercent.Value > 50 Then
            PictureBox1.BackColor = Color.Blue
        End If
        If tankPercent.Value = 100 Then
            motor.Enabled = False
            motor.Stop()
            MessageBox.Show("Tank Filled")
        End If
    End Sub

    Private Sub stopMotor_Click(sender As Object, e As EventArgs) Handles stopMotor.Click
        motor.Stop()
    End Sub

End Class
