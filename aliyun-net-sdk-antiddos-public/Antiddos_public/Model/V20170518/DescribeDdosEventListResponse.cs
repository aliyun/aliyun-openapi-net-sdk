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

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
	public class DescribeDdosEventListResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeDdosEventList_DdosEvent> ddosEventList;

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<DescribeDdosEventList_DdosEvent> DdosEventList
		{
			get
			{
				return ddosEventList;
			}
			set	
			{
				ddosEventList = value;
			}
		}

		public class DescribeDdosEventList_DdosEvent
		{

			private string ddosType;

			private long? endTime;

			private long? startTime;

			private long? delayTime;

			private string ddosStatus;

			private long? unBlackholeTime;

			public string DdosType
			{
				get
				{
					return ddosType;
				}
				set	
				{
					ddosType = value;
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

			public long? DelayTime
			{
				get
				{
					return delayTime;
				}
				set	
				{
					delayTime = value;
				}
			}

			public string DdosStatus
			{
				get
				{
					return ddosStatus;
				}
				set	
				{
					ddosStatus = value;
				}
			}

			public long? UnBlackholeTime
			{
				get
				{
					return unBlackholeTime;
				}
				set	
				{
					unBlackholeTime = value;
				}
			}
		}
	}
}
