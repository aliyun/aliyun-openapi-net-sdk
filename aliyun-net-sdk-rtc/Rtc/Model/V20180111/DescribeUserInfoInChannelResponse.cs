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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeUserInfoInChannelResponse : AcsResponse
	{

		private string requestId;

		private int? timestamp;

		private bool? isChannelExist;

		private bool? isInChannel;

		private List<DescribeUserInfoInChannel_PropertyItem> property;

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

		public int? Timestamp
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

		public bool? IsChannelExist
		{
			get
			{
				return isChannelExist;
			}
			set	
			{
				isChannelExist = value;
			}
		}

		public bool? IsInChannel
		{
			get
			{
				return isInChannel;
			}
			set	
			{
				isInChannel = value;
			}
		}

		public List<DescribeUserInfoInChannel_PropertyItem> Property
		{
			get
			{
				return property;
			}
			set	
			{
				property = value;
			}
		}

		public class DescribeUserInfoInChannel_PropertyItem
		{

			private string session;

			private int? join;

			private int? role;

			public string Session
			{
				get
				{
					return session;
				}
				set	
				{
					session = value;
				}
			}

			public int? Join
			{
				get
				{
					return join;
				}
				set	
				{
					join = value;
				}
			}

			public int? Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}
		}
	}
}
