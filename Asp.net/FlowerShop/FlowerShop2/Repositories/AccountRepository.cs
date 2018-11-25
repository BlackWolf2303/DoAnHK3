using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop2.Models;

namespace FlowerShop2.Repositories
{
  public class AccountRepository :IAccountRepository
  {
    private MyDemoEntities myDemoEntities = new MyDemoEntities();

    public void create (Account account)
    {
      myDemoEntities.Accounts.Add(account);
      myDemoEntities.SaveChanges();
    }

    public Account login(string username, string password)
    {
      try
      {
        return myDemoEntities.Accounts.Single(account => account.username.Equals(username) && account.password.Equals(password));
      }
      catch
      {
        return null;
      }
    }
  }
}