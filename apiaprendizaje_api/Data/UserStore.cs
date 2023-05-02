using apiaprendizaje_api.Models.Dto;

namespace apiaprendizaje_api.Data
{
    public static class UserStore
    {
        public static List<UserDto> userList = new List<UserDto>
        {
            new UserDto {Id= 1, Role ="Admin"}, new UserDto {Id= 2, Role = "Clients"}, new UserDto {Id= 3, Role ="Store"},
        };
    }
}
