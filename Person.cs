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

  [Table("Persons")]
  class Person {
    [Key]
    public long ID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    [Computed]
    public List<Phone> Phone { get; set; } = new List<Phone>();

    public override string ToString() {
      return $"{ID} {LastName} {FirstName} {Patronymic} " +
        $"{((BirthDate != null) ? ((DateTime)BirthDate).ToString("dd-MM-yyyy") : "NULL")} {Street} {City} {State} {ZipCode}";
    }

    //public static Customer Get(long Id) {
    //  using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
    //    return conn.Get<Customer>(Id);
    //  }
    //}

    public static Person Get(long Id) {
      Person result = new Person();
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PersonGet2", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = Id });
        SqlDataReader reader = command.ExecuteReader();
        if (!reader.HasRows)
          return null;
        reader.Read();
        result.ID = Id;
        result.FirstName = reader.GetString(1);
        result.LastName = reader.GetString(2);
        result.Patronymic = !reader.IsDBNull(3) ? reader.GetString(3) : null;
        result.BirthDate = !reader.IsDBNull(4) ? reader.GetDateTime(4) : (DateTime?)null;

        result.Street = !reader.IsDBNull(5) ? reader.GetString(5) : null;
        result.City = !reader.IsDBNull(6) ? reader.GetString(6) : null;
        result.State = !reader.IsDBNull(7) ? reader.GetString(7) : null;
        result.ZipCode = !reader.IsDBNull(8) ? reader.GetString(8) : null;
      }
      return result;
    }

    public static long Add(Person customer) {
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PersonAdd", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@firstName", Value = customer.FirstName });
        command.Parameters.Add(new SqlParameter { ParameterName = "@lastName", Value = customer.LastName });
        command.Parameters.Add(new SqlParameter { ParameterName = "@patronymic", Value = customer.Patronymic });
        command.Parameters.Add(new SqlParameter { ParameterName = "@birthDate", Value = customer.BirthDate });

        command.Parameters.Add(new SqlParameter { ParameterName = "@street", Value = customer.Street });
        command.Parameters.Add(new SqlParameter { ParameterName = "@city", Value = customer.City });
        command.Parameters.Add(new SqlParameter { ParameterName = "@state", Value = customer.State });
        command.Parameters.Add(new SqlParameter { ParameterName = "@zipCode", Value = customer.ZipCode });
        var outputParam = new SqlParameter { ParameterName = "@id", SqlDbType = SqlDbType.BigInt, Direction = ParameterDirection.Output };
        command.Parameters.Add(outputParam);
        command.ExecuteNonQuery();
        return (long)outputParam.Value;
      }
    }

    public static bool Update(long id, Person customer) {
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PersonUpdate", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@firstName", Value = customer.FirstName });
        command.Parameters.Add(new SqlParameter { ParameterName = "@lastName", Value = customer.LastName });
        command.Parameters.Add(new SqlParameter { ParameterName = "@patronymic", Value = customer.Patronymic });
        command.Parameters.Add(new SqlParameter { ParameterName = "@birthDate", Value = customer.BirthDate });
        command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

        command.Parameters.Add(new SqlParameter { ParameterName = "@street", Value = customer.Street });
        command.Parameters.Add(new SqlParameter { ParameterName = "@city", Value = customer.City });
        command.Parameters.Add(new SqlParameter { ParameterName = "@state", Value = customer.State });
        command.Parameters.Add(new SqlParameter { ParameterName = "@zipCode", Value = customer.ZipCode });
        int cnt = command.ExecuteNonQuery();
        return true ? cnt != 0 : false;
      }
    }

    public static bool Delete(long id) {
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_PersonDelete", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
        int cnt = command.ExecuteNonQuery();
        return true ? cnt != 0 : false;
      }
    }

    public static List<Person> SearchByName(string name) {
      var result = new List<Person>();
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        conn.Open();
        var command = new SqlCommand("dbo.sp_Search", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter { ParameterName = "@search", Value = name });
        SqlDataReader reader = command.ExecuteReader();
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
