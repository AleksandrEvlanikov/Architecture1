using Architecture10PatternRepository.Models;

namespace Architecture10PatternRepository.Services
{
    public interface IPetRepository : IRepository<Pet, int, string> { }

}
