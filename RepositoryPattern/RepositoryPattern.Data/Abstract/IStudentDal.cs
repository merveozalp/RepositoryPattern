
using RepositoryPattern.Core.DataAccess;
using RepositoryPattern.Data.Concrete.EntityFramework.Context;
using RepositoryPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Abstract
{

    //IStudentDal içerisinde artık IEntityRepository içerisinde olan her sey var. (Implemente ettiğimiz için)
    public interface IStudentDal:IEntityRepository<Student>
    {
    }
}
