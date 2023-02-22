using Tuesday.API.Controllers;
using Tuesday.API.Data;
using Tuesday.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//CarController myCars = new CarController(new DatabaseContext());
//myCars.getSeb();

//Square s = new Square();
//Circle circle = new Circle();
//IFigure figure = new Square();
//IFigure figure2 = new Circle();
////if(s.color=="red")....

//if(figure.color =="red")...
//List<IFigure> list = new List<IFigure>();
//list.Add(figure);
//list.Add(new Circle());
//list.Add(new Square());
//foreach (var item in list)
//{
//    if(item.color=="red").. jubii du har vundet
//}
// typeoff evt refleksion...
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// test

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
