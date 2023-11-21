using EventLib;

namespace EventLib.Repo
{
    public class EventRepo
    {
        private readonly IDbContext _context;
        public EventRepo(IDbContext context)
        {
            _context = context;
        }
        public User? Login(string username, string password)
        {
            try
            {
                var user = _context.User.AsQueryable().FirstOrDefault(x=>x.Username==username&&x.Password==password);
                return user;
            }catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public User? SignUp(string username, string password)
        {
            try
            {
                var user = _context.User.AsQueryable().FirstOrDefault(x => x.Username == username && x.Password == password);
                if(user!=null) 
                {
                    return null;
                }
                var response=_context.User.Add(new User() { Username=username,Password=password});
                _context.SaveChanges();
                return response.Entity;
            } catch (Exception ex) 
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public User? UpdateProfile(User newUser)
        {
            try
            {
                var user = _context.User.Update(newUser);
                _context.SaveChanges();
                return user.Entity;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public bool CreateEvent(Event eventReq)
        {
            try 
            {
                var response = _context.Event.Add(eventReq);
                _context.SaveChanges();
                return response.Entity!=null;
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public List<Event> ReadEvent()
        {
            try
            {
                return _context.Event.AsQueryable()
                    .Select(x=>new Event()
                {
                    EventId = x.EventId,
                    UserId  = x.UserId,
                    EventName = x.EventName,
                    EventLogo = x.EventLogo,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Location = x.Location,
                    CategoryNum = x.CategoryNum,
                    LikedCount = _context.EventLikes.AsQueryable().Where(el => el.EventId == x.EventId).Count(),
                    Comments = _context.EventComments.AsQueryable().Where(em => em.EventId == x.EventId).ToList(),
                    CreateOn =x.CreateOn,
                    UpdateOn = x.UpdateOn,
                }).ToList();
            }catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public List<Event> ReadEventByDate(DateTime dateTime)
        {
            try
            {
                return _context.Event.AsQueryable()
                    .Where(x=>x.StartDate<=dateTime&&x.EndDate>=dateTime)
                    .Select(x => new Event()
                {
                    EventId = x.EventId,
                    UserId = x.UserId,
                    EventName = x.EventName,
                    EventLogo = x.EventLogo,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Location = x.Location,
                    CategoryNum = x.CategoryNum,
                    LikedCount = _context.EventLikes.AsQueryable().Where(el => el.EventId == x.EventId).Count(),
                    Comments = _context.EventComments.AsQueryable().Where(em => em.EventId == x.EventId).ToList(),
                    CreateOn = x.CreateOn,
                    UpdateOn = x.UpdateOn,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public List<Event> ReadEventByUserId(int userId)
        {
            try
            {
                return _context.Event.AsQueryable()
                    .Where(x=>x.UserId==userId)
                    .Select(x => new Event()
                {
                    EventId = x.EventId,
                    UserId = x.UserId,
                    EventName = x.EventName,
                    EventLogo = x.EventLogo,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Location = x.Location,
                    CategoryNum = x.CategoryNum,
                    LikedCount = _context.EventLikes.AsQueryable().Where(el => el.EventId == x.EventId).Count(),
                    Comments = _context.EventComments.AsQueryable().Where(em => em.EventId == x.EventId).ToList(),
                    CreateOn = x.CreateOn,
                    UpdateOn = x.UpdateOn,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public List<Event> ReadEventByCategory(Category categoryNum)
        {
            try
            {
                return _context.Event.AsQueryable()
                    .Where(x=>x.CategoryNum==categoryNum)
                    .Select(x => new Event()
                {
                    EventId = x.EventId,
                    UserId = x.UserId,
                    EventName = x.EventName,
                    EventLogo = x.EventLogo,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Location = x.Location,
                    CategoryNum = x.CategoryNum,
                    LikedCount = _context.EventLikes.AsQueryable().Where(el => el.EventId == x.EventId).Count(),
                    Comments = _context.EventComments.AsQueryable().Where(em => em.EventId == x.EventId).ToList(),
                    CreateOn = x.CreateOn,
                    UpdateOn = x.UpdateOn,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public List<Event> ReadEventByName(string name)
        {
            try
            {
                return _context.Event.AsQueryable()
                    .Where(x=>x.EventName.Contains(name))
                    .Select(x => new Event()
                {
                    EventId = x.EventId,
                    UserId = x.UserId,
                    EventName = x.EventName,
                    EventLogo = x.EventLogo,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Location = x.Location,
                    CategoryNum = x.CategoryNum,
                    LikedCount = _context.EventLikes.AsQueryable().Where(el => el.EventId == x.EventId).Count(),
                    Comments = _context.EventComments.AsQueryable().Where(em => em.EventId == x.EventId).ToList(),
                    CreateOn = x.CreateOn,
                    UpdateOn = x.UpdateOn,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public bool UpdateEvent(Event eventReq)
        {
            try
            {
                var response = _context.Event.Update(eventReq);
                _context.SaveChanges();
                return response.Entity != null;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public bool DeleteEvent(int eventId)
        {
            try
            {
                var found = _context.Event.AsQueryable()
                    .FirstOrDefault(x=>x.EventId==eventId);
                if (found == null) return false;
                 _context.Event.Remove(found);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public bool LikeEvent(EventLikes eventLike)
        {
            try
            {
                var found = _context.EventLikes.AsQueryable().FirstOrDefault(x => x.UserId == eventLike.UserId&&x.EventId==eventLike.EventId);
                if (found == null) 
                { 
                    _context.EventLikes.Add(eventLike);
                }
                else
                {
                    _context.EventLikes.Remove(found);
                };
                _context.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public bool CreateEventComment(EventComments eventComments)
        {
            try
            {
                var response=_context.EventComments.Add(eventComments);
                _context.SaveChanges();
                return response.Entity != null;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
