using Microsoft.AspNetCore.Mvc;

namespace tuan4.Controllers
{
    public class FollowingsController : Controller
    {
        public readonly ApplicationDbContext dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
    public IHttpActionResult Follow(Followingdto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Following.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var folowing = new Following
            {
                Follower = userId,
                Follower = followingDto.FolloweeId
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
