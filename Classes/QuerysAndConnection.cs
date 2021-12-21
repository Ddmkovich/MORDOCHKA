using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORDOCHKA.Classes
{
    public class Connection
    {
       public string connectionString = @"Server=10.10.1.24;Database=PolitDV;User id =pro-41;Password=Pro_41student;TrustServerCertificate =True;";
    }
    public class Querys
    {
        public string GetSql(int pageNumber, int pageSize)
        {
            return "SELECT Clients.ID, FirstName,LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath,max(StartTime) as LastVisit,COUNT(StartTime) as Visit " +
        "FROM Clients LEFT JOIN ClientService " +
        "ON ClientService.ClientID = Clients.ID " +
        "Group by Clients.ID, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath " +
        "ORDER BY Id OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";

        }
    }
}
