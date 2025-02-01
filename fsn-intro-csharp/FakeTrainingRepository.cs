using fsn_intro_csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsn_intro_csharp;

internal class FakeTrainingRepository : ITraingRepository
{
    private List<Training> _trainings =
    [
        new Training(1, "C# Basics", 100M, "Learn the basics of C#", DateTime.Now, TimeSpan.FromHours(2)),
        new Training(2, "C# Advanced", 200M, "Learn the advanced features of C#", DateTime.Now, TimeSpan.FromHours(3)),
        new Training(3, "C# Master", 300M, "Become a master in C#", DateTime.Now, TimeSpan.FromHours(4)),
        new Training(4, "Stadsnatuur", 7.50M, "leer de natuur kennen in je buurt", new DateTime(2025,2,20,10,0,0), TimeSpan.FromHours(4), true),

    ];
    public int Count => _trainings.Count;

    public void Add(Training training) => _trainings.Add(training);

    public void Delete(int id) => _trainings.Remove(_trainings.First(t => t.Id == id));

    public IEnumerable<Training> GetAll() => _trainings;

    public Training GetById(int id) => _trainings.First(t => t.Id == id);

    public void Update(Training training) => _trainings[_trainings.FindIndex(t => t.Id == training.Id)] = training;
}
