﻿
using DataAccess.Repositories.Abstracts;
using Model.Entitys.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concreds
{
    public class S_CardRepositories : BaseRepositories<S_Card>, IS_CardRepositories
    {
    }
}