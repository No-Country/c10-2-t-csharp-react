using System;
using System.Collections.Generic;
using System.IO;
using Core.Entities;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        

        public static async Task SeedAsync(KeyZoneContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.RequisitosMin.Any())
                {
                    var requisitosMinData = File.ReadAllText("../Infrastructure/Data/SeedData/requisitosMin.json");
                    var requisitosMin = JsonSerializer.Deserialize<List<RequisitosMin>>(requisitosMinData);

                    foreach (var requisito in requisitosMin)
                    {
                        context.RequisitosMin.Add(requisito);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.RequisitosRec.Any())
                {
                    var requisitosRecData = File.ReadAllText("../Infrastructure/Data/SeedData/requisitosMin.json");
                    var requisitosRec = JsonSerializer.Deserialize<List<RequisitosRec>>(requisitosRecData);

                    foreach (var requisito in requisitosRec)
                    {
                        context.RequisitosRec.Add(requisito);
                    }

                    await context.SaveChangesAsync();
                }
                if (!context.Juegos.Any())
                {
                    var juegosData = File.ReadAllText("../Infrastructure/Data/SeedData/juegos.json");
                    var juegos =  JsonSerializer.Deserialize<List<Juego>>(juegosData);

                    foreach (var juego in juegos)
                    {
                        context.Juegos.Add(juego); 
                    }

                    await context.SaveChangesAsync();   
                }
            }
            catch (Exception ex) {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
