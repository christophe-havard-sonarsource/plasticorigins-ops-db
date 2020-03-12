﻿using System;
using System.Collections.Generic;

namespace Data.SchemaMigrator.Models.Raw
{
    public partial class Campaign
    {
        public Campaign()
        {
            CampaignImageAssoc = new HashSet<CampaignImageAssoc>();
            CampaignStaff = new HashSet<CampaignStaff>();
            Trash = new HashSet<Trash>();
        }

        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? StartLat { get; set; }
        public double? StartLong { get; set; }
        public double? EndLat { get; set; }
        public double? EndLong { get; set; }
        public string Locomotion { get; set; }
        public bool IsAidriven { get; set; }
        public string Remark { get; set; }
        public decimal? RiverId { get; set; }
        public bool TracedRiverSide { get; set; }
        public Guid? UserId { get; set; }

        public virtual River River { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CampaignImageAssoc> CampaignImageAssoc { get; set; }
        public virtual ICollection<CampaignStaff> CampaignStaff { get; set; }
        public virtual ICollection<Trash> Trash { get; set; }
    }
}