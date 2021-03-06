﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proyectoint.Models;
using Proyectoint.Data;

namespace Proyectoint
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddDbContext<Proyecto_integradorContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PersonaContext")));

            services.AddDbContext<PersonaContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("PersonaContext")));

            services.AddDbContext<UsuariosContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("UsuariosContext")));

            services.AddDbContext<CandidatoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CandidatoContext")));

            services.AddDbContext<EmpresaContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("EmpresaContext")));

            //services.AddDbContext<Historial1Context>(options =>
                   // options.UseSqlServer(Configuration.GetConnectionString("Historial1Context")));

            services.AddDbContext<LaboralContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("LaboralContext")));

            services.AddDbContext<CandiContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CandiContext")));

        }

       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
