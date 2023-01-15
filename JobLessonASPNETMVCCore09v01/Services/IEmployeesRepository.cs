using JobLessonASPNETMVCCore09v01.Models;

namespace JobLessonASPNETMVCCore09v01.Services
{
    public interface IEmployeesRepository
    {
        IEnumerable<Employee> GetAll();

        Employee? GetById(int Id);

        int Add(Employee item);

        bool Edit(Employee item);

        bool Remove(int Id);
    }
}
