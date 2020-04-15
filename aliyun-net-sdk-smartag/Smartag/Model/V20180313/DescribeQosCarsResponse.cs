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
	public class DescribeQosCarsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeQosCars_QosCar> qosCars;

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

		public List<DescribeQosCars_QosCar> QosCars
		{
			get
			{
				return qosCars;
			}
			set	
			{
				qosCars = value;
			}
		}

		public class DescribeQosCars_QosCar
		{

			private string qosCarId;

			private string qosId;

			private string description;

			private int? priority;

			private string limitType;

			private int? minBandwidthAbs;

			private int? maxBandwidthAbs;

			private int? minBandwidthPercent;

			private int? maxBandwidthPercent;

			private string percentSourceType;

			private string name;

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
		}
	}
}
