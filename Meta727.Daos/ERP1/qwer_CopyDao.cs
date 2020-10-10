using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Meta727.Daos.Interfaces.ERP1;
using Meta727.Entities.ERP1;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.ERP1
{
	public class qwer_CopyDao : CommonObjectDao<qwer_Copy>, Iqwer_CopyDao
	{
		public class qwer_CopySqlBuilder : ObjectSqlBuilder
		{
			public qwer_CopySqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"qwer_Copy")
			{
				this.SqlInsert = "INSERT INTO qwer_Copy (Phone,Num,Price," + this.SqlBaseFieldInsertFront + ") VALUES (@Phone,@Num,@Price," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE qwer_Copy SET Phone=@Phone,Num=@Num,Price=@Price," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class qwer_CopyResultHandler : CommonObjectResultHandler<qwer_Copy>
		{
			public override void GetColumnValues(IDataReader reader, qwer_Copy item)
			{
				base.GetColumnValues(reader, item);
				int ordinalPhone = reader.GetOrdinal("Phone");
				item.Phone = !reader.IsDBNull(ordinalPhone) && reader.GetBoolean(ordinalPhone);
				int ordinalPrice = reader.GetOrdinal("Price");
				item.Price = reader.IsDBNull(ordinalPrice) ? null : reader.GetString(ordinalPrice);
				int ordinalNum = reader.GetOrdinal("Num");
				item.Num = reader.IsDBNull(ordinalNum) ? 0 : reader.GetInt32(ordinalNum);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, qwer_Copy item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Phone", item.Phone);
				context.AddParameter(command, "Price", item.Price ?? (object) DBNull.Value);
				context.AddParameter(command, "Num", item.Num);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public qwer_CopyDao(SqlDialect sqlDialect) : base(new qwer_CopySqlBuilder(sqlDialect), new qwer_CopyResultHandler())
		{
		}

		public qwer_CopyDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new qwer_CopySqlBuilder(sqlDialect), new qwer_CopyResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
