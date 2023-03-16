using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPF_EF_CF_EmployeeDepartmentDB.Migrations
{
    /// <inheritdoc />
    public partial class Seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT [dbo].[Departments] ON
INSERT INTO [dbo].[Departments] ([DepartmentId], [Title], [HeadId], [Address], [PhoneNumber]) VALUES (1, N'financial department
', 2, N'Jump street, 21 /4.124', N'+19(55)5644')
INSERT INTO [dbo].[Departments] ([DepartmentId], [Title], [HeadId], [Address], [PhoneNumber]) VALUES (2, N'sales department', 8, N'Jump street, 21 /4.132', N'+14(55)6633')
INSERT INTO [dbo].[Departments] ([DepartmentId], [Title], [HeadId], [Address], [PhoneNumber]) VALUES (3, N'advertising departmant', 6, N'Jump street, 21 /4.105', N'+12(55)6565')
INSERT INTO [dbo].[Departments] ([DepartmentId], [Title], [HeadId], [Address], [PhoneNumber]) VALUES (4, N'production department', 11, N'Jump street, 22 /1.101', N'+55(15)2201')
SET IDENTITY_INSERT [dbo].[Departments] OFF

SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (1, N'Jack', N'Londo', N'1985-10-23 00:00:00', N'USA, Detroit, Freedom str, 55/18', N'e:\temp\db.EmployeeDepartmant_photo\1.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (2, N'Timon', N'Rodriges', N'1988-11-22 00:00:00', N'Poland, Krakow, Independent str, 57/96', N'e:\temp\db.EmployeeDepartmant_photo\2.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (3, N'Roman', N'Salvatore', N'1995-05-05 00:00:00', N'Italia, Bolonia, Musolini, 18', N'e:\temp\db.EmployeeDepartmant_photo\3.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (4, N'Alex', N'Freeman', N'1980-06-07 00:00:00', N'India, Deli, 1st street, 28', N'e:\temp\db.EmployeeDepartmant_photo\4.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (5, N'Gordon', N'White', N'1975-01-05 00:00:00', N'New Zealand,  Wellington, Great str, 99', N'e:\temp\db.EmployeeDepartmant_photo\5.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (6, N'Nik', N'Smith', N'1996-10-10 00:00:00', N'Canada, Ottawa, Green str, 95', N'e:\temp\db.EmployeeDepartmant_photo\6.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (7, N'Bill', N'Gibson', N'1999-10-25 00:00:00', N'Mexica, Tihuana, Red str, 22/11', N'e:\temp\db.EmployeeDepartmant_photo\7.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (8, N'Margaret', N'Galt', N'2000-12-30 00:00:00', N'USA, Miami, Blue str, 77/13', N'e:\temp\db.EmployeeDepartmant_photo\8.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (9, N'Nikol', N'Gray', N'2000-04-12 00:00:00', N'USA, NY, Wall str, 77/85', N'e:\temp\db.EmployeeDepartmant_photo\9.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (10, N'Julia', N'Smith', N'1991-01-01 00:00:00', N'Italia, Bolonia, White str. 44', N'e:\temp\db.EmployeeDepartmant_photo\10.jpg')
INSERT INTO [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Age], [Address], [PhotoPath]) VALUES (11, N'Elena', N'Morrison', N'1995-05-23 00:00:00', N'Austria, Lei, Gray str. 82/33', N'e:\temp\db.EmployeeDepartmant_photo\11.jpg')
SET IDENTITY_INSERT [dbo].[Employees] OFF

INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (1, 1)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (1, 2)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (2, 3)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (2, 4)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (2, 5)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (2, 8)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (3, 6)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (3, 7)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (4, 9)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (4, 10)
INSERT INTO [dbo].[DepartmentsEmployees] ([DepartmentId], [EmployeeId]) VALUES (4, 11)

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
