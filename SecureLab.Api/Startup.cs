using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using FluentValidation;
using SecureLab.Persistence;
using SecureLab.Domain.Entities;
using FluentValidation.AspNetCore;
using SecureLab.Application.Users.Commands.CreateUser;
using SecureLab.Application.Users.Commands.UpdateUser;
using Microsoft.EntityFrameworkCore;
using SecureLab.Api.Middlewares;

namespace SecureLab
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("SecureLab.Application");
            services.AddMediatR(assembly);

            services.AddDbContext<SecureLabDbContext>();
            services.AddIdentity<User, IdentityRole<Guid>>().AddEntityFrameworkStores<SecureLabDbContext>();
            services.AddMvc(op => op.EnableEndpointRouting = false).AddFluentValidation();
            services.AddHttpContextAccessor();

            services.AddTransient<IValidator<CreateUserCommand>, CreateUserCommandValidator>();
            services.AddTransient<IValidator<UpdateUserCommand>, UpdateUserCommandValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [System.Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SecureLabDbContext>();
                if (context.Database.EnsureCreated())
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    context.Database.ExecuteSqlCommand(@"ALTER DATABASE securelab COLLATE Cyrillic_General_CI_AS;");
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
