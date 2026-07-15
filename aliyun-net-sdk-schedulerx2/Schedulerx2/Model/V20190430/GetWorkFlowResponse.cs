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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class GetWorkFlowResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private bool? success;

		private GetWorkFlow_Data data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public GetWorkFlow_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetWorkFlow_Data
		{

			private GetWorkFlow_WorkFlowNodeInfo workFlowNodeInfo;

			private GetWorkFlow_WorkFlowInfo workFlowInfo;

			public GetWorkFlow_WorkFlowNodeInfo WorkFlowNodeInfo
			{
				get
				{
					return workFlowNodeInfo;
				}
				set	
				{
					workFlowNodeInfo = value;
				}
			}

			public GetWorkFlow_WorkFlowInfo WorkFlowInfo
			{
				get
				{
					return workFlowInfo;
				}
				set	
				{
					workFlowInfo = value;
				}
			}

			public class GetWorkFlow_WorkFlowNodeInfo
			{

				private List<GetWorkFlow_Edge> edges;

				private List<GetWorkFlow_Node> nodes;

				public List<GetWorkFlow_Edge> Edges
				{
					get
					{
						return edges;
					}
					set	
					{
						edges = value;
					}
				}

				public List<GetWorkFlow_Node> Nodes
				{
					get
					{
						return nodes;
					}
					set	
					{
						nodes = value;
					}
				}

				public class GetWorkFlow_Edge
				{

					private long? target;

					private long? source;

					public long? Target
					{
						get
						{
							return target;
						}
						set	
						{
							target = value;
						}
					}

					public long? Source
					{
						get
						{
							return source;
						}
						set	
						{
							source = value;
						}
					}
				}

				public class GetWorkFlow_Node
				{

					private int? status;

					private string label;

					private long? id;

					public int? Status
					{
						get
						{
							return status;
						}
						set	
						{
							status = value;
						}
					}

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

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

			public class GetWorkFlow_WorkFlowInfo
			{

				private string status;

				private string description;

				private string maxConcurrency;

				private string timeExpression;

				private long? workflowId;

				private string _namespace;

				private string name;

				private string timeType;

				private string groupId;

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
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

				public string MaxConcurrency
				{
					get
					{
						return maxConcurrency;
					}
					set	
					{
						maxConcurrency = value;
					}
				}

				public string TimeExpression
				{
					get
					{
						return timeExpression;
					}
					set	
					{
						timeExpression = value;
					}
				}

				public long? WorkflowId
				{
					get
					{
						return workflowId;
					}
					set	
					{
						workflowId = value;
					}
				}

				public string _Namespace
				{
					get
					{
						return _namespace;
					}
					set	
					{
						_namespace = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string TimeType
				{
					get
					{
						return timeType;
					}
					set	
					{
						timeType = value;
					}
				}

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}
			}
		}
	}
}
