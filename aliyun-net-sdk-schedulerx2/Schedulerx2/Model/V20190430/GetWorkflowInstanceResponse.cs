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
	public class GetWorkflowInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private bool? success;

		private string message;

		private GetWorkflowInstance_Data data;

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

		public GetWorkflowInstance_Data Data
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

		public class GetWorkflowInstance_Data
		{

			private GetWorkflowInstance_WfInstanceInfo wfInstanceInfo;

			private GetWorkflowInstance_WfInstanceDag wfInstanceDag;

			public GetWorkflowInstance_WfInstanceInfo WfInstanceInfo
			{
				get
				{
					return wfInstanceInfo;
				}
				set	
				{
					wfInstanceInfo = value;
				}
			}

			public GetWorkflowInstance_WfInstanceDag WfInstanceDag
			{
				get
				{
					return wfInstanceDag;
				}
				set	
				{
					wfInstanceDag = value;
				}
			}

			public class GetWorkflowInstance_WfInstanceInfo
			{

				private int? status;

				private string startTime;

				private string endTime;

				private string scheduleTime;

				private string dataTime;

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

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string ScheduleTime
				{
					get
					{
						return scheduleTime;
					}
					set	
					{
						scheduleTime = value;
					}
				}

				public string DataTime
				{
					get
					{
						return dataTime;
					}
					set	
					{
						dataTime = value;
					}
				}
			}

			public class GetWorkflowInstance_WfInstanceDag
			{

				private List<GetWorkflowInstance_Node> nodes;

				private List<GetWorkflowInstance_Edge> edges;

				public List<GetWorkflowInstance_Node> Nodes
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

				public List<GetWorkflowInstance_Edge> Edges
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

				public class GetWorkflowInstance_Node
				{

					private long? jobInstanceId;

					private long? jobId;

					private string startTime;

					private string endTime;

					private string scheduleTime;

					private string dataTime;

					private string workAddr;

					private string result;

					private int? attempt;

					public long? JobInstanceId
					{
						get
						{
							return jobInstanceId;
						}
						set	
						{
							jobInstanceId = value;
						}
					}

					public long? JobId
					{
						get
						{
							return jobId;
						}
						set	
						{
							jobId = value;
						}
					}

					public string StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public string EndTime
					{
						get
						{
							return endTime;
						}
						set	
						{
							endTime = value;
						}
					}

					public string ScheduleTime
					{
						get
						{
							return scheduleTime;
						}
						set	
						{
							scheduleTime = value;
						}
					}

					public string DataTime
					{
						get
						{
							return dataTime;
						}
						set	
						{
							dataTime = value;
						}
					}

					public string WorkAddr
					{
						get
						{
							return workAddr;
						}
						set	
						{
							workAddr = value;
						}
					}

					public string Result
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

					public int? Attempt
					{
						get
						{
							return attempt;
						}
						set	
						{
							attempt = value;
						}
					}
				}

				public class GetWorkflowInstance_Edge
				{

					private long? source;

					private long? target;

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
				}
			}
		}
	}
}
