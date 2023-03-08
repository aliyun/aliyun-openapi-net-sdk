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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class DescribeDBClusterHealthStatusResponse : AcsResponse
	{

		private string instanceStatus;

		private string requestId;

		private DescribeDBClusterHealthStatus_CS cS;

		private DescribeDBClusterHealthStatus_Executor executor;

		private DescribeDBClusterHealthStatus_Worker worker;

		public string InstanceStatus
		{
			get
			{
				return instanceStatus;
			}
			set	
			{
				instanceStatus = value;
			}
		}

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

		public DescribeDBClusterHealthStatus_CS CS
		{
			get
			{
				return cS;
			}
			set	
			{
				cS = value;
			}
		}

		public DescribeDBClusterHealthStatus_Executor Executor
		{
			get
			{
				return executor;
			}
			set	
			{
				executor = value;
			}
		}

		public DescribeDBClusterHealthStatus_Worker Worker
		{
			get
			{
				return worker;
			}
			set	
			{
				worker = value;
			}
		}

		public class DescribeDBClusterHealthStatus_CS
		{

			private long? activeCount;

			private long? unavailableCount;

			private long? riskCount;

			private long? expectedCount;

			private string status;

			public long? ActiveCount
			{
				get
				{
					return activeCount;
				}
				set	
				{
					activeCount = value;
				}
			}

			public long? UnavailableCount
			{
				get
				{
					return unavailableCount;
				}
				set	
				{
					unavailableCount = value;
				}
			}

			public long? RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}

			public long? ExpectedCount
			{
				get
				{
					return expectedCount;
				}
				set	
				{
					expectedCount = value;
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

		public class DescribeDBClusterHealthStatus_Executor
		{

			private long? activeCount;

			private long? unavailableCount;

			private long? riskCount;

			private long? expectedCount;

			private string status;

			public long? ActiveCount
			{
				get
				{
					return activeCount;
				}
				set	
				{
					activeCount = value;
				}
			}

			public long? UnavailableCount
			{
				get
				{
					return unavailableCount;
				}
				set	
				{
					unavailableCount = value;
				}
			}

			public long? RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}

			public long? ExpectedCount
			{
				get
				{
					return expectedCount;
				}
				set	
				{
					expectedCount = value;
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

		public class DescribeDBClusterHealthStatus_Worker
		{

			private long? activeCount;

			private long? unavailableCount;

			private long? riskCount;

			private long? expectedCount;

			private string status;

			public long? ActiveCount
			{
				get
				{
					return activeCount;
				}
				set	
				{
					activeCount = value;
				}
			}

			public long? UnavailableCount
			{
				get
				{
					return unavailableCount;
				}
				set	
				{
					unavailableCount = value;
				}
			}

			public long? RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}

			public long? ExpectedCount
			{
				get
				{
					return expectedCount;
				}
				set	
				{
					expectedCount = value;
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
