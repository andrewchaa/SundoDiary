﻿using System.Web.Hosting;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SundoDiary.Domain;
using SundoDiary.Domain.Repositories;

namespace SundoDiary.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<DataPageParser, IParse<DataPage>>());
            container.Register(
                Component.For<ContentRepository, IRepository<DataPage>>()
                .DependsOn(new { contentDirectory = HostingEnvironment.MapPath("/Content/Html")})
            );

            container.Register(
                Component.For<ContentLinkRepository, IRepository<ContentLink>>()
                .DependsOn(new {contentDirectory = HostingEnvironment.MapPath("/Content/json")})
            );
        }
    }
}