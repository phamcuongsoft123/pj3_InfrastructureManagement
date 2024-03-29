﻿using InfrastructureManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureManagement.Core.Interfaces.IRepositories
{
    public interface IItemLogRepository : IBaseRepository<ItemLog>
    {
        List<ItemLog> GetLogOfItem(Guid itemId);
    }
}
