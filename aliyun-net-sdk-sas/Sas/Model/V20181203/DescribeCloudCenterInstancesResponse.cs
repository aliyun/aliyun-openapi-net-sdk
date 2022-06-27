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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeCloudCenterInstancesResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<DescribeCloudCenterInstances_Instance> instances;

		private DescribeCloudCenterInstances_PageInfo pageInfo;

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

			private string status;

			private string cpuInfo;

			private string internetIp;

			private string kernel;

			private bool? bind;

			private string osName;

			private string tag;

			private string clientStatus;

			private int? mem;

			private string vpcInstanceId;

			private string tagId;

			private int? flag;

			private long? lastLoginTimestamp;

			private int? authVersion;

			private string region;

			private string instanceName;

			private int? podCount;

			private int? vulCount;

			private string hcStatus;

			private long? createdTime;

			private string groupTrace;

			private string clusterId;

			private string riskStatus;

			private int? cores;

			private string vulStatus;

			private string alarmStatus;

			private string macListString;

			private int? importance;

			private int? healthCheckCount;

			private string ip;

			private string os;

			private long? authModifyTime;

			private int? safeEventCount;

			private string instanceId;

			private string assetType;

			private string intranetIp;

			private int? vendor;

			private string regionId;

			private string uuid;

			private long? groupId;

			private string regionName;

			private string vendorName;

			private string authVersionName;

			private string clusterName;

			private int? exposedStatus;

			private string riskCount;

			private string ipListString;

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

			public string CpuInfo
			{
				get
				{
					return cpuInfo;
				}
				set	
				{
					cpuInfo = value;
				}
			}

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

			public string Kernel
			{
				get
				{
					return kernel;
				}
				set	
				{
					kernel = value;
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

			public int? Mem
			{
				get
				{
					return mem;
				}
				set	
				{
					mem = value;
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

			public string TagId
			{
				get
				{
					return tagId;
				}
				set	
				{
					tagId = value;
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

			public long? LastLoginTimestamp
			{
				get
				{
					return lastLoginTimestamp;
				}
				set	
				{
					lastLoginTimestamp = value;
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

			public string GroupTrace
			{
				get
				{
					return groupTrace;
				}
				set	
				{
					groupTrace = value;
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

			public string MacListString
			{
				get
				{
					return macListString;
				}
				set	
				{
					macListString = value;
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

			public long? GroupId
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

			public string AuthVersionName
			{
				get
				{
					return authVersionName;
				}
				set	
				{
					authVersionName = value;
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

			public string IpListString
			{
				get
				{
					return ipListString;
				}
				set	
				{
					ipListString = value;
				}
			}
		}

		public class DescribeCloudCenterInstances_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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
		}
	}
}
