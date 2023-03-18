using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class AddCoffeeShops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge1', '9-5 Mon-Sun1', 'Jawatta Colombo1')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge2', '9-5 Mon-Sun2', 'Jawatta Colombo2')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge3', '9-5 Mon-Sun3', 'Jawatta Colombo3')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge4', '9-5 Mon-Sun4', 'Jawatta Colombo4')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge5', '9-5 Mon-Sun5', 'Jawatta Colombo5')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge6', '9-5 Mon-Sun6', 'Jawatta Colombo6')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge7', '9-5 Mon-Sun7', 'Jawatta Colombo7')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge8', '9-5 Mon-Sun8', 'Jawatta Colombo8')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge9', '9-5 Mon-Sun9', 'Jawatta Colombo9')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours,Address) VALUES ('Java Lounge10', '9-5 Mon-Sun10', 'Jawatta Colombo10')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
