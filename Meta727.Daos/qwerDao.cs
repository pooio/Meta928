using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Meta727.Daos.Interfaces;
using Meta727.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos
{
	public class qwerDao : CommonObjectDao<qwer>, IqwerDao
	{
		public class qwerSqlBuilder : ObjectSqlBuilder
		{
			public qwerSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"qwer")
			{
				this.SqlInsert = "INSERT INTO qwer (Num,Price,Phone," + this.SqlBaseFieldInsertFront + ") VALUES (@Num,@Price,@Phone," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE qwer SET Num=@Num,Price=@Price,Phone=@Phone," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class qwerResultHandler : CommonObjectResultHandler<qwer>
		{
			public override void GetColumnValues(IDataReader reader, qwer item)
			{
				base.GetColumnValues(reader, item);
				int ordinalPrice = reader.GetOrdinal("Price");
				item.Price = reader.IsDBNull(ordinalPrice) ? null : reader.GetString(ordinalPrice);
				int ordinalPhone = reader.GetOrdinal("Phone");
				item.Phone = !reader.IsDBNull(ordinalPhone) && reader.GetBoolean(ordinalPhone);
				int ordinalNum = reader.GetOrdinal("Num");
				item.Num = reader.IsDBNull(ordinalNum) ? 0 : reader.GetInt32(ordinalNum);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, qwer item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Price", item.Price ?? (object) DBNull.Value);
				context.AddParameter(command, "Phone", item.Phone);
				context.AddParameter(command, "Num", item.Num);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public qwerDao(SqlDialect sqlDialect) : base(new qwerSqlBuilder(sqlDialect), new qwerResultHandler())
		{
		}

		public qwerDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new qwerSqlBuilder(sqlDialect), new qwerResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
