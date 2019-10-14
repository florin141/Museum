using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Museum.Core;
using Museum.Core.Data;

namespace Museum.Service.Tests.MockRepository
{
    public class MockRepository<TEntity> where TEntity : BaseEntity
    {
        public Mock<IRepository<TEntity>> Repository { get; set; }

        public MockRepository()
        {
            Repository = new Mock<IRepository<TEntity>>();
            Setup();
        }

        private void Setup()
        {
            //Repository.Setup()
        }
    }
}
