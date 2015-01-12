Namespace LauncherType
	Public Class Launcher
		Public Enum BackupMethod
			Integrated = 0
			Manual = 1
		End Enum

		Property ID As String = String.Empty
		Property Name As String = String.Empty
		Property Publisher As String = String.Empty
		Property Disabled As Boolean = False
		Property Detected As Boolean = False
		Property Backup As BackupMethod = Nothing

		Property MainDirectory As String = String.Empty
		Property MainExecutable As String = String.Empty
		Property GameDirectory As String = String.Empty
		Property AdditionalPaths As New Dictionary(Of String, String)

		Property StartArgument As String = String.Empty
		Property ShutdownArgument As String = String.Empty
		Property LaunchGameArgument As String = String.Empty
		Property RestoreBackupArgument As String = String.Empty

		Property StartIsStandalone As Boolean = False
		Property ShutdownIsStandalone As Boolean = False
		Property LaunchGameIsStandalone As Boolean = False
		Property RestoreBackupIsStandalone As Boolean = False

		Sub New()
			ClearData()
		End Sub

		Public Sub ClearData()
			ID = String.Empty
			Name = String.Empty
			Publisher = String.Empty
			Disabled = False
			Detected = False
			Backup = Nothing

			MainDirectory = String.Empty
			MainExecutable = String.Empty
			GameDirectory = String.Empty
			AdditionalPaths = New Dictionary(Of String, String)

			StartArgument = String.Empty
			ShutdownArgument = String.Empty
			LaunchGameArgument = String.Empty
			RestoreBackupArgument = String.Empty

			StartIsStandalone = False
			ShutdownIsStandalone = False
			LaunchGameIsStandalone = False
			RestoreBackupIsStandalone = False
		End Sub
	End Class
End Namespace