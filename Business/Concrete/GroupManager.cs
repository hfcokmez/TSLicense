using Business.Abstract;
using Business.Contents;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GroupManager : IGroupService
    {
        private IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        public IResult Add(Group group)
        {
            _groupDal.add(group);
            return new SuccessResult(Messages.GroupAdded);
        }

        public IResult Delete(Group group)
        {
            _groupDal.delete(group);
            return new SuccessResult(Messages.GroupDeleted);
        }

        public IDataResult<Group> GetById(int GroupId)
        {
            return new SuccessDataResult<Group>(_groupDal.Get(filter: p=> p.Id == GroupId)); 
        }

        public IDataResult<List<Group>> GetList()
        {
            return new SuccessDataResult<List<Group>>(_groupDal.GetList().ToList());
        }

        public IResult Update(Group group)
        {
            _groupDal.update(group);
            return new SuccessResult(Messages.GroupUpdated);
        }
    }
}
