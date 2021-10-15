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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeEslDeviceResponse : AcsResponse
	{

		private long? totalCount;

		private long? pageSize;

		private string requestId;

		private long? pageNumber;

		private bool? success;

		private List<DescribeEslDevice_EslDetailsItem> eslDetails;

		public long? TotalCount
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

		public long? PageSize
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

		public long? PageNumber
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

		public List<DescribeEslDevice_EslDetailsItem> EslDetails
		{
			get
			{
				return eslDetails;
			}
			set	
			{
				eslDetails = value;
			}
		}

		public class DescribeEslDevice_EslDetailsItem
		{

			private string eslBarCode;

			private string lastUpdateTime;

			private long? itemBarCode;

			private long? itemId;

			private string itemShortTitle;

			private string status;

			private string storeId;

			public string EslBarCode
			{
				get
				{
					return eslBarCode;
				}
				set	
				{
					eslBarCode = value;
				}
			}

			public string LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
				}
			}

			public long? ItemBarCode
			{
				get
				{
					return itemBarCode;
				}
				set	
				{
					itemBarCode = value;
				}
			}

			public long? ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public string ItemShortTitle
			{
				get
				{
					return itemShortTitle;
				}
				set	
				{
					itemShortTitle = value;
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

			public string StoreId
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
		}
	}
}
