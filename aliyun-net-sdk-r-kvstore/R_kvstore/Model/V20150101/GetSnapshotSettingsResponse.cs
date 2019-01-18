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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class GetSnapshotSettingsResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private int? beginHour;

		private int? endHour;

		private int? retentionDay;

		private int? maxAutoSnapshots;

		private int? maxManualSnapshots;

		private int? dayList;

		private string nextTime;

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

		public int? BeginHour
		{
			get
			{
				return beginHour;
			}
			set	
			{
				beginHour = value;
			}
		}

		public int? EndHour
		{
			get
			{
				return endHour;
			}
			set	
			{
				endHour = value;
			}
		}

		public int? RetentionDay
		{
			get
			{
				return retentionDay;
			}
			set	
			{
				retentionDay = value;
			}
		}

		public int? MaxAutoSnapshots
		{
			get
			{
				return maxAutoSnapshots;
			}
			set	
			{
				maxAutoSnapshots = value;
			}
		}

		public int? MaxManualSnapshots
		{
			get
			{
				return maxManualSnapshots;
			}
			set	
			{
				maxManualSnapshots = value;
			}
		}

		public int? DayList
		{
			get
			{
				return dayList;
			}
			set	
			{
				dayList = value;
			}
		}

		public string NextTime
		{
			get
			{
				return nextTime;
			}
			set	
			{
				nextTime = value;
			}
		}
	}
}