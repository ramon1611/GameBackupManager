Imports System.Xml, System.Globalization, System.Threading, System.Resources
Imports GameBackupManager.LauncherType

Public Class Settings
	Dim locRM As New ResourceManager("GameBackupManager.Strings", GetType(MainWindow).Assembly)
	Dim availableLanguages As New List(Of Integer)

	Sub New()
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(My.Settings.defaultLanguage)
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(My.Settings.defaultLanguage)

		' Dieser Aufruf ist für den Designer erforderlich.
		InitializeComponent()

		' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

	End Sub

	Private Sub Settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		availableLanguages.Add(1031)
		availableLanguages.Add(1033)

		loadLanguageComboBox()
	End Sub

	Private Sub ApplyConfigButton_Click(sender As System.Object, e As System.EventArgs) Handles ApplyConfigButton.Click
		My.Settings.Save()
		My.Settings.Reload()
		reloadLocalization()
	End Sub

	Private Sub CancelConfigButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelConfigButton.Click
		My.Settings.Reload()
		Me.Close()
	End Sub

	Private Sub OkConfigButton_Click(sender As System.Object, e As System.EventArgs) Handles OkConfigButton.Click
		My.Settings.Save()
		My.Settings.Reload()
		reloadLocalization()
		Me.Close()
	End Sub

	Private Sub LanguageComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LanguageComboBox.SelectedIndexChanged
		My.Settings.defaultLanguage = CultureInfo.GetCultureInfo(LanguageComboBox.SelectedItem.ToString).LCID
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(LanguageComboBox.SelectedItem.ToString)
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(LanguageComboBox.SelectedItem.ToString)
	End Sub

	Public Sub loadLanguageComboBox()
		LanguageComboBox.Items.Clear()

		For Each languageItem As Integer In availableLanguages
			LanguageComboBox.Items.Add(CultureInfo.GetCultureInfo(languageItem).DisplayName)
		Next

		LanguageComboBox.SelectedItem = CultureInfo.GetCultureInfo(My.Settings.defaultLanguage).DisplayName
	End Sub

	Public Sub reloadLocalization()
		If MessageBox.Show(locRM.GetString("localizationReloadMessage"), locRM.GetString("localizationReloadMessage_caption"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
			Application.Restart()
		End If
	End Sub
End Class