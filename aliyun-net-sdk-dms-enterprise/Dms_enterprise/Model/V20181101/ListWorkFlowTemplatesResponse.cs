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
	public class ListWorkFlowTemplatesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListWorkFlowTemplates_WorkFlowTemplate> workFlowTemplates;

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

		public List<ListWorkFlowTemplates_WorkFlowTemplate> WorkFlowTemplates
		{
			get
			{
				return workFlowTemplates;
			}
			set	
			{
				workFlowTemplates = value;
			}
		}

		public class ListWorkFlowTemplates_WorkFlowTemplate
		{

			private string templateName;

			private string comment;

			private long? templateId;

			private int? isSystem;

			private string enabled;

			private List<ListWorkFlowTemplates_WorkflowNode> workflowNodes;

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
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

			public long? TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public int? IsSystem
			{
				get
				{
					return isSystem;
				}
				set	
				{
					isSystem = value;
				}
			}

			public string Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public List<ListWorkFlowTemplates_WorkflowNode> WorkflowNodes
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

			public class ListWorkFlowTemplates_WorkflowNode
			{

				private long? nodeId;

				private long? templateId;

				private string nodeName;

				private string nodeType;

				private string comment;

				private int? position;

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

				public long? TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
					}
				}

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

				public int? Position
				{
					get
					{
						return position;
					}
					set	
					{
						position = value;
					}
				}
			}
		}
	}
}
