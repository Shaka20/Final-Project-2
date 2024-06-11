namespace AddressBookAPI.NewFolder
{
    using AddressBookAPI.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Reflection.Metadata;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<DTOs.ClientInfo> ClientInfos { get; set; }

        // Additional CRUD methods for ClientInfo

        public void AddClientInfo(DTOs.ClientInfo clientInfo)
        {
            ClientInfos.Add(clientInfo);
            SaveChanges();
        }

        public DTOs.ClientInfo GetClientInfoById(int id)
        {
            
            return ClientInfos.Find((long)id);
        }

        public void UpdateClientInfo(DTOs.ClientInfo clientInfo)
        {
            ClientInfos.Update(clientInfo);
            SaveChanges();
        }

        public bool DeleteClientInfo(int id)
        {
            var clientInfo = GetClientInfoById(id);
            if (clientInfo != null)
            {
                ClientInfos.Remove(clientInfo);
                SaveChanges();
                return true;
            }
            return false;
        }
    }
}
