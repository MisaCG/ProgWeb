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
    Public Class VisitasController
        Inherits System.Web.Mvc.Controller

        Private db As New ContactosEntities

        ' GET: Visitas
        Function Index() As ActionResult
            Dim visitas = db.Visitas.Include(Function(v) v.Miembros)
            Return View(visitas.ToList())
        End Function

        ' GET: Visitas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim visitas As Visitas = db.Visitas.Find(id)
            If IsNothing(visitas) Then
                Return HttpNotFound()
            End If
            Return View(visitas)
        End Function

        ' GET: Visitas/Create
        Function Create() As ActionResult
            ViewBag.idMiembro = New SelectList(db.Miembros, "idMiembro", "m_nombre")
            Return View()
        End Function

        ' POST: Visitas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="idVisita,motivo_visita,nombre_completo,h_entrada,h_salida,m_recibio,idMiembro")> ByVal visitas As Visitas) As ActionResult
            If ModelState.IsValid Then
                db.Visitas.Add(visitas)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.idMiembro = New SelectList(db.Miembros, "idMiembro", "m_nombre", visitas.idMiembro)
            Return View(visitas)
        End Function

        ' GET: Visitas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim visitas As Visitas = db.Visitas.Find(id)
            If IsNothing(visitas) Then
                Return HttpNotFound()
            End If
            ViewBag.idMiembro = New SelectList(db.Miembros, "idMiembro", "m_nombre", visitas.idMiembro)
            Return View(visitas)
        End Function

        ' POST: Visitas/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="idVisita,motivo_visita,nombre_completo,h_entrada,h_salida,m_recibio,idMiembro")> ByVal visitas As Visitas) As ActionResult
            If ModelState.IsValid Then
                db.Entry(visitas).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.idMiembro = New SelectList(db.Miembros, "idMiembro", "m_nombre", visitas.idMiembro)
            Return View(visitas)
        End Function

        ' GET: Visitas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim visitas As Visitas = db.Visitas.Find(id)
            If IsNothing(visitas) Then
                Return HttpNotFound()
            End If
            Return View(visitas)
        End Function

        ' POST: Visitas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim visitas As Visitas = db.Visitas.Find(id)
            db.Visitas.Remove(visitas)
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
