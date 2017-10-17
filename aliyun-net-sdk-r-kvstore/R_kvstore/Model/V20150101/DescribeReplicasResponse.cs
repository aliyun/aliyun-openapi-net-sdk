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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeReplicasResponse : AcsResponse
	{

		private string requestId;

		private string pageNumber;

		private int? totalRecordCount;

		private int? pageRecordCount;

		private List<DescribeReplicas_Items> replicas;

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

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public List<DescribeReplicas_Items> Replicas
		{
			get
			{
				return replicas;
			}
			set	
			{
				replicas = value;
			}
		}

		public class DescribeReplicas_Items
		{

			private string replicaId;

			private string replicaDescription;

			private string replicaStatus;

			private List<DescribeReplicas_Items1> dBInstances;

			public string ReplicaId
			{
				get
				{
					return replicaId;
				}
				set	
				{
					replicaId = value;
				}
			}

			public string ReplicaDescription
			{
				get
				{
					return replicaDescription;
				}
				set	
				{
					replicaDescription = value;
				}
			}

			public string ReplicaStatus
			{
				get
				{
					return replicaStatus;
				}
				set	
				{
					replicaStatus = value;
				}
			}

			public List<DescribeReplicas_Items1> DBInstances
			{
				get
				{
					return dBInstances;
				}
				set	
				{
					dBInstances = value;
				}
			}

			public class DescribeReplicas_Items1
			{

				private string dBInstanceId;

				private string role;

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

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}
			}
		}
	}
}