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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeCloudCenterInstancesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeCloudCenterInstances_Instance> instances;

		private DescribeCloudCenterInstances_PageInfo pageInfo;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeCloudCenterInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public DescribeCloudCenterInstances_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeCloudCenterInstances_Instance
		{

			private string internetIp;

			private string os;

			private string instanceId;

			private string instanceName;

			private string regionName;

			private string ip;

			private string clientStatus;

			private string region;

			private string uuid;

			private string intranetIp;

			private string assetType;

			private string status;

			private string tag;

			private string vpcInstanceId;

			private string osName;

			private int? flag;

			private string hcStatus;

			private string vulStatus;

			private string alarmStatus;

			private string riskStatus;

			private int? healthCheckCount;

			private int? vulCount;

			private int? safeEventCount;

			private string regionId;

			private string groupId;

			private int? importance;

			private string clientVersion;

			private string riskCount;

			private string clusterId;

			private string clusterName;

			private long? createdTime;

			private int? podCount;

			private int? exposedStatus;

			private int? autoSnapshotsLevel;

			private int? exposedCount;

			private int? vendor;

			private string vendorName;

			private int? cores;

			private int? authVersion;

			private bool? bind;

			private long? authModifyTime;

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string Os
			{
				get
				{
					return os;
				}
				set	
				{
					os = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
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

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string ClientStatus
			{
				get
				{
					return clientStatus;
				}
				set	
				{
					clientStatus = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string AssetType
			{
				get
				{
					return assetType;
				}
				set	
				{
					assetType = value;
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

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
				}
			}

			public string OsName
			{
				get
				{
					return osName;
				}
				set	
				{
					osName = value;
				}
			}

			public int? Flag
			{
				get
				{
					return flag;
				}
				set	
				{
					flag = value;
				}
			}

			public string HcStatus
			{
				get
				{
					return hcStatus;
				}
				set	
				{
					hcStatus = value;
				}
			}

			public string VulStatus
			{
				get
				{
					return vulStatus;
				}
				set	
				{
					vulStatus = value;
				}
			}

			public string AlarmStatus
			{
				get
				{
					return alarmStatus;
				}
				set	
				{
					alarmStatus = value;
				}
			}

			public string RiskStatus
			{
				get
				{
					return riskStatus;
				}
				set	
				{
					riskStatus = value;
				}
			}

			public int? HealthCheckCount
			{
				get
				{
					return healthCheckCount;
				}
				set	
				{
					healthCheckCount = value;
				}
			}

			public int? VulCount
			{
				get
				{
					return vulCount;
				}
				set	
				{
					vulCount = value;
				}
			}

			public int? SafeEventCount
			{
				get
				{
					return safeEventCount;
				}
				set	
				{
					safeEventCount = value;
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

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public int? Importance
			{
				get
				{
					return importance;
				}
				set	
				{
					importance = value;
				}
			}

			public string ClientVersion
			{
				get
				{
					return clientVersion;
				}
				set	
				{
					clientVersion = value;
				}
			}

			public string RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public long? CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public int? PodCount
			{
				get
				{
					return podCount;
				}
				set	
				{
					podCount = value;
				}
			}

			public int? ExposedStatus
			{
				get
				{
					return exposedStatus;
				}
				set	
				{
					exposedStatus = value;
				}
			}

			public int? AutoSnapshotsLevel
			{
				get
				{
					return autoSnapshotsLevel;
				}
				set	
				{
					autoSnapshotsLevel = value;
				}
			}

			public int? ExposedCount
			{
				get
				{
					return exposedCount;
				}
				set	
				{
					exposedCount = value;
				}
			}

			public int? Vendor
			{
				get
				{
					return vendor;
				}
				set	
				{
					vendor = value;
				}
			}

			public string VendorName
			{
				get
				{
					return vendorName;
				}
				set	
				{
					vendorName = value;
				}
			}

			public int? Cores
			{
				get
				{
					return cores;
				}
				set	
				{
					cores = value;
				}
			}

			public int? AuthVersion
			{
				get
				{
					return authVersion;
				}
				set	
				{
					authVersion = value;
				}
			}

			public bool? Bind
			{
				get
				{
					return bind;
				}
				set	
				{
					bind = value;
				}
			}

			public long? AuthModifyTime
			{
				get
				{
					return authModifyTime;
				}
				set	
				{
					authModifyTime = value;
				}
			}
		}

		public class DescribeCloudCenterInstances_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
