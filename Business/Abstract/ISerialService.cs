using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISerialService
    {
        IDataResult<Serial> GetById(int serialId);
        IDataResult<List<Serial>> GetList();
        IResult Delete(Serial serial);
        IResult Update(Serial serial);
        IResult Add(Serial serial);
    }
}
