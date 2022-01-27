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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeInstanceStatisticsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceStatistics_InstanceStatistic> instanceStatistics;

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

		public List<DescribeInstanceStatistics_InstanceStatistic> InstanceStatistics
		{
			get
			{
				return instanceStatistics;
			}
			set	
			{
				instanceStatistics = value;
			}
		}

		public class DescribeInstanceStatistics_InstanceStatistic
		{

			private string instanceId;

			private int? portUsage;

			private int? domainUsage;

			private int? siteUsage;

			private int? defenseCountUsage;

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

			public int? PortUsage
			{
				get
				{
					return portUsage;
				}
				set	
				{
					portUsage = value;
				}
			}

			public int? DomainUsage
			{
				get
				{
					return domainUsage;
				}
				set	
				{
					domainUsage = value;
				}
			}

			public int? SiteUsage
			{
				get
				{
					return siteUsage;
				}
				set	
				{
					siteUsage = value;
				}
			}

			public int? DefenseCountUsage
			{
				get
				{
					return defenseCountUsage;
				}
				set	
				{
					defenseCountUsage = value;
				}
			}
		}
	}
}
