using fishingapp.Api.Core.Entities;
using fishingapp.Api.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace fishingapp.Api.Application.Services;

public class UserService(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    public async Task<User> CreateUserAndAddress()
    {
        var address = new Address("travessaibirarema12", "santoandre", "saopaulo", "brazil", "09169178");
        var user = new User("victor", "rodrigues", "victor@email.com", "123456", address.Id);
        
        _context.Address.Add(address);
        _context.User.Add(user);
        await _context.SaveChangesAsync();
        
        return user;    
    }

}