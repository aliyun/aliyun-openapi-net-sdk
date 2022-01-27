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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListOrdersResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListOrders_Order> orders;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Orders")]
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

			private string comment;

			private string lastModifyTime;

			private string statusCode;

			private string createTime;

			private string committer;

			private long? committerId;

			private string statusDesc;

			private string pluginType;

			private long? orderId;

			[JsonProperty(PropertyName = "Comment")]
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

			[JsonProperty(PropertyName = "LastModifyTime")]
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

			[JsonProperty(PropertyName = "StatusCode")]
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

			[JsonProperty(PropertyName = "CreateTime")]
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

			[JsonProperty(PropertyName = "Committer")]
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

			[JsonProperty(PropertyName = "CommitterId")]
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

			[JsonProperty(PropertyName = "StatusDesc")]
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

			[JsonProperty(PropertyName = "PluginType")]
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

			[JsonProperty(PropertyName = "OrderId")]
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
		}
	}
}
