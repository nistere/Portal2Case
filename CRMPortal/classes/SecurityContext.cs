﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal2Case.classes
{
    public class SecurityContext
    {
        public EntityPermissionsContext EntityPermissions;
        public EntityPermissionsContext RelatedEntityPermissions;

        /// <summary>
        /// List of entity logical names allowed for create, update, and read
        /// Can define for entities and related entities (entities retrieved in relations to another)
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="relatedEntities"></param>
        public SecurityContext(EntityPermissionsContext entities, EntityPermissionsContext relatedEntities)
        {
            EntityPermissions = entities ?? new EntityPermissionsContext(null, null, null);
            RelatedEntityPermissions = relatedEntities ?? new EntityPermissionsContext(null, null, null);
        }
    }

    /// <summary>
    /// List of entities which have permissions
    /// </summary>
    public class EntityPermissionsContext
    {
        public readonly List<string> Read;
        public readonly List<string> Create;
        public readonly List<string> Update;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="read">List of crm entities (logical name) with read permissions. Case sensitive</param>
        /// <param name="create">List of crm entities (logical name) with create permissions. Case sensitive</param>
        /// <param name="update">List of crm entities (logical name) with update permissions. Case sensitive</param>
        public EntityPermissionsContext(List<string> read, List<string> create, List<string> update)
        {
            Read = read ?? new List<string>();
            Create = create ?? new List<string>();
            Update = update ?? new List<string>();
        }
    }
}