using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Mappings;

public interface IBaseMapping<T> where T : class
{
    public void CreateBaseMapping(EntityTypeBuilder<T> entity);
}
