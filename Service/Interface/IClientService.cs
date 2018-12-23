﻿using Model;
using Model.ViewModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IClientService : IRepository<Client>
    {
        IndexPageViewModel GetAllIndex(int page);
        IndexPageViewModel Search(string parameter,int page);
        string NameOfClient(int id);
        Client GetByIdUser(string id);
    }

}