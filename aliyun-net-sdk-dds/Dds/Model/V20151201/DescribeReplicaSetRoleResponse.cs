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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeReplicaSetRoleResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private List<DescribeReplicaSetRole_ReplicaSet> replicaSets;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		public List<DescribeReplicaSetRole_ReplicaSet> ReplicaSets
		{
			get
			{
				return replicaSets;
			}
			set	
			{
				replicaSets = value;
			}
		}

		public class DescribeReplicaSetRole_ReplicaSet
		{

			private string replicaSetRole;

			private string connectionDomain;

			private string connectionPort;

			private string expiredTime;

			private string networkType;

			public string ReplicaSetRole
			{
				get
				{
					return replicaSetRole;
				}
				set	
				{
					replicaSetRole = value;
				}
			}

			public string ConnectionDomain
			{
				get
				{
					return connectionDomain;
				}
				set	
				{
					connectionDomain = value;
				}
			}

			public string ConnectionPort
			{
				get
				{
					return connectionPort;
				}
				set	
				{
					connectionPort = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}
		}
	}
}