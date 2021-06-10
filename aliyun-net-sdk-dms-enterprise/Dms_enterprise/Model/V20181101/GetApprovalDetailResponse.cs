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
	public class GetApprovalDetailResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetApprovalDetail_ApprovalDetail approvalDetail;

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

		[JsonProperty(PropertyName = "ApprovalDetail")]
		public GetApprovalDetail_ApprovalDetail ApprovalDetail
		{
			get
			{
				return approvalDetail;
			}
			set	
			{
				approvalDetail = value;
			}
		}

		public class GetApprovalDetail_ApprovalDetail
		{

			private string description;

			private string orderType;

			private string title;

			private long? auditId;

			private long? orderId;

			private string workflowInsCode;

			private List<GetApprovalDetail_WorkflowNode> workflowNodes;

			private List<GetApprovalDetail_CurrentHandler> currentHandlers;

			private List<string> reasonList;

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			[JsonProperty(PropertyName = "OrderType")]
			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}

			[JsonProperty(PropertyName = "Title")]
			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			[JsonProperty(PropertyName = "AuditId")]
			public long? AuditId
			{
				get
				{
					return auditId;
				}
				set	
				{
					auditId = value;
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

			[JsonProperty(PropertyName = "WorkflowInsCode")]
			public string WorkflowInsCode
			{
				get
				{
					return workflowInsCode;
				}
				set	
				{
					workflowInsCode = value;
				}
			}

			[JsonProperty(PropertyName = "WorkflowNodes")]
			public List<GetApprovalDetail_WorkflowNode> WorkflowNodes
			{
				get
				{
					return workflowNodes;
				}
				set	
				{
					workflowNodes = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentHandlers")]
			public List<GetApprovalDetail_CurrentHandler> CurrentHandlers
			{
				get
				{
					return currentHandlers;
				}
				set	
				{
					currentHandlers = value;
				}
			}

			[JsonProperty(PropertyName = "ReasonList")]
			public List<string> ReasonList
			{
				get
				{
					return reasonList;
				}
				set	
				{
					reasonList = value;
				}
			}

			public class GetApprovalDetail_WorkflowNode
			{

				private string operateTime;

				private long? operatorId;

				private string nodeName;

				private string operateComment;

				private string workflowInsCode;

				private List<string> auditUserIdList;

				[JsonProperty(PropertyName = "OperateTime")]
				public string OperateTime
				{
					get
					{
						return operateTime;
					}
					set	
					{
						operateTime = value;
					}
				}

				[JsonProperty(PropertyName = "OperatorId")]
				public long? OperatorId
				{
					get
					{
						return operatorId;
					}
					set	
					{
						operatorId = value;
					}
				}

				[JsonProperty(PropertyName = "NodeName")]
				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				[JsonProperty(PropertyName = "OperateComment")]
				public string OperateComment
				{
					get
					{
						return operateComment;
					}
					set	
					{
						operateComment = value;
					}
				}

				[JsonProperty(PropertyName = "WorkflowInsCode")]
				public string WorkflowInsCode
				{
					get
					{
						return workflowInsCode;
					}
					set	
					{
						workflowInsCode = value;
					}
				}

				[JsonProperty(PropertyName = "AuditUserIdList")]
				public List<string> AuditUserIdList
				{
					get
					{
						return auditUserIdList;
					}
					set	
					{
						auditUserIdList = value;
					}
				}
			}

			public class GetApprovalDetail_CurrentHandler
			{

				private string nickName;

				private long? id;

				[JsonProperty(PropertyName = "NickName")]
				public string NickName
				{
					get
					{
						return nickName;
					}
					set	
					{
						nickName = value;
					}
				}

				[JsonProperty(PropertyName = "Id")]
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
			}
		}
	}
}
