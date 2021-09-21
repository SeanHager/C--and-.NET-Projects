namespace StudentProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        gradeLevel = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.gradeLevel);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GPA = c.Double(nullable: false),
                        gradeLevel = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.gradeLevel)
                .Index(t => t.gradeLevel);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "gradeLevel", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "gradeLevel" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
