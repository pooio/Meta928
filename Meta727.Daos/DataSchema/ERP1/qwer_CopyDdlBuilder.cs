using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.DataSchema.ERP1
{
	public class qwer_CopyDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE qwer_Copy(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Phone bit,Price nvarchar(255),Name nvarchar(255),Num int,Description nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE qwer_Copy";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'qwer_Copy'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
