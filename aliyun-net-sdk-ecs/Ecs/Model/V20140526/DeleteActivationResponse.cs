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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DeleteActivationResponse : AcsResponse
	{

		private string requestId;

		private DeleteActivation_Activation activation;

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

		public DeleteActivation_Activation Activation
		{
			get
			{
				return activation;
			}
			set	
			{
				activation = value;
			}
		}

		public class DeleteActivation_Activation
		{

			private string activationId;

			private string instanceName;

			private string description;

			private int? instanceCount;

			private long? timeToLiveInHours;

			private string ipAddressRange;

			private int? registeredCount;

			private int? deregisteredCount;

			private string creationTime;

			public string ActivationId
			{
				get
				{
					return activationId;
				}
				set	
				{
					activationId = value;
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

			public int? InstanceCount
			{
				get
				{
					return instanceCount;
				}
				set	
				{
					instanceCount = value;
				}
			}

			public long? TimeToLiveInHours
			{
				get
				{
					return timeToLiveInHours;
				}
				set	
				{
					timeToLiveInHours = value;
				}
			}

			public string IpAddressRange
			{
				get
				{
					return ipAddressRange;
				}
				set	
				{
					ipAddressRange = value;
				}
			}

			public int? RegisteredCount
			{
				get
				{
					return registeredCount;
				}
				set	
				{
					registeredCount = value;
				}
			}

			public int? DeregisteredCount
			{
				get
				{
					return deregisteredCount;
				}
				set	
				{
					deregisteredCount = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}
		}
	}
}
