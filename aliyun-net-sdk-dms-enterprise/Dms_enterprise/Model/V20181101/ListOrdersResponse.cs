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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListOrdersResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? totalCount;

		private List<ListOrders_Order> orders;

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

		public List<ListOrders_Order> Orders
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

		public class ListOrders_Order
		{

			private long? orderId;

			private string comment;

			private string committer;

			private long? committerId;

			private string createTime;

			private string lastModifyTime;

			private string pluginType;

			private string statusCode;

			private string statusDesc;

			public long? OrderId
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

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string Committer
			{
				get
				{
					return committer;
				}
				set	
				{
					committer = value;
				}
			}

			public long? CommitterId
			{
				get
				{
					return committerId;
				}
				set	
				{
					committerId = value;
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

			public string LastModifyTime
			{
				get
				{
					return lastModifyTime;
				}
				set	
				{
					lastModifyTime = value;
				}
			}

			public string PluginType
			{
				get
				{
					return pluginType;
				}
				set	
				{
					pluginType = value;
				}
			}

			public string StatusCode
			{
				get
				{
					return statusCode;
				}
				set	
				{
					statusCode = value;
				}
			}

			public string StatusDesc
			{
				get
				{
					return statusDesc;
				}
				set	
				{
					statusDesc = value;
				}
			}
		}
	}
}
