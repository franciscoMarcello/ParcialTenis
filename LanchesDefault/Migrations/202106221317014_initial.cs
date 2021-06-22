namespace LanchesDefault.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tenis", "Marca", c => c.String(maxLength: 8000, unicode: false));
            AddColumn("dbo.Tenis", "Modelo", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.Tenis", "Descricao");
            DropColumn("dbo.Tenis", "Codigo");
            DropColumn("dbo.Tenis", "Quantidade");
            DropColumn("dbo.Tenis", "EstoqueMinimo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tenis", "EstoqueMinimo", c => c.Int(nullable: false));
            AddColumn("dbo.Tenis", "Quantidade", c => c.Int(nullable: false));
            AddColumn("dbo.Tenis", "Codigo", c => c.String(maxLength: 8000, unicode: false));
            AddColumn("dbo.Tenis", "Descricao", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.Tenis", "Modelo");
            DropColumn("dbo.Tenis", "Marca");
        }
    }
}
