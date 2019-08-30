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

namespace Aliyun.Acs.xtrace.Model.V20190808
{
	public class SearchTracesResponse : AcsResponse
	{

		private string requestId;

		private SearchTraces_PageBean pageBean;

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

		public SearchTraces_PageBean PageBean
		{
			get
			{
				return pageBean;
			}
			set	
			{
				pageBean = value;
			}
		}

		public class SearchTraces_PageBean
		{

			private long? totalCount;

			private int? pageSize;

			private int? pageNumber;

			private List<SearchTraces_TraceInfo> traceInfos;

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public List<SearchTraces_TraceInfo> TraceInfos
			{
				get
				{
					return traceInfos;
				}
				set	
				{
					traceInfos = value;
				}
			}

			public class SearchTraces_TraceInfo
			{

				private string traceID;

				private string operationName;

				private string serviceName;

				private string serviceIp;

				private long? duration;

				private long? timestamp;

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
			}
		}
	}
}
