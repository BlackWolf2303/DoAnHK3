using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop2.Models;

namespace FlowerShop2.Repositories
{
  public class IAccountRepository
  {
    void create(Account account);

    Account login(string username, string password);
  }
}