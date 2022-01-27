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
	public class GetOrderBaseInfoResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetOrderBaseInfo_OrderBaseInfo orderBaseInfo;

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

		[JsonProperty(PropertyName = "OrderBaseInfo")]
		public GetOrderBaseInfo_OrderBaseInfo OrderBaseInfo
		{
			get
			{
				return orderBaseInfo;
			}
			set	
			{
				orderBaseInfo = value;
			}
		}

		public class GetOrderBaseInfo_OrderBaseInfo
		{

			private string comment;

			private string createTime;

			private string committer;

			private long? workflowInstanceId;

			private long? committerId;

			private string lastModifyTime;

			private string statusCode;

			private string workflowStatusDesc;

			private string statusDesc;

			private string pluginType;

			private long? orderId;

			private List<string> relatedUserNickList;

			private List<string> relatedUserList;

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

			[JsonProperty(PropertyName = "WorkflowInstanceId")]
			public long? WorkflowInstanceId
			{
				get
				{
					return workflowInstanceId;
				}
				set	
				{
					workflowInstanceId = value;
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

			[JsonProperty(PropertyName = "WorkflowStatusDesc")]
			public string WorkflowStatusDesc
			{
				get
				{
					return workflowStatusDesc;
				}
				set	
				{
					workflowStatusDesc = value;
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

			[JsonProperty(PropertyName = "RelatedUserNickList")]
			public List<string> RelatedUserNickList
			{
				get
				{
					return relatedUserNickList;
				}
				set	
				{
					relatedUserNickList = value;
				}
			}

			[JsonProperty(PropertyName = "RelatedUserList")]
			public List<string> RelatedUserList
			{
				get
				{
					return relatedUserList;
				}
				set	
				{
					relatedUserList = value;
				}
			}
		}
	}
}
