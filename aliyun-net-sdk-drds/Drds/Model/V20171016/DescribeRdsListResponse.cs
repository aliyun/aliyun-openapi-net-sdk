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

namespace Aliyun.Acs.Drds.Model.V20171016
{
	public class DescribeRdsListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeRdsList_RdsInstance> data;

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

		public List<DescribeRdsList_RdsInstance> Data
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

		public class DescribeRdsList_RdsInstance
		{

			private int? instanceId;

			private string instanceName;

			private string connectUrl;

			private int? port;

			private string instanceStatus;

			private string dbType;

			private int? readWeight;

			private List<DescribeRdsList_Child> readOnlyChildren;

			public int? InstanceId
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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string ConnectUrl
			{
				get
				{
					return connectUrl;
				}
				set	
				{
					connectUrl = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			public int? ReadWeight
			{
				get
				{
					return readWeight;
				}
				set	
				{
					readWeight = value;
				}
			}

			public List<DescribeRdsList_Child> ReadOnlyChildren
			{
				get
				{
					return readOnlyChildren;
				}
				set	
				{
					readOnlyChildren = value;
				}
			}

			public class DescribeRdsList_Child
			{

				private string instanceId;

				private string instanceName;

				private string connectUrl;

				private int? port;

				private string instanceStatus;

				private string dbType;

				private int? readWeight;

				public string InstanceId
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

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public string ConnectUrl
				{
					get
					{
						return connectUrl;
					}
					set	
					{
						connectUrl = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string InstanceStatus
				{
					get
					{
						return instanceStatus;
					}
					set	
					{
						instanceStatus = value;
					}
				}

				public string DbType
				{
					get
					{
						return dbType;
					}
					set	
					{
						dbType = value;
					}
				}

				public int? ReadWeight
				{
					get
					{
						return readWeight;
					}
					set	
					{
						readWeight = value;
					}
				}
			}
		}
	}
}
