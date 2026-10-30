namespace ZombieParty.Models.Data
{
    public interface IZombiePartyDbContextSeed1
    {
        Task SeedAsync(int retry = 0);
    }
}