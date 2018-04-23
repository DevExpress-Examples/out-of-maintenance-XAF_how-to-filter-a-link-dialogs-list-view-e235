Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace HowToFilterListViewInLinkDialog.Win
   Partial Public Class HowToFilterListViewInLinkDialogWindowsFormsApplication
	   Inherits WinApplication
	  Public Sub New()
		 InitializeComponent()
	  End Sub

	  Private Sub HowToFilterListViewInLinkDialogWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
		 If System.Diagnostics.Debugger.IsAttached Then
			e.Updater.Update()
			e.Handled = True
		 Else
			Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & "The automatical update is disabled, because the application was started without debugging." & Constants.vbCrLf & "You should start the application under Visual Studio, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database with the help of the 'DBUpdater' tool.")
		 End If
	  End Sub
   End Class
End Namespace
