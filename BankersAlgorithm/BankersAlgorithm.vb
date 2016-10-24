Public Class BankersAlgorithm

    ' declare variables
    Private getRemainingResource As Integer = Nothing

    Private Sub txtHold_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHold_1.TextChanged

        txtNeed_1.Text = Val(txtMax_1.Text) - Val(txtHold_1.Text)
        txtHoldTotal.Text = Val(txtHold_1.Text) + Val(txtHold_2.Text) + Val(txtHold_3.Text)

    End Sub

    Private Sub txtHold_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHold_2.TextChanged

        txtNeed_2.Text = Val(txtMax_2.Text) - Val(txtHold_2.Text)
        txtHoldTotal.Text = Val(txtHold_1.Text) + Val(txtHold_2.Text) + Val(txtHold_3.Text)

    End Sub

    Private Sub txtHold_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHold_3.TextChanged

        txtNeed_3.Text = Val(txtMax_3.Text) - Val(txtHold_3.Text)
        txtHoldTotal.Text = Val(txtHold_1.Text) + Val(txtHold_2.Text) + Val(txtHold_3.Text)

    End Sub

    Private Sub txtMax_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMax_1.TextChanged

        txtNeed_1.Text = Val(txtMax_1.Text) - Val(txtHold_1.Text)

    End Sub

    Private Sub txtMax_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMax_2.TextChanged

        txtNeed_2.Text = Val(txtMax_2.Text) - Val(txtHold_2.Text)

    End Sub

    Private Sub txtMax_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMax_3.TextChanged

        txtNeed_3.Text = Val(txtMax_3.Text) - Val(txtHold_3.Text)

    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        txtHold_1.BackColor = Color.White
        txtHold_2.BackColor = Color.White
        txtHold_3.BackColor = Color.White

        If Val(txtMax_1.Text) < Val(txtHold_1.Text) Then

            txtHold_1.BackColor = Color.Yellow

        ElseIf Val(txtMax_2.Text) < Val(txtHold_2.Text) Then

            txtHold_2.BackColor = Color.Yellow

        ElseIf Val(txtMax_3.Text) < Val(txtHold_3.Text) Then

            txtHold_3.BackColor = Color.Yellow

        ElseIf Val(txtResources.Text) >= Val(txtHoldTotal.Text) Then

            txtHold_1.BackColor = Color.White
            txtHold_2.BackColor = Color.White
            txtHold_3.BackColor = Color.White

            getRemainingResource = Val(txtResources.Text) - Val(txtHoldTotal.Text)

            ' WORKING ON PROCESS A

            If Val(txtNeed_1.Text) <= Val(txtNeed_2.Text) And Val(txtNeed_1.Text) <= Val(txtNeed_3.Text) Then


                If getRemainingResource >= Val(txtNeed_1.Text) Then

                    getRemainingResource = getRemainingResource - Val(txtNeed_1.Text) + Val(txtMax_1.Text)

                    If Val(txtNeed_2.Text) <= Val(txtNeed_3.Text) Then

                        If getRemainingResource >= Val(txtNeed_2.Text) Then

                            getRemainingResource = getRemainingResource - Val(txtNeed_2.Text) + Val(txtMax_2.Text)

                            If getRemainingResource >= Val(txtNeed_3.Text) Then

                                getRemainingResource = getRemainingResource - Val(txtNeed_3.Text) + Val(txtMax_3.Text)

                                resultSafe()

                                txtAvailable.Text = getRemainingResource

                            Else

                                txtProcess_3.BackColor = Color.Black
                                txtHold_3.BackColor = Color.Black
                                txtMax_3.BackColor = Color.Black
                                txtNeed_3.BackColor = Color.Black

                                resultDeadLock()

                                txtAvailable.Text = getRemainingResource

                            End If

                        Else

                            txtProcess_2.BackColor = Color.Black
                            txtHold_2.BackColor = Color.Black
                            txtMax_2.BackColor = Color.Black
                            txtNeed_2.BackColor = Color.Black

                            resultDeadLock()

                            txtAvailable.Text = getRemainingResource

                        End If

                    ElseIf Val(txtNeed_3.Text) < Val(txtNeed_2.Text) Then

                        If getRemainingResource >= Val(txtNeed_3.Text) Then

                            getRemainingResource = getRemainingResource - Val(txtNeed_3.Text) + Val(txtMax_3.Text)

                            If getRemainingResource > Val(txtNeed_2.Text) Then

                                getRemainingResource = getRemainingResource - Val(txtNeed_2.Text) + Val(txtMax_2.Text)

                                resultSafe()

                                txtAvailable.Text = getRemainingResource

                            Else

                                txtProcess_2.BackColor = Color.Black
                                txtHold_2.BackColor = Color.Black
                                txtMax_2.BackColor = Color.Black
                                txtNeed_2.BackColor = Color.Black

                                resultDeadLock()

                                txtAvailable.Text = getRemainingResource

                            End If

                        Else

                            txtProcess_3.BackColor = Color.Black
                            txtHold_3.BackColor = Color.Black
                            txtMax_3.BackColor = Color.Black
                            txtNeed_3.BackColor = Color.Black

                            resultDeadLock()

                            txtAvailable.Text = getRemainingResource

                        End If

                    End If

                Else

                    txtProcess_1.BackColor = Color.Black
                    txtHold_1.BackColor = Color.Black
                    txtMax_1.BackColor = Color.Black
                    txtNeed_1.BackColor = Color.Black

                    resultDeadLock()

                    txtAvailable.Text = getRemainingResource

                End If

                ' WORKING ON PROCESS B

            ElseIf Val(txtNeed_2.Text) < Val(txtNeed_1.Text) And Val(txtNeed_2.Text) <= Val(txtNeed_3.Text) Then


                If getRemainingResource >= Val(txtNeed_2.Text) Then

                    getRemainingResource = getRemainingResource - Val(txtNeed_2.Text) + Val(txtMax_2.Text)

                    If Val(txtNeed_1.Text) <= Val(txtNeed_3.Text) Then

                        getRemainingResource = getRemainingResource - Val(txtNeed_1.Text) + Val(txtMax_1.Text)

                        If getRemainingResource >= Val(txtNeed_3.Text) Then

                            getRemainingResource = getRemainingResource - Val(txtNeed_3.Text) + Val(txtMax_3.Text)

                            resultSafe()

                            txtAvailable.Text = getRemainingResource

                        Else

                            txtProcess_3.BackColor = Color.Black
                            txtHold_3.BackColor = Color.Black
                            txtMax_3.BackColor = Color.Black
                            txtNeed_3.BackColor = Color.Black

                            resultDeadLock()

                            txtAvailable.Text = getRemainingResource

                        End If

                    ElseIf Val(txtNeed_3.Text) < Val(txtNeed_1.Text) Then

                        If getRemainingResource >= Val(txtNeed_3.Text) Then

                            getRemainingResource = getRemainingResource - Val(txtNeed_3.Text) + Val(txtMax_3.Text)

                            If getRemainingResource >= Val(txtNeed_1.Text) Then

                                getRemainingResource = getRemainingResource - Val(txtNeed_1.Text) + Val(txtMax_1.Text)

                                resultSafe()

                                txtAvailable.Text = getRemainingResource

                            Else

                                txtProcess_1.BackColor = Color.Black
                                txtHold_1.BackColor = Color.Black
                                txtMax_1.BackColor = Color.Black
                                txtNeed_1.BackColor = Color.Black

                                resultDeadLock()

                            End If

                        Else

                            txtProcess_3.BackColor = Color.Black
                            txtHold_3.BackColor = Color.Black
                            txtMax_3.BackColor = Color.Black
                            txtNeed_3.BackColor = Color.Black

                            resultDeadLock()

                            txtAvailable.Text = getRemainingResource

                        End If

                    End If

                Else

                    txtProcess_2.BackColor = Color.Black
                    txtHold_2.BackColor = Color.Black
                    txtMax_2.BackColor = Color.Black
                    txtNeed_2.BackColor = Color.Black

                    resultDeadLock()

                    txtAvailable.Text = getRemainingResource

                End If


                ' WORKING ON PROCESS C

            ElseIf Val(txtNeed_3.Text) < Val(txtNeed_1.Text) And Val(txtNeed_3.Text) < Val(txtNeed_2.Text) Then


                If getRemainingResource >= Val(txtNeed_3.Text) Then

                    getRemainingResource = getRemainingResource - Val(txtNeed_3.Text) + Val(txtMax_1.Text)

                    If Val(txtNeed_1.Text) <= Val(txtNeed_2.Text) Then

                        If getRemainingResource >= Val(txtNeed_1.Text) Then

                            getRemainingResource = getRemainingResource - Val(txtNeed_1.Text) + Val(txtMax_1.Text)

                            If getRemainingResource >= Val(txtNeed_2.Text) Then

                                getRemainingResource = getRemainingResource - Val(txtNeed_2.Text) + Val(txtMax_2.Text)

                                resultSafe()

                                txtAvailable.Text = getRemainingResource

                            Else

                                txtProcess_2.BackColor = Color.Black
                                txtHold_2.BackColor = Color.Black
                                txtMax_2.BackColor = Color.Black
                                txtNeed_2.BackColor = Color.Black

                                resultDeadLock()

                                txtAvailable.Text = getRemainingResource

                            End If

                        Else

                            txtProcess_1.BackColor = Color.Black
                            txtHold_1.BackColor = Color.Black
                            txtMax_1.BackColor = Color.Black
                            txtNeed_1.BackColor = Color.Black

                            resultDeadLock()

                            txtAvailable.Text = getRemainingResource

                        End If

                    ElseIf Val(txtNeed_2.Text) < Val(txtNeed_1.Text) Then

                        If getRemainingResource >= Val(txtNeed_2.Text) Then

                            getRemainingResource = getRemainingResource - Val(txtNeed_2.Text) + Val(txtMax_2.Text)

                            If getRemainingResource >= Val(txtNeed_1.Text) Then

                                getRemainingResource = getRemainingResource - Val(txtNeed_1.Text)

                                resultSafe()

                                txtAvailable.Text = getRemainingResource

                            Else

                                txtProcess_1.BackColor = Color.Black
                                txtHold_1.BackColor = Color.Black
                                txtMax_1.BackColor = Color.Black
                                txtNeed_1.BackColor = Color.Black

                                resultDeadLock()

                                txtAvailable.Text = getRemainingResource

                            End If


                        Else

                            txtProcess_2.BackColor = Color.Black
                            txtHold_2.BackColor = Color.Black
                            txtMax_2.BackColor = Color.Black
                            txtNeed_2.BackColor = Color.Black

                            resultDeadLock()

                            txtAvailable.Text = getRemainingResource

                        End If

                    End If

                Else

                    txtProcess_3.BackColor = Color.Black
                    txtHold_3.BackColor = Color.Black
                    txtMax_3.BackColor = Color.Black
                    txtNeed_3.BackColor = Color.Black

                    resultDeadLock()

                    txtAvailable.Text = getRemainingResource

                End If

            End If


        Else


            resultDeadLock()

            txtAvailable.Text = getRemainingResource
            txtResources.BackColor = Color.Black

        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtProcess_1.BackColor = Color.White
        txtHold_1.BackColor = Color.White
        txtMax_1.BackColor = Color.White
        txtNeed_1.BackColor = Color.White

        txtProcess_2.BackColor = Color.White
        txtHold_2.BackColor = Color.White
        txtMax_2.BackColor = Color.White
        txtNeed_2.BackColor = Color.White

        txtProcess_3.BackColor = Color.White
        txtHold_3.BackColor = Color.White
        txtMax_3.BackColor = Color.White
        txtNeed_3.BackColor = Color.White

        GroupBox1.Enabled = True
        GroupBox1.BackColor = Color.WhiteSmoke
        lblStatus.Visible = False
        txtResources.BackColor = Color.White

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        txtMax_1.Clear()
        txtMax_2.Clear()
        txtMax_3.Clear()
        txtNeed_1.Text = ""
        txtNeed_2.Text = ""
        txtNeed_3.Text = ""
        txtHold_1.Clear()
        txtHold_2.Clear()
        txtHold_3.Clear()
        txtAvailable.Clear()
        txtResources.Clear()
        txtHoldTotal.Clear()
        GroupBox1.BackColor = Color.WhiteSmoke
        lblStatus.Visible = False
        txtNeed_1.Text = ""
        txtNeed_2.Text = ""
        txtNeed_3.Text = ""

    End Sub

    Private Sub resultDeadLock()

        GroupBox1.BackColor = Color.Red
        lblStatus.Text = "DEADLOCK!"
        lblStatus.ForeColor = Color.Red
        lblStatus.Visible = True
        GroupBox1.Enabled = False

    End Sub

    Private Sub resultSafe()

        lblStatus.Visible = True
        lblStatus.Text = "SAFE!"
        lblStatus.ForeColor = Color.Green
        GroupBox1.BackColor = Color.Green
        GroupBox1.Enabled = True

    End Sub

End Class