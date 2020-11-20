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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListDataTasksResponse : AcsResponse
	{

		private string requestId;

		private List<ListDataTasks_ResultItem> result;

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

		public List<ListDataTasks_ResultItem> Result
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

		public class ListDataTasks_ResultItem
		{

			private string createTime;

			private string status;

			private string taskId;

			private ListDataTasks_SinkCluster sinkCluster;

			private ListDataTasks_SourceCluster sourceCluster;

			public string CreateTime
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

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public ListDataTasks_SinkCluster SinkCluster
			{
				get
				{
					return sinkCluster;
				}
				set	
				{
					sinkCluster = value;
				}
			}

			public ListDataTasks_SourceCluster SourceCluster
			{
				get
				{
					return sourceCluster;
				}
				set	
				{
					sourceCluster = value;
				}
			}

			public class ListDataTasks_SinkCluster
			{

				private string dataSourceType;

				private string endpoint;

				private string index;

				private string type;

				private string vpcId;

				private string vpcInstanceId;

				private string vpcInstancePort;

				public string DataSourceType
				{
					get
					{
						return dataSourceType;
					}
					set	
					{
						dataSourceType = value;
					}
				}

				public string Endpoint
				{
					get
					{
						return endpoint;
					}
					set	
					{
						endpoint = value;
					}
				}

				public string Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string VpcInstanceId
				{
					get
					{
						return vpcInstanceId;
					}
					set	
					{
						vpcInstanceId = value;
					}
				}

				public string VpcInstancePort
				{
					get
					{
						return vpcInstancePort;
					}
					set	
					{
						vpcInstancePort = value;
					}
				}
			}

			public class ListDataTasks_SourceCluster
			{

				private string dataSourceType;

				private string index;

				private string mapping;

				private string routing;

				private string settings;

				private string type;

				public string DataSourceType
				{
					get
					{
						return dataSourceType;
					}
					set	
					{
						dataSourceType = value;
					}
				}

				public string Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string Mapping
				{
					get
					{
						return mapping;
					}
					set	
					{
						mapping = value;
					}
				}

				public string Routing
				{
					get
					{
						return routing;
					}
					set	
					{
						routing = value;
					}
				}

				public string Settings
				{
					get
					{
						return settings;
					}
					set	
					{
						settings = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}
			}
		}
	}
}
