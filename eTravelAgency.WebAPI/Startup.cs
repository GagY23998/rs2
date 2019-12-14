using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Helpers;
using eTravelAgency.DataLayer.Interfaces;
using eTravelAgency.DataLayer.Services;
using eTravelAgency.Model.Helpers;
using eTravelAgency.WebAPI.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using eTravelAgency.WebAPI.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace eTravelAgency.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
            {
                {"basic",new string[]{ } }
            };
            swaggerDoc.Security = new[] { securityRequirements };
        }
    }



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
            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddDbContext<eTravelContext>(options => 
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=eTravel;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddAutoMapper();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoomTypeService, RoomTypeService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IHotelOfferService, HotelOfferService>();
            services.AddScoped<IHotelRoomsService, HotelRoomsService>();
            services.AddScoped<ITransportTypeService, TransportTypeService>();
            services.AddScoped<ITransportCompanyService, TransportCompanyService>();
            services.AddScoped<ICountryFavoritesService, CountryFavoritesService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IAttractionService, AttractionService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICountryFavoritesService, CountryFavoritesService>();
            services.AddScoped<ITransportOfferService, TransportOfferService>();
   
            
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "eTravel API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() {Type="basic"});
                c.DocumentFilter<BasicAuthDocumentFilter>();
                });
            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,eTravelContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for  production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseMvc();
            DatabaseSeed.SeedDatabase(context);
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));

        }
    }
}
