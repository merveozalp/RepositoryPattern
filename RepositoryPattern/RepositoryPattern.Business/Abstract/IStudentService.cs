using RepositoryPattern.Domain;
using RepositoryPattern.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Business.Abstract
{
    public interface IStudentService
    {
        // 
        //
        Student GetById(int StudentId);
        List<Student> GetList();
        void Add(Student student);
        void Update(Student student);
        void Delete(int Id);

    }
}
