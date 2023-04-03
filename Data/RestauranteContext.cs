﻿using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Data;

    public class RestauranteContext : DbContext
    {

    public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
    {
        
    }



    public DbSet<Pedido> Pedidos { get; set; }

        
       





    }

