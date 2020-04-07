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

namespace Aliyun.Acs.ARMS.Model.V20190808
{
	public class GetTraceResponse : AcsResponse
	{

		private string requestId;

		private List<GetTrace_Span> spans;

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

		public List<GetTrace_Span> Spans
		{
			get
			{
				return spans;
			}
			set	
			{
				spans = value;
			}
		}

		public class GetTrace_Span
		{

			private string traceID;

			private string operationName;

			private long? duration;

			private string serviceName;

			private string serviceIp;

			private long? timestamp;

			private string rpcId;

			private string resultCode;

			private bool? haveStack;

			private List<GetTrace_TagEntry> tagEntryList;

			private List<GetTrace_LogEvent> logEventList;

			public string TraceID
			{
				get
				{
					return traceID;
				}
				set	
				{
					traceID = value;
				}
			}

			public string OperationName
			{
				get
				{
					return operationName;
				}
				set	
				{
					operationName = value;
				}
			}

			public long? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ServiceIp
			{
				get
				{
					return serviceIp;
				}
				set	
				{
					serviceIp = value;
				}
			}

			public long? Timestamp
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

			public string RpcId
			{
				get
				{
					return rpcId;
				}
				set	
				{
					rpcId = value;
				}
			}

			public string ResultCode
			{
				get
				{
					return resultCode;
				}
				set	
				{
					resultCode = value;
				}
			}

			public bool? HaveStack
			{
				get
				{
					return haveStack;
				}
				set	
				{
					haveStack = value;
				}
			}

			public List<GetTrace_TagEntry> TagEntryList
			{
				get
				{
					return tagEntryList;
				}
				set	
				{
					tagEntryList = value;
				}
			}

			public List<GetTrace_LogEvent> LogEventList
			{
				get
				{
					return logEventList;
				}
				set	
				{
					logEventList = value;
				}
			}

			public class GetTrace_TagEntry
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class GetTrace_LogEvent
			{

				private long? timestamp;

				private List<GetTrace_TagEntry2> tagEntryList1;

				public long? Timestamp
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

				public List<GetTrace_TagEntry2> TagEntryList1
				{
					get
					{
						return tagEntryList1;
					}
					set	
					{
						tagEntryList1 = value;
					}
				}

				public class GetTrace_TagEntry2
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
