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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class InsertClusterResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private InsertCluster_Cluster cluster;

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

		public InsertCluster_Cluster Cluster
		{
			get
			{
				return cluster;
			}
			set	
			{
				cluster = value;
			}
		}

		public class InsertCluster_Cluster
		{

			private string clusterId;

			private string regionId;

			private string clusterName;

			private int? clusterType;

			private int? oversoldFactor;

			private int? networkMode;

			private string vpcId;

			private string iaasProvider;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public int? ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
				}
			}

			public int? OversoldFactor
			{
				get
				{
					return oversoldFactor;
				}
				set	
				{
					oversoldFactor = value;
				}
			}

			public int? NetworkMode
			{
				get
				{
					return networkMode;
				}
				set	
				{
					networkMode = value;
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

			public string IaasProvider
			{
				get
				{
					return iaasProvider;
				}
				set	
				{
					iaasProvider = value;
				}
			}
		}
	}
}
