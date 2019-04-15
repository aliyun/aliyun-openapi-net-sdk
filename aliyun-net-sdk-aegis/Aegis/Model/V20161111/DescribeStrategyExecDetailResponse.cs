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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeStrategyExecDetailResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private string source;

		private string percent;

		private int? successCount;

		private int? failCount;

		private int? inProcessCount;

		private List<DescribeStrategyExecDetail_FailedEcs> failedEcsList;

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

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
			}
		}

		public string Percent
		{
			get
			{
				return percent;
			}
			set	
			{
				percent = value;
			}
		}

		public int? SuccessCount
		{
			get
			{
				return successCount;
			}
			set	
			{
				successCount = value;
			}
		}

		public int? FailCount
		{
			get
			{
				return failCount;
			}
			set	
			{
				failCount = value;
			}
		}

		public int? InProcessCount
		{
			get
			{
				return inProcessCount;
			}
			set	
			{
				inProcessCount = value;
			}
		}

		public List<DescribeStrategyExecDetail_FailedEcs> FailedEcsList
		{
			get
			{
				return failedEcsList;
			}
			set	
			{
				failedEcsList = value;
			}
		}

		public class DescribeStrategyExecDetail_FailedEcs
		{

			private string reason;

			private string instanceName;

			private string iP;

			private string intranetIp;

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string IP
			{
				get
				{
					return iP;
				}
				set	
				{
					iP = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}
		}
	}
}
