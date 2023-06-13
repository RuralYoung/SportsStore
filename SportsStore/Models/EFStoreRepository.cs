namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository 
    {
        private StoreDbContext context;

        // TODO: Figure out more of what this does/the intention behind it.
        public EFStoreRepository(StoreDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
