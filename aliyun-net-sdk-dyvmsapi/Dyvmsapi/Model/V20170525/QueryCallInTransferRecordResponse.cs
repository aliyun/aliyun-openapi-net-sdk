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

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
	public class QueryCallInTransferRecordResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private QueryCallInTransferRecord_Data data;

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

		public QueryCallInTransferRecord_Data Data
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

		public class QueryCallInTransferRecord_Data
		{

			private long? total;

			private long? pageNo;

			private long? pageSize;

			private List<QueryCallInTransferRecord_ValuesItem> values;

			public long? Total
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

			public long? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
				}
			}

			public long? PageSize
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

			public List<QueryCallInTransferRecord_ValuesItem> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public class QueryCallInTransferRecord_ValuesItem
			{

				private string callInCaller;

				private string callInCalled;

				private string transferCaller;

				private string transferCalled;

				private string recordUrl;

				private long? gmtCreate;

				public string CallInCaller
				{
					get
					{
						return callInCaller;
					}
					set	
					{
						callInCaller = value;
					}
				}

				public string CallInCalled
				{
					get
					{
						return callInCalled;
					}
					set	
					{
						callInCalled = value;
					}
				}

				public string TransferCaller
				{
					get
					{
						return transferCaller;
					}
					set	
					{
						transferCaller = value;
					}
				}

				public string TransferCalled
				{
					get
					{
						return transferCalled;
					}
					set	
					{
						transferCalled = value;
					}
				}

				public string RecordUrl
				{
					get
					{
						return recordUrl;
					}
					set	
					{
						recordUrl = value;
					}
				}

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}
			}
		}
	}
}
