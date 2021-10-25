using AutoMapper;
using EMS.DataAcess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.Services.Base
{
    public class BaseService
    {
        protected readonly IUnitOfWork _unitofWork;
        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitofWork = unitOfWork;
            _mapper = mapper;
        }
    }
}