﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndieVisible.Infra.Data.Migrations
{
    public partial class userbadges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBadges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    Badge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadges", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BrainstormSessions",
                keyColumn: "Id",
                keyValue: new Guid("1fee0e42-7cfb-4438-96f9-4dbee6019de9"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("0d607bf9-040a-48bc-8925-b423981c7daf"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("10a4aa6c-5b83-44fb-b817-de60c81bc375"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("72ab0038-de85-4ca0-9c38-aa9075441ee4"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("8b1aec66-ed4e-4d8b-85f2-fa46eda341ee"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("a7139047-a7c6-4d56-a102-a9f103a75438"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("c002bd0d-06ff-44de-b4aa-9d3b540cfe28"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("cccbd822-5cb7-405c-8539-6ba7e2ded11f"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("f9d77561-1b39-4422-91bc-cbc9b05d8393"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("1aaaf717-4cbd-4ee3-90d3-0452e51d1a19"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("77c72240-b6d9-49e0-885d-de202c4f9dfd"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("923bfb12-ea49-442d-8f28-bf9726644264"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("929b63bf-9464-49db-8904-6b500d52082b"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("a043343c-cdf7-4c0e-a51a-cddd020d5884"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("cb72c778-337f-48be-b255-86f26d086084"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("d7df851b-2a76-4640-9dc5-2de4cdcac722"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("dbbd17a9-2114-4cf5-a723-251dc6521cad"),
                columns: new[] { "CreateDate", "XpToAchieve" },
                values: new object[] { new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local), 2000 });

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("ef8220ff-f7ea-451a-a229-3435669b3854"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("f539bd4c-04f8-4f1a-b815-55b46d85b49b"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 23, 0, 21, 44, 473, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBadges");

            migrationBuilder.UpdateData(
                table: "BrainstormSessions",
                keyColumn: "Id",
                keyValue: new Guid("1fee0e42-7cfb-4438-96f9-4dbee6019de9"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 403, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("0d607bf9-040a-48bc-8925-b423981c7daf"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("10a4aa6c-5b83-44fb-b817-de60c81bc375"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("72ab0038-de85-4ca0-9c38-aa9075441ee4"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("8b1aec66-ed4e-4d8b-85f2-fa46eda341ee"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("a7139047-a7c6-4d56-a102-a9f103a75438"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("c002bd0d-06ff-44de-b4aa-9d3b540cfe28"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("cccbd822-5cb7-405c-8539-6ba7e2ded11f"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationActions",
                keyColumn: "Id",
                keyValue: new Guid("f9d77561-1b39-4422-91bc-cbc9b05d8393"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 406, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("1aaaf717-4cbd-4ee3-90d3-0452e51d1a19"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("77c72240-b6d9-49e0-885d-de202c4f9dfd"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("923bfb12-ea49-442d-8f28-bf9726644264"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("929b63bf-9464-49db-8904-6b500d52082b"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("a043343c-cdf7-4c0e-a51a-cddd020d5884"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 407, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("cb72c778-337f-48be-b255-86f26d086084"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("d7df851b-2a76-4640-9dc5-2de4cdcac722"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("dbbd17a9-2114-4cf5-a723-251dc6521cad"),
                columns: new[] { "CreateDate", "XpToAchieve" },
                values: new object[] { new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local), 21000 });

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("ef8220ff-f7ea-451a-a229-3435669b3854"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "GamificationLevels",
                keyColumn: "Id",
                keyValue: new Guid("f539bd4c-04f8-4f1a-b815-55b46d85b49b"),
                column: "CreateDate",
                value: new DateTime(2019, 5, 8, 22, 10, 43, 408, DateTimeKind.Local));
        }
    }
}
