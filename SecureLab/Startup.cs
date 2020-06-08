using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using MediatR;
using FluentValidation.AspNetCore;
using SecureLab.Application.Users.Commands.CreateUser;
using FluentValidation;

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
            services.AddMvc( op => op.EnableEndpointRouting = false).AddFluentValidation();
            services.AddHttpContextAccessor();

            services.AddTransient<IValidator<CreateUserCommand>, CreateUserCommandValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [System.Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SecureLabDbContext>();
                context.Database.EnsureCreated();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc();
            
        }
    }
}
