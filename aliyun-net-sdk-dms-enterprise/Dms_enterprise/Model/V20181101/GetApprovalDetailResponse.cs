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
	public class GetApprovalDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetApprovalDetail_ApprovalDetail approvalDetail;

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

			private long? auditId;

			private long? orderId;

			private string orderType;

			private string title;

			private string workflowInsCode;

			private string description;

			private List<GetApprovalDetail_WorkflowNode> workflowNodes;

			private List<GetApprovalDetail_CurrentHandler> currentHandlers;

			private List<string> reasonList;

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

				private string nodeName;

				private string operateComment;

				private string operateTime;

				private long? operatorId;

				private string workflowInsCode;

				private List<string> auditUserIdList;

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

				private long? id;

				private string nickName;

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
			}
		}
	}
}
