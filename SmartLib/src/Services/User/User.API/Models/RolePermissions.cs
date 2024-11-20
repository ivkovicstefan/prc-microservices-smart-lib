namespace User.API.Models
{
    public static class RolePermissions
    {
        public static readonly Dictionary<Role, List<Permission>> Permissions = new()
        {
            { Role.Student, new List<Permission> { Permission.UpateUser } },
            { Role.Teacher, new List<Permission> { Permission.UpateUser, Permission.ManageCourses, Permission.AssignBooks } },
            { Role.Staff, new List<Permission> { Permission.UpateUser, Permission.RegisterUsers, Permission.ManageBooks, Permission.AssignBooks, Permission.ManageCourses, Permission.ManageFines } }
        };
    }
}
