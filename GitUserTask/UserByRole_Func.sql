Create Function UserByRole(@role NVARCHAR(50))
Returns Table
as
Return 
(Select u.UserId, u.Email, u.UserName, u.DateBirthday, u.JobTitleId
 From Users u, Roles r, UserInRoles ur
 Where u.UserId = ur.UserId AND ur.RoleId = r.RoleId AND r.RoleName = @role )
Go

Select * From UserByRole('administrator')

Select * From Roles