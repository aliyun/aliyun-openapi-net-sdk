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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListManualDagInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<ListManualDagInstances_InstancesItem> instances;

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

		public List<ListManualDagInstances_InstancesItem> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class ListManualDagInstances_InstancesItem
		{

			private long? nodeId;

			private long? instanceId;

			private long? dagId;

			private string dagType;

			private string status;

			private long? bizDate;

			private long? cycTime;

			private long? createTime;

			private long? modifyTime;

			private string nodeName;

			private long? beginWaitTimeTime;

			private long? beginWaitResTime;

			private long? beginRunningTime;

			private string paramValues;

			private long? finishTime;

			private string taskType;

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

			public long? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? DagId
			{
				get
				{
					return dagId;
				}
				set	
				{
					dagId = value;
				}
			}

			public string DagType
			{
				get
				{
					return dagType;
				}
				set	
				{
					dagType = value;
				}
			}

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

			public long? BizDate
			{
				get
				{
					return bizDate;
				}
				set	
				{
					bizDate = value;
				}
			}

			public long? CycTime
			{
				get
				{
					return cycTime;
				}
				set	
				{
					cycTime = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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

			public long? BeginWaitTimeTime
			{
				get
				{
					return beginWaitTimeTime;
				}
				set	
				{
					beginWaitTimeTime = value;
				}
			}

			public long? BeginWaitResTime
			{
				get
				{
					return beginWaitResTime;
				}
				set	
				{
					beginWaitResTime = value;
				}
			}

			public long? BeginRunningTime
			{
				get
				{
					return beginRunningTime;
				}
				set	
				{
					beginRunningTime = value;
				}
			}

			public string ParamValues
			{
				get
				{
					return paramValues;
				}
				set	
				{
					paramValues = value;
				}
			}

			public long? FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}
		}
	}
}
