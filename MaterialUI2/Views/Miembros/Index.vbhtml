@ModelType IEnumerable(Of MaterialUI2.MaterialUI2.Miembros)
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
            <p>Nombre</p>
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.m_apellido)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.m_nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.m_apellido)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.idMiembro }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.idMiembro }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.idMiembro })
        </td>
    </tr>
Next

</table>
