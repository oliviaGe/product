using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;

namespace Products.Daos
{
	public class OrganizationDao : CommonObjectDao<Organization>, IOrganizationDao
	{
		public class OrganizationSqlBuilder : ObjectSqlBuilder
		{
			public OrganizationSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Organization")
			{
				this.SqlInsert = "INSERT INTO Organization (" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Organization SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class OrganizationResultHandler : CommonObjectResultHandler<Organization>
		{
			public override void GetColumnValues(IDataReader reader, Organization item)
			{
				base.GetColumnValues(reader, item);
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Organization item)
			{
				base.AddInsertParameters(context, command, item);
			}
		}

		public OrganizationDao(SqlDialect sqlDialect) : base(new OrganizationSqlBuilder(sqlDialect), new OrganizationResultHandler())
		{
		}

		public OrganizationDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new OrganizationSqlBuilder(sqlDialect), new OrganizationResultHandler(), schemaConnectionString)
		{
		}
	}
}
