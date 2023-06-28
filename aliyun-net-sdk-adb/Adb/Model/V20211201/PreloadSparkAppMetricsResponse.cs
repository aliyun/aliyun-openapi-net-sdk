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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class PreloadSparkAppMetricsResponse : AcsResponse
	{

		private string requestId;

		private PreloadSparkAppMetrics_Data data;

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

		public PreloadSparkAppMetrics_Data Data
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

		public class PreloadSparkAppMetrics_Data
		{

			private string appId;

			private string attemptId;

			private bool? finished;

			private string eventLogPath;

			private PreloadSparkAppMetrics_ScanMetrics scanMetrics;

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

			public string AttemptId
			{
				get
				{
					return attemptId;
				}
				set	
				{
					attemptId = value;
				}
			}

			public bool? Finished
			{
				get
				{
					return finished;
				}
				set	
				{
					finished = value;
				}
			}

			public string EventLogPath
			{
				get
				{
					return eventLogPath;
				}
				set	
				{
					eventLogPath = value;
				}
			}

			public PreloadSparkAppMetrics_ScanMetrics ScanMetrics
			{
				get
				{
					return scanMetrics;
				}
				set	
				{
					scanMetrics = value;
				}
			}

			public class PreloadSparkAppMetrics_ScanMetrics
			{

				private long? outputRowsCount;

				private long? totalReadFileSizeInByte;

				public long? OutputRowsCount
				{
					get
					{
						return outputRowsCount;
					}
					set	
					{
						outputRowsCount = value;
					}
				}

				public long? TotalReadFileSizeInByte
				{
					get
					{
						return totalReadFileSizeInByte;
					}
					set	
					{
						totalReadFileSizeInByte = value;
					}
				}
			}
		}
	}
}
