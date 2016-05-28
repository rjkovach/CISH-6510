using System;
using Microsoft.EntityFrameworkCore;

namespace CISH6510.AddressBook.Models.Configuration
{
	public static class ConfigurationExtensions
	{
        public static ModelBuilder AddConfiguration<TEntity, TConfiguration>(this ModelBuilder modelBuilder) where TEntity : class where TConfiguration : IEntityConfiguration<TEntity>, new()
		{
			if (modelBuilder == null)
				throw new ArgumentNullException(nameof(modelBuilder));
			
			var configuration = new TConfiguration();
			var entity = modelBuilder.Entity<TEntity>();
			
			configuration.Configure(entity);
			
			return modelBuilder;
		}
    }
}