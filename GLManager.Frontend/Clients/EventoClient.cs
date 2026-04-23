using System;
using GLManager.Frontend.Models;

namespace GLManager.Frontend.Clients;

public class EventoClient
{
     private readonly List<Evento> eventos = new List<Evento>
    {
        new Evento(1,"Evento A", DateOnly.FromDateTime(DateTime.Now).AddDays(5)),
        new Evento(2,"Evento B", DateOnly.FromDateTime(DateTime.Now).AddDays(10)),
        new Evento(3,"Evento C", DateOnly.FromDateTime(DateTime.Now).AddDays(15)),
        new Evento(4,"Evento D", DateOnly.FromDateTime(DateTime.Now).AddDays(20)),
        new Evento(5,"Evento E", DateOnly.FromDateTime(DateTime.Now).AddDays(25)),
    };

    public Evento[] getEventos()
    {
        return eventos.ToArray();
    }
}
