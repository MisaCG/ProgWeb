@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>Examen Final - Programación Web</h1>
    <p class="lead">En este proyecto implementamos herramientas de Material UI para crear un diseño agradable y facil de modificar.</p> 
</div>

<div class="row">
    <div class="col-md-4">
        <h2>@Html.ActionLink("Miembros", "Index", "Miembros")</h2>
        <p>
            Aca puede encontrar los miembros que frecuentan en este lugar, agregar miembros y editarlos.
        </p>        
    </div>
    <div class="col-md-4">
        <h2>@Html.ActionLink("Visitas", "Index", "Visitas")</h2>
        <p>Aca puede registrar las visitas al lugar</p>
    </div>
</div>
