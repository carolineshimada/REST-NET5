CREATE TABLE IF NOT EXISTS person (
	`id` bigint(20) NOT NULL AUTO_INCREMENT,
	`address` varchar(100) NOT NULL,
	`first_name` varchar(80) NOT NULL,
	`last_name` varchar(80) NOT NULL,
	`genger` varchar(6) NOT NULL,
	PRIMARY KEY(`id`)
)"   at Microsoft.Extensions.DependencyInjection.ServiceProvider..ctor(ICollection`1 serviceDescriptors, ServiceProviderOptions options)\n   at Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(IServiceCollection services, ServiceProviderOptions options)\n   at Microsoft.Extensions.Hosting.Internal.ServiceFactoryAdapter`1.CreateServiceProvider(Object containerBuilder)\n   at Microsoft.Extensions.Hosting.HostBuilder.CreateServiceProvider()\n   at Microsoft.Extensions.Hosting.HostBuilder.Build()\n   at Microsoft.AspNetCore.Builder.WebApplicationBuilder.Build()\n   at Program.<Main>$(String[] args) in /Users/carolineshimada/Documents/RESTAPI-NET5/RESTAPI-NET5/01 - RestApiNet5/RestApiNet5/RestApiNet5/Program.cs:line 15"