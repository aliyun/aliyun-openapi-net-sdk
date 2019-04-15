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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeEventLevelCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeEventLevelCount_EventLevels eventLevels;

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

		public DescribeEventLevelCount_EventLevels EventLevels
		{
			get
			{
				return eventLevels;
			}
			set	
			{
				eventLevels = value;
			}
		}

		public class DescribeEventLevelCount_EventLevels
		{

			private int? serious;

			private int? suspicious;

			private int? remind;

			public int? Serious
			{
				get
				{
					return serious;
				}
				set	
				{
					serious = value;
				}
			}

			public int? Suspicious
			{
				get
				{
					return suspicious;
				}
				set	
				{
					suspicious = value;
				}
			}

			public int? Remind
			{
				get
				{
					return remind;
				}
				set	
				{
					remind = value;
				}
			}
		}
	}
}
