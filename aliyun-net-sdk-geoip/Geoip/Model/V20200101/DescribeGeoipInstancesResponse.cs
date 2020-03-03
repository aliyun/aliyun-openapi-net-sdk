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

namespace Aliyun.Acs.geoip.Model.V20200101
{
	public class DescribeGeoipInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGeoipInstances_GeoipInstance> geoipInstances;

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

		public List<DescribeGeoipInstances_GeoipInstance> GeoipInstances
		{
			get
			{
				return geoipInstances;
			}
			set	
			{
				geoipInstances = value;
			}
		}

		public class DescribeGeoipInstances_GeoipInstance
		{

			private string productCode;

			private string instanceId;

			private string versionCode;

			private string status;

			private string createTime;

			private long? createTimestamp;

			private string expireTime;

			private long? expireTimestamp;

			private long? maxQps;

			private long? maxQpd;

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
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

			public string VersionCode
			{
				get
				{
					return versionCode;
				}
				set	
				{
					versionCode = value;
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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public long? ExpireTimestamp
			{
				get
				{
					return expireTimestamp;
				}
				set	
				{
					expireTimestamp = value;
				}
			}

			public long? MaxQps
			{
				get
				{
					return maxQps;
				}
				set	
				{
					maxQps = value;
				}
			}

			public long? MaxQpd
			{
				get
				{
					return maxQpd;
				}
				set	
				{
					maxQpd = value;
				}
			}
		}
	}
}
