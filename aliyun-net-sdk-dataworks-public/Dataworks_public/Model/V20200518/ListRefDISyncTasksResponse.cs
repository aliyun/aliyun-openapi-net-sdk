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
	public class ListRefDISyncTasksResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private ListRefDISyncTasks_Data data;

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

		public ListRefDISyncTasks_Data Data
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

		public class ListRefDISyncTasks_Data
		{

			private List<ListRefDISyncTasks_DISyncTasksItem> dISyncTasks;

			public List<ListRefDISyncTasks_DISyncTasksItem> DISyncTasks
			{
				get
				{
					return dISyncTasks;
				}
				set	
				{
					dISyncTasks = value;
				}
			}

			public class ListRefDISyncTasks_DISyncTasksItem
			{

				private string diSourceDatasource;

				private string taskType;

				private string diDestinationDatasource;

				private string nodeName;

				private long? nodeId;

				public string DiSourceDatasource
				{
					get
					{
						return diSourceDatasource;
					}
					set	
					{
						diSourceDatasource = value;
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

				public string DiDestinationDatasource
				{
					get
					{
						return diDestinationDatasource;
					}
					set	
					{
						diDestinationDatasource = value;
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
}
