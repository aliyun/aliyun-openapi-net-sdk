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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeUserUvByDayResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeUserUvByDay_UserPlayStatisticsInfo> userPlayStatisticsInfos;

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

		public List<DescribeUserUvByDay_UserPlayStatisticsInfo> UserPlayStatisticsInfos
		{
			get
			{
				return userPlayStatisticsInfos;
			}
			set	
			{
				userPlayStatisticsInfos = value;
			}
		}

		public class DescribeUserUvByDay_UserPlayStatisticsInfo
		{

			private string date;

			private string android;

			private string ios;

			private string h5;

			private string flash;

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

			public string Android
			{
				get
				{
					return android;
				}
				set	
				{
					android = value;
				}
			}

			public string Ios
			{
				get
				{
					return ios;
				}
				set	
				{
					ios = value;
				}
			}

			public string H5
			{
				get
				{
					return h5;
				}
				set	
				{
					h5 = value;
				}
			}

			public string Flash
			{
				get
				{
					return flash;
				}
				set	
				{
					flash = value;
				}
			}
		}
	}
}