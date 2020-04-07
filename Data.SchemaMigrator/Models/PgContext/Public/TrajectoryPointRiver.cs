﻿using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Data.SchemaMigrator.Models.PgContext.Public
{
    public partial class TrajectoryPointRiver
    {
        public int Id { get; set; }
        public Guid IdRefTrajectoryPointFk { get; set; }
        public int IdRefRiverFk { get; set; }
        public Geometry TrajectoryPointTheGeom { get; set; }
        public Geometry RiverTheGeom { get; set; }
        public Geometry ClosestPointTheGeom { get; set; }
        public double DistanceRiverTrajectoryPoint { get; set; }
        public Geometry ProjectionTrajectoryPointRiverTheGeom { get; set; }
        public int? Importance { get; set; }
        public DateTime? Createdon { get; set; }

        public virtual River IdRefRiverFkNavigation { get; set; }
        public virtual TrajectoryPoint IdRefTrajectoryPointFkNavigation { get; set; }
    }
}
