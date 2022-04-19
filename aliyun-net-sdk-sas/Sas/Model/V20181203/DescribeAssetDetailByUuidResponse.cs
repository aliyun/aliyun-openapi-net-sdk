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
	public class DescribeAssetDetailByUuidResponse : AcsResponse
	{

		private string requestId;

		private DescribeAssetDetailByUuid_AssetDetail assetDetail;

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

		public DescribeAssetDetailByUuid_AssetDetail AssetDetail
		{
			get
			{
				return assetDetail;
			}
			set	
			{
				assetDetail = value;
			}
		}

		public class DescribeAssetDetailByUuid_AssetDetail
		{

			private string cpuInfo;

			private string internetIp;

			private string osDetail;

			private long? createTime;

			private string kernel;

			private bool? bind;

			private string osName;

			private string tag;

			private string clientStatus;

			private int? mem;

			private long? memory;

			private string vpcInstanceId;

			private int? authVersion;

			private string instanceName;

			private string region;

			private string groupTrace;

			private string ip;

			private string hostName;

			private string os;

			private long? authModifyTime;

			private string instanceId;

			private string intranetIp;

			private string assetType;

			private string regionId;

			private string sysInfo;

			private string uuid;

			private int? cpu;

			private string regionName;

			private string instanceStatus;

			private int? flag;

			private string clientVersion;

			private List<string> ipList;

			private List<string> macList;

			private List<string> diskInfoList;

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

			public string OsDetail
			{
				get
				{
					return osDetail;
				}
				set	
				{
					osDetail = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
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

			public long? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
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

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
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

			public string SysInfo
			{
				get
				{
					return sysInfo;
				}
				set	
				{
					sysInfo = value;
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

			public int? Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
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

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
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

			public List<string> IpList
			{
				get
				{
					return ipList;
				}
				set	
				{
					ipList = value;
				}
			}

			public List<string> MacList
			{
				get
				{
					return macList;
				}
				set	
				{
					macList = value;
				}
			}

			public List<string> DiskInfoList
			{
				get
				{
					return diskInfoList;
				}
				set	
				{
					diskInfoList = value;
				}
			}
		}
	}
}
