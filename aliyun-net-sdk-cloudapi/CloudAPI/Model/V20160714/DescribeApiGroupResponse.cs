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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiGroupResponse : AcsResponse
	{

		private string groupId;

		private string groupName;

		private string subDomain;

		private string description;

		private string createdTime;

		private string modifiedTime;

		private string regionId;

		private string status;

		private BillingStatusEnum? billingStatus;

		private IllegalStatusEnum? illegalStatus;

		private int? trafficLimit;

		private List<DomainItem> customDomains;

		private List<StageInfo> stageItems;

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

		public BillingStatusEnum? BillingStatus
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

		public IllegalStatusEnum? IllegalStatus
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

		public List<DomainItem> CustomDomains
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

		public List<StageInfo> StageItems
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

public enum BillingStatusEnum {

			NORMAL,
			LOCKED,
}

public enum IllegalStatusEnum {

			NORMAL,
			LOCKED,
}

		public class DomainItem{

			private string domainName;

			private string certificateId;

			private string certificateName;

			private string domainCNAMEStatus;

			private string domainBindingStatus;

			private string domainLegalStatus;

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

		public class StageInfo{

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