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

namespace Aliyun.Acs.reid.Model.V20190928
{
	public class DescribeCustomerFlowByLocationResponse : AcsResponse
	{

		private long? locationId;

		private string parentLocationIds;

		private string requestId;

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private string locationName;

		private float? percent;

		private long? storeId;

		private long? count;

		private List<DescribeCustomerFlowByLocation_CustomerFlowItem> customerFlowItems;

		public long? LocationId
		{
			get
			{
				return locationId;
			}
			set	
			{
				locationId = value;
			}
		}

		public string ParentLocationIds
		{
			get
			{
				return parentLocationIds;
			}
			set	
			{
				parentLocationIds = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string LocationName
		{
			get
			{
				return locationName;
			}
			set	
			{
				locationName = value;
			}
		}

		public float? Percent
		{
			get
			{
				return percent;
			}
			set	
			{
				percent = value;
			}
		}

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
			}
		}

		public long? Count
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

		public List<DescribeCustomerFlowByLocation_CustomerFlowItem> CustomerFlowItems
		{
			get
			{
				return customerFlowItems;
			}
			set	
			{
				customerFlowItems = value;
			}
		}

		public class DescribeCustomerFlowByLocation_CustomerFlowItem
		{

			private long? count;

			private long? storeId;

			private float? percent;

			private string locationName;

			private string parentLocationIds;

			private long? locationId;

			public long? Count
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

			public long? StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public float? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string LocationName
			{
				get
				{
					return locationName;
				}
				set	
				{
					locationName = value;
				}
			}

			public string ParentLocationIds
			{
				get
				{
					return parentLocationIds;
				}
				set	
				{
					parentLocationIds = value;
				}
			}

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}
		}
	}
}
