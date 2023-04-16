﻿using DoAnThucTap.DTOs.Const;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using DoAnThucTap.Web.WebConfig.Const;
using System;

namespace DoAnThucTap.Web.Common
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class AppAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private int actionPermission;
        public AppAuthorizeAttribute(int permission = AuthConst.NO_PERMISSION)
        {
            actionPermission = permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;
            var userPermission = user.FindFirstValue(AppClaimType.Permissions);

            if (actionPermission != AuthConst.NO_PERMISSION)
            {
                var isAuthorized = userPermission.Contains(this.actionPermission.ToString());
                if (!isAuthorized)
                {
                    context.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
                }
            }
        }
    }
}
