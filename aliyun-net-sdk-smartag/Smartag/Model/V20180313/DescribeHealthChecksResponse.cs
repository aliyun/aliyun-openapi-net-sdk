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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeHealthChecksResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeHealthChecks_HealthCheck> healthChecks;

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

		public List<DescribeHealthChecks_HealthCheck> HealthChecks
		{
			get
			{
				return healthChecks;
			}
			set	
			{
				healthChecks = value;
			}
		}

		public class DescribeHealthChecks_HealthCheck
		{

			private string hcInstanceId;

			private string smartAGId;

			private string name;

			private string description;

			private string type;

			private string dstIpAddr;

			private int? dstPort;

			private string srcIpAddr;

			private int? srcPort;

			private int? probeInterval;

			private int? probeCount;

			private int? probeTimeout;

			private int? rttThreshold;

			private int? rttFailThreshold;

			private int? failCountThreshold;

			private int? relationCount;

			private string status;

			public string HcInstanceId
			{
				get
				{
					return hcInstanceId;
				}
				set	
				{
					hcInstanceId = value;
				}
			}

			public string SmartAGId
			{
				get
				{
					return smartAGId;
				}
				set	
				{
					smartAGId = value;
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

			public string DstIpAddr
			{
				get
				{
					return dstIpAddr;
				}
				set	
				{
					dstIpAddr = value;
				}
			}

			public int? DstPort
			{
				get
				{
					return dstPort;
				}
				set	
				{
					dstPort = value;
				}
			}

			public string SrcIpAddr
			{
				get
				{
					return srcIpAddr;
				}
				set	
				{
					srcIpAddr = value;
				}
			}

			public int? SrcPort
			{
				get
				{
					return srcPort;
				}
				set	
				{
					srcPort = value;
				}
			}

			public int? ProbeInterval
			{
				get
				{
					return probeInterval;
				}
				set	
				{
					probeInterval = value;
				}
			}

			public int? ProbeCount
			{
				get
				{
					return probeCount;
				}
				set	
				{
					probeCount = value;
				}
			}

			public int? ProbeTimeout
			{
				get
				{
					return probeTimeout;
				}
				set	
				{
					probeTimeout = value;
				}
			}

			public int? RttThreshold
			{
				get
				{
					return rttThreshold;
				}
				set	
				{
					rttThreshold = value;
				}
			}

			public int? RttFailThreshold
			{
				get
				{
					return rttFailThreshold;
				}
				set	
				{
					rttFailThreshold = value;
				}
			}

			public int? FailCountThreshold
			{
				get
				{
					return failCountThreshold;
				}
				set	
				{
					failCountThreshold = value;
				}
			}

			public int? RelationCount
			{
				get
				{
					return relationCount;
				}
				set	
				{
					relationCount = value;
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
		}
	}
}
