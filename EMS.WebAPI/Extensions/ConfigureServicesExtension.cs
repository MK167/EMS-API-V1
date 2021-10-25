using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using AutoMapper;
using EMS.Services.AutoMapperConigration;
using EMS.DataAcess.Context;
using EMS.DataAcess.UnitOfWork;
using EMS.Services.Interfaces;
using EMS.Services.Services;

namespace EMS.WebAPI.Extensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors();
            services.DataBaseConfig(configuration);
            services.AddAutoMapper(Assembly.GetAssembly(typeof(MappConfig)));
            services.SwaggerConfig(configuration);
            services.SendMail(configuration);
            services.InjectUnitOfWork();
            services.InjectServices();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            return services;
        }

        private static void SendMail(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<SmtpClient>((serviceProvider) =>
            {
                var config = serviceProvider.GetRequiredService<IConfiguration>();
                return new SmtpClient()
                {
                    Host = config.GetValue<String>("Email:Smtp:Host"),
                    Port = config.GetValue<int>("Email:Smtp:Port"),
                    Credentials = new NetworkCredential(
                            config.GetValue<String>("Email:Smtp:Username"),
                            config.GetValue<String>("Email:Smtp:Password")
                        )
                };
            });
        }

        private static void DataBaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("EMSContext");
            services.AddDbContext<EMSContext>(options => options.UseSqlServer(connection));

            services.AddScoped<DbContext, EMSContext>();
        }
        private static void SwaggerConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                string title = configuration["SwaggerConfig:Title"];
                string version = configuration["SwaggerConfig:Version"];
                string docPath = configuration["SwaggerConfig:DocPath"];
                options.SwaggerDoc(version, new Info { Title = title, Version = version });
                options.DescribeAllEnumsAsStrings();
            });
        }
        private static void InjectUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
        private static void InjectServices(this IServiceCollection services)
        {

            services.AddTransient<IEventAttendanceService, EventAttendanceService>();
            services.AddTransient<IEventCategoryService, EventCategoryService>();
            services.AddTransient<IEventDetailsService, EventDetailsService>();
            services.AddTransient<IEventStatusService, EventStatusService>();
            services.AddTransient<IEventVenueService, EventVenueService>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<INationalityService, NationalityService>();
            services.AddTransient<IOrganizerService, OrganizerService>();
            services.AddTransient<IUniversityService, UniversityService>();
            services.AddTransient<IUserAdminService, UserAdminService>();
            services.AddTransient<IUserAttendService, UserAttendService>();
            services.AddTransient<IUserImageService, UserImageService>();
            services.AddTransient<IUserTypeService, UserTypeService>();

        }
    }
}
