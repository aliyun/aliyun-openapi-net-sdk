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
	public class DescribeApmResponse : AcsResponse
	{

		private string requestId;

		private DescribeApm_Result result;

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

		public DescribeApm_Result Result
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

		public class DescribeApm_Result
		{

			private string apmServerDomain;

			private string createdAt;

			private long? deployedReplica;

			private string description;

			private long? endTime;

			private string instanceId;

			private long? nodeAmount;

			private string outputES;

			private string outputESUserName;

			private string ownerId;

			private string paymentType;

			private string region;

			private int? replica;

			private string resourceSpec;

			private string status;

			private string version;

			private string vpcId;

			private string vsArea;

			private string vswitchId;

			public string ApmServerDomain
			{
				get
				{
					return apmServerDomain;
				}
				set	
				{
					apmServerDomain = value;
				}
			}

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

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
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

			public int? Replica
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
	}
}
