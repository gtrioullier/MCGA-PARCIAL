using Microsoft.Practices.EnterpriseLibrary.Data;
using Rent.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data
{
    public class EquipmentDAC : DataAccessComponent
    {
        private static Equipment LoadEquipment(IDataReader dr)
        {
            var equipment = new Equipment
            {
                Id = GetDataValue<Int32>(dr, "Id"),
                Name = GetDataValue<string>(dr, "Name"),
                Description = GetDataValue<string>(dr, "Description"),
                Make = GetDataValue<string>(dr, "Make"),
                Model = GetDataValue<string>(dr, "Model"),
                Year = GetDataValue<Int32>(dr, "Year"),
                CreatedBy = GetDataValue<Int32>(dr, "CreatedBy"),
                CreatedOn = GetDataValue<DateTime>(dr, "CreatedOn"),
                ChangedBy = GetDataValue<Int32>(dr, "ChangedBy"),
                ChangedOn = GetDataValue<DateTime>(dr, "ChangedOn")
            };
            return equipment;
        }

        public List<Equipment> Select()
        {
            const string sql = "SELECT * FROM dbo.Equipment";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);

            var result = new List<Equipment>();

            using (var cmd = db.GetSqlStringCommand(sql))
            {
                using (var dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        var equipment = LoadEquipment(dr);
                        result.Add(equipment);
                    }
                }
            }
            return result;
        }

        public Equipment Create(Equipment equipment)
        {
            const string sql = "INSERT INTO dbo.Equipment ([Name], [Description], [Make], [Model], [Year], [CreatedBy], [CreatedOn], [ChangedBy], [ChangedOn])" +
                "VALUES (@Name, @Description, @Make, @Model, @Year, @CreatedBy, @CreatedOn, @ChangedBy, @ChangedOn)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);

            using (var cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "@Name", DbType.String, equipment.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, equipment.Description);
                db.AddInParameter(cmd, "@Make", DbType.String, equipment.Make);
                db.AddInParameter(cmd, "@Model", DbType.String, equipment.Model);
                db.AddInParameter(cmd, "@Year", DbType.Int32, equipment.Year);
                db.AddInParameter(cmd, "@CreatedBy", DbType.Int32, equipment.CreatedBy);
                db.AddInParameter(cmd, "@CreatedOn", DbType.DateTime, equipment.CreatedOn);
                db.AddInParameter(cmd, "@ChangedBy", DbType.Int32, equipment.ChangedBy);
                db.AddInParameter(cmd, "@ChangedOn", DbType.DateTime, equipment.ChangedOn);

                equipment.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return equipment;
        }
    }
}
