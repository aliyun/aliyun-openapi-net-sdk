/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenBandwidthPackagesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeCenBandwidthPackages_CenBandwidthPackage> cenBandwidthPackages;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeCenBandwidthPackages_CenBandwidthPackage> CenBandwidthPackages
		{
			get
			{
				return cenBandwidthPackages;
			}
			set	
			{
				cenBandwidthPackages = value;
			}
		}

		public class DescribeCenBandwidthPackages_CenBandwidthPackage
		{

			private string cenBandwidthPackageId;

			private string name;

			private string description;

			private long? bandwidth;

			private string bandwidthPackageChargeType;

			private string geographicRegionAId;

			private string geographicRegionBId;

			private string geographicSpanId;

			private string businessStatus;

			private string creationTime;

			private string expiredTime;

			private string status;

			private bool? isCrossBorder;

			private string typeFor95;

			private string ratio;

			private string hasReservationData;

			private string reservationBandwidth;

			private string reservationInternetChargeType;

			private string reservationActiveTime;

			private string reservationOrderType;

			private List<DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit> orginInterRegionBandwidthLimits;

			private List<DescribeCenBandwidthPackages_Tag> tags;

			private List<string> cenIds;

			public string CenBandwidthPackageId
			{
				get
				{
					return cenBandwidthPackageId;
				}
				set	
				{
					cenBandwidthPackageId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string BandwidthPackageChargeType
			{
				get
				{
					return bandwidthPackageChargeType;
				}
				set	
				{
					bandwidthPackageChargeType = value;
				}
			}

			public string GeographicRegionAId
			{
				get
				{
					return geographicRegionAId;
				}
				set	
				{
					geographicRegionAId = value;
				}
			}

			public string GeographicRegionBId
			{
				get
				{
					return geographicRegionBId;
				}
				set	
				{
					geographicRegionBId = value;
				}
			}

			public string GeographicSpanId
			{
				get
				{
					return geographicSpanId;
				}
				set	
				{
					geographicSpanId = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public bool? IsCrossBorder
			{
				get
				{
					return isCrossBorder;
				}
				set	
				{
					isCrossBorder = value;
				}
			}

			public string TypeFor95
			{
				get
				{
					return typeFor95;
				}
				set	
				{
					typeFor95 = value;
				}
			}

			public string Ratio
			{
				get
				{
					return ratio;
				}
				set	
				{
					ratio = value;
				}
			}

			public string HasReservationData
			{
				get
				{
					return hasReservationData;
				}
				set	
				{
					hasReservationData = value;
				}
			}

			public string ReservationBandwidth
			{
				get
				{
					return reservationBandwidth;
				}
				set	
				{
					reservationBandwidth = value;
				}
			}

			public string ReservationInternetChargeType
			{
				get
				{
					return reservationInternetChargeType;
				}
				set	
				{
					reservationInternetChargeType = value;
				}
			}

			public string ReservationActiveTime
			{
				get
				{
					return reservationActiveTime;
				}
				set	
				{
					reservationActiveTime = value;
				}
			}

			public string ReservationOrderType
			{
				get
				{
					return reservationOrderType;
				}
				set	
				{
					reservationOrderType = value;
				}
			}

			public List<DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit> OrginInterRegionBandwidthLimits
			{
				get
				{
					return orginInterRegionBandwidthLimits;
				}
				set	
				{
					orginInterRegionBandwidthLimits = value;
				}
			}

			public List<DescribeCenBandwidthPackages_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> CenIds
			{
				get
				{
					return cenIds;
				}
				set	
				{
					cenIds = value;
				}
			}

			public class DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit
			{

				private string localRegionId;

				private string oppositeRegionId;

				private string geographicSpanId;

				private string bandwidthLimit;

				public string LocalRegionId
				{
					get
					{
						return localRegionId;
					}
					set	
					{
						localRegionId = value;
					}
				}

				public string OppositeRegionId
				{
					get
					{
						return oppositeRegionId;
					}
					set	
					{
						oppositeRegionId = value;
					}
				}

				public string GeographicSpanId
				{
					get
					{
						return geographicSpanId;
					}
					set	
					{
						geographicSpanId = value;
					}
				}

				public string BandwidthLimit
				{
					get
					{
						return bandwidthLimit;
					}
					set	
					{
						bandwidthLimit = value;
					}
				}
			}

			public class DescribeCenBandwidthPackages_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
