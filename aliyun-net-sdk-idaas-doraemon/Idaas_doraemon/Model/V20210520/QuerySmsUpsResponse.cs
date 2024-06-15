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

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
	public class QuerySmsUpsResponse : AcsResponse
	{

		private string requestId;

		private long? totalElements;

		private List<QuerySmsUps_SmsUpsItem> smsUps;

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

		public long? TotalElements
		{
			get
			{
				return totalElements;
			}
			set	
			{
				totalElements = value;
			}
		}

		public List<QuerySmsUps_SmsUpsItem> SmsUps
		{
			get
			{
				return smsUps;
			}
			set	
			{
				smsUps = value;
			}
		}

		public class QuerySmsUps_SmsUpsItem
		{

			private string phoneNumber;

			private string content;

			private string destCode;

			private string sequenceId;

			private string tenantId;

			private string sendTime;

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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string DestCode
			{
				get
				{
					return destCode;
				}
				set	
				{
					destCode = value;
				}
			}

			public string SequenceId
			{
				get
				{
					return sequenceId;
				}
				set	
				{
					sequenceId = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string SendTime
			{
				get
				{
					return sendTime;
				}
				set	
				{
					sendTime = value;
				}
			}
		}
	}
}
