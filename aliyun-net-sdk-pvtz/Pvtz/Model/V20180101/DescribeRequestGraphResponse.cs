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

namespace Aliyun.Acs.pvtz.Model.V20180101
{
	public class DescribeRequestGraphResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRequestGraph_ZoneRequestTop> requestDetails;

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

		public List<DescribeRequestGraph_ZoneRequestTop> RequestDetails
		{
			get
			{
				return requestDetails;
			}
			set	
			{
				requestDetails = value;
			}
		}

		public class DescribeRequestGraph_ZoneRequestTop
		{

			private string time;

			private long? timestamp;

			private long? requestCount;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public long? RequestCount
			{
				get
				{
					return requestCount;
				}
				set	
				{
					requestCount = value;
				}
			}
		}
	}
}