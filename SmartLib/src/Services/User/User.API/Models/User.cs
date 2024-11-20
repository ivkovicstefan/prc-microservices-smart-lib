namespace User.API.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Address { get; set; } = default!;
        public List<Role> Roles { get; set; } = default!;

        public bool HasPermission(Permission permission)
        {
            return Roles.Any(role => RolePermissions.Permissions[role].Contains(permission));
        }
    }
}
