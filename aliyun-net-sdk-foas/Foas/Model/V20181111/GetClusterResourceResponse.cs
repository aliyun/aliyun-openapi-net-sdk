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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class GetClusterResourceResponse : AcsResponse
	{

		private string requestId;

		private GetClusterResource_Resource resource;

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

		public GetClusterResource_Resource Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
			}
		}

		public class GetClusterResource_Resource
		{

			private long? totalMB;

			private long? allocatedMB;

			private long? availableMB;

			private long? totalVirtualCores;

			private long? allocatedVirtualCores;

			private long? availableVirtualCores;

			public long? TotalMB
			{
				get
				{
					return totalMB;
				}
				set	
				{
					totalMB = value;
				}
			}

			public long? AllocatedMB
			{
				get
				{
					return allocatedMB;
				}
				set	
				{
					allocatedMB = value;
				}
			}

			public long? AvailableMB
			{
				get
				{
					return availableMB;
				}
				set	
				{
					availableMB = value;
				}
			}

			public long? TotalVirtualCores
			{
				get
				{
					return totalVirtualCores;
				}
				set	
				{
					totalVirtualCores = value;
				}
			}

			public long? AllocatedVirtualCores
			{
				get
				{
					return allocatedVirtualCores;
				}
				set	
				{
					allocatedVirtualCores = value;
				}
			}

			public long? AvailableVirtualCores
			{
				get
				{
					return availableVirtualCores;
				}
				set	
				{
					availableVirtualCores = value;
				}
			}
		}
	}
}
