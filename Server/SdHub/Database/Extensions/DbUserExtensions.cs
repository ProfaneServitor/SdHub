﻿using System;
using System.Linq;
using SdHub.Database.Entities.Users;

namespace SdHub.Database.Extensions;

public static class DbUserExtensions
{
    public static IQueryable<UserEntity> ApplyFilter(this IQueryable<UserEntity> q, string? loginOrEmail = null,
        string? email = null, string? login = null, bool? anonymous = false, Guid? guid = null, bool? deleted = false)
    {
        if (loginOrEmail != null)
        {
            loginOrEmail = loginOrEmail.ToUpper().Normalize();
            q = q.Where(x => x.EmailNormalized == loginOrEmail || x.LoginNormalized == loginOrEmail);
        }

        if (deleted == false)
            q = q.Where(x => x.DeletedAt == null);
        else if (deleted == true)
            q = q.Where(x => x.DeletedAt != null);

        if (email != null)
            q = q.Where(x => x.EmailNormalized == email.ToUpper().Normalize());

        if (login != null)
            q = q.Where(x => x.LoginNormalized == login.ToUpper().Normalize());

        if (anonymous != null)
            q = q.Where(x => x.IsAnonymous == anonymous);

        if (guid != null)
            q = q.Where(x => x.Guid == guid);

        return q;
    }
}