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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class ListInstancesTrafficPackagesResponse : AcsResponse
	{

		private string requestId;

		private List<ListInstancesTrafficPackages_InstanceTrafficPackageUsage> instanceTrafficPackageUsages;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "InstanceTrafficPackageUsages")]
		public List<ListInstancesTrafficPackages_InstanceTrafficPackageUsage> InstanceTrafficPackageUsages
		{
			get
			{
				return instanceTrafficPackageUsages;
			}
			set	
			{
				instanceTrafficPackageUsages = value;
			}
		}

		public class ListInstancesTrafficPackages_InstanceTrafficPackageUsage
		{

			private string instanceId;

			private long? trafficUsed;

			private long? trafficPackageTotal;

			private long? trafficPackageRemaining;

			private long? trafficOverflow;

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "TrafficUsed")]
			public long? TrafficUsed
			{
				get
				{
					return trafficUsed;
				}
				set	
				{
					trafficUsed = value;
				}
			}

			[JsonProperty(PropertyName = "TrafficPackageTotal")]
			public long? TrafficPackageTotal
			{
				get
				{
					return trafficPackageTotal;
				}
				set	
				{
					trafficPackageTotal = value;
				}
			}

			[JsonProperty(PropertyName = "TrafficPackageRemaining")]
			public long? TrafficPackageRemaining
			{
				get
				{
					return trafficPackageRemaining;
				}
				set	
				{
					trafficPackageRemaining = value;
				}
			}

			[JsonProperty(PropertyName = "TrafficOverflow")]
			public long? TrafficOverflow
			{
				get
				{
					return trafficOverflow;
				}
				set	
				{
					trafficOverflow = value;
				}
			}
		}
	}
}
