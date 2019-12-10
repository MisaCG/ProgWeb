<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">

    
</head>
<body>

    <!-- Compiled and minified JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>

    <nav>
        <div class="nav-wrapper">
            <div class="container">
                <a href="https://localhost:44308/" class="navbar-brand" id="name">Gestionador de visitas</a>
                <ul id="nav-mobile" class="right hide-on-med-and-down">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Miembros", "Index", "Miembros")</li>
                    <li>@Html.ActionLink("Visitas", "Index", "Visitas")</li>
            </ul>
             </div>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>

<footer class="page-footer">
    <div class="container">
        <div class="row">
            <div class="col l6 s12">
                <h5 class="white-text">Programacion Web - Examen Final</h5>
                <p class="grey-text text-lighten-4">Aplicacion ASP.NET desarrollada por Misael Cortes - 2018-6348</p>
            </div>
            <div class="col l4 offset-l2 s12">
           
            </div>
        </div>
    </div>
    <div class="footer-copyright">
        <div class="container">
            © 2020 Copyright - Misael Cortes
        </div>
    </div>
</footer>
</html>
