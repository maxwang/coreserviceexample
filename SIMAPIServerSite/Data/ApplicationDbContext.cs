using Microsoft.EntityFrameworkCore;
using SIMAPIServerSite.Models;

namespace SIMAPIServerSite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CmsSettings> CmsSettings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeviceAllocation> DeviceAllocations { get; set; }
        public DbSet<DeviceConfiguration> DeviceConfigurations { get; set; }

        public DbSet<DeviceSimAllocation> DeviceSimAllocations { get; set; }
        public DbSet<PollingPlan> PollingPlan { get; set; }
        public DbSet<RequestFeature> RequestFeatures { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<FeatureValueType> FeatureValueTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}