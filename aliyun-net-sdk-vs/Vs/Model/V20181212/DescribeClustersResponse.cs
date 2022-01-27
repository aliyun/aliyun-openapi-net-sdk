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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeClustersResponse : AcsResponse
	{

		private string requestId;

		private long? total;

		private List<DescribeClusters_Cluster> clusters;

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

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<DescribeClusters_Cluster> Clusters
		{
			get
			{
				return clusters;
			}
			set	
			{
				clusters = value;
			}
		}

		public class DescribeClusters_Cluster
		{

			private string clusterId;

			private string name;

			private string description;

			private string maintainTime;

			private string status;

			private List<DescribeClusters_InternalPort> internalPorts;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string MaintainTime
			{
				get
				{
					return maintainTime;
				}
				set	
				{
					maintainTime = value;
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

			public List<DescribeClusters_InternalPort> InternalPorts
			{
				get
				{
					return internalPorts;
				}
				set	
				{
					internalPorts = value;
				}
			}

			public class DescribeClusters_InternalPort
			{

				private string platform;

				private string ipProtocol;

				private List<string> port;

				public string Platform
				{
					get
					{
						return platform;
					}
					set	
					{
						platform = value;
					}
				}

				public string IpProtocol
				{
					get
					{
						return ipProtocol;
					}
					set	
					{
						ipProtocol = value;
					}
				}

				public List<string> Port
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
			}
		}
	}
}
