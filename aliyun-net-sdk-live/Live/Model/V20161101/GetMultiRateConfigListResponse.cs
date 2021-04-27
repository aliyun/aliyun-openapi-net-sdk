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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class GetMultiRateConfigListResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private List<GetMultiRateConfigList_Info> groupInfo;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public List<GetMultiRateConfigList_Info> GroupInfo
		{
			get
			{
				return groupInfo;
			}
			set	
			{
				groupInfo = value;
			}
		}

		public class GetMultiRateConfigList_Info
		{

			private string app;

			private string avFormat;

			private string groupId;

			private int? count;

			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			public string AvFormat
			{
				get
				{
					return avFormat;
				}
				set	
				{
					avFormat = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public int? Count
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
