﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using BookAPI.Data;
using BookAPI.Interface;
using BookAPI.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using NSwag.AspNetCore;
using NJsonSchema;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Swashbuckle.AspNetCore.Swagger;
using BookAPI.Entities;
using Microsoft.AspNetCore.Identity;
using BookAPI.Interfaces;

namespace BookAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();

            var connection = Configuration.GetConnectionString("Book");

            var appSettings = Configuration.GetSection("AppSettings:Secret").Value;
            var key = Encoding.ASCII.GetBytes(appSettings);

            services.AddDbContext<BookApiDataContext>(options => options.UseSqlServer(connection));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "V1",
                    Title = "Book API",
                    Description = "Book application API",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact
                    {
                        Name = "Steph Goddy",
                        Email = "efuayegodwin@gmail.com",
                        Url = "cyberinterns.slack.com"
                    },
                });

                c.AddSecurityDefinition("Oauth2", new ApiKeyScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example:\"bearer {token}",
                    In = "Header",
                    Name = "Authorization",
                    Type = "apiKey"
                });


               // c.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            services.AddIdentity<ApplicationUser, ApplicationRole>()
               .AddUserManager<UserManager<ApplicationUser>>()
               .AddRoleManager<RoleManager<ApplicationRole>>()
               .AddSignInManager<SignInManager<ApplicationUser>>()
               .AddEntityFrameworkStores<BookApiDataContext>();


            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
          .AddJwtBearer(x =>
          {
              x.RequireHttpsMetadata = false;
              x.SaveToken = true;
              x.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuerSigningKey = true,
                  IssuerSigningKey = new SymmetricSecurityKey(key),
                  ValidateIssuer = false,
                  ValidateAudience = false
              };
          });


            services.AddScoped<IAuthor, AuthorService>();
            services.AddScoped<IBook, BookService>();
            services.AddScoped<ICategory, CategoryService>();
            services.AddScoped<IGenre, GenreService>();
            services.AddScoped<IPublisher, PublisherService>();
            services.AddScoped<IReader, ReaderService>();
            services.AddScoped<IUser, UserService>();
            services.AddScoped<IAccount, AccountService>();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();
            // Enable the Swagger UI middleware and the Swagger generator
            //app.UseSwaggerUI();
            app.UseSwaggerUi3(typeof(Startup).GetTypeInfo().Assembly, settings =>
            {
                settings.GeneratorSettings.DefaultPropertyNameHandling = PropertyNameHandling.CamelCase;


            });


            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
