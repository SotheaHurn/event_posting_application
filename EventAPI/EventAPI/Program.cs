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
    app.MapPost("api/login", ([FromServices] EventRepo repo, string username, string password) => { return repo.Login(username, password); }).WithTags("User");
    app.MapPost("api/sign_up", ([FromServices] EventRepo repo, string username,string password) => { return repo.SignUp(username,password); }).WithTags("User");
    app.MapPost("api/create_event", ([FromServices] EventRepo repo, Event eventReq) => { return repo.CreateEvent(eventReq); }).WithTags("Event");
    app.MapGet("api/event", ([FromServices] EventRepo repo) => { return repo.ReadEvent(); }).WithTags("Event");
    app.MapGet("api/event_date", ([FromServices] EventRepo repo, DateTime dateTime) => { return repo.ReadEventByDate(dateTime); }).WithTags("Event");
    app.MapGet("api/event_user_id", ([FromServices] EventRepo repo, int userId) => { return repo.ReadEventByUserId(userId); }).WithTags("Event");
    app.MapGet("api/event_category", ([FromServices] EventRepo repo, Category category) => { return repo.ReadEventByCategory(category); }).WithTags("Event");
    app.MapGet("api/event_name", ([FromServices] EventRepo repo,string eventName) => { return repo.ReadEventByName(eventName); }).WithTags("Event");
    app.MapPost("api/update_event", ([FromServices] EventRepo repo, Event eventReq) => { return repo.UpdateEvent(eventReq); }).WithTags("Event");
    app.MapPost("api/delete_event", ([FromServices] EventRepo repo, int eventId) => { return repo.DeleteEvent(eventId); }).WithTags("Event");
    app.MapPost("api/event_like", ([FromServices] EventRepo repo, EventLikes eventLike) => { return repo.LikeEvent(eventLike); }).WithTags("Event Likes");
    app.MapPost("api/event_comment", ([FromServices] EventRepo repo, EventComments eventComments) => { return repo.CreateEventComment(eventComments); }).WithTags("Event Comments");
}
