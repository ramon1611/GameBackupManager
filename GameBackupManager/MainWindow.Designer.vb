<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
		Me.LaunchersListView = New System.Windows.Forms.ListView()
		Me.LauncherColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.MainDirectoryColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GameDirectoryColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.DetectedColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.SettingsButton = New System.Windows.Forms.Button()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.GameNameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GameMainDirectoryColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GameUserDataDirectoryColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GameTypeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.DetectedGamesLabel = New System.Windows.Forms.Label()
		Me.AddLauncherButton = New System.Windows.Forms.Button()
		Me.EditLauncherButton = New System.Windows.Forms.Button()
		Me.RemoveLauncherButton = New System.Windows.Forms.Button()
		Me.DisableLauncherButton = New System.Windows.Forms.Button()
		Me.EnableLauncherButton = New System.Windows.Forms.Button()
		Me.AddGameButton = New System.Windows.Forms.Button()
		Me.EditGameButton = New System.Windows.Forms.Button()
		Me.RemoveGameButton = New System.Windows.Forms.Button()
		Me.DisbaleGameButton = New System.Windows.Forms.Button()
		Me.EnableGameButton = New System.Windows.Forms.Button()
		Me.DetectedLaunchersLabel = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'LaunchersListView
		'
		resources.ApplyResources(Me.LaunchersListView, "LaunchersListView")
		Me.LaunchersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LauncherColumnHeader, Me.MainDirectoryColumnHeader, Me.GameDirectoryColumnHeader, Me.DetectedColumnHeader})
		Me.LaunchersListView.FullRowSelect = True
		Me.LaunchersListView.LabelEdit = True
		Me.LaunchersListView.MultiSelect = False
		Me.LaunchersListView.Name = "LaunchersListView"
		Me.LaunchersListView.UseCompatibleStateImageBehavior = False
		Me.LaunchersListView.View = System.Windows.Forms.View.Details
		'
		'LauncherColumnHeader
		'
		resources.ApplyResources(Me.LauncherColumnHeader, "LauncherColumnHeader")
		'
		'MainDirectoryColumnHeader
		'
		resources.ApplyResources(Me.MainDirectoryColumnHeader, "MainDirectoryColumnHeader")
		'
		'GameDirectoryColumnHeader
		'
		resources.ApplyResources(Me.GameDirectoryColumnHeader, "GameDirectoryColumnHeader")
		'
		'DetectedColumnHeader
		'
		resources.ApplyResources(Me.DetectedColumnHeader, "DetectedColumnHeader")
		'
		'ExitButton
		'
		resources.ApplyResources(Me.ExitButton, "ExitButton")
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.UseVisualStyleBackColor = True
		'
		'SettingsButton
		'
		resources.ApplyResources(Me.SettingsButton, "SettingsButton")
		Me.SettingsButton.Name = "SettingsButton"
		Me.SettingsButton.UseVisualStyleBackColor = True
		'
		'ListView1
		'
		resources.ApplyResources(Me.ListView1, "ListView1")
		Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GameNameColumnHeader, Me.GameMainDirectoryColumnHeader, Me.GameUserDataDirectoryColumnHeader, Me.GameTypeColumnHeader})
		Me.ListView1.Name = "ListView1"
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.Details
		'
		'GameNameColumnHeader
		'
		resources.ApplyResources(Me.GameNameColumnHeader, "GameNameColumnHeader")
		'
		'GameMainDirectoryColumnHeader
		'
		resources.ApplyResources(Me.GameMainDirectoryColumnHeader, "GameMainDirectoryColumnHeader")
		'
		'GameUserDataDirectoryColumnHeader
		'
		resources.ApplyResources(Me.GameUserDataDirectoryColumnHeader, "GameUserDataDirectoryColumnHeader")
		'
		'GameTypeColumnHeader
		'
		resources.ApplyResources(Me.GameTypeColumnHeader, "GameTypeColumnHeader")
		'
		'DetectedGamesLabel
		'
		resources.ApplyResources(Me.DetectedGamesLabel, "DetectedGamesLabel")
		Me.DetectedGamesLabel.Name = "DetectedGamesLabel"
		'
		'AddLauncherButton
		'
		resources.ApplyResources(Me.AddLauncherButton, "AddLauncherButton")
		Me.AddLauncherButton.Name = "AddLauncherButton"
		Me.AddLauncherButton.UseVisualStyleBackColor = True
		'
		'EditLauncherButton
		'
		resources.ApplyResources(Me.EditLauncherButton, "EditLauncherButton")
		Me.EditLauncherButton.Name = "EditLauncherButton"
		Me.EditLauncherButton.UseVisualStyleBackColor = True
		'
		'RemoveLauncherButton
		'
		resources.ApplyResources(Me.RemoveLauncherButton, "RemoveLauncherButton")
		Me.RemoveLauncherButton.Name = "RemoveLauncherButton"
		Me.RemoveLauncherButton.UseVisualStyleBackColor = True
		'
		'DisableLauncherButton
		'
		resources.ApplyResources(Me.DisableLauncherButton, "DisableLauncherButton")
		Me.DisableLauncherButton.Name = "DisableLauncherButton"
		Me.DisableLauncherButton.UseVisualStyleBackColor = True
		'
		'EnableLauncherButton
		'
		resources.ApplyResources(Me.EnableLauncherButton, "EnableLauncherButton")
		Me.EnableLauncherButton.Name = "EnableLauncherButton"
		Me.EnableLauncherButton.UseVisualStyleBackColor = True
		'
		'AddGameButton
		'
		resources.ApplyResources(Me.AddGameButton, "AddGameButton")
		Me.AddGameButton.Name = "AddGameButton"
		Me.AddGameButton.UseVisualStyleBackColor = True
		'
		'EditGameButton
		'
		resources.ApplyResources(Me.EditGameButton, "EditGameButton")
		Me.EditGameButton.Name = "EditGameButton"
		Me.EditGameButton.UseVisualStyleBackColor = True
		'
		'RemoveGameButton
		'
		resources.ApplyResources(Me.RemoveGameButton, "RemoveGameButton")
		Me.RemoveGameButton.Name = "RemoveGameButton"
		Me.RemoveGameButton.UseVisualStyleBackColor = True
		'
		'DisbaleGameButton
		'
		resources.ApplyResources(Me.DisbaleGameButton, "DisbaleGameButton")
		Me.DisbaleGameButton.Name = "DisbaleGameButton"
		Me.DisbaleGameButton.UseVisualStyleBackColor = True
		'
		'EnableGameButton
		'
		resources.ApplyResources(Me.EnableGameButton, "EnableGameButton")
		Me.EnableGameButton.Name = "EnableGameButton"
		Me.EnableGameButton.UseVisualStyleBackColor = True
		'
		'DetectedLaunchersLabel
		'
		resources.ApplyResources(Me.DetectedLaunchersLabel, "DetectedLaunchersLabel")
		Me.DetectedLaunchersLabel.Name = "DetectedLaunchersLabel"
		'
		'MainWindow
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.DetectedLaunchersLabel)
		Me.Controls.Add(Me.EnableGameButton)
		Me.Controls.Add(Me.DisbaleGameButton)
		Me.Controls.Add(Me.RemoveGameButton)
		Me.Controls.Add(Me.EditGameButton)
		Me.Controls.Add(Me.AddGameButton)
		Me.Controls.Add(Me.EnableLauncherButton)
		Me.Controls.Add(Me.DisableLauncherButton)
		Me.Controls.Add(Me.RemoveLauncherButton)
		Me.Controls.Add(Me.EditLauncherButton)
		Me.Controls.Add(Me.AddLauncherButton)
		Me.Controls.Add(Me.DetectedGamesLabel)
		Me.Controls.Add(Me.ListView1)
		Me.Controls.Add(Me.SettingsButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.LaunchersListView)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "MainWindow"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LaunchersListView As System.Windows.Forms.ListView
	Friend WithEvents LauncherColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents MainDirectoryColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents GameDirectoryColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents DetectedColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents ExitButton As System.Windows.Forms.Button
	Friend WithEvents SettingsButton As System.Windows.Forms.Button
	Friend WithEvents ListView1 As System.Windows.Forms.ListView
	Friend WithEvents DetectedGamesLabel As System.Windows.Forms.Label
	Friend WithEvents AddLauncherButton As System.Windows.Forms.Button
	Friend WithEvents EditLauncherButton As System.Windows.Forms.Button
	Friend WithEvents RemoveLauncherButton As System.Windows.Forms.Button
	Friend WithEvents DisableLauncherButton As System.Windows.Forms.Button
	Friend WithEvents EnableLauncherButton As System.Windows.Forms.Button
	Friend WithEvents AddGameButton As System.Windows.Forms.Button
	Friend WithEvents EditGameButton As System.Windows.Forms.Button
	Friend WithEvents RemoveGameButton As System.Windows.Forms.Button
	Friend WithEvents DisbaleGameButton As System.Windows.Forms.Button
	Friend WithEvents EnableGameButton As System.Windows.Forms.Button
	Friend WithEvents DetectedLaunchersLabel As System.Windows.Forms.Label
	Friend WithEvents GameNameColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents GameMainDirectoryColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents GameUserDataDirectoryColumnHeader As System.Windows.Forms.ColumnHeader
	Friend WithEvents GameTypeColumnHeader As System.Windows.Forms.ColumnHeader

End Class
