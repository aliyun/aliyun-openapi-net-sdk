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
	public class CreateDataTasksResponse : AcsResponse
	{

		private string requestId;

		private List<CreateDataTasks_ResultItem> result;

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

		public List<CreateDataTasks_ResultItem> Result
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

		public class CreateDataTasks_ResultItem
		{

			private CreateDataTasks_SourceCluster sourceCluster;

			private CreateDataTasks_SinkCluster sinkCluster;

			public CreateDataTasks_SourceCluster SourceCluster
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

			public CreateDataTasks_SinkCluster SinkCluster
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

			public class CreateDataTasks_SourceCluster
			{

				private string dataSourceType;

				private int? vpcInstancePort;

				private string vpcId;

				private string vpcInstanceId;

				private string index;

				private string type;

				private string endpoint;

				private string username;

				private string password;

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

				public int? VpcInstancePort
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

				public string Username
				{
					get
					{
						return username;
					}
					set	
					{
						username = value;
					}
				}

				public string Password
				{
					get
					{
						return password;
					}
					set	
					{
						password = value;
					}
				}
			}

			public class CreateDataTasks_SinkCluster
			{

				private string dataSourceType;

				private string index;

				private string type;

				private string settings;

				private string mapping;

				private string routing;

				private string vpcId;

				private string vpcInstanceId;

				private string vpcInstancePort;

				private string username;

				private string password;

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

				public string Username
				{
					get
					{
						return username;
					}
					set	
					{
						username = value;
					}
				}

				public string Password
				{
					get
					{
						return password;
					}
					set	
					{
						password = value;
					}
				}
			}
		}
	}
}
