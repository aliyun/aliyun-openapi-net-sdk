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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribePlayUserAvgResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePlayUserAvg_UserPlayStatisAvg> userPlayStatisAvgs;

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

		public List<DescribePlayUserAvg_UserPlayStatisAvg> UserPlayStatisAvgs
		{
			get
			{
				return userPlayStatisAvgs;
			}
			set	
			{
				userPlayStatisAvgs = value;
			}
		}

		public class DescribePlayUserAvg_UserPlayStatisAvg
		{

			private string date;

			private string avgPlayDuration;

			private string avgPlayCount;

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

			public string AvgPlayDuration
			{
				get
				{
					return avgPlayDuration;
				}
				set	
				{
					avgPlayDuration = value;
				}
			}

			public string AvgPlayCount
			{
				get
				{
					return avgPlayCount;
				}
				set	
				{
					avgPlayCount = value;
				}
			}
		}
	}
}
