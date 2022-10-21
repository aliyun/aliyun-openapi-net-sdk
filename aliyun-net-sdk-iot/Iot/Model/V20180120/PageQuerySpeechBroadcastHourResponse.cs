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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class PageQuerySpeechBroadcastHourResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private PageQuerySpeechBroadcastHour_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public PageQuerySpeechBroadcastHour_Data Data
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

		public class PageQuerySpeechBroadcastHour_Data
		{

			private int? pageId;

			private int? pageSize;

			private int? total;

			private string pageToken;

			private List<PageQuerySpeechBroadcastHour_Data1> resultData;

			public int? PageId
			{
				get
				{
					return pageId;
				}
				set	
				{
					pageId = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public string PageToken
			{
				get
				{
					return pageToken;
				}
				set	
				{
					pageToken = value;
				}
			}

			public List<PageQuerySpeechBroadcastHour_Data1> ResultData
			{
				get
				{
					return resultData;
				}
				set	
				{
					resultData = value;
				}
			}

			public class PageQuerySpeechBroadcastHour_Data1
			{

				private string productKey;

				private string deviceName;

				private string shareTaskCode;

				private string speechs;

				private int? code;

				private string msg;

				private string speechId;

				private long? startTime;

				public string ProductKey
				{
					get
					{
						return productKey;
					}
					set	
					{
						productKey = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public string ShareTaskCode
				{
					get
					{
						return shareTaskCode;
					}
					set	
					{
						shareTaskCode = value;
					}
				}

				public string Speechs
				{
					get
					{
						return speechs;
					}
					set	
					{
						speechs = value;
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

				public string Msg
				{
					get
					{
						return msg;
					}
					set	
					{
						msg = value;
					}
				}

				public string SpeechId
				{
					get
					{
						return speechId;
					}
					set	
					{
						speechId = value;
					}
				}

				public long? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}
			}
		}
	}
}
