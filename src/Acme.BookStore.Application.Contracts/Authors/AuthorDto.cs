using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Authors;

public class AuthorDto : EntityDto<Guid>
{
    public string Name { get; set; }
    public DateTime BrithDate { get; set; }
    public string ShortBio { get; set; }
}