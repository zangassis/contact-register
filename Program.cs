
using ContactRegister.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IContactRepository, ContactRepository>();
var app = builder.Build();

app.MapGet("/contacts", (IContactRepository repository) => {
    var contacts = repository.FindContacts();
    return Results.Ok(contacts);
});

app.Run();
