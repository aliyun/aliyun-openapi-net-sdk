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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDomainInfoResponse : AcsResponse
	{

		private string requestId;

		private string domainId;

		private string domainName;

		private string punyCode;

		private bool? aliDomain;

		private string remark;

		private string groupId;

		private string groupName;

		private string instanceId;

		private string versionCode;

		private string versionName;

		private long? minTtl;

		private string recordLineTreeJson;

		private string lineType;

		private bool? regionLines;

		private bool? inBlackHole;

		private bool? inClean;

		private bool? slaveDns;

		private string resourceGroupId;

		private string createTime;

		private List<DescribeDomainInfo_RecordLine> recordLines;

		private List<string> dnsServers;

		private List<string> availableTtls;

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

		public string DomainId
		{
			get
			{
				return domainId;
			}
			set	
			{
				domainId = value;
			}
		}

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

		public string PunyCode
		{
			get
			{
				return punyCode;
			}
			set	
			{
				punyCode = value;
			}
		}

		public bool? AliDomain
		{
			get
			{
				return aliDomain;
			}
			set	
			{
				aliDomain = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
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

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
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

		public string VersionCode
		{
			get
			{
				return versionCode;
			}
			set	
			{
				versionCode = value;
			}
		}

		public string VersionName
		{
			get
			{
				return versionName;
			}
			set	
			{
				versionName = value;
			}
		}

		public long? MinTtl
		{
			get
			{
				return minTtl;
			}
			set	
			{
				minTtl = value;
			}
		}

		public string RecordLineTreeJson
		{
			get
			{
				return recordLineTreeJson;
			}
			set	
			{
				recordLineTreeJson = value;
			}
		}

		public string LineType
		{
			get
			{
				return lineType;
			}
			set	
			{
				lineType = value;
			}
		}

		public bool? RegionLines
		{
			get
			{
				return regionLines;
			}
			set	
			{
				regionLines = value;
			}
		}

		public bool? InBlackHole
		{
			get
			{
				return inBlackHole;
			}
			set	
			{
				inBlackHole = value;
			}
		}

		public bool? InClean
		{
			get
			{
				return inClean;
			}
			set	
			{
				inClean = value;
			}
		}

		public bool? SlaveDns
		{
			get
			{
				return slaveDns;
			}
			set	
			{
				slaveDns = value;
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		public string CreateTime
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

		public List<DescribeDomainInfo_RecordLine> RecordLines
		{
			get
			{
				return recordLines;
			}
			set	
			{
				recordLines = value;
			}
		}

		public List<string> DnsServers
		{
			get
			{
				return dnsServers;
			}
			set	
			{
				dnsServers = value;
			}
		}

		public List<string> AvailableTtls
		{
			get
			{
				return availableTtls;
			}
			set	
			{
				availableTtls = value;
			}
		}

		public class DescribeDomainInfo_RecordLine
		{

			private string lineCode;

			private string fatherCode;

			private string lineName;

			private string lineDisplayName;

			public string LineCode
			{
				get
				{
					return lineCode;
				}
				set	
				{
					lineCode = value;
				}
			}

			public string FatherCode
			{
				get
				{
					return fatherCode;
				}
				set	
				{
					fatherCode = value;
				}
			}

			public string LineName
			{
				get
				{
					return lineName;
				}
				set	
				{
					lineName = value;
				}
			}

			public string LineDisplayName
			{
				get
				{
					return lineDisplayName;
				}
				set	
				{
					lineDisplayName = value;
				}
			}
		}
	}
}
