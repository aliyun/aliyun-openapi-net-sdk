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
	public class QuerySmsReportsResponse : AcsResponse
	{

		private string requestId;

		private long? totalElements;

		private List<QuerySmsReports_SmsReportsItem> smsReports;

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

		public List<QuerySmsReports_SmsReportsItem> SmsReports
		{
			get
			{
				return smsReports;
			}
			set	
			{
				smsReports = value;
			}
		}

		public class QuerySmsReports_SmsReportsItem
		{

			private string tid;

			private string mobile;

			private string code;

			private string stat;

			private string sn;

			private string tenantId;

			private string appId;

			private string eventId;

			private string time;

			private int? chargedCount;

			public string Tid
			{
				get
				{
					return tid;
				}
				set	
				{
					tid = value;
				}
			}

			public string Mobile
			{
				get
				{
					return mobile;
				}
				set	
				{
					mobile = value;
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

			public string Stat
			{
				get
				{
					return stat;
				}
				set	
				{
					stat = value;
				}
			}

			public string Sn
			{
				get
				{
					return sn;
				}
				set	
				{
					sn = value;
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

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string EventId
			{
				get
				{
					return eventId;
				}
				set	
				{
					eventId = value;
				}
			}

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

			public int? ChargedCount
			{
				get
				{
					return chargedCount;
				}
				set	
				{
					chargedCount = value;
				}
			}
		}
	}
}
