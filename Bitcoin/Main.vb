Imports System.Net
Imports System
Imports System.IO
Imports System.Text
Public Class Main
    Dim BlockChain As String = "https://blockchain.info/q/"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub currencytoBTCButton_Click(sender As Object, e As EventArgs) Handles currencytoBTCButton.Click
        Dim MoneyType As String = "KRW"
        If USDRadio.Checked = True Then
            MoneyType = "USD"
        End If
        If KRWRadio.Checked = True Then
            MoneyType = "KRW"
        End If
        currencytoBTCLabel.Text = New WebClient().DownloadString("https://blockchain.info/tobtc?currency=" & MoneyType & "&value=" & ValueofMoneyTextBox.Text) & " BTC"
    End Sub
    Private Sub getreceivedbyaddressCheckButton_Click(sender As Object, e As EventArgs) Handles getreceivedbyaddressCheckButton.Click
        Dim sb As New StringBuilder
        sb.Append(BlockChain & "getreceivedbyaddress/" & getreceivedbyaddressTextBox.Text)
        If UsingconfirmationsCheckBox.Checked = True Then
            sb.Append("confirmations=" & confirmationsTrackBar.Value)
        End If
        Dim c = New WebClient().DownloadString(sb.ToString)
        getreceivedbyaddressLabel.Text = (ConvertIntToBtc(c))
    End Sub
    Function ConvertIntToBtc(btc As String) As String
        If btc.Length < 8 Then ' 8보다 짧다면
            Return "0." & String.Format("{0:D8}", Convert.ToInt32(btc))
        ElseIf btc.Length = 8 Then '8이라면
            Return "0." & btc
        Else
            Dim temp As String = Strings.Right(btc, 8)
            Return (btc.Remove(btc.Length - 8, 8) & "." & temp)
        End If
    End Function

    Private Sub addressbalanceCheckButton_Click(sender As Object, e As EventArgs) Handles addressbalanceCheckButton.Click
        Dim sb As New StringBuilder
        sb.Append(BlockChain & "addressbalance/" & getreceivedbyaddressTextBox.Text)
        If UsingconfirmationsCheckBox.Checked = True Then
            sb.Append("confirmations=" & confirmationsTrackBar.Value)
        End If
        Dim c = New WebClient().DownloadString(sb.ToString)
        addressbalanceLabel.Text = (ConvertIntToBtc(c))
    End Sub

    Private Sub UsingconfirmationsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles UsingconfirmationsCheckBox.CheckedChanged
        If UsingconfirmationsCheckBox.Checked = True Then
            UsingconfirmationsCheckBox.Text = "Using Confirmation"
        Else
            UsingconfirmationsCheckBox.Text = "Not Using Confirmation"
        End If
    End Sub

    Private Sub getsentbyaddressCheckButton_Click(sender As Object, e As EventArgs) Handles getsentbyaddressCheckButton.Click
        Dim sb As New StringBuilder
        sb.Append(BlockChain & "getsentbyaddress/" & getreceivedbyaddressTextBox.Text)
        If UsingconfirmationsCheckBox.Checked = True Then
            sb.Append("confirmations=" & confirmationsTrackBar.Value)
        End If
        Dim c = New WebClient().DownloadString(sb.ToString)
        getsentbyaddressLabel.Text = (ConvertIntToBtc(c))
    End Sub

    Private Sub confirmationsTrackBar_Scroll(sender As Object, e As EventArgs) Handles confirmationsTrackBar.Scroll
        TrackBarLabel.Text = confirmationsTrackBar.Value
    End Sub
End Class
