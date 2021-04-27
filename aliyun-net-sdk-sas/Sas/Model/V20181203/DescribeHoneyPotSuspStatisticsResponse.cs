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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeHoneyPotSuspStatisticsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem> suspHoneyPotStatisticsResponse;

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

		public List<DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem> SuspHoneyPotStatisticsResponse
		{
			get
			{
				return suspHoneyPotStatisticsResponse;
			}
			set	
			{
				suspHoneyPotStatisticsResponse = value;
			}
		}

		public class DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem
		{

			private int? count;

			private string type;

			private string instanceId;

			private string instanceName;

			private string vpcId;

			private string vpcName;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
				}
			}
		}
	}
}
