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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeEventsResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeEvents__Event> items;

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

		public List<DescribeEvents__Event> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeEvents__Event
		{

			private string displayName;

			private int? status;

			private int? warnLevel;

			private long? userId;

			private string statusName;

			private string departName;

			private string dealUserIdValue;

			private long? dealTime;

			private string dealLoginName;

			private string subTypeName;

			private bool? backed;

			private string instanceName;

			private long? eventTime;

			private string loginName;

			private string userIdValue;

			private string subTypeCode;

			private string targetProductCode;

			private string typeCode;

			private long? alertTime;

			private long? dealUserId;

			private string typeName;

			private string dealDisplayName;

			private long? id;

			private string productCode;

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
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

			public int? WarnLevel
			{
				get
				{
					return warnLevel;
				}
				set	
				{
					warnLevel = value;
				}
			}

			public long? UserId
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

			public string StatusName
			{
				get
				{
					return statusName;
				}
				set	
				{
					statusName = value;
				}
			}

			public string DepartName
			{
				get
				{
					return departName;
				}
				set	
				{
					departName = value;
				}
			}

			public string DealUserIdValue
			{
				get
				{
					return dealUserIdValue;
				}
				set	
				{
					dealUserIdValue = value;
				}
			}

			public long? DealTime
			{
				get
				{
					return dealTime;
				}
				set	
				{
					dealTime = value;
				}
			}

			public string DealLoginName
			{
				get
				{
					return dealLoginName;
				}
				set	
				{
					dealLoginName = value;
				}
			}

			public string SubTypeName
			{
				get
				{
					return subTypeName;
				}
				set	
				{
					subTypeName = value;
				}
			}

			public bool? Backed
			{
				get
				{
					return backed;
				}
				set	
				{
					backed = value;
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

			public long? EventTime
			{
				get
				{
					return eventTime;
				}
				set	
				{
					eventTime = value;
				}
			}

			public string LoginName
			{
				get
				{
					return loginName;
				}
				set	
				{
					loginName = value;
				}
			}

			public string UserIdValue
			{
				get
				{
					return userIdValue;
				}
				set	
				{
					userIdValue = value;
				}
			}

			public string SubTypeCode
			{
				get
				{
					return subTypeCode;
				}
				set	
				{
					subTypeCode = value;
				}
			}

			public string TargetProductCode
			{
				get
				{
					return targetProductCode;
				}
				set	
				{
					targetProductCode = value;
				}
			}

			public string TypeCode
			{
				get
				{
					return typeCode;
				}
				set	
				{
					typeCode = value;
				}
			}

			public long? AlertTime
			{
				get
				{
					return alertTime;
				}
				set	
				{
					alertTime = value;
				}
			}

			public long? DealUserId
			{
				get
				{
					return dealUserId;
				}
				set	
				{
					dealUserId = value;
				}
			}

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public string DealDisplayName
			{
				get
				{
					return dealDisplayName;
				}
				set	
				{
					dealDisplayName = value;
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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}
		}
	}
}
