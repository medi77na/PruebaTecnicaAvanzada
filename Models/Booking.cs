using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models;

[Table("bookings")]
public class Booking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_id")]
    public int RoomId { get; set; }

    [Column("guest_id")]
    public int GuestId { get; set; }

    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Column("start_date")]
    public DateOnly StartDate { get; set; }

    [Column("end_date")]
    public DateOnly EndDate { get; set; }

    [Column("total_cost")]
    public double TotalCost { get; set; }

    [ForeignKey(nameof(RoomId))]
    public Room? Room { get; set; }

    [ForeignKey(nameof(GuestId))]
    public Guest? Guest { get; set; }

    [ForeignKey(nameof(EmployeeId))]
    public Employee? Employee { get; set; }
}