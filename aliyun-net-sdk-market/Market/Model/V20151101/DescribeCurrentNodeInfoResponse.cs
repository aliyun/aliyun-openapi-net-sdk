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
	public class DescribeCurrentNodeInfoResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeCurrentNodeInfo_Result result;

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

		public DescribeCurrentNodeInfo_Result Result
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

		public class DescribeCurrentNodeInfo_Result
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
