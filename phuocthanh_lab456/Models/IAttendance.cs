namespace phuocthanh_lab456.Models
{
    public interface IAttendance
    {
        ApplicationUser Attendee { get; set; }
        string AttendeeId { get; set; }
        Course Course { get; set; }
        int CourseId { get; set; }
    }
}