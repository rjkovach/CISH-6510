using Microsoft.EntityFrameworkCore.Metadata.Builders;

public interface IEntityConfiguration<TEntity> where TEntity : class
{
	void Configure(EntityTypeBuilder<TEntity> entity);
}