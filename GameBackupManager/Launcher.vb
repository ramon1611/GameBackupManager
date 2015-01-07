Namespace LauncherType
	Public Class Launcher
		Public Enum BackupMethod
			Integrated = 0
			Manual = 1
		End Enum

		Property ID As String
		Property Name As String
		Property Publisher As String
		Property Disabled As Boolean
		Property Detected As Boolean
		Property Backup As BackupMethod

		Property MainDirectory As String
		Property MainExecutable As String
		Property GameDirectory As String
		Property AdditionalPaths As Dictionary(Of String, String)

		Property StartArgument As String
		Property ShutdownArgument As String
		Property LaunchGameArgument As String
		Property RestoreBackupArgument As String

		Property StartIsStandalone As Boolean
		Property ShutdownIsStandalone As Boolean
		Property LaunchGameIsStandalone As Boolean
		Property RestoreBackupIsStandalone As Boolean

		Sub New()
			ClearData()
		End Sub

		Public Sub ClearData()
			ID = String.Empty
			Name = String.Empty
			Publisher = String.Empty
			Disabled = Nothing
			Detected = Nothing

			MainDirectory = String.Empty
			MainExecutable = String.Empty
			GameDirectory = String.Empty
			AdditionalPaths = New Dictionary(Of String, String)

			StartArgument = String.Empty
			ShutdownArgument = String.Empty
			LaunchGameArgument = String.Empty
			RestoreBackupArgument = String.Empty

			StartIsStandalone = Nothing
			ShutdownIsStandalone = Nothing
			LaunchGameIsStandalone = Nothing
			RestoreBackupIsStandalone = Nothing
		End Sub
	End Class
End Namespace