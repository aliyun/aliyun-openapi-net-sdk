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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnOfflineLogDeliveryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDcdnOfflineLogDelivery_Domain> domains;

		private List<DescribeDcdnOfflineLogDelivery_Region> regions;

		private List<string> fields;

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

		public List<DescribeDcdnOfflineLogDelivery_Domain> Domains
		{
			get
			{
				return domains;
			}
			set	
			{
				domains = value;
			}
		}

		public List<DescribeDcdnOfflineLogDelivery_Region> Regions
		{
			get
			{
				return regions;
			}
			set	
			{
				regions = value;
			}
		}

		public List<string> Fields
		{
			get
			{
				return fields;
			}
			set	
			{
				fields = value;
			}
		}

		public class DescribeDcdnOfflineLogDelivery_Domain
		{

			private string domainName;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}
		}

		public class DescribeDcdnOfflineLogDelivery_Region
		{

			private int? ossId;

			private string ossBucketName;

			private string ossPathPrefix;

			private string dlaVcName;

			private string regionId;

			private string regionName;

			private string isOverseas;

			private string ossEndpoint;

			private string areaId;

			private string areaName;

			private string dlaDbName;

			private string dlaTableName;

			public int? OssId
			{
				get
				{
					return ossId;
				}
				set	
				{
					ossId = value;
				}
			}

			public string OssBucketName
			{
				get
				{
					return ossBucketName;
				}
				set	
				{
					ossBucketName = value;
				}
			}

			public string OssPathPrefix
			{
				get
				{
					return ossPathPrefix;
				}
				set	
				{
					ossPathPrefix = value;
				}
			}

			public string DlaVcName
			{
				get
				{
					return dlaVcName;
				}
				set	
				{
					dlaVcName = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public string IsOverseas
			{
				get
				{
					return isOverseas;
				}
				set	
				{
					isOverseas = value;
				}
			}

			public string OssEndpoint
			{
				get
				{
					return ossEndpoint;
				}
				set	
				{
					ossEndpoint = value;
				}
			}

			public string AreaId
			{
				get
				{
					return areaId;
				}
				set	
				{
					areaId = value;
				}
			}

			public string AreaName
			{
				get
				{
					return areaName;
				}
				set	
				{
					areaName = value;
				}
			}

			public string DlaDbName
			{
				get
				{
					return dlaDbName;
				}
				set	
				{
					dlaDbName = value;
				}
			}

			public string DlaTableName
			{
				get
				{
					return dlaTableName;
				}
				set	
				{
					dlaTableName = value;
				}
			}
		}
	}
}
