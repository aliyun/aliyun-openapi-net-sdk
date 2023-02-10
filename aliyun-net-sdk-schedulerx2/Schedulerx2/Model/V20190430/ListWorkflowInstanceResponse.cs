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
	public class ListWorkflowInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private bool? success;

		private string message;

		private ListWorkflowInstance_Data data;

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

		public ListWorkflowInstance_Data Data
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

		public class ListWorkflowInstance_Data
		{

			private List<ListWorkflowInstance_WfInstanceInfosItem> wfInstanceInfos;

			public List<ListWorkflowInstance_WfInstanceInfosItem> WfInstanceInfos
			{
				get
				{
					return wfInstanceInfos;
				}
				set	
				{
					wfInstanceInfos = value;
				}
			}

			public class ListWorkflowInstance_WfInstanceInfosItem
			{

				private long? wfInstanceId;

				private long? workflowId;

				private int? status;

				private string startTime;

				private string endTime;

				private string scheduleTime;

				private string dataTime;

				public long? WfInstanceId
				{
					get
					{
						return wfInstanceId;
					}
					set	
					{
						wfInstanceId = value;
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
		}
	}
}
