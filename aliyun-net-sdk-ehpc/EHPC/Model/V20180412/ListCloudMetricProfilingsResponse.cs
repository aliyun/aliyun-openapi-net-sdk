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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListCloudMetricProfilingsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListCloudMetricProfilings_ProfilingInfo> profilings;

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

		public List<ListCloudMetricProfilings_ProfilingInfo> Profilings
		{
			get
			{
				return profilings;
			}
			set	
			{
				profilings = value;
			}
		}

		public class ListCloudMetricProfilings_ProfilingInfo
		{

			private string profilingId;

			private string instanceId;

			private string hostName;

			private int? pid;

			private int? duration;

			private int? freq;

			private string triggerTime;

			public string ProfilingId
			{
				get
				{
					return profilingId;
				}
				set	
				{
					profilingId = value;
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

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public int? Pid
			{
				get
				{
					return pid;
				}
				set	
				{
					pid = value;
				}
			}

			public int? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public int? Freq
			{
				get
				{
					return freq;
				}
				set	
				{
					freq = value;
				}
			}

			public string TriggerTime
			{
				get
				{
					return triggerTime;
				}
				set	
				{
					triggerTime = value;
				}
			}
		}
	}
}