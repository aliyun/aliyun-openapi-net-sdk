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
	public class FindOrderedListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindOrderedList_Data data;

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

		public FindOrderedList_Data Data
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

		public class FindOrderedList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindOrderedList_Order> orderList;

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

			public List<FindOrderedList_Order> OrderList
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

			public class FindOrderedList_Order
			{

				private string alias;

				private string projectName;

				private string serviceName;

				private string serviceVersion;

				private int? orderStatus;

				private int? aliveOrderCount;

				private long? gmtCreate;

				private int? maxRT;

				private int? minRT;

				private string serviceId;

				private int? serviceStatus;

				private List<FindOrderedList_ErrorTypeCatagory> errorTypeCatagoryList;

				private List<FindOrderedList_Order1> orders;

				private FindOrderedList_Total total;

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

				public int? AliveOrderCount
				{
					get
					{
						return aliveOrderCount;
					}
					set	
					{
						aliveOrderCount = value;
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

				public int? MaxRT
				{
					get
					{
						return maxRT;
					}
					set	
					{
						maxRT = value;
					}
				}

				public int? MinRT
				{
					get
					{
						return minRT;
					}
					set	
					{
						minRT = value;
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

				public List<FindOrderedList_ErrorTypeCatagory> ErrorTypeCatagoryList
				{
					get
					{
						return errorTypeCatagoryList;
					}
					set	
					{
						errorTypeCatagoryList = value;
					}
				}

				public List<FindOrderedList_Order1> Orders
				{
					get
					{
						return orders;
					}
					set	
					{
						orders = value;
					}
				}

				public FindOrderedList_Total Total
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

				public class FindOrderedList_ErrorTypeCatagory
				{

					private string name;

					private long? total;

					private long? errorNum;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					public long? ErrorNum
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
				}

				public class FindOrderedList_Order1
				{

					private string alias;

					private string approveComments;

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

					private string userId;

					private FindOrderedList_SlaInfo slaInfo;

					private FindOrderedList_Total2 total2;

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

					public string ApproveComments
					{
						get
						{
							return approveComments;
						}
						set	
						{
							approveComments = value;
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

					public FindOrderedList_SlaInfo SlaInfo
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

					public FindOrderedList_Total2 Total2
					{
						get
						{
							return total2;
						}
						set	
						{
							total2 = value;
						}
					}

					public class FindOrderedList_SlaInfo
					{

						private string qph;

						private string qps;

						public string Qph
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

						public string Qps
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

					public class FindOrderedList_Total2
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

				public class FindOrderedList_Total
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
