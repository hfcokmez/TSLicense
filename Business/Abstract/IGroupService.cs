using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGroupService
    {
        IDataResult<Group> GetById(int GroupId);
        IDataResult<List<Group>> GetList();
        IResult Add(Group group);
        IResult Delete(Group group);
        IResult Update(Group group);
    }
}
