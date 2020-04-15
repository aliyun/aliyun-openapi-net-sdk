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
	public class DescribeQosPoliciesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeQosPolicies_QosPolicy> qosPolicies;

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

		public List<DescribeQosPolicies_QosPolicy> QosPolicies
		{
			get
			{
				return qosPolicies;
			}
			set	
			{
				qosPolicies = value;
			}
		}

		public class DescribeQosPolicies_QosPolicy
		{

			private string qosPolicyId;

			private string qosId;

			private int? priority;

			private string description;

			private string sourceCidr;

			private string destCidr;

			private string ipProtocol;

			private string sourcePortRange;

			private string destPortRange;

			private string startTime;

			private string endTime;

			private string name;

			public string QosPolicyId
			{
				get
				{
					return qosPolicyId;
				}
				set	
				{
					qosPolicyId = value;
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

			public string SourceCidr
			{
				get
				{
					return sourceCidr;
				}
				set	
				{
					sourceCidr = value;
				}
			}

			public string DestCidr
			{
				get
				{
					return destCidr;
				}
				set	
				{
					destCidr = value;
				}
			}

			public string IpProtocol
			{
				get
				{
					return ipProtocol;
				}
				set	
				{
					ipProtocol = value;
				}
			}

			public string SourcePortRange
			{
				get
				{
					return sourcePortRange;
				}
				set	
				{
					sourcePortRange = value;
				}
			}

			public string DestPortRange
			{
				get
				{
					return destPortRange;
				}
				set	
				{
					destPortRange = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
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
