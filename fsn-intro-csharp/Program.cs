// See https://aka.ms/new-console-template for more information
using fsn_intro_csharp;

var traingsRepository = new FakeTrainingRepository();

Console.WriteLine($"Check out these {traingsRepository.Count} trainings:");

foreach (var training in traingsRepository.GetAll())
{
    Console.WriteLine($"{training.Title} - {training.Price} - {training.StartTime}");
}

Console.WriteLine("\n\nThes trainings are outside:");
var outsideTrainings = traingsRepository
    .GetAll()
    .Where(t => t.IsOutside == true);

foreach (var training in outsideTrainings)
{
    Console.WriteLine($"{training.Title} - {training.Price} - {training.StartTime}");
}
