Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class MoviesDBModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=MovieAppModel")
    End Sub


    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
