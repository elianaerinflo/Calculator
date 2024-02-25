Public Class Form1
    'the global variables that is going to be used throughout the form  
    Dim num1 As Double
    Dim num2 As Double
    Dim ans As Double
    'the global variable for the operators: Add,sub,Mul and Div
    Dim opr As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMul.Click, btnAdd.Click, btnDiv.Click, btnSub.Click
        Dim num As Button = sender

        num1 = Convert.ToDouble(txtBox1.Text)

        If (num.Text = "÷") Then
            opr = "/"
        Else
            opr = num.Text
        End If

        txtBox1.Text = txtBox1.Text + num.Text

        btnDec.Enabled = True

    End Sub

    Private Sub btnNum0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNum0.Click
        'BTN NUM0
        txtBox1.Text = txtBox1.Text & "0"
    End Sub

    Private Sub btnNum1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNum1.Click
        'BTN NUM1
        If txtBox1.Text = "0" Then
            txtBox1.Text = "1"
        Else
            txtBox1.Text = txtBox1.Text & "1"
        End If
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        'BTN NUM2
        If txtBox1.Text = "0" Then
            txtBox1.Text = "2"
        Else
            txtBox1.Text = txtBox1.Text & "2"
        End If
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        'BTN NUM3
        If txtBox1.Text = "0" Then
            txtBox1.Text = "3"
        Else
            txtBox1.Text = txtBox1.Text & "3"
        End If
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        'BTN NUM4
        If txtBox1.Text = "0" Then
            txtBox1.Text = "4"
        Else
            txtBox1.Text = txtBox1.Text & "4"
        End If
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        'BTN NUM5
        If txtBox1.Text = "0" Then
            txtBox1.Text = "5"
        Else
            txtBox1.Text = txtBox1.Text & "5"
        End If
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        'BTN NUM6
        If txtBox1.Text = "0" Then
            txtBox1.Text = "6"
        Else
            txtBox1.Text = txtBox1.Text & "6"
        End If
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        'BTN NUM7
        If txtBox1.Text = "0" Then
            txtBox1.Text = "7"
        Else
            txtBox1.Text = txtBox1.Text & "7"
        End If
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        'BTN NUM8
        If txtBox1.Text = "0" Then
            txtBox1.Text = "8"
        Else
            txtBox1.Text = txtBox1.Text & "8"
        End If
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        'BTN NUM9
        If txtBox1.Text = "0" Then
            txtBox1.Text = "9"
        Else
            txtBox1.Text = txtBox1.Text & "9"
        End If
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        'for decimal

        If txtBox1.Text = "" Then
            txtBox1.Text = "0"
        End If

        If btnDec.Enabled = True Then
            txtBox1.Text = txtBox1.Text + "."
            btnDec.Enabled = False


        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        'OPERATOR FOR EQUAL BTN: 

        EvaluateEntries()

        If opr = "+" Then
            ans = num1 + num2
            txtBox1.Text = Convert.ToString(ans)
        ElseIf opr = "-" Then
            ans = num1 - num2
            txtBox1.Text = Convert.ToString(ans)
        ElseIf opr = "*" Then
            ans = num1 * num2
            txtBox1.Text = Convert.ToString(ans)
        ElseIf opr = "/" Then
            ans = num1 / num2
            txtBox1.Text = Convert.ToString(ans)
        End If

        btnDec.Enabled = True
    End Sub

    Private Sub InitializeAllEntry()

        'INITIALIZATION FOR VARIABLES AND OPERATORS
        ans = 0
        num1 = 0
        num2 = 0
        opr = ""
        btnDec.Enabled = True
    End Sub

    Private Sub ClearEntry()
        Try

            Dim tempOpr As String = ""

            If (opr = "/") Then
                tempOpr = "÷"
            Else
                tempOpr = opr
            End If

            txtBox1.Text = txtBox1.Text.Substring(0, txtBox1.Text.IndexOf(tempOpr) + 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEAR ALL BTN
        InitializeAllEntry()
        txtBox1.Text = ""
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        'CLEAR ENTRY BTN
        ClearEntry()
        btnDec.Enabled = True
    End Sub

    Private Sub EvaluateEntries()

        'THE TRY CATCH IS FOR ERROR, IF TXTBOX CONTAINS ONLY 1 VALUE WITHOUT
        'OPERATOR THEN IT WILL STAY THE SAME

        Try
            Dim tempOpr As String = ""
            If (opr = "/") Then
                tempOpr = "÷"  'for catch division
            Else
                tempOpr = opr '
            End If

            'FUNCTION

            num1 = txtBox1.Text.Substring(0, txtBox1.Text.IndexOf(tempOpr))
            'RETRIEVE THE FIRST VARIABLE
            'using substring function to get the 1st operand which starts with index 0, and ends at the position of the operation symbol

            Dim forNum2 = txtBox1.Text.Substring(txtBox1.Text.IndexOf(tempOpr) + 1, txtBox1.Text.Length - (txtBox1.Text.IndexOf(tempOpr) + 1))
            'RETRIEVE THE SECOND VARIABLE
            'THE COUNT STARTS WITH THE OPERATION

            If (forNum2 = "") Then
                num2 = num1
                'IF NUM2 IS EMPTY THEN NUM2 WILL ALSO HAVE THE SAME VALUE AS NUM1 

            Else
                num2 = forNum2
            End If

        Catch ex As Exception

            If txtBox1.Text IsNot "" Then
                num1 = txtBox1.Text
            End If

        End Try

    End Sub

    Private Sub btnSquared_Click(sender As Object, e As EventArgs) Handles btnSquared.Click
        'SQUAREROOT


        If txtBox1.Text = "" Or txtBox1.Text = "." Then
            Return
        End If

        num1 = txtBox1.Text
        ans = txtBox1.Text ^ 2
        txtBox1.Text = ans

    End Sub

    Private Sub btnPosNeg_Click(sender As Object, e As EventArgs) Handles btnPosNeg.Click
        'POSITVE, NEGATIVE 

        If txtBox1.Text = "" Or txtBox1.Text = "." Then
            Return
        End If

        If (txtBox1.Text.Contains("-")) Then
            txtBox1.Text = txtBox1.Text.Remove(0, 1)

        ElseIf (txtBox1.Text <> 0) Then
            txtBox1.Text = "-" + txtBox1.Text

        End If
    End Sub
End Class