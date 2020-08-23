﻿using System;
using Devboost.DroneDelivery.Domain.Enums;

namespace Devboost.DroneDelivery.Domain.Entities
{
    public class PedidoEntity
    {
        public Guid Id { get; set; }
        public int PesoGramas {get; set;}
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime? DataHora { get; set; }
        public PedidoStatus Status { get; set; }
        public DroneEntity Drone { get; set; }
        public Guid DroneId { get; set; }
        public readonly double DistanciaMaxima = 17;
        public readonly int PesoGamasMaximo = 12000;

        public bool ValidaPedido(double distanciaKm)
        {
            return distanciaKm <= DistanciaMaxima && PesoGramas <= PesoGamasMaximo;
        }
    }
}