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
	public class DescribeMediaDistributionResponse : AcsResponse
	{

		private string requestId;

		private long? total;

		private List<DescribeMediaDistribution_MediaDistribution> mediaDistributionList;

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

		public long? Total
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

		public List<DescribeMediaDistribution_MediaDistribution> MediaDistributionList
		{
			get
			{
				return mediaDistributionList;
			}
			set	
			{
				mediaDistributionList = value;
			}
		}

		public class DescribeMediaDistribution_MediaDistribution
		{

			private string startTime;

			private string endTime;

			private long? count;

			public string StartTime
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

			public string EndTime
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

			public long? Count
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
		}
	}
}
