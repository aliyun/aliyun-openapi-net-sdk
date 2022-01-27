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
	public class DescribeContainerStatisticsResponse : AcsResponse
	{

		private string requestId;

		private DescribeContainerStatistics_Data data;

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

		public DescribeContainerStatistics_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeContainerStatistics_Data
		{

			private int? totalAlarmCount;

			private int? remindAlarmCount;

			private int? suspiciousAlarmCount;

			private int? seriousAlarmCount;

			private int? totalNode;

			private int? hasRiskNode;

			public int? TotalAlarmCount
			{
				get
				{
					return totalAlarmCount;
				}
				set	
				{
					totalAlarmCount = value;
				}
			}

			public int? RemindAlarmCount
			{
				get
				{
					return remindAlarmCount;
				}
				set	
				{
					remindAlarmCount = value;
				}
			}

			public int? SuspiciousAlarmCount
			{
				get
				{
					return suspiciousAlarmCount;
				}
				set	
				{
					suspiciousAlarmCount = value;
				}
			}

			public int? SeriousAlarmCount
			{
				get
				{
					return seriousAlarmCount;
				}
				set	
				{
					seriousAlarmCount = value;
				}
			}

			public int? TotalNode
			{
				get
				{
					return totalNode;
				}
				set	
				{
					totalNode = value;
				}
			}

			public int? HasRiskNode
			{
				get
				{
					return hasRiskNode;
				}
				set	
				{
					hasRiskNode = value;
				}
			}
		}
	}
}
