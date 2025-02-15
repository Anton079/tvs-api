using FluentMigrator;

namespace tvs_api.Data
{
    [Migration(02022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("tv")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("model").AsString(120).NotNullable()
                .WithColumn("price").AsInt32().NotNullable();
        }
    }
}
