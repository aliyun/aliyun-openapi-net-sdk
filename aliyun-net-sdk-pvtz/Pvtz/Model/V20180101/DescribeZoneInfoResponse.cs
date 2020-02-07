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

namespace Aliyun.Acs.pvtz.Model.V20180101
{
	public class DescribeZoneInfoResponse : AcsResponse
	{

		private string requestId;

		private string zoneId;

		private string zoneName;

		private string remark;

		private int? recordCount;

		private string createTime;

		private long? createTimestamp;

		private string updateTime;

		private long? updateTimestamp;

		private bool? isPtr;

		private string proxyPattern;

		private bool? slaveDns;

		private List<DescribeZoneInfo_Vpc> bindVpcs;

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

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
			}
		}

		public string ZoneName
		{
			get
			{
				return zoneName;
			}
			set	
			{
				zoneName = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
			}
		}

		public int? RecordCount
		{
			get
			{
				return recordCount;
			}
			set	
			{
				recordCount = value;
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

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public long? UpdateTimestamp
		{
			get
			{
				return updateTimestamp;
			}
			set	
			{
				updateTimestamp = value;
			}
		}

		public bool? IsPtr
		{
			get
			{
				return isPtr;
			}
			set	
			{
				isPtr = value;
			}
		}

		public string ProxyPattern
		{
			get
			{
				return proxyPattern;
			}
			set	
			{
				proxyPattern = value;
			}
		}

		public bool? SlaveDns
		{
			get
			{
				return slaveDns;
			}
			set	
			{
				slaveDns = value;
			}
		}

		public List<DescribeZoneInfo_Vpc> BindVpcs
		{
			get
			{
				return bindVpcs;
			}
			set	
			{
				bindVpcs = value;
			}
		}

		public class DescribeZoneInfo_Vpc
		{

			private string vpcId;

			private string vpcName;

			private string regionName;

			private string regionId;

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

			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
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
		}
	}
}
