﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Search_Application.Data.Migrations
{
    public partial class JobAnalyticsModelReAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job_Analytics",
                columns: table => new
                {
                    JobAnalysis_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JobId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    Applies = table.Column<int>(type: "int", nullable: false),
                    ReviewedCandidates = table.Column<int>(type: "int", nullable: false),
                    SelectedCandidates = table.Column<int>(type: "int", nullable: false),
                    InterviewedCandidates = table.Column<int>(type: "int", nullable: false),
                    HiredCandidates = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Analytics", x => x.JobAnalysis_Id);
                    table.ForeignKey(
                        name: "FK_Job_Analytics_Employer_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employer",
                        principalColumn: "Employer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Job_Analytics_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Jobs_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Job_Analytics_EmployerId",
                table: "Job_Analytics",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_Analytics_JobId",
                table: "Job_Analytics",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job_Analytics");
        }
    }
}
