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
    public class SerialManager : ISerialService
    {
        private ISerialDal _serialDal;
        public SerialManager(ISerialDal serialDal)
        {
            _serialDal = serialDal;
        }
        public IResult Add(Serial serial)
        {
            _serialDal.add(serial);
            return new SuccessResult(message: Messages.SerialAdded);
        }

        public IResult Delete(Serial serial)
        {
            _serialDal.delete(serial);
            return new SuccessResult(message: Messages.SerialDeleted);
        }

        public IDataResult<Serial> GetById(int serialId)
        {
            return new SuccessDataResult<Serial>(_serialDal.Get(filter: p => p.Id == serialId));
        }

        public IDataResult<List<Serial>> GetList()
        {
            return new SuccessDataResult<List<Serial>>(_serialDal.GetList().ToList());
        }

        public IResult Update(Serial serial)
        {
            _serialDal.update(serial);
            return new SuccessResult(message: Messages.SerialUpdated);
        }
    }
}
