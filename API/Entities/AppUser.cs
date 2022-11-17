using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUser : IdentityUser<int>
{
  public string Firstname { get; set; } = null!; //this shows that it can't be null
  public string Lastname { get; set; } = null!;
  public string Gender { get; set; } = null!;
  public DateTime DateOfBirth { get; set; }
  public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.UtcNow;
  public DateTimeOffset LastActive { get; set; } = DateTimeOffset.UtcNow;
  public string? Interests { get; set; }
  public string? City { get; set; }
  public string? Country { get; set; }
  public string? Introduction { get; set; }
  public string? Relationship {get; set;}
  public string?  Religion { get; set; }

  public ICollection<AppUserRole>? UserRoles {get; set;}
  public ICollection<Photo>? Photos {get; set;}
  public string GetFullName(){
    return $"{Firstname} {Lastname}";
  } // this and Fullname does the same thing
  public string FullName => $"{Firstname} {Lastname}";
}