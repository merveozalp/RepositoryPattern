using AutoMapper;
using RepositoryPattern.Business.Abstract;
using RepositoryPattern.Data.Abstract;
using RepositoryPattern.Data.Concrete.EntityFramework;
using RepositoryPattern.Domain;
using RepositoryPattern.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        // Business katmanını kullanabilmek için Data katmanına ihtiyacımız var.

        private IStudentDal studentDal;
        private IMapper mapper;

        public StudentManager(IStudentDal studentDal, IMapper mapper)
        {
            this.studentDal = studentDal;
            //this.mapper = mapper;
        }

        public void Add(Student student)
        {
            
           studentDal.Add(student);
        }

        public void Delete(int Id)
        {

            studentDal.Delete(GetById(Id));
        }

        public Student GetById(int StudentId)
        {
            return studentDal.Get(filter: s => s.Id == StudentId).Result;
           
        }

        public List<Student> GetList()
        {
            //Result kullanma sebebimiz Task olan tanımlı olan methodların dönüşümünü sağlıyoruz.
            return studentDal.GetList().Result.ToList();
        }

        public void Update(Student student)
        {
            studentDal.Update(student);
        }
    }
}
