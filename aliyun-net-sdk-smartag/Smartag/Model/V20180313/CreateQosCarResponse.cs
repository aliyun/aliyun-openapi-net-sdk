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
	public class CreateQosCarResponse : AcsResponse
	{

		private string requestId;

		private string qosId;

		private string qosCarId;

		private string description;

		private int? priority;

		private string limitType;

		private int? minBandwidthAbs;

		private int? maxBandwidthAbs;

		private int? minBandwidthPercent;

		private int? maxBandwidthPercent;

		private string percentSourceType;

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

		public string QosId
		{
			get
			{
				return qosId;
			}
			set	
			{
				qosId = value;
			}
		}

		public string QosCarId
		{
			get
			{
				return qosCarId;
			}
			set	
			{
				qosCarId = value;
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

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
			}
		}

		public string LimitType
		{
			get
			{
				return limitType;
			}
			set	
			{
				limitType = value;
			}
		}

		public int? MinBandwidthAbs
		{
			get
			{
				return minBandwidthAbs;
			}
			set	
			{
				minBandwidthAbs = value;
			}
		}

		public int? MaxBandwidthAbs
		{
			get
			{
				return maxBandwidthAbs;
			}
			set	
			{
				maxBandwidthAbs = value;
			}
		}

		public int? MinBandwidthPercent
		{
			get
			{
				return minBandwidthPercent;
			}
			set	
			{
				minBandwidthPercent = value;
			}
		}

		public int? MaxBandwidthPercent
		{
			get
			{
				return maxBandwidthPercent;
			}
			set	
			{
				maxBandwidthPercent = value;
			}
		}

		public string PercentSourceType
		{
			get
			{
				return percentSourceType;
			}
			set	
			{
				percentSourceType = value;
			}
		}
	}
}
