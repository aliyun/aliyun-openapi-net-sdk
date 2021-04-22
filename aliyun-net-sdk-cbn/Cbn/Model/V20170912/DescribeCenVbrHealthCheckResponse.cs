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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenVbrHealthCheckResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeCenVbrHealthCheck_VbrHealthCheck> vbrHealthChecks;

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

		public List<DescribeCenVbrHealthCheck_VbrHealthCheck> VbrHealthChecks
		{
			get
			{
				return vbrHealthChecks;
			}
			set	
			{
				vbrHealthChecks = value;
			}
		}

		public class DescribeCenVbrHealthCheck_VbrHealthCheck
		{

			private string cenId;

			private string vbrInstanceId;

			private string linkStatus;

			private long? packetLoss;

			private string healthCheckSourceIp;

			private string healthCheckTargetIp;

			private long? delay;

			private int? healthCheckInterval;

			private int? healthyThreshold;

			private string vbrInstanceRegionId;

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public string VbrInstanceId
			{
				get
				{
					return vbrInstanceId;
				}
				set	
				{
					vbrInstanceId = value;
				}
			}

			public string LinkStatus
			{
				get
				{
					return linkStatus;
				}
				set	
				{
					linkStatus = value;
				}
			}

			public long? PacketLoss
			{
				get
				{
					return packetLoss;
				}
				set	
				{
					packetLoss = value;
				}
			}

			public string HealthCheckSourceIp
			{
				get
				{
					return healthCheckSourceIp;
				}
				set	
				{
					healthCheckSourceIp = value;
				}
			}

			public string HealthCheckTargetIp
			{
				get
				{
					return healthCheckTargetIp;
				}
				set	
				{
					healthCheckTargetIp = value;
				}
			}

			public long? Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}

			public int? HealthCheckInterval
			{
				get
				{
					return healthCheckInterval;
				}
				set	
				{
					healthCheckInterval = value;
				}
			}

			public int? HealthyThreshold
			{
				get
				{
					return healthyThreshold;
				}
				set	
				{
					healthyThreshold = value;
				}
			}

			public string VbrInstanceRegionId
			{
				get
				{
					return vbrInstanceRegionId;
				}
				set	
				{
					vbrInstanceRegionId = value;
				}
			}
		}
	}
}
