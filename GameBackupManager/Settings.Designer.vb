<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.OkConfigButton = New System.Windows.Forms.Button()
		Me.CancelConfigButton = New System.Windows.Forms.Button()
		Me.ApplyConfigButton = New System.Windows.Forms.Button()
		Me.GeneralGroupBox = New System.Windows.Forms.GroupBox()
		Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
		Me.GeneralGroupBox.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		'
		'OkConfigButton
		'
		resources.ApplyResources(Me.OkConfigButton, "OkConfigButton")
		Me.OkConfigButton.Name = "OkConfigButton"
		Me.OkConfigButton.UseVisualStyleBackColor = True
		'
		'CancelConfigButton
		'
		resources.ApplyResources(Me.CancelConfigButton, "CancelConfigButton")
		Me.CancelConfigButton.Name = "CancelConfigButton"
		Me.CancelConfigButton.UseVisualStyleBackColor = True
		'
		'ApplyConfigButton
		'
		resources.ApplyResources(Me.ApplyConfigButton, "ApplyConfigButton")
		Me.ApplyConfigButton.Name = "ApplyConfigButton"
		Me.ApplyConfigButton.UseVisualStyleBackColor = True
		'
		'GeneralGroupBox
		'
		resources.ApplyResources(Me.GeneralGroupBox, "GeneralGroupBox")
		Me.GeneralGroupBox.Controls.Add(Me.LanguageComboBox)
		Me.GeneralGroupBox.Controls.Add(Me.Label1)
		Me.GeneralGroupBox.Name = "GeneralGroupBox"
		Me.GeneralGroupBox.TabStop = False
		'
		'LanguageComboBox
		'
		resources.ApplyResources(Me.LanguageComboBox, "LanguageComboBox")
		Me.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.LanguageComboBox.FormattingEnabled = True
		Me.LanguageComboBox.Name = "LanguageComboBox"
		'
		'Settings
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.GeneralGroupBox)
		Me.Controls.Add(Me.ApplyConfigButton)
		Me.Controls.Add(Me.CancelConfigButton)
		Me.Controls.Add(Me.OkConfigButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Settings"
		Me.GeneralGroupBox.ResumeLayout(False)
		Me.GeneralGroupBox.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents OkConfigButton As System.Windows.Forms.Button
	Friend WithEvents CancelConfigButton As System.Windows.Forms.Button
	Friend WithEvents ApplyConfigButton As System.Windows.Forms.Button
	Friend WithEvents GeneralGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents LanguageComboBox As System.Windows.Forms.ComboBox
End Class
