Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports MaterialUI2.MaterialUI2

Namespace Controllers
    Public Class MiembrosController
        Inherits System.Web.Mvc.Controller

        Private db As New ContactosEntities

        ' GET: Miembros
        Function Index() As ActionResult
            Return View(db.Miembros.ToList())
        End Function

        ' GET: Miembros/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim miembros As Miembros = db.Miembros.Find(id)
            If IsNothing(miembros) Then
                Return HttpNotFound()
            End If
            Return View(miembros)
        End Function

        ' GET: Miembros/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Miembros/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="idMiembro,m_nombre,m_apellido")> ByVal miembros As Miembros) As ActionResult
            If ModelState.IsValid Then
                db.Miembros.Add(miembros)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(miembros)
        End Function

        ' GET: Miembros/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim miembros As Miembros = db.Miembros.Find(id)
            If IsNothing(miembros) Then
                Return HttpNotFound()
            End If
            Return View(miembros)
        End Function

        ' POST: Miembros/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="idMiembro,m_nombre,m_apellido")> ByVal miembros As Miembros) As ActionResult
            If ModelState.IsValid Then
                db.Entry(miembros).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(miembros)
        End Function

        ' GET: Miembros/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim miembros As Miembros = db.Miembros.Find(id)
            If IsNothing(miembros) Then
                Return HttpNotFound()
            End If
            Return View(miembros)
        End Function

        ' POST: Miembros/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim miembros As Miembros = db.Miembros.Find(id)
            db.Miembros.Remove(miembros)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
