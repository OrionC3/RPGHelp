﻿using System.Security.Claims;
using System.Security.Principal;

namespace TI_Net2025_DemoCleanAsp.Extensions
{
    public static class UserExtensions
    {
        public static int GetId(this ClaimsPrincipal claims)
        {
            return int.Parse(claims.FindFirst(ClaimTypes.Sid)!.Value);
        }

        public static string GetEmail(this ClaimsPrincipal claims)
        {
            return claims.FindFirst(ClaimTypes.Email)!.Value;
        }

        public static bool IsConnected(this ClaimsPrincipal claims)
        {
            return claims.Identity?.IsAuthenticated ?? false;
        }

        public static bool IsConnected(this IPrincipal claims)
        {
            return claims.Identity?.IsAuthenticated ?? false;
        }
    }
}
