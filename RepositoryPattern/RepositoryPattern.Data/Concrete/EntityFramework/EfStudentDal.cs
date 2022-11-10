using RepositoryPattern.Core.EntityFramework;
using RepositoryPattern.Data.Abstract;
using RepositoryPattern.Data.Concrete.EntityFramework.Context;
using RepositoryPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Concrete.EntityFramework
{

    // tek başına IStudentDal Implemente edilmiş olsaydı tüm methodları yazmamız gerekirdi ama 
    //EntityRepositoryBase implemente edince o zaten bir IStudentDal ımp. olduğu için tüm methodlar otomatik olarak algılandı.
    public class EfStudentDal:EntityRepositoryBase<Student,MyContext>,IStudentDal
    {
    }
}
