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
	public class DescribeDefenseRecordsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<DescribeDefenseRecords_DefenseRecord> defenseRecords;

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

		public long? TotalCount
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

		public List<DescribeDefenseRecords_DefenseRecord> DefenseRecords
		{
			get
			{
				return defenseRecords;
			}
			set	
			{
				defenseRecords = value;
			}
		}

		public class DescribeDefenseRecords_DefenseRecord
		{

			private long? startTime;

			private long? endTime;

			private string instanceId;

			private int? status;

			private long? attackPeak;

			private int? eventCount;

			public long? StartTime
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

			public long? EndTime
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

			public int? Status
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

			public long? AttackPeak
			{
				get
				{
					return attackPeak;
				}
				set	
				{
					attackPeak = value;
				}
			}

			public int? EventCount
			{
				get
				{
					return eventCount;
				}
				set	
				{
					eventCount = value;
				}
			}
		}
	}
}
