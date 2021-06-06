﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SyncfusionBlazorServerWithAuthCore3
{
    public partial class EventDetails
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int DomainId { get; set; }
        public int EventCategoryId { get; set; }
        public string EventAddress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string EventDescription { get; set; }
        public string SendTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public int? LastSentBy { get; set; }
        public DateTime? LastSentDate { get; set; }
        public int CountSent { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}