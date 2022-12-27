using Microsoft.EntityFrameworkCore;

namespace store_info.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new StoreInfoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<StoreInfoContext>>());
        if (context == null)
        {
            throw new ArgumentNullException();
        }

        context.Database.EnsureCreated();
        
        if (context.StoreInfos.Any())
        {
            return;   // DB has been seeded
            // To re-seed the db: delete the existing *.db file and let the app create a new one
        }

        context.StoreInfos.AddRange(
            new StoreInfo {
                StoreId = 1,
                StoreName = "Curry",
                Street = "Tobaw Place",
                PostalCode = "J3M 7K3",
                City = "Piduhe"
            },
            new StoreInfo {
                StoreId = 2,
                StoreName = "Weber",
                Street = "Ibiraw Street",
                PostalCode = "T1N 1F0",
                City = "Ihemota"
            },
            new StoreInfo {
                StoreId = 3,
                StoreName = "Washington",
                Street = "Uswe Pike",
                PostalCode = "A3J 0H0",
                City = "Kileete"
            },
            new StoreInfo {
                StoreId = 4,
                StoreName = "Stevenson",
                Street = "Viubo Trail",
                PostalCode = "C1W 6H6",
                City = "Nujiolu"
            },
            new StoreInfo {
                StoreId = 5,
                StoreName = "Riley",
                Street = "Zice Point",
                PostalCode = "H1H 7D4",
                City = "Mafocov"
            },
            new StoreInfo {
                StoreId = 6,
                StoreName = "Daniel",
                Street = "Ehuwi Turnpike",
                PostalCode = "J9F 9I9",
                City = "Salfema"
            },
            new StoreInfo {
                StoreId = 7,
                StoreName = "McDaniel",
                Street = "Poto Plaza",
                PostalCode = "J5S 1T1",
                City = "Diszowoj"
            },
            new StoreInfo {
                StoreId = 8,
                StoreName = "Thomas",
                Street = "Zuac Point",
                PostalCode = "A0E 9O7",
                City = "Hobivab"
            }
        );

        context.SaveChanges();
    }
}