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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class DescribeAppGroupDataReportResponse : AcsResponse
	{

		private string requestId;

		private DescribeAppGroupDataReport_Result result;

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

		public DescribeAppGroupDataReport_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeAppGroupDataReport_Result
		{

			private int? receivedCount;

			private List<DescribeAppGroupDataReport_ReceivedSampleItem> receivedSample;

			public int? ReceivedCount
			{
				get
				{
					return receivedCount;
				}
				set	
				{
					receivedCount = value;
				}
			}

			public List<DescribeAppGroupDataReport_ReceivedSampleItem> ReceivedSample
			{
				get
				{
					return receivedSample;
				}
				set	
				{
					receivedSample = value;
				}
			}

			public class DescribeAppGroupDataReport_ReceivedSampleItem
			{

				private long? receivedTimeMs;

				private DescribeAppGroupDataReport_Message message;

				public long? ReceivedTimeMs
				{
					get
					{
						return receivedTimeMs;
					}
					set	
					{
						receivedTimeMs = value;
					}
				}

				public DescribeAppGroupDataReport_Message Message
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

				public class DescribeAppGroupDataReport_Message
				{

					private string clientIp;

					private string arg3;

					private string userId;

					private string args;

					private string arg1;

					private string sdkType;

					private string sessionId;

					private int? eventId;

					private string sdkVersion;

					private string page;

					public string ClientIp
					{
						get
						{
							return clientIp;
						}
						set	
						{
							clientIp = value;
						}
					}

					public string Arg3
					{
						get
						{
							return arg3;
						}
						set	
						{
							arg3 = value;
						}
					}

					public string UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}

					public string Args
					{
						get
						{
							return args;
						}
						set	
						{
							args = value;
						}
					}

					public string Arg1
					{
						get
						{
							return arg1;
						}
						set	
						{
							arg1 = value;
						}
					}

					public string SdkType
					{
						get
						{
							return sdkType;
						}
						set	
						{
							sdkType = value;
						}
					}

					public string SessionId
					{
						get
						{
							return sessionId;
						}
						set	
						{
							sessionId = value;
						}
					}

					public int? EventId
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

					public string SdkVersion
					{
						get
						{
							return sdkVersion;
						}
						set	
						{
							sdkVersion = value;
						}
					}

					public string Page
					{
						get
						{
							return page;
						}
						set	
						{
							page = value;
						}
					}
				}
			}
		}
	}
}
