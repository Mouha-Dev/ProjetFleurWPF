using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetFleurWPF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bouquets",
                columns: table => new
                {
                    BouquetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouquets", x => x.BouquetId);
                });

            migrationBuilder.CreateTable(
                name: "BouquetsPreconfigures",
                columns: table => new
                {
                    BouquetPreconfigureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BouquetsPreconfigures", x => x.BouquetPreconfigureId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "CommandesFournisseurs",
                columns: table => new
                {
                    CommandeFournisseurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomFleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidePar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateValidation = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandesFournisseurs", x => x.CommandeFournisseurId);
                });

            migrationBuilder.CreateTable(
                name: "Fleurs",
                columns: table => new
                {
                    FleurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fleurs", x => x.FleurId);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    FournisseurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.FournisseurId);
                });

            migrationBuilder.CreateTable(
                name: "Proprietaires",
                columns: table => new
                {
                    ProprietaireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietaires", x => x.ProprietaireId);
                });

            migrationBuilder.CreateTable(
                name: "Vendeurs",
                columns: table => new
                {
                    VendeurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendeurs", x => x.VendeurId);
                });

            migrationBuilder.CreateTable(
                name: "FleurBouquetPreconfigures",
                columns: table => new
                {
                    FleurBouquetPreconfigureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BouquetPreconfigureId = table.Column<int>(type: "int", nullable: false),
                    FleurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FleurBouquetPreconfigures", x => x.FleurBouquetPreconfigureId);
                    table.ForeignKey(
                        name: "FK_FleurBouquetPreconfigures_BouquetsPreconfigures_BouquetPreconfigureId",
                        column: x => x.BouquetPreconfigureId,
                        principalTable: "BouquetsPreconfigures",
                        principalColumn: "BouquetPreconfigureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FleurBouquetPreconfigures_Fleurs_FleurId",
                        column: x => x.FleurId,
                        principalTable: "Fleurs",
                        principalColumn: "FleurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FleurBouquets",
                columns: table => new
                {
                    FleurBouquetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BouquetId = table.Column<int>(type: "int", nullable: false),
                    FleurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FleurBouquets", x => x.FleurBouquetId);
                    table.ForeignKey(
                        name: "FK_FleurBouquets_Bouquets_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquets",
                        principalColumn: "BouquetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FleurBouquets_Fleurs_FleurId",
                        column: x => x.FleurId,
                        principalTable: "Fleurs",
                        principalColumn: "FleurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    CommandeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCommande = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoyenPaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatutPaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantTotal = table.Column<double>(type: "float", nullable: false),
                    MessagePersonnalise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    VendeurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.CommandeId);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commandes_Vendeurs_VendeurId",
                        column: x => x.VendeurId,
                        principalTable: "Vendeurs",
                        principalColumn: "VendeurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommandeProduits",
                columns: table => new
                {
                    CommandeProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommandeId = table.Column<int>(type: "int", nullable: false),
                    FleurId = table.Column<int>(type: "int", nullable: true),
                    BouquetId = table.Column<int>(type: "int", nullable: true),
                    BouquetPreconfigureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeProduits", x => x.CommandeProduitId);
                    table.ForeignKey(
                        name: "FK_CommandeProduits_BouquetsPreconfigures_BouquetPreconfigureId",
                        column: x => x.BouquetPreconfigureId,
                        principalTable: "BouquetsPreconfigures",
                        principalColumn: "BouquetPreconfigureId");
                    table.ForeignKey(
                        name: "FK_CommandeProduits_Bouquets_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquets",
                        principalColumn: "BouquetId");
                    table.ForeignKey(
                        name: "FK_CommandeProduits_Commandes_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commandes",
                        principalColumn: "CommandeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommandeProduits_Fleurs_FleurId",
                        column: x => x.FleurId,
                        principalTable: "Fleurs",
                        principalColumn: "FleurId");
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    FactureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoyenPaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantTotal = table.Column<double>(type: "float", nullable: false),
                    MessagePersonnalise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommandeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => x.FactureId);
                    table.ForeignKey(
                        name: "FK_Factures_Commandes_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commandes",
                        principalColumn: "CommandeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandeProduits_BouquetId",
                table: "CommandeProduits",
                column: "BouquetId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeProduits_BouquetPreconfigureId",
                table: "CommandeProduits",
                column: "BouquetPreconfigureId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeProduits_CommandeId",
                table: "CommandeProduits",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeProduits_FleurId",
                table: "CommandeProduits",
                column: "FleurId");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ClientId",
                table: "Commandes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_VendeurId",
                table: "Commandes",
                column: "VendeurId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_CommandeId",
                table: "Factures",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_FleurBouquetPreconfigures_BouquetPreconfigureId",
                table: "FleurBouquetPreconfigures",
                column: "BouquetPreconfigureId");

            migrationBuilder.CreateIndex(
                name: "IX_FleurBouquetPreconfigures_FleurId",
                table: "FleurBouquetPreconfigures",
                column: "FleurId");

            migrationBuilder.CreateIndex(
                name: "IX_FleurBouquets_BouquetId",
                table: "FleurBouquets",
                column: "BouquetId");

            migrationBuilder.CreateIndex(
                name: "IX_FleurBouquets_FleurId",
                table: "FleurBouquets",
                column: "FleurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandeProduits");

            migrationBuilder.DropTable(
                name: "CommandesFournisseurs");

            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "FleurBouquetPreconfigures");

            migrationBuilder.DropTable(
                name: "FleurBouquets");

            migrationBuilder.DropTable(
                name: "Fournisseurs");

            migrationBuilder.DropTable(
                name: "Proprietaires");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "BouquetsPreconfigures");

            migrationBuilder.DropTable(
                name: "Bouquets");

            migrationBuilder.DropTable(
                name: "Fleurs");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Vendeurs");
        }
    }
}
