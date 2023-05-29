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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProjectNodesResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<DescribeProjectNodes_ProjectNode> result;

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

		[JsonProperty(PropertyName = "Result")]
		public List<DescribeProjectNodes_ProjectNode> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeProjectNodes_ProjectNode
		{

			private long? nextNodeId;

			private int? stepNo;

			private bool? autoFinishNode;

			private int? finalStepNo;

			private long? previousNodeId;

			private long? parentNodeId;

			private long? gmtExpired;

			private string operatorRole;

			private long? gmtStart;

			private string nodeStatus;

			private string nodeName;

			private long? gmtFinished;

			private bool? allowRollbackNode;

			private string templateForm;

			private bool? needAttachment;

			private long? nodeId;

			[JsonProperty(PropertyName = "NextNodeId")]
			public long? NextNodeId
			{
				get
				{
					return nextNodeId;
				}
				set	
				{
					nextNodeId = value;
				}
			}

			[JsonProperty(PropertyName = "StepNo")]
			public int? StepNo
			{
				get
				{
					return stepNo;
				}
				set	
				{
					stepNo = value;
				}
			}

			[JsonProperty(PropertyName = "AutoFinishNode")]
			public bool? AutoFinishNode
			{
				get
				{
					return autoFinishNode;
				}
				set	
				{
					autoFinishNode = value;
				}
			}

			[JsonProperty(PropertyName = "FinalStepNo")]
			public int? FinalStepNo
			{
				get
				{
					return finalStepNo;
				}
				set	
				{
					finalStepNo = value;
				}
			}

			[JsonProperty(PropertyName = "PreviousNodeId")]
			public long? PreviousNodeId
			{
				get
				{
					return previousNodeId;
				}
				set	
				{
					previousNodeId = value;
				}
			}

			[JsonProperty(PropertyName = "ParentNodeId")]
			public long? ParentNodeId
			{
				get
				{
					return parentNodeId;
				}
				set	
				{
					parentNodeId = value;
				}
			}

			[JsonProperty(PropertyName = "GmtExpired")]
			public long? GmtExpired
			{
				get
				{
					return gmtExpired;
				}
				set	
				{
					gmtExpired = value;
				}
			}

			[JsonProperty(PropertyName = "OperatorRole")]
			public string OperatorRole
			{
				get
				{
					return operatorRole;
				}
				set	
				{
					operatorRole = value;
				}
			}

			[JsonProperty(PropertyName = "GmtStart")]
			public long? GmtStart
			{
				get
				{
					return gmtStart;
				}
				set	
				{
					gmtStart = value;
				}
			}

			[JsonProperty(PropertyName = "NodeStatus")]
			public string NodeStatus
			{
				get
				{
					return nodeStatus;
				}
				set	
				{
					nodeStatus = value;
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

			[JsonProperty(PropertyName = "GmtFinished")]
			public long? GmtFinished
			{
				get
				{
					return gmtFinished;
				}
				set	
				{
					gmtFinished = value;
				}
			}

			[JsonProperty(PropertyName = "AllowRollbackNode")]
			public bool? AllowRollbackNode
			{
				get
				{
					return allowRollbackNode;
				}
				set	
				{
					allowRollbackNode = value;
				}
			}

			[JsonProperty(PropertyName = "TemplateForm")]
			public string TemplateForm
			{
				get
				{
					return templateForm;
				}
				set	
				{
					templateForm = value;
				}
			}

			[JsonProperty(PropertyName = "NeedAttachment")]
			public bool? NeedAttachment
			{
				get
				{
					return needAttachment;
				}
				set	
				{
					needAttachment = value;
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
		}
	}
}
