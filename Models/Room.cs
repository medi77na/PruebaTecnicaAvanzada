using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models;

[Table("rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_number")]
    public string? RoomNumber { get; set; }

    [Column("room_type_id")]
    public int RoomTypeId { get; set; }

    [Column("price_per_night")]
    public double PricePerNight { get; set; }

    [Column("availability")]
    public bool Availability { get; set; }
    
    [Column("max_occupancy_persons")]
    public int MaxOccupancyPersons { get; set; }

    [ForeignKey(nameof(RoomTypeId))]
    public RoomType? RoomType { get; set; }
}