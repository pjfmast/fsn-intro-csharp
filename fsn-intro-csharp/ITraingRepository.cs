using fsn_intro_csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsn_intro_csharp;

internal interface ITraingRepository
{
    IEnumerable<Training> GetAll();
    Training GetById(int id);
    void Add(Training training);
    void Update(Training training);
    void Delete(int id);
}
