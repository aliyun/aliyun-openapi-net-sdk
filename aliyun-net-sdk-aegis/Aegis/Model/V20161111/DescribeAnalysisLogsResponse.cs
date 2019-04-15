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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeAnalysisLogsResponse : AcsResponse
	{

		private string requestId;

		private DescribeAnalysisLogs_Logs logs;

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

		public DescribeAnalysisLogs_Logs Logs
		{
			get
			{
				return logs;
			}
			set	
			{
				logs = value;
			}
		}

		public class DescribeAnalysisLogs_Logs
		{

			private int? processedRow;

			private string whereQuery;

			private string aggQuery;

			private int? mLimited;

			private string terms;

			private string keys;

			private int? count;

			private int? elapsedMilliSecond;

			private string logs;

			private string mMarker;

			public int? ProcessedRow
			{
				get
				{
					return processedRow;
				}
				set	
				{
					processedRow = value;
				}
			}

			public string WhereQuery
			{
				get
				{
					return whereQuery;
				}
				set	
				{
					whereQuery = value;
				}
			}

			public string AggQuery
			{
				get
				{
					return aggQuery;
				}
				set	
				{
					aggQuery = value;
				}
			}

			public int? MLimited
			{
				get
				{
					return mLimited;
				}
				set	
				{
					mLimited = value;
				}
			}

			public string Terms
			{
				get
				{
					return terms;
				}
				set	
				{
					terms = value;
				}
			}

			public string Keys
			{
				get
				{
					return keys;
				}
				set	
				{
					keys = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public int? ElapsedMilliSecond
			{
				get
				{
					return elapsedMilliSecond;
				}
				set	
				{
					elapsedMilliSecond = value;
				}
			}

			public string Logs
			{
				get
				{
					return logs;
				}
				set	
				{
					logs = value;
				}
			}

			public string MMarker
			{
				get
				{
					return mMarker;
				}
				set	
				{
					mMarker = value;
				}
			}
		}
	}
}
