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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetDailyPlayRegionStatisResponse : AcsResponse
	{

		private string requestId;

		private List<GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO> dailyPlayRegionStatisList;

		private List<string> failDates;

		private List<string> emptyDates;

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

		public List<GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO> DailyPlayRegionStatisList
		{
			get
			{
				return dailyPlayRegionStatisList;
			}
			set	
			{
				dailyPlayRegionStatisList = value;
			}
		}

		public List<string> FailDates
		{
			get
			{
				return failDates;
			}
			set	
			{
				failDates = value;
			}
		}

		public List<string> EmptyDates
		{
			get
			{
				return emptyDates;
			}
			set	
			{
				emptyDates = value;
			}
		}

		public class GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO
		{

			private string date;

			private string fileUrl;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public string FileUrl
			{
				get
				{
					return fileUrl;
				}
				set	
				{
					fileUrl = value;
				}
			}
		}
	}
}
