using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
                        c => {
                                c.SwaggerDoc("v1", new OpenApiInfo()
                                {
                                    Title = "Gestion de Tâche",
                                    Version = "1.0.0",
                                    Description = "Documentation d'une Application de Gestion de Tâche"
                                });
                            //Ajout des fichiers Xml dans Swagger
                            string nomFichier = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                            string FichierXml = Path.Combine(AppContext.BaseDirectory, nomFichier);
                            c.IncludeXmlComments(FichierXml);
                        });

var app = builder.Build();

// Configure the HTTP request pipeline.
   app.UseSwagger();
   app.UseSwaggerUI(
           c => {
                   c.RoutePrefix = string.Empty;
                   c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); 
                }
       );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
