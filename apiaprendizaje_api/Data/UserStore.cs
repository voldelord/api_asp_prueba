using apiaprendizaje_api.Models.Dto;

namespace apiaprendizaje_api.Data
{
    public static class UserStore
    {
        public static List<UserDto> userList = new List<UserDto>
        {
            new UserDto {Id= 1, Role ="Admin", Name = "Luis", Email = "xxxx@xxx.com"  }, 
            new UserDto {Id= 2, Role = "Clients" , Name= "Fernando", Email="admin@admin.com"}, 
            new UserDto {Id= 3, Role ="Store", Name= "Juan" , Email ="asa@asas.com"},
        };
    }
}
