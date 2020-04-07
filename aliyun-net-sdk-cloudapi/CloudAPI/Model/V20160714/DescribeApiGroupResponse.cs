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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiGroupResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private string groupName;

		private string subDomain;

		private string description;

		private string createdTime;

		private string modifiedTime;

		private string regionId;

		private string status;

		private string billingStatus;

		private string illegalStatus;

		private int? trafficLimit;

		private string vpcDomain;

		private string instanceType;

		private string instanceId;

		private string httpsPolicy;

		private string userLogConfig;

		private string customTraceConfig;

		private string rpcPattern;

		private string compatibleFlags;

		private List<DescribeApiGroup_DomainItem> customDomains;

		private List<DescribeApiGroup_StageInfo> stageItems;

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

		public string SubDomain
		{
			get
			{
				return subDomain;
			}
			set	
			{
				subDomain = value;
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

		public string CreatedTime
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

		public string ModifiedTime
		{
			get
			{
				return modifiedTime;
			}
			set	
			{
				modifiedTime = value;
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

		public string BillingStatus
		{
			get
			{
				return billingStatus;
			}
			set	
			{
				billingStatus = value;
			}
		}

		public string IllegalStatus
		{
			get
			{
				return illegalStatus;
			}
			set	
			{
				illegalStatus = value;
			}
		}

		public int? TrafficLimit
		{
			get
			{
				return trafficLimit;
			}
			set	
			{
				trafficLimit = value;
			}
		}

		public string VpcDomain
		{
			get
			{
				return vpcDomain;
			}
			set	
			{
				vpcDomain = value;
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
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

		public string HttpsPolicy
		{
			get
			{
				return httpsPolicy;
			}
			set	
			{
				httpsPolicy = value;
			}
		}

		public string UserLogConfig
		{
			get
			{
				return userLogConfig;
			}
			set	
			{
				userLogConfig = value;
			}
		}

		public string CustomTraceConfig
		{
			get
			{
				return customTraceConfig;
			}
			set	
			{
				customTraceConfig = value;
			}
		}

		public string RpcPattern
		{
			get
			{
				return rpcPattern;
			}
			set	
			{
				rpcPattern = value;
			}
		}

		public string CompatibleFlags
		{
			get
			{
				return compatibleFlags;
			}
			set	
			{
				compatibleFlags = value;
			}
		}

		public List<DescribeApiGroup_DomainItem> CustomDomains
		{
			get
			{
				return customDomains;
			}
			set	
			{
				customDomains = value;
			}
		}

		public List<DescribeApiGroup_StageInfo> StageItems
		{
			get
			{
				return stageItems;
			}
			set	
			{
				stageItems = value;
			}
		}

		public class DescribeApiGroup_DomainItem
		{

			private string domainName;

			private string certificateId;

			private string certificateName;

			private string domainCNAMEStatus;

			private string domainBindingStatus;

			private string bindStageName;

			private string domainLegalStatus;

			private string domainWebSocketStatus;

			private string domainRemark;

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

			public string CertificateId
			{
				get
				{
					return certificateId;
				}
				set	
				{
					certificateId = value;
				}
			}

			public string CertificateName
			{
				get
				{
					return certificateName;
				}
				set	
				{
					certificateName = value;
				}
			}

			public string DomainCNAMEStatus
			{
				get
				{
					return domainCNAMEStatus;
				}
				set	
				{
					domainCNAMEStatus = value;
				}
			}

			public string DomainBindingStatus
			{
				get
				{
					return domainBindingStatus;
				}
				set	
				{
					domainBindingStatus = value;
				}
			}

			public string BindStageName
			{
				get
				{
					return bindStageName;
				}
				set	
				{
					bindStageName = value;
				}
			}

			public string DomainLegalStatus
			{
				get
				{
					return domainLegalStatus;
				}
				set	
				{
					domainLegalStatus = value;
				}
			}

			public string DomainWebSocketStatus
			{
				get
				{
					return domainWebSocketStatus;
				}
				set	
				{
					domainWebSocketStatus = value;
				}
			}

			public string DomainRemark
			{
				get
				{
					return domainRemark;
				}
				set	
				{
					domainRemark = value;
				}
			}
		}

		public class DescribeApiGroup_StageInfo
		{

			private string stageId;

			private string stageName;

			private string description;

			public string StageId
			{
				get
				{
					return stageId;
				}
				set	
				{
					stageId = value;
				}
			}

			public string StageName
			{
				get
				{
					return stageName;
				}
				set	
				{
					stageName = value;
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
		}
	}
}
