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
				this.SqlInsert = "INSERT INTO qwer (Phone," + this.SqlBaseFieldInsertFront + ") VALUES (@Phone," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE qwer SET Phone=@Phone," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class qwerResultHandler : CommonObjectResultHandler<qwer>
		{
			public override void GetColumnValues(IDataReader reader, qwer item)
			{
				base.GetColumnValues(reader, item);
				int ordinalPhone = reader.GetOrdinal("Phone");
				item.Phone = !reader.IsDBNull(ordinalPhone) && reader.GetBoolean(ordinalPhone);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, qwer item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Phone", item.Phone);
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
