using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using Core.Utilities.Results;
using Business.Contents;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.add(product);
            return new SuccessResult(message: Messages.ProductAdded );
        }

        public IResult Delete(Product product)
        {
            _productDal.delete(product);
            return new SuccessResult(message: Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter: p => p.Id == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter: p => p.GroupId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.update(product);
            return new SuccessResult(message: Messages.ProductUpdated);
        }
    }
}
