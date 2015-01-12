Imports System.Xml, System.Globalization, System.Threading, System.Resources
Imports GameBackupManager.LauncherType


Public Class MainWindow
	Dim locRM As New ResourceManager("GameBackupManager.Strings", GetType(MainWindow).Assembly)
	Dim Launchers As New Dictionary(Of String, Launcher)

	Sub New()
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(My.Settings.defaultLanguage)
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(My.Settings.defaultLanguage)

		' Dieser Aufruf ist für den Designer erforderlich.
		InitializeComponent()

		' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

	End Sub

	Private Sub MainWindow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		Initialize()

		GetLaunchersXml()
		ParseLauncherContents()
		DetectLaunchers()
	End Sub

	Public Sub Initialize()
		If My.Settings.disabledLaunchers Is Nothing Then
			My.Settings.disabledLaunchers = New System.Collections.Specialized.StringCollection
		End If

		If My.Settings.disabledGames Is Nothing Then
			My.Settings.disabledGames = New System.Collections.Specialized.StringCollection
		End If
	End Sub

	Public Sub GetLaunchersXml()
		For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\" & My.Settings.launchersDirectoryName, FileIO.SearchOption.SearchTopLevelOnly, "*.xml")
			Dim reader As XmlTextReader = New XmlTextReader(foundFile)
			Dim newLauncher As New Launcher

			Do While (reader.Read())

				Select Case reader.Name
					Case "launcher"
						If reader.HasAttributes Then
							newLauncher.ID = reader.GetAttribute("id", reader.NamespaceURI)
							newLauncher.Name = reader.GetAttribute("name", reader.NamespaceURI)
							newLauncher.Publisher = reader.GetAttribute("publisher", reader.NamespaceURI)

							For Each disabledLauncher As String In My.Settings.disabledLaunchers
								If disabledLauncher = newLauncher.ID Then
									newLauncher.Disabled = True
								End If
							Next
						End If
					Case "path"
							If reader.HasAttributes Then
								Select Case reader.GetAttribute("type", reader.NamespaceURI)
									Case "default"
										If reader.HasAttributes Then
											Select Case reader.GetAttribute("name", reader.NamespaceURI)
												Case "mainDirectory"
													newLauncher.MainDirectory = reader.ReadElementContentAsString
												Case "mainExe"
													newLauncher.MainExecutable = reader.ReadElementContentAsString
												Case "gameDirectory"
													newLauncher.GameDirectory = reader.ReadElementContentAsString
												Case Else
											End Select
										End If
									Case "additional"
										If reader.HasAttributes Then
											newLauncher.AdditionalPaths.Add(reader.GetAttribute("name", reader.NamespaceURI), reader.ReadElementContentAsString)
										End If
									Case Else
								End Select
							End If
					Case "argument"
							If reader.HasAttributes Then
								Select Case reader.GetAttribute("type", reader.NamespaceURI)
									Case "start"
										If reader.HasAttributes Then
											Select Case reader.GetAttribute("standalone", reader.NamespaceURI)
												Case "true", "false"
													newLauncher.StartIsStandalone = CBool(reader.GetAttribute("standalone", reader.NamespaceURI))
												Case Else
													newLauncher.StartIsStandalone = False
											End Select
										End If

										newLauncher.StartArgument = reader.ReadElementContentAsString
									Case "shutdown"
										If reader.HasAttributes Then
											Select Case reader.GetAttribute("standalone", reader.NamespaceURI)
												Case "true", "false"
													newLauncher.ShutdownIsStandalone = CBool(reader.GetAttribute("standalone", reader.NamespaceURI))
												Case Else
													newLauncher.ShutdownIsStandalone = False
											End Select
										End If

										newLauncher.ShutdownArgument = reader.ReadElementContentAsString
									Case "launchGame"
										If reader.HasAttributes Then
											Select Case reader.GetAttribute("standalone", reader.NamespaceURI)
												Case "true", "false"
													newLauncher.LaunchGameIsStandalone = CBool(reader.GetAttribute("standalone", reader.NamespaceURI))
												Case Else
													newLauncher.LaunchGameIsStandalone = False
											End Select
										End If

										newLauncher.LaunchGameArgument = reader.ReadElementContentAsString
									Case "restoreBackup"
										If reader.HasAttributes Then
											Select Case reader.GetAttribute("standalone", reader.NamespaceURI)
												Case "true", "false"
													newLauncher.RestoreBackupIsStandalone = CBool(reader.GetAttribute("standalone", reader.NamespaceURI))
												Case Else
													newLauncher.RestoreBackupIsStandalone = False
											End Select
										End If

										newLauncher.RestoreBackupArgument = reader.ReadElementContentAsString
									Case Else
								End Select
							End If

					Case "backup"
							If reader.HasAttributes Then
								Select Case reader.GetAttribute("method", reader.NamespaceURI)
									Case "integrated"
										newLauncher.Backup = Launcher.BackupMethod.Integrated
									Case "manual"
										newLauncher.Backup = Launcher.BackupMethod.Manual
									Case Else
										newLauncher.Backup = Launcher.BackupMethod.Manual
								End Select
							End If
					Case Else
				End Select
			Loop

			Launchers.Add(newLauncher.ID, newLauncher)
		Next
	End Sub


	Public Sub ParseLauncherContents()
		For Each launcherItem As Launcher In Launchers.Values
			Dim variables As New Dictionary(Of String, String)
			variables.Add("Programs", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))

			If Environment.Is64BitOperatingSystem Then
				variables.Add("Programs-x86", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86))
			Else
				variables.Add("Programs-x86", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
			End If

			variables.Add("mainDirectory", launcherItem.MainDirectory)
			variables.Add("mainExe", launcherItem.MainExecutable)
			variables.Add("gameDirectory", launcherItem.GameDirectory)
			variables.Add("id", launcherItem.ID)
			variables.Add("name", launcherItem.Name)
			variables.Add("publisher", launcherItem.Publisher)

			For Each additionalPath As String In launcherItem.AdditionalPaths.Keys
				variables.Add("additional_" & additionalPath, launcherItem.AdditionalPaths(additionalPath))
			Next

			Dim parsedVars As Boolean = False
			Do While parsedVars = False
				parsedVars = True

				For i As Integer = 0 To variables.Values.Count - 1
					For i2 As Integer = 0 To variables.Keys.Count - 1
						If variables.Values(i).Contains("%" & variables.Keys(i2) & "%") Then
							parsedVars = False
							variables(variables.Keys(i)) = Replace(variables.Values(i), "%" & variables.Keys(i2) & "%", variables.Values(i2))
						End If
					Next
				Next
			Loop

			For Each variableItem As String In variables.Keys
				launcherItem.MainDirectory = Replace(launcherItem.MainDirectory, "%" & variableItem & "%", variables(variableItem))
				launcherItem.MainExecutable = Replace(launcherItem.MainExecutable, "%" & variableItem & "%", variables(variableItem))
				launcherItem.GameDirectory = Replace(launcherItem.GameDirectory, "%" & variableItem & "%", variables(variableItem))

				For Each additionalPath As String In launcherItem.AdditionalPaths.Keys
					If "additional_" & additionalPath <> variableItem Then
						additionalPath = Replace(additionalPath, "%" & variableItem & "%", variables(variableItem))
					End If
				Next

				launcherItem.StartArgument = Replace(launcherItem.StartArgument, "%" & variableItem & "%", variables(variableItem))
				launcherItem.ShutdownArgument = Replace(launcherItem.ShutdownArgument, "%" & variableItem & "%", variables(variableItem))
				launcherItem.LaunchGameArgument = Replace(launcherItem.LaunchGameArgument, "%" & variableItem & "%", variables(variableItem))
				launcherItem.RestoreBackupArgument = Replace(launcherItem.RestoreBackupArgument, "%" & variableItem & "%", variables(variableItem))
			Next
		Next
	End Sub

	Public Sub DetectLaunchers()
		For Each launcherItem As Launcher In Launchers.Values
			If My.Computer.FileSystem.DirectoryExists(launcherItem.MainDirectory) And My.Computer.FileSystem.FileExists(launcherItem.MainExecutable) And My.Computer.FileSystem.DirectoryExists(launcherItem.GameDirectory) Then

				launcherItem.Detected = True

				If Not launcherItem.Disabled = True Then
					With LaunchersListView.Items.Add(launcherItem.Name)
						.SubItems.Add(launcherItem.MainDirectory)
						.SubItems.Add(launcherItem.GameDirectory)
						.SubItems.Add(locRM.GetString("launcherListView_detected_yes"), Color.Green, Color.Transparent, New Font("Microsoft Sans Serif", 8.25))
					End With
				End If
			Else
				launcherItem.Detected = False

				If Not launcherItem.Disabled = True Then
					With LaunchersListView.Items.Add(launcherItem.Name)
						.SubItems.Add(launcherItem.MainDirectory)
						.SubItems.Add(launcherItem.GameDirectory)
						.SubItems.Add(locRM.GetString("launcherListView_detected_no"), Color.Red, Color.Transparent, New Font("Microsoft Sans Serif", 8.25))
					End With
				End If
			End If

			For Each launcherListViewItem As ListViewItem In LaunchersListView.Items
				launcherListViewItem.UseItemStyleForSubItems = False
			Next
		Next

		DetectedLaunchersLabel.Text = Replace(locRM.GetString("detectedLaunchersLabel"), "%count%", CStr(Launchers.Count))
	End Sub

	Private Sub SettingsButton_Click(sender As System.Object, e As System.EventArgs) Handles SettingsButton.Click
		Settings.ShowDialog()
	End Sub

	Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
		Me.Close()
	End Sub
End Class