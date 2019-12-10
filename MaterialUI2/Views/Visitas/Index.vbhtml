@ModelType IEnumerable(Of MaterialUI2.MaterialUI2.Visitas)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.motivo_visita)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombre_completo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.h_entrada)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.h_salida)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.m_recibio)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Miembros.m_nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.motivo_visita)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre_completo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.h_entrada)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.h_salida)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.m_recibio)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Miembros.m_nombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.idVisita }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.idVisita }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.idVisita })
        </td>
    </tr>
Next

</table>
