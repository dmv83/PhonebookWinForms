using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookWinForms {
  public static class Globals {
    const string server = "(local)";
    const string connString = @"Data Source=Server;Initial Catalog=Base;Integrated Security=true;MultipleActiveResultSets=true;";
    public static readonly string PhonebookConnString = connString.Replace("Server", server).Replace("Base", "Phonebook");
  }
}
