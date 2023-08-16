using Calling_Cat_Apis;
using Microsoft.Extensions.DependencyInjection;

var service = new ServiceCollection();

service.AddSingleton<ICatService, CatService>();

service.AddTransient<ICatLogic, CatLogic>();

service.AddScoped<IAddCats, AddCats>();


var serviceProvider = service.BuildServiceProvider();

var cats = serviceProvider.GetRequiredService<ICatService>();

var catLogic = serviceProvider.GetRequiredService<ICatLogic>();

var addCats = serviceProvider.GetRequiredService<IAddCats>();

var catOrch = new CatOrchestrator(cats, catLogic, addCats);

var orchestrate = await catOrch.CompleteCatOrchestrate();

Console.WriteLine(orchestrate);



