﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasktower.BoardService.Data.Context;
using Tasktower.BoardService.Data.Entities;
using Tasktower.Webtools.Datatools.BaseDAL;
using Tasktower.Webtools.DependencyInjection;

namespace Tasktower.BoardService.Data.DAL.Impl
{
    [ScopedService]
    public class TaskCardRepository : BaseCrudEFCoreRepository<TaskCard, BoardDBContext>, ITaskCardRepository
    {
        public TaskCardRepository(BoardDBContext context) : base(context) { }
    }
}
