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
	public class DescribePlayVideoStatisResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePlayVideoStatis_VideoPlayStatisDetail> videoPlayStatisDetails;

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

		public List<DescribePlayVideoStatis_VideoPlayStatisDetail> VideoPlayStatisDetails
		{
			get
			{
				return videoPlayStatisDetails;
			}
			set	
			{
				videoPlayStatisDetails = value;
			}
		}

		public class DescribePlayVideoStatis_VideoPlayStatisDetail
		{

			private string date;

			private string playDuration;

			private string vV;

			private string uV;

			private string playRange;

			private string title;

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

			public string PlayDuration
			{
				get
				{
					return playDuration;
				}
				set	
				{
					playDuration = value;
				}
			}

			public string VV
			{
				get
				{
					return vV;
				}
				set	
				{
					vV = value;
				}
			}

			public string UV
			{
				get
				{
					return uV;
				}
				set	
				{
					uV = value;
				}
			}

			public string PlayRange
			{
				get
				{
					return playRange;
				}
				set	
				{
					playRange = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}
		}
	}
}
