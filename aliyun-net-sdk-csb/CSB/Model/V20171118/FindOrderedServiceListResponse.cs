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
	public class FindOrderedServiceListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindOrderedServiceList_Data data;

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

		public FindOrderedServiceList_Data Data
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

		public class FindOrderedServiceList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private long? total;

			private List<FindOrderedServiceList_Order> orderList;

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

			public long? Total
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

			public List<FindOrderedServiceList_Order> OrderList
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

			public class FindOrderedServiceList_Order
			{

				private string serviceName;

				private string serviceVersion;

				private int? orderStatus;

				private long? gmtCreate;

				private string serviceId;

				private int? serviceStatus;

				private long? credentialGroupId;

				private long? gmtModified;

				private string projectName;

				private long? id;

				private string credentialGroupName;

				private FindOrderedServiceList_SlaInfo slaInfo;

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

				public int? OrderStatus
				{
					get
					{
						return orderStatus;
					}
					set	
					{
						orderStatus = value;
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

				public string ServiceId
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

				public string CredentialGroupName
				{
					get
					{
						return credentialGroupName;
					}
					set	
					{
						credentialGroupName = value;
					}
				}

				public FindOrderedServiceList_SlaInfo SlaInfo
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

				public class FindOrderedServiceList_SlaInfo
				{

					private long? qps;

					private long? qph;

					public long? Qps
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

					public long? Qph
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
				}
			}
		}
	}
}
