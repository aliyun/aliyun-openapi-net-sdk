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
	public class ListWorkFlowNodesResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListWorkFlowNodes_WorkflowNode> workflowNodes;

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

		[JsonProperty(PropertyName = "WorkflowNodes")]
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

			private string comment;

			private string createUserNickName;

			private string nodeType;

			private string nodeName;

			private long? createUserId;

			private long? nodeId;

			private List<ListWorkFlowNodes_AuditUser> auditUsers;

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

			[JsonProperty(PropertyName = "CreateUserNickName")]
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

			[JsonProperty(PropertyName = "NodeType")]
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

			[JsonProperty(PropertyName = "CreateUserId")]
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

			[JsonProperty(PropertyName = "NodeId")]
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

			[JsonProperty(PropertyName = "AuditUsers")]
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

				private string realName;

				private long? userId;

				private string nickName;

				[JsonProperty(PropertyName = "RealName")]
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

				[JsonProperty(PropertyName = "UserId")]
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
			}
		}
	}
}
