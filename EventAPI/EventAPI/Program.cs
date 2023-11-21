using EventAPI;
using EventLib;
using EventLib.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IDbContext, SqlDbContext>(optionBuilder => 
{
    optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<EventRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

MapEndPoint(app);

app.Run();

void MapEndPoint(WebApplication app)
{
    app.MapPost("api/login", (EventRepo repo, string username, string password) => { return repo.Login(username, password); }).WithTags("User");
    app.MapPost("api/sign_up", (EventRepo repo, string username,string password) => { return repo.SignUp(username,password); }).WithTags("User");
    app.MapPut("api/update_profile", (EventRepo repo, User newUser) => { return repo.UpdateProfile(newUser); }).WithTags("User");
    app.MapPut("api/create_event", (EventRepo repo, Event eventReq) => { return repo.CreateEvent(eventReq); }).WithTags("Event");
    app.MapGet("api/event", (EventRepo repo) => { return repo.ReadEvent(); }).WithTags("Event");
    app.MapGet("api/event_date", (EventRepo repo, DateTime dateTime) => { return repo.ReadEventByDate(dateTime); }).WithTags("Event");
    app.MapGet("api/event_user_id", (EventRepo repo, int userId) => { return repo.ReadEventByUserId(userId); }).WithTags("Event");
    app.MapGet("api/event_category", (EventRepo repo, Category category) => { return repo.ReadEventByCategory(category); }).WithTags("Event");
    app.MapGet("api/event_name", (EventRepo repo,string eventName) => { return repo.ReadEventByName(eventName); }).WithTags("Event");
    app.MapPut("api/update_event", (EventRepo repo, Event eventReq) => { return repo.UpdateEvent(eventReq); }).WithTags("Event");
    app.MapDelete("api/delete_event", (EventRepo repo, int eventId) => { return repo.DeleteEvent(eventId); }).WithTags("Event");
    app.MapPut("api/event_like", (EventRepo repo, EventLikes eventLike) => { return repo.LikeEvent(eventLike); }).WithTags("Event Likes");
    app.MapPut("api/event_comment", (EventRepo repo, EventComments eventComments) => { return repo.CreateEventComment(eventComments); }).WithTags("Event Comments");
}
