var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
    .AddInMemoryClients(OAuthServer.IdentityConfiguration.Clients.Get())
    .AddInMemoryIdentityResources(OAuthServer.IdentityConfiguration.Resources.GetIdentityResources())
    .AddInMemoryApiResources(OAuthServer.IdentityConfiguration.Resources.GetApiResources())
    .AddInMemoryApiScopes(OAuthServer.IdentityConfiguration.Scopes.GetApiScopes())
    .AddTestUsers(OAuthServer.IdentityConfiguration.Users.Get())
    .AddDeveloperSigningCredential();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();

app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

app.Run();