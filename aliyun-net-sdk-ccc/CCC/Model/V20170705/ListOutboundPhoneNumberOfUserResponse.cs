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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class ListOutboundPhoneNumberOfUserResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListOutboundPhoneNumberOfUser_PhoneNumber> outboundPhoneNumbers;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public List<ListOutboundPhoneNumberOfUser_PhoneNumber> OutboundPhoneNumbers
		{
			get
			{
				return outboundPhoneNumbers;
			}
			set	
			{
				outboundPhoneNumbers = value;
			}
		}

		public class ListOutboundPhoneNumberOfUser_PhoneNumber
		{

			private string phoneNumberId;

			private string instanceId;

			private string number;

			private string phoneNumberDescription;

			private bool? testOnly;

			private int? remainingTime;

			private bool? allowOutbound;

			private string usage;

			private int? trunks;

			private string city;

			private string province;

			private bool? privateFlag;

			private string sipTelX;

			private ListOutboundPhoneNumberOfUser_PrivacyNumber privacyNumber;

			public string PhoneNumberId
			{
				get
				{
					return phoneNumberId;
				}
				set	
				{
					phoneNumberId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string Number
			{
				get
				{
					return number;
				}
				set	
				{
					number = value;
				}
			}

			public string PhoneNumberDescription
			{
				get
				{
					return phoneNumberDescription;
				}
				set	
				{
					phoneNumberDescription = value;
				}
			}

			public bool? TestOnly
			{
				get
				{
					return testOnly;
				}
				set	
				{
					testOnly = value;
				}
			}

			public int? RemainingTime
			{
				get
				{
					return remainingTime;
				}
				set	
				{
					remainingTime = value;
				}
			}

			public bool? AllowOutbound
			{
				get
				{
					return allowOutbound;
				}
				set	
				{
					allowOutbound = value;
				}
			}

			public string Usage
			{
				get
				{
					return usage;
				}
				set	
				{
					usage = value;
				}
			}

			public int? Trunks
			{
				get
				{
					return trunks;
				}
				set	
				{
					trunks = value;
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

			public bool? PrivateFlag
			{
				get
				{
					return privateFlag;
				}
				set	
				{
					privateFlag = value;
				}
			}

			public string SipTelX
			{
				get
				{
					return sipTelX;
				}
				set	
				{
					sipTelX = value;
				}
			}

			public ListOutboundPhoneNumberOfUser_PrivacyNumber PrivacyNumber
			{
				get
				{
					return privacyNumber;
				}
				set	
				{
					privacyNumber = value;
				}
			}

			public class ListOutboundPhoneNumberOfUser_PrivacyNumber
			{

				private string poolId;

				private string type;

				private string telX;

				private string poolName;

				private string phoneNumber;

				private string extra;

				private string bizId;

				private string subId;

				private string regionNameCity;

				public string PoolId
				{
					get
					{
						return poolId;
					}
					set	
					{
						poolId = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string TelX
				{
					get
					{
						return telX;
					}
					set	
					{
						telX = value;
					}
				}

				public string PoolName
				{
					get
					{
						return poolName;
					}
					set	
					{
						poolName = value;
					}
				}

				public string PhoneNumber
				{
					get
					{
						return phoneNumber;
					}
					set	
					{
						phoneNumber = value;
					}
				}

				public string Extra
				{
					get
					{
						return extra;
					}
					set	
					{
						extra = value;
					}
				}

				public string BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				public string SubId
				{
					get
					{
						return subId;
					}
					set	
					{
						subId = value;
					}
				}

				public string RegionNameCity
				{
					get
					{
						return regionNameCity;
					}
					set	
					{
						regionNameCity = value;
					}
				}
			}
		}
	}
}
