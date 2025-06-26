    using System;

    namespace TenableApi.Models
    {
        public class Group
        {
            public int Id { get; set; }
            public Guid Uuid { get; set; }
            public string Name { get; set; }
            public long CreationDate { get; set; }
            public long LastModificationDate { get; set; }
            public long Timestamp { get; set; }
            public int Shared { get; set; }
            public string Owner { get; set; }
            public int OwnerId { get; set; }
            public string OwnerName { get; set; }
            public Guid OwnerUuid { get; set; }
            public int UserPermissions { get; set; }
            public int AgentsCount { get; set; }
        }
    }