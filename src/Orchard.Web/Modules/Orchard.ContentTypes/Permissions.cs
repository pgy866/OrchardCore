﻿using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace Orchard.ContentTypes {
    public class Permissions : IPermissionProvider {
        public static readonly Permission ViewContentTypes = new Permission("ViewContentTypes", "View content types.");
        public static readonly Permission EditContentTypes = new Permission("EditContentTypes", "Edit content types.");

        public virtual Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions() {
            return new [] {
                ViewContentTypes,
                EditContentTypes
            };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = GetPermissions()
                }
            };
        }
    }
}
