using AutoMapper;
using Investment.Core.Dtos.User;
using Investment.Core.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace Investment.Infra.Settings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            var types = Assembly.GetAssembly(typeof(CreateUserDto)).GetExportedTypes();

            var maps = (
                    from type in types
                    from instance in type.GetInterfaces()
                    where
                        typeof(IMapping).IsAssignableFrom(type) &&
                        !type.IsAbstract &&
                        !type.IsInterface
                    select (IMapping)Activator.CreateInstance(type)).ToList();

            foreach (var map in maps)
            {
                map.CreateMappings(this);
            }
        }
    }
}
