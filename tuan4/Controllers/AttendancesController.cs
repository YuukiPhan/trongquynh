using Microsoft.AspNetCore.Mvc;

namespace tuan4.Controllers
{
    public IHttpActionResult Attend (AttendanceDto attendanceDto)
    {
        var userId = User.Identity.GetUserId();
        if (_dbcontext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            return BadReques("The Attendance already exists");

        var attendance = new Attendance
        {
            CourseId = attendanceDto.CourseId,
            AttendeeId = userId
        };
        _dbcontext.Attendances.Add(attendance);
        _dbcontext.SaveChanges();
        return OK();
    }
}
