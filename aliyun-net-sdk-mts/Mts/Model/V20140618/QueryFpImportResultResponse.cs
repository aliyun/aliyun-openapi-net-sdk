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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryFpImportResultResponse : AcsResponse
	{

		private string requestId;

		private long? logCount;

		private List<QueryFpImportResult_FpResultLogInfo> fpResultLogInfoList;

		private QueryFpImportResult_PageInfo pageInfo;

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

		public long? LogCount
		{
			get
			{
				return logCount;
			}
			set	
			{
				logCount = value;
			}
		}

		public List<QueryFpImportResult_FpResultLogInfo> FpResultLogInfoList
		{
			get
			{
				return fpResultLogInfoList;
			}
			set	
			{
				fpResultLogInfoList = value;
			}
		}

		public QueryFpImportResult_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class QueryFpImportResult_FpResultLogInfo
		{

			private string logPath;

			private string logName;

			private long? logStartTime;

			private long? logEndTime;

			private long? logSize;

			private long? createTime;

			public string LogPath
			{
				get
				{
					return logPath;
				}
				set	
				{
					logPath = value;
				}
			}

			public string LogName
			{
				get
				{
					return logName;
				}
				set	
				{
					logName = value;
				}
			}

			public long? LogStartTime
			{
				get
				{
					return logStartTime;
				}
				set	
				{
					logStartTime = value;
				}
			}

			public long? LogEndTime
			{
				get
				{
					return logEndTime;
				}
				set	
				{
					logEndTime = value;
				}
			}

			public long? LogSize
			{
				get
				{
					return logSize;
				}
				set	
				{
					logSize = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}
		}

		public class QueryFpImportResult_PageInfo
		{

			private long? pageIndex;

			private long? pageSize;

			private long? total;

			public long? PageIndex
			{
				get
				{
					return pageIndex;
				}
				set	
				{
					pageIndex = value;
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
		}
	}
}
