using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Authors;

public class CreatAuthorDto
{
    [Required]
    [StringLength(AuthorConsts.MaxNameLength)]
    public string Name { get; set; }
    
    [Required]
    public DateTime BrithDate { get; set; }
    
    public string ShortBio { get; set; }
}