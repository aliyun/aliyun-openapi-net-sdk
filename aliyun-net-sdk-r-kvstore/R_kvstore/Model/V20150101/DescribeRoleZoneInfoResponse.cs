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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeRoleZoneInfoResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeRoleZoneInfo_NodeInfo> node;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalCount
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

		public List<DescribeRoleZoneInfo_NodeInfo> Node
		{
			get
			{
				return node;
			}
			set	
			{
				node = value;
			}
		}

		public class DescribeRoleZoneInfo_NodeInfo
		{

			private string nodeId;

			private string nodeType;

			private string role;

			private string zoneId;

			private string cPUUsage;

			private float? connection;

			private float? avgRt;

			private float? intranetIn;

			private float? intranetOut;

			private string custinsId;

			private int? insType;

			private string insName;

			private int? isLatestVersion;

			private string currentMinorVersion;

			private long? currentBandWidth;

			private long? defaultBandWidth;

			private bool? isOpenBandWidthService;

			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
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

			public string CPUUsage
			{
				get
				{
					return cPUUsage;
				}
				set	
				{
					cPUUsage = value;
				}
			}

			public float? Connection
			{
				get
				{
					return connection;
				}
				set	
				{
					connection = value;
				}
			}

			public float? AvgRt
			{
				get
				{
					return avgRt;
				}
				set	
				{
					avgRt = value;
				}
			}

			public float? IntranetIn
			{
				get
				{
					return intranetIn;
				}
				set	
				{
					intranetIn = value;
				}
			}

			public float? IntranetOut
			{
				get
				{
					return intranetOut;
				}
				set	
				{
					intranetOut = value;
				}
			}

			public string CustinsId
			{
				get
				{
					return custinsId;
				}
				set	
				{
					custinsId = value;
				}
			}

			public int? InsType
			{
				get
				{
					return insType;
				}
				set	
				{
					insType = value;
				}
			}

			public string InsName
			{
				get
				{
					return insName;
				}
				set	
				{
					insName = value;
				}
			}

			public int? IsLatestVersion
			{
				get
				{
					return isLatestVersion;
				}
				set	
				{
					isLatestVersion = value;
				}
			}

			public string CurrentMinorVersion
			{
				get
				{
					return currentMinorVersion;
				}
				set	
				{
					currentMinorVersion = value;
				}
			}

			public long? CurrentBandWidth
			{
				get
				{
					return currentBandWidth;
				}
				set	
				{
					currentBandWidth = value;
				}
			}

			public long? DefaultBandWidth
			{
				get
				{
					return defaultBandWidth;
				}
				set	
				{
					defaultBandWidth = value;
				}
			}

			public bool? IsOpenBandWidthService
			{
				get
				{
					return isOpenBandWidthService;
				}
				set	
				{
					isOpenBandWidthService = value;
				}
			}
		}
	}
}
