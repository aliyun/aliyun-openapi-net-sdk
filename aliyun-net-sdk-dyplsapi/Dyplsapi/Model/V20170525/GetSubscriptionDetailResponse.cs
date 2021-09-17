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

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
	public class GetSubscriptionDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetSubscriptionDetail_Data data;

		public string Code
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

		public GetSubscriptionDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetSubscriptionDetail_Data
		{

			private string phoneNo;

			private string city;

			private int? switchStatus;

			private long? subsId;

			private string secretNo;

			private string vendor;

			private string province;

			public string PhoneNo
			{
				get
				{
					return phoneNo;
				}
				set	
				{
					phoneNo = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public int? SwitchStatus
			{
				get
				{
					return switchStatus;
				}
				set	
				{
					switchStatus = value;
				}
			}

			public long? SubsId
			{
				get
				{
					return subsId;
				}
				set	
				{
					subsId = value;
				}
			}

			public string SecretNo
			{
				get
				{
					return secretNo;
				}
				set	
				{
					secretNo = value;
				}
			}

			public string Vendor
			{
				get
				{
					return vendor;
				}
				set	
				{
					vendor = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}
		}
	}
}
