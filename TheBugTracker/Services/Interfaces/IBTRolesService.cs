using TheBugTracker.Models;

namespace TheBugTracker.Services.Interfaces
{
    public interface IBTRolesService
    {
        public Task<bool> IsUserInRoleAsync(BTUser user, string roleName);

        public Task<IEnumerable<string>> GetUserRolesAsync(BTUser user);

        public Task<bool> AddUserToRoleAsync(BTUser user, string roleName);

        //remove user from a role
        public Task<bool> RemoveUserFromRoleAsync(BTUser user, string roleName);

        //remove user from all roles
        public Task<bool> RemoveUserFromRoleAsync(BTUser user, IEnumerable<string> roles);

        public Task<List<BTUser>> GetUsersInRoleAsync(string roleName, int companyId);
    }
}
