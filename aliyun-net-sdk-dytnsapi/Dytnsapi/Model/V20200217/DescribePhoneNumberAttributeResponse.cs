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

namespace Aliyun.Acs.Dytnsapi.Model.V20200217
{
	public class DescribePhoneNumberAttributeResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private DescribePhoneNumberAttribute_PhoneNumberAttribute phoneNumberAttribute;

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

		public DescribePhoneNumberAttribute_PhoneNumberAttribute PhoneNumberAttribute
		{
			get
			{
				return phoneNumberAttribute;
			}
			set	
			{
				phoneNumberAttribute = value;
			}
		}

		public class DescribePhoneNumberAttribute_PhoneNumberAttribute
		{

			private string basicCarrier;

			private string carrier;

			private bool? isNumberPortability;

			private long? numberSegment;

			private string city;

			private string province;

			public string BasicCarrier
			{
				get
				{
					return basicCarrier;
				}
				set	
				{
					basicCarrier = value;
				}
			}

			public string Carrier
			{
				get
				{
					return carrier;
				}
				set	
				{
					carrier = value;
				}
			}

			public bool? IsNumberPortability
			{
				get
				{
					return isNumberPortability;
				}
				set	
				{
					isNumberPortability = value;
				}
			}

			public long? NumberSegment
			{
				get
				{
					return numberSegment;
				}
				set	
				{
					numberSegment = value;
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
