using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfGroupDal : EfEntityRepositoryBase<Group, TSLicenseContext>, IGroupDal
    {
    }
}
