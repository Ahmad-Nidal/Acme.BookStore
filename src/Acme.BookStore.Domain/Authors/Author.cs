using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Authors;

public class Author : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; private set; }
    public DateTime BrithDate { get; set; }
    public string ShortBio { get; set; }

    private Author()
    {
        
    }

    internal Author(
        Guid id,
        [NotNull] string name,
        DateTime brithDate,
        [CanBeNull] string shortBio = null)
        : base(id)
    {
        SetName(name);
        BrithDate = brithDate;
        ShortBio = shortBio;
    }

    internal Author ChangeName([NotNull] string name)
    {
        SetName(name);
        return this;
    }

    private void SetName([NotNull]string name)
    {
        Name = Check.NotNullOrWhiteSpace(
            name,
            nameof(name),
            maxLength: AuthorConsts.MaxNameLength);
    }
}