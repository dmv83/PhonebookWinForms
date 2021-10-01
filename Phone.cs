using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace PhonebookWinForms {
  [Table("Phones")]
  class Phone {
    [Key]
    public long IdPerson { get; set; }
    public string Number { get; set; }

    public static List<Phone> Get(long Id) {
      var result = new List<Phone>();
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PersonGet2", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = Id });
        SqlDataReader reader = command.ExecuteReader();
        reader.NextResult();
        if (!reader.HasRows)
          return null;
        while (reader.Read()) {
          Phone phone = new Phone { IdPerson = Id , Number = reader.GetString(1) };
          result.Add(phone);
        }
      }
      return result;
    }


    public static bool Delele(long id, string number) {
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PhoneDelete2", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
        command.Parameters.Add(new SqlParameter { ParameterName = "@number", Value = number });
        int cnt = command.ExecuteNonQuery();
        return true ? cnt != 0 : false;
      }
    }

    public static bool Update(long id, string number, string newNumber) {
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PhoneUpdate", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
        command.Parameters.Add(new SqlParameter { ParameterName = "@number", Value = number });
        command.Parameters.Add(new SqlParameter { ParameterName = "@newNumber", Value = newNumber });
        int cnt = command.ExecuteNonQuery();
        return true ? cnt != 0 : false;
      }
    }

    public static List<Person> SearchByNumber(string number) {
      var result = new List<Person>();
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_Search", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@search", Value = number });
        SqlDataReader reader = command.ExecuteReader();
        reader.NextResult();
        if (!reader.HasRows)
          return null;
        while (reader.Read()) {
          Person person = new Person();
          person.ID = reader.GetInt64(0);
          person.FirstName = reader.GetString(1);
          person.LastName = reader.GetString(2);
          person.Patronymic = !reader.IsDBNull(3) ? reader.GetString(3) : null;

          person.BirthDate = !reader.IsDBNull(4) ? reader.GetDateTime(4) : (DateTime?)null;
          person.Street = !reader.IsDBNull(5) ? reader.GetString(5) : null;
          person.City = !reader.IsDBNull(6) ? reader.GetString(6) : null;
          person.State = !reader.IsDBNull(7) ? reader.GetString(7) : null;
          person.ZipCode = !reader.IsDBNull(8) ? reader.GetString(8) : null;

          result.Add(person);
        }
      }
      return result;
    }
  }
}
