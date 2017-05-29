// Copyright 2017 Vasylyk Andriy
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sith.Data.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sith.Data
{
    public class CustomUserStore : UserStore<ApplicationUser>
    {
        public CustomUserStore(DbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        public override Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken = new CancellationToken())
        {
            return Users.Include(u => u.Store).ThenInclude(ps => ps.Passwords)
                .FirstOrDefaultAsync(u => String.Equals(u.Id, userId), cancellationToken);
        }
    }
}