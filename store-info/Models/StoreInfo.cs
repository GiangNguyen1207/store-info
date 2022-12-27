using System.ComponentModel.DataAnnotations;

namespace store_info.Models;

public class StoreInfo
{
    [Key]
    public int StoreId { get; set; }
    public string StoreName { get; set; }
    public string Street { get; set; }        
    public string PostalCode { get; set; }
    public string City { get; set; }
}