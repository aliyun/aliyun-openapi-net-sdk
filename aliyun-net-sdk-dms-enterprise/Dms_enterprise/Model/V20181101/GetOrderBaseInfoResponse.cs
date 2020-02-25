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
	public class GetOrderBaseInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetOrderBaseInfo_OrderBaseInfo orderBaseInfo;

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

			private string committer;

			private long? committerId;

			private string createTime;

			private string lastModifyTime;

			private long? orderId;

			private string pluginType;

			private string statusCode;

			private string statusDesc;

			private long? workflowInstanceId;

			private string workflowStatusDesc;

			private List<string> relatedUserList;

			private List<string> relatedUserNickList;

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
		}
	}
}
