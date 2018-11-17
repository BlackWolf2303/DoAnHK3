namespace FlowerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrorImages : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "Category");
            RenameTable(name: "dbo.Products", newName: "Product");
            RenameTable(name: "dbo.Images", newName: "Image");
            RenameTable(name: "dbo.OrderDetails", newName: "OrderDetail");
            RenameTable(name: "dbo.Orders", newName: "Order");
            RenameTable(name: "dbo.Discounts", newName: "Discount");
            RenameTable(name: "dbo.Users", newName: "User");
            RenameTable(name: "dbo.Roles", newName: "Role");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Role", newName: "Roles");
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Discount", newName: "Discounts");
            RenameTable(name: "dbo.Order", newName: "Orders");
            RenameTable(name: "dbo.OrderDetail", newName: "OrderDetails");
            RenameTable(name: "dbo.Image", newName: "Images");
            RenameTable(name: "dbo.Product", newName: "Products");
            RenameTable(name: "dbo.Category", newName: "Categories");
        }
    }
}
