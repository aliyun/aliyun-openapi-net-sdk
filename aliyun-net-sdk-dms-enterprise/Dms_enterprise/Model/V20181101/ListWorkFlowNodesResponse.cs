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
	public class ListWorkFlowNodesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListWorkFlowNodes_WorkflowNode> workflowNodes;

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

		public List<ListWorkFlowNodes_WorkflowNode> WorkflowNodes
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

		public class ListWorkFlowNodes_WorkflowNode
		{

			private string nodeName;

			private string comment;

			private long? nodeId;

			private string nodeType;

			private long? createUserId;

			private string createUserNickName;

			private List<ListWorkFlowNodes_AuditUser> auditUsers;

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

			public long? NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public long? CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public string CreateUserNickName
			{
				get
				{
					return createUserNickName;
				}
				set	
				{
					createUserNickName = value;
				}
			}

			public List<ListWorkFlowNodes_AuditUser> AuditUsers
			{
				get
				{
					return auditUsers;
				}
				set	
				{
					auditUsers = value;
				}
			}

			public class ListWorkFlowNodes_AuditUser
			{

				private long? userId;

				private string nickName;

				private string realName;

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

				public string RealName
				{
					get
					{
						return realName;
					}
					set	
					{
						realName = value;
					}
				}
			}
		}
	}
}
