<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.currencytoBTCButton = New System.Windows.Forms.Button()
        Me.KRWRadio = New System.Windows.Forms.RadioButton()
        Me.USDRadio = New System.Windows.Forms.RadioButton()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.currencyToBTCTabPage = New System.Windows.Forms.TabPage()
        Me.currencytoBTCToLabel = New System.Windows.Forms.Label()
        Me.currencytoBTCLabel = New System.Windows.Forms.Label()
        Me.ValueofMoneyTextBox = New System.Windows.Forms.TextBox()
        Me.getreceivedbyaddressTabPage = New System.Windows.Forms.TabPage()
        Me.getreceivedbyaddressLabel = New System.Windows.Forms.Label()
        Me.getreceivedbyaddressCheckButton = New System.Windows.Forms.Button()
        Me.getreceivedbyaddressTextBox = New System.Windows.Forms.TextBox()
        Me.addressbalanceTabPage = New System.Windows.Forms.TabPage()
        Me.addressbalanceLabel = New System.Windows.Forms.Label()
        Me.addressbalanceCheckButton = New System.Windows.Forms.Button()
        Me.addressbalanceTextBox = New System.Windows.Forms.TextBox()
        Me.getsentbyaddress = New System.Windows.Forms.TabPage()
        Me.confirmationsTabPage = New System.Windows.Forms.TabPage()
        Me.getsentbyaddressLabel = New System.Windows.Forms.Label()
        Me.getsentbyaddressCheckButton = New System.Windows.Forms.Button()
        Me.getsentbyaddressTextBox = New System.Windows.Forms.TextBox()
        Me.UsingconfirmationsCheckBox = New System.Windows.Forms.CheckBox()
        Me.confirmationsTrackBar = New System.Windows.Forms.TrackBar()
        Me.TrackBarLabel = New System.Windows.Forms.Label()
        Me.MainTabControl.SuspendLayout()
        Me.currencyToBTCTabPage.SuspendLayout()
        Me.getreceivedbyaddressTabPage.SuspendLayout()
        Me.addressbalanceTabPage.SuspendLayout()
        Me.getsentbyaddress.SuspendLayout()
        Me.confirmationsTabPage.SuspendLayout()
        CType(Me.confirmationsTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currencytoBTCButton
        '
        Me.currencytoBTCButton.Location = New System.Drawing.Point(253, 28)
        Me.currencytoBTCButton.Name = "currencytoBTCButton"
        Me.currencytoBTCButton.Size = New System.Drawing.Size(75, 23)
        Me.currencytoBTCButton.TabIndex = 0
        Me.currencytoBTCButton.Text = "Check"
        Me.currencytoBTCButton.UseVisualStyleBackColor = True
        '
        'KRWRadio
        '
        Me.KRWRadio.AutoSize = True
        Me.KRWRadio.Checked = True
        Me.KRWRadio.Location = New System.Drawing.Point(8, 6)
        Me.KRWRadio.Name = "KRWRadio"
        Me.KRWRadio.Size = New System.Drawing.Size(49, 16)
        Me.KRWRadio.TabIndex = 1
        Me.KRWRadio.TabStop = True
        Me.KRWRadio.Text = "KRW"
        Me.KRWRadio.UseVisualStyleBackColor = True
        '
        'USDRadio
        '
        Me.USDRadio.AutoSize = True
        Me.USDRadio.Location = New System.Drawing.Point(63, 6)
        Me.USDRadio.Name = "USDRadio"
        Me.USDRadio.Size = New System.Drawing.Size(47, 16)
        Me.USDRadio.TabIndex = 2
        Me.USDRadio.Text = "USD"
        Me.USDRadio.UseVisualStyleBackColor = True
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.currencyToBTCTabPage)
        Me.MainTabControl.Controls.Add(Me.getreceivedbyaddressTabPage)
        Me.MainTabControl.Controls.Add(Me.addressbalanceTabPage)
        Me.MainTabControl.Controls.Add(Me.getsentbyaddress)
        Me.MainTabControl.Controls.Add(Me.confirmationsTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(575, 116)
        Me.MainTabControl.TabIndex = 3
        '
        'currencyToBTCTabPage
        '
        Me.currencyToBTCTabPage.Controls.Add(Me.currencytoBTCToLabel)
        Me.currencyToBTCTabPage.Controls.Add(Me.currencytoBTCLabel)
        Me.currencyToBTCTabPage.Controls.Add(Me.ValueofMoneyTextBox)
        Me.currencyToBTCTabPage.Controls.Add(Me.KRWRadio)
        Me.currencyToBTCTabPage.Controls.Add(Me.currencytoBTCButton)
        Me.currencyToBTCTabPage.Controls.Add(Me.USDRadio)
        Me.currencyToBTCTabPage.Location = New System.Drawing.Point(4, 22)
        Me.currencyToBTCTabPage.Name = "currencyToBTCTabPage"
        Me.currencyToBTCTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.currencyToBTCTabPage.Size = New System.Drawing.Size(567, 90)
        Me.currencyToBTCTabPage.TabIndex = 0
        Me.currencyToBTCTabPage.Text = "currencytoBTC"
        Me.currencyToBTCTabPage.UseVisualStyleBackColor = True
        '
        'currencytoBTCToLabel
        '
        Me.currencytoBTCToLabel.AutoSize = True
        Me.currencytoBTCToLabel.Location = New System.Drawing.Point(334, 33)
        Me.currencytoBTCToLabel.Name = "currencytoBTCToLabel"
        Me.currencytoBTCToLabel.Size = New System.Drawing.Size(20, 12)
        Me.currencytoBTCToLabel.TabIndex = 5
        Me.currencytoBTCToLabel.Text = "To"
        '
        'currencytoBTCLabel
        '
        Me.currencytoBTCLabel.AutoSize = True
        Me.currencytoBTCLabel.Location = New System.Drawing.Point(360, 33)
        Me.currencytoBTCLabel.Name = "currencytoBTCLabel"
        Me.currencytoBTCLabel.Size = New System.Drawing.Size(92, 12)
        Me.currencytoBTCLabel.TabIndex = 4
        Me.currencytoBTCLabel.Text = "0.00000000 BTC"
        '
        'ValueofMoneyTextBox
        '
        Me.ValueofMoneyTextBox.Location = New System.Drawing.Point(6, 28)
        Me.ValueofMoneyTextBox.Name = "ValueofMoneyTextBox"
        Me.ValueofMoneyTextBox.Size = New System.Drawing.Size(241, 21)
        Me.ValueofMoneyTextBox.TabIndex = 3
        '
        'getreceivedbyaddressTabPage
        '
        Me.getreceivedbyaddressTabPage.Controls.Add(Me.getreceivedbyaddressLabel)
        Me.getreceivedbyaddressTabPage.Controls.Add(Me.getreceivedbyaddressCheckButton)
        Me.getreceivedbyaddressTabPage.Controls.Add(Me.getreceivedbyaddressTextBox)
        Me.getreceivedbyaddressTabPage.Location = New System.Drawing.Point(4, 22)
        Me.getreceivedbyaddressTabPage.Name = "getreceivedbyaddressTabPage"
        Me.getreceivedbyaddressTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.getreceivedbyaddressTabPage.Size = New System.Drawing.Size(567, 90)
        Me.getreceivedbyaddressTabPage.TabIndex = 1
        Me.getreceivedbyaddressTabPage.Text = "getreceivedbyaddress"
        Me.getreceivedbyaddressTabPage.UseVisualStyleBackColor = True
        '
        'getreceivedbyaddressLabel
        '
        Me.getreceivedbyaddressLabel.AutoSize = True
        Me.getreceivedbyaddressLabel.Location = New System.Drawing.Point(8, 30)
        Me.getreceivedbyaddressLabel.Name = "getreceivedbyaddressLabel"
        Me.getreceivedbyaddressLabel.Size = New System.Drawing.Size(92, 12)
        Me.getreceivedbyaddressLabel.TabIndex = 2
        Me.getreceivedbyaddressLabel.Text = "0.00000000 BTC"
        '
        'getreceivedbyaddressCheckButton
        '
        Me.getreceivedbyaddressCheckButton.Location = New System.Drawing.Point(484, 6)
        Me.getreceivedbyaddressCheckButton.Name = "getreceivedbyaddressCheckButton"
        Me.getreceivedbyaddressCheckButton.Size = New System.Drawing.Size(75, 23)
        Me.getreceivedbyaddressCheckButton.TabIndex = 1
        Me.getreceivedbyaddressCheckButton.Text = "Check"
        Me.getreceivedbyaddressCheckButton.UseVisualStyleBackColor = True
        '
        'getreceivedbyaddressTextBox
        '
        Me.getreceivedbyaddressTextBox.Location = New System.Drawing.Point(8, 6)
        Me.getreceivedbyaddressTextBox.Name = "getreceivedbyaddressTextBox"
        Me.getreceivedbyaddressTextBox.Size = New System.Drawing.Size(470, 21)
        Me.getreceivedbyaddressTextBox.TabIndex = 0
        '
        'addressbalanceTabPage
        '
        Me.addressbalanceTabPage.Controls.Add(Me.addressbalanceLabel)
        Me.addressbalanceTabPage.Controls.Add(Me.addressbalanceCheckButton)
        Me.addressbalanceTabPage.Controls.Add(Me.addressbalanceTextBox)
        Me.addressbalanceTabPage.Location = New System.Drawing.Point(4, 22)
        Me.addressbalanceTabPage.Name = "addressbalanceTabPage"
        Me.addressbalanceTabPage.Size = New System.Drawing.Size(567, 90)
        Me.addressbalanceTabPage.TabIndex = 2
        Me.addressbalanceTabPage.Text = "addressbalance"
        Me.addressbalanceTabPage.UseVisualStyleBackColor = True
        '
        'addressbalanceLabel
        '
        Me.addressbalanceLabel.AutoSize = True
        Me.addressbalanceLabel.Location = New System.Drawing.Point(8, 27)
        Me.addressbalanceLabel.Name = "addressbalanceLabel"
        Me.addressbalanceLabel.Size = New System.Drawing.Size(92, 12)
        Me.addressbalanceLabel.TabIndex = 5
        Me.addressbalanceLabel.Text = "0.00000000 BTC"
        '
        'addressbalanceCheckButton
        '
        Me.addressbalanceCheckButton.Location = New System.Drawing.Point(484, 3)
        Me.addressbalanceCheckButton.Name = "addressbalanceCheckButton"
        Me.addressbalanceCheckButton.Size = New System.Drawing.Size(75, 23)
        Me.addressbalanceCheckButton.TabIndex = 4
        Me.addressbalanceCheckButton.Text = "Check"
        Me.addressbalanceCheckButton.UseVisualStyleBackColor = True
        '
        'addressbalanceTextBox
        '
        Me.addressbalanceTextBox.Location = New System.Drawing.Point(8, 3)
        Me.addressbalanceTextBox.Name = "addressbalanceTextBox"
        Me.addressbalanceTextBox.Size = New System.Drawing.Size(470, 21)
        Me.addressbalanceTextBox.TabIndex = 3
        '
        'getsentbyaddress
        '
        Me.getsentbyaddress.Controls.Add(Me.getsentbyaddressLabel)
        Me.getsentbyaddress.Controls.Add(Me.getsentbyaddressCheckButton)
        Me.getsentbyaddress.Controls.Add(Me.getsentbyaddressTextBox)
        Me.getsentbyaddress.Location = New System.Drawing.Point(4, 22)
        Me.getsentbyaddress.Name = "getsentbyaddress"
        Me.getsentbyaddress.Size = New System.Drawing.Size(567, 90)
        Me.getsentbyaddress.TabIndex = 3
        Me.getsentbyaddress.Text = "getsentbyaddressTabPage"
        Me.getsentbyaddress.UseVisualStyleBackColor = True
        '
        'confirmationsTabPage
        '
        Me.confirmationsTabPage.Controls.Add(Me.TrackBarLabel)
        Me.confirmationsTabPage.Controls.Add(Me.confirmationsTrackBar)
        Me.confirmationsTabPage.Controls.Add(Me.UsingconfirmationsCheckBox)
        Me.confirmationsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.confirmationsTabPage.Name = "confirmationsTabPage"
        Me.confirmationsTabPage.Size = New System.Drawing.Size(567, 90)
        Me.confirmationsTabPage.TabIndex = 4
        Me.confirmationsTabPage.Text = "confirmations"
        Me.confirmationsTabPage.UseVisualStyleBackColor = True
        '
        'getsentbyaddressLabel
        '
        Me.getsentbyaddressLabel.AutoSize = True
        Me.getsentbyaddressLabel.Location = New System.Drawing.Point(8, 27)
        Me.getsentbyaddressLabel.Name = "getsentbyaddressLabel"
        Me.getsentbyaddressLabel.Size = New System.Drawing.Size(92, 12)
        Me.getsentbyaddressLabel.TabIndex = 8
        Me.getsentbyaddressLabel.Text = "0.00000000 BTC"
        '
        'getsentbyaddressCheckButton
        '
        Me.getsentbyaddressCheckButton.Location = New System.Drawing.Point(484, 3)
        Me.getsentbyaddressCheckButton.Name = "getsentbyaddressCheckButton"
        Me.getsentbyaddressCheckButton.Size = New System.Drawing.Size(75, 23)
        Me.getsentbyaddressCheckButton.TabIndex = 7
        Me.getsentbyaddressCheckButton.Text = "Check"
        Me.getsentbyaddressCheckButton.UseVisualStyleBackColor = True
        '
        'getsentbyaddressTextBox
        '
        Me.getsentbyaddressTextBox.Location = New System.Drawing.Point(8, 3)
        Me.getsentbyaddressTextBox.Name = "getsentbyaddressTextBox"
        Me.getsentbyaddressTextBox.Size = New System.Drawing.Size(470, 21)
        Me.getsentbyaddressTextBox.TabIndex = 6
        '
        'UsingconfirmationsCheckBox
        '
        Me.UsingconfirmationsCheckBox.AutoSize = True
        Me.UsingconfirmationsCheckBox.Location = New System.Drawing.Point(8, 8)
        Me.UsingconfirmationsCheckBox.Name = "UsingconfirmationsCheckBox"
        Me.UsingconfirmationsCheckBox.Size = New System.Drawing.Size(154, 16)
        Me.UsingconfirmationsCheckBox.TabIndex = 0
        Me.UsingconfirmationsCheckBox.Text = "Not Using Confirmation"
        Me.UsingconfirmationsCheckBox.UseVisualStyleBackColor = True
        '
        'confirmationsTrackBar
        '
        Me.confirmationsTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.confirmationsTrackBar.Location = New System.Drawing.Point(0, 45)
        Me.confirmationsTrackBar.Maximum = 120
        Me.confirmationsTrackBar.Name = "confirmationsTrackBar"
        Me.confirmationsTrackBar.Size = New System.Drawing.Size(567, 45)
        Me.confirmationsTrackBar.TabIndex = 1
        '
        'TrackBarLabel
        '
        Me.TrackBarLabel.AutoSize = True
        Me.TrackBarLabel.Location = New System.Drawing.Point(212, 12)
        Me.TrackBarLabel.Name = "TrackBarLabel"
        Me.TrackBarLabel.Size = New System.Drawing.Size(0, 12)
        Me.TrackBarLabel.TabIndex = 2
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 116)
        Me.Controls.Add(Me.MainTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(591, 155)
        Me.MinimumSize = New System.Drawing.Size(591, 155)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bitcoin"
        Me.MainTabControl.ResumeLayout(False)
        Me.currencyToBTCTabPage.ResumeLayout(False)
        Me.currencyToBTCTabPage.PerformLayout()
        Me.getreceivedbyaddressTabPage.ResumeLayout(False)
        Me.getreceivedbyaddressTabPage.PerformLayout()
        Me.addressbalanceTabPage.ResumeLayout(False)
        Me.addressbalanceTabPage.PerformLayout()
        Me.getsentbyaddress.ResumeLayout(False)
        Me.getsentbyaddress.PerformLayout()
        Me.confirmationsTabPage.ResumeLayout(False)
        Me.confirmationsTabPage.PerformLayout()
        CType(Me.confirmationsTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents currencytoBTCButton As Button
    Friend WithEvents KRWRadio As RadioButton
    Friend WithEvents USDRadio As RadioButton
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents currencyToBTCTabPage As TabPage
    Friend WithEvents ValueofMoneyTextBox As TextBox
    Friend WithEvents getreceivedbyaddressTabPage As TabPage
    Friend WithEvents currencytoBTCLabel As Label
    Friend WithEvents currencytoBTCToLabel As Label
    Friend WithEvents getreceivedbyaddressCheckButton As Button
    Friend WithEvents getreceivedbyaddressTextBox As TextBox
    Friend WithEvents getreceivedbyaddressLabel As Label
    Friend WithEvents addressbalanceTabPage As TabPage
    Friend WithEvents addressbalanceLabel As Label
    Friend WithEvents addressbalanceCheckButton As Button
    Friend WithEvents addressbalanceTextBox As TextBox
    Friend WithEvents getsentbyaddress As TabPage
    Friend WithEvents getsentbyaddressLabel As Label
    Friend WithEvents getsentbyaddressCheckButton As Button
    Friend WithEvents getsentbyaddressTextBox As TextBox
    Friend WithEvents confirmationsTabPage As TabPage
    Friend WithEvents confirmationsTrackBar As TrackBar
    Friend WithEvents UsingconfirmationsCheckBox As CheckBox
    Friend WithEvents TrackBarLabel As Label
End Class
