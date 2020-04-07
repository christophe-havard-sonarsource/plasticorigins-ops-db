﻿using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Data.SchemaMigrator.Models.PgContext.Public
{
    public partial class TrajectoryPoint
    {
        public TrajectoryPoint()
        {
            Image = new HashSet<Image>();
            TrajectoryPointRiver = new HashSet<TrajectoryPointRiver>();
        }

        public Guid Id { get; set; }
        public Geometry TheGeom { get; set; }
        public Guid IdRefCampaignFk { get; set; }
        public double? Elevation { get; set; }
        public double? Distance { get; set; }
        public TimeSpan? TimeDiff { get; set; }
        public DateTime? Time { get; set; }
        public double? Speed { get; set; }
        public DateTime? Createdon { get; set; }

        public virtual Campaign IdRefCampaignFkNavigation { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<TrajectoryPointRiver> TrajectoryPointRiver { get; set; }
    }
}
