using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Routine.Models;

namespace Routine.ViewModels.Interfaces
{
    public interface IRoutineCreator
    {
        Task<IEnumerable<RoutineT>> GetRoutineTsAsync();
        Task<RoutineT> GetRoutineT(int ID);
        Task AddRoutineT(RoutineT routineT);
        Task UpdateRoutineT(RoutineT routineT);
        Task DeleteRoutineT(RoutineT routineT);
    }
}
