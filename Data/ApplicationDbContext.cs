﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactLister.Models;

namespace ContactLister.Data;
public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; } = default!;
    public virtual DbSet<Category> Categories { get; set; } = default!;
}
