﻿using System.ComponentModel;

namespace MDRService.Common.Linq.Model
{
    public record DynamicOrderFields
    {
        public int SortNumber { get; init; }
        public string PropertyName { get; init; } = "CreatedOn";
        public ListSortDirection SortDirection { get; init; }
    }
}
