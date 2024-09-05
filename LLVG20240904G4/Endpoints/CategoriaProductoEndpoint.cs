﻿using Microsoft.AspNetCore.Authorization;

namespace LLVG20240904G4.Endpoints
{
    public static class CategoriaProductoEndpoint
    {
        // Lista estática en memoria para almacenar las categorías de productos
        static List<object> categorias = new List<object>();

        public static void AddCategoriaProductoEndpoints(this WebApplication app)
        {
            // Endpoint público para obtener todas las categorías de productos
            app.MapGet("/categorias", () =>
            {
                return Results.Ok(categorias);
            });

            // Endpoint privado para registrar una nueva categoría
            app.MapPost("/categorias", [Authorize] (Guid id, string nuevaCategoria) =>
            {
                // Agrega la nueva categoría con el ID proporcionado por el usuario
                categorias.Add(new { Id = id, Nombre = nuevaCategoria });
                return Results.Ok("Categoría registrada exitosamente.");
            }).RequireAuthorization();
        }
    }
}


