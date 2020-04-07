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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class ListIcpApplicationsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ListIcpApplications_Application> applications;

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

		public List<ListIcpApplications_Application> Applications
		{
			get
			{
				return applications;
			}
			set	
			{
				applications = value;
			}
		}

		public class ListIcpApplications_Application
		{

			private string orderId;

			private float? orderPrice;

			private int? applicationStatus;

			private string companyName;

			private string legalPersonName;

			private int? applicationType;

			private string companyAddress;

			private string domain;

			private bool? includeForeignInvestment;

			private string partnerCode;

			private string userId;

			private string bizId;

			private string intentionBizId;

			private string companyArea;

			private long? updateTime;

			private int? type;

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public float? OrderPrice
			{
				get
				{
					return orderPrice;
				}
				set	
				{
					orderPrice = value;
				}
			}

			public int? ApplicationStatus
			{
				get
				{
					return applicationStatus;
				}
				set	
				{
					applicationStatus = value;
				}
			}

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public string LegalPersonName
			{
				get
				{
					return legalPersonName;
				}
				set	
				{
					legalPersonName = value;
				}
			}

			public int? ApplicationType
			{
				get
				{
					return applicationType;
				}
				set	
				{
					applicationType = value;
				}
			}

			public string CompanyAddress
			{
				get
				{
					return companyAddress;
				}
				set	
				{
					companyAddress = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public bool? IncludeForeignInvestment
			{
				get
				{
					return includeForeignInvestment;
				}
				set	
				{
					includeForeignInvestment = value;
				}
			}

			public string PartnerCode
			{
				get
				{
					return partnerCode;
				}
				set	
				{
					partnerCode = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string IntentionBizId
			{
				get
				{
					return intentionBizId;
				}
				set	
				{
					intentionBizId = value;
				}
			}

			public string CompanyArea
			{
				get
				{
					return companyArea;
				}
				set	
				{
					companyArea = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}
	}
}
