using Microsoft.EntityFrameworkCore;
using Prueba_tecnica.Contexto;
using Prueba_tecnica.Entidades;
using Prueba_tecnica.Entidades.Dto;
using System;
using System.Globalization;
using System.Text.Json;

namespace Prueba_tecnica.Servicio
{
    public interface IRecepcionService
    {
        Task<Recepcion> ProcesarRecepcionAsync(RecepcionDto request);
    }
    public class RecepcionService : IRecepcionService
    {
        private readonly AppDbContext _context;
        private readonly IHttpClientFactory _httpClientFactory;

        public RecepcionService(AppDbContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Recepcion> ProcesarRecepcionAsync(RecepcionDto request)
        {


            throw new NotImplementedException("Error");

        }
    }
}
