namespace McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Adapters;

public interface IAdapter<out Adaptee, in Adapter> where Adaptee : class where Adapter : class
{
    public abstract Adaptee Adapt(Adapter adapter);
}
