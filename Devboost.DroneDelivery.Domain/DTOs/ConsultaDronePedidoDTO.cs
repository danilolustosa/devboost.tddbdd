﻿using System;
using System.Collections.Generic;

namespace Devboost.DroneDelivery.Domain.DTOs
{
    public class ConsultaDronePedidoDTO
    {
        public Guid IdDrone { get; set; }
        public string Situacao { get; set; }        
        public Guid? PedidoId { get; set; }
    }
}