namespace FlowerShop.Models.Cores
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
