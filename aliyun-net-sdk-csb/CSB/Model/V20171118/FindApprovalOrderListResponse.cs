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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindApprovalOrderListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindApprovalOrderList_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public FindApprovalOrderList_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class FindApprovalOrderList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindApprovalOrderList_Order> orderList;

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

			public List<FindApprovalOrderList_Order> OrderList
			{
				get
				{
					return orderList;
				}
				set	
				{
					orderList = value;
				}
			}

			public class FindApprovalOrderList_Order
			{

				private string alias;

				private long? credentialGroupId;

				private long? csbId;

				private long? gmtCreate;

				private long? gmtModified;

				private string groupName;

				private long? id;

				private string projectName;

				private long? serviceId;

				private string serviceName;

				private int? serviceStatus;

				private string serviceVersion;

				private string statisticName;

				private int? status;

				private string strictWhiteListJson;

				private string userId;

				private string userName;

				private FindApprovalOrderList_SlaInfo slaInfo;

				private FindApprovalOrderList_Total total;

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}

				public long? CredentialGroupId
				{
					get
					{
						return credentialGroupId;
					}
					set	
					{
						credentialGroupId = value;
					}
				}

				public long? CsbId
				{
					get
					{
						return csbId;
					}
					set	
					{
						csbId = value;
					}
				}

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public long? GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
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

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string ProjectName
				{
					get
					{
						return projectName;
					}
					set	
					{
						projectName = value;
					}
				}

				public long? ServiceId
				{
					get
					{
						return serviceId;
					}
					set	
					{
						serviceId = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public int? ServiceStatus
				{
					get
					{
						return serviceStatus;
					}
					set	
					{
						serviceStatus = value;
					}
				}

				public string ServiceVersion
				{
					get
					{
						return serviceVersion;
					}
					set	
					{
						serviceVersion = value;
					}
				}

				public string StatisticName
				{
					get
					{
						return statisticName;
					}
					set	
					{
						statisticName = value;
					}
				}

				public int? Status
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

				public string StrictWhiteListJson
				{
					get
					{
						return strictWhiteListJson;
					}
					set	
					{
						strictWhiteListJson = value;
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

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				public FindApprovalOrderList_SlaInfo SlaInfo
				{
					get
					{
						return slaInfo;
					}
					set	
					{
						slaInfo = value;
					}
				}

				public FindApprovalOrderList_Total Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}

				public class FindApprovalOrderList_SlaInfo
				{

					private int? qph;

					private int? qps;

					public int? Qph
					{
						get
						{
							return qph;
						}
						set	
						{
							qph = value;
						}
					}

					public int? Qps
					{
						get
						{
							return qps;
						}
						set	
						{
							qps = value;
						}
					}
				}

				public class FindApprovalOrderList_Total
				{

					private int? errorNum;

					private int? total;

					public int? ErrorNum
					{
						get
						{
							return errorNum;
						}
						set	
						{
							errorNum = value;
						}
					}

					public int? Total
					{
						get
						{
							return total;
						}
						set	
						{
							total = value;
						}
					}
				}
			}
		}
	}
}
