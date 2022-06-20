﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="BookMastersDB")>  _
Partial Public Class UserLogTimeDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertUserLogTime(instance As UserLogTime)
    End Sub
  Partial Private Sub UpdateUserLogTime(instance As UserLogTime)
    End Sub
  Partial Private Sub DeleteUserLogTime(instance As UserLogTime)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.BookMasters.My.MySettings.Default.BookMastersDBConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property UserLogTimes() As System.Data.Linq.Table(Of UserLogTime)
		Get
			Return Me.GetTable(Of UserLogTime)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.UserLogTime")>  _
Partial Public Class UserLogTime
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _logID As String
	
	Private _loginTime As Date
	
	Private _logoutTime As Date
	
	Private _staffID As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnlogIDChanging(value As String)
    End Sub
    Partial Private Sub OnlogIDChanged()
    End Sub
    Partial Private Sub OnloginTimeChanging(value As Date)
    End Sub
    Partial Private Sub OnloginTimeChanged()
    End Sub
    Partial Private Sub OnlogoutTimeChanging(value As Date)
    End Sub
    Partial Private Sub OnlogoutTimeChanged()
    End Sub
    Partial Private Sub OnstaffIDChanging(value As String)
    End Sub
    Partial Private Sub OnstaffIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logID", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property logID() As String
		Get
			Return Me._logID
		End Get
		Set
			If (String.Equals(Me._logID, value) = false) Then
				Me.OnlogIDChanging(value)
				Me.SendPropertyChanging
				Me._logID = value
				Me.SendPropertyChanged("logID")
				Me.OnlogIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_loginTime", DbType:="DateTime NOT NULL")>  _
	Public Property loginTime() As Date
		Get
			Return Me._loginTime
		End Get
		Set
			If ((Me._loginTime = value)  _
						= false) Then
				Me.OnloginTimeChanging(value)
				Me.SendPropertyChanging
				Me._loginTime = value
				Me.SendPropertyChanged("loginTime")
				Me.OnloginTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logoutTime", DbType:="DateTime NOT NULL")>  _
	Public Property logoutTime() As Date
		Get
			Return Me._logoutTime
		End Get
		Set
			If ((Me._logoutTime = value)  _
						= false) Then
				Me.OnlogoutTimeChanging(value)
				Me.SendPropertyChanging
				Me._logoutTime = value
				Me.SendPropertyChanged("logoutTime")
				Me.OnlogoutTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_staffID", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property staffID() As String
		Get
			Return Me._staffID
		End Get
		Set
			If (String.Equals(Me._staffID, value) = false) Then
				Me.OnstaffIDChanging(value)
				Me.SendPropertyChanging
				Me._staffID = value
				Me.SendPropertyChanged("staffID")
				Me.OnstaffIDChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class