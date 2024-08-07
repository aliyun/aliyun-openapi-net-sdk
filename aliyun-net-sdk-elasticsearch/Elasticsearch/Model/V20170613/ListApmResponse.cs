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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListApmResponse : AcsResponse
	{

		private string requestId;

		private List<ListApm__Object> result;

		private ListApm_Headers headers;

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

		public List<ListApm__Object> Result
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

		public ListApm_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListApm__Object
		{

			private string createdAt;

			private long? deployedReplica;

			private string description;

			private string instanceId;

			private long? nodeAmount;

			private string outputES;

			private string outputESUserName;

			private string ownerId;

			private string paymentType;

			private string region;

			private long? replica;

			private string resourceSpec;

			private string status;

			private string version;

			private string vpcId;

			private string vsArea;

			private string vswitchId;

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public long? DeployedReplica
			{
				get
				{
					return deployedReplica;
				}
				set	
				{
					deployedReplica = value;
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

			public long? NodeAmount
			{
				get
				{
					return nodeAmount;
				}
				set	
				{
					nodeAmount = value;
				}
			}

			public string OutputES
			{
				get
				{
					return outputES;
				}
				set	
				{
					outputES = value;
				}
			}

			public string OutputESUserName
			{
				get
				{
					return outputESUserName;
				}
				set	
				{
					outputESUserName = value;
				}
			}

			public string OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public string PaymentType
			{
				get
				{
					return paymentType;
				}
				set	
				{
					paymentType = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public long? Replica
			{
				get
				{
					return replica;
				}
				set	
				{
					replica = value;
				}
			}

			public string ResourceSpec
			{
				get
				{
					return resourceSpec;
				}
				set	
				{
					resourceSpec = value;
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

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
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

			public string VsArea
			{
				get
				{
					return vsArea;
				}
				set	
				{
					vsArea = value;
				}
			}

			public string VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}
		}

		public class ListApm_Headers
		{

			private long? xTotalCount;

			public long? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
