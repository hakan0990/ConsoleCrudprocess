namespace ConsoleDers2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeID = c.Int(nullable: false, identity: true),
                        EmployeName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
