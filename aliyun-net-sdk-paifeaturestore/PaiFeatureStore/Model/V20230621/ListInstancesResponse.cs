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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class ListInstancesResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<ListInstances_InstancesItem> instances;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListInstances_InstancesItem> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class ListInstances_InstancesItem
		{

			private string instanceId;

			private string type;

			private string status;

			private string regionId;

			private string gmtCreateTime;

			private string gmtModifiedTime;

			private ListInstances_FeatureDBInstanceInfo featureDBInstanceInfo;

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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public string GmtCreateTime
			{
				get
				{
					return gmtCreateTime;
				}
				set	
				{
					gmtCreateTime = value;
				}
			}

			public string GmtModifiedTime
			{
				get
				{
					return gmtModifiedTime;
				}
				set	
				{
					gmtModifiedTime = value;
				}
			}

			public ListInstances_FeatureDBInstanceInfo FeatureDBInstanceInfo
			{
				get
				{
					return featureDBInstanceInfo;
				}
				set	
				{
					featureDBInstanceInfo = value;
				}
			}

			public class ListInstances_FeatureDBInstanceInfo
			{

				private string status;

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
			}
		}
	}
}
