﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using AyAPrueba.DATOS;

namespace AyAPrueba.UI.App_Start
{
    public class ItemsConfig
    {
        public static List<MaterialPedido> ListaItems = new List<DATOS.MaterialPedido>();
        public static void CrearProductos()
        {
            ListaItems = new List<DATOS.MaterialPedido>
            {
                new MaterialPedido
                {
                    id_pedido =5,
                    codigo_mat = "CodigoGenerado1",
                    cantidad = 2
                },
                new MaterialPedido
                {
                    id_pedido =5,
                    codigo_mat = "CodigoGenerado2",
                    cantidad = 5
                }
            };
        }
    }
}