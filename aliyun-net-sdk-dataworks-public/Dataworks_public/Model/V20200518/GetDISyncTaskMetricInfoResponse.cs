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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetDISyncTaskMetricInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetDISyncTaskMetricInfo_MetricInfo metricInfo;

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

		public GetDISyncTaskMetricInfo_MetricInfo MetricInfo
		{
			get
			{
				return metricInfo;
			}
			set	
			{
				metricInfo = value;
			}
		}

		public class GetDISyncTaskMetricInfo_MetricInfo
		{

			private string message;

			private long? sumReaderRecords;

			private long? sumWriterRecords;

			private long? lastTaskDelay;

			private long? insertReaderRecords;

			private long? updateReaderRecords;

			private long? deleteReaderRecords;

			private long? insertWriterRecords;

			private long? updateWriterRecords;

			private long? deleteWriterRecords;

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

			public long? SumReaderRecords
			{
				get
				{
					return sumReaderRecords;
				}
				set	
				{
					sumReaderRecords = value;
				}
			}

			public long? SumWriterRecords
			{
				get
				{
					return sumWriterRecords;
				}
				set	
				{
					sumWriterRecords = value;
				}
			}

			public long? LastTaskDelay
			{
				get
				{
					return lastTaskDelay;
				}
				set	
				{
					lastTaskDelay = value;
				}
			}

			public long? InsertReaderRecords
			{
				get
				{
					return insertReaderRecords;
				}
				set	
				{
					insertReaderRecords = value;
				}
			}

			public long? UpdateReaderRecords
			{
				get
				{
					return updateReaderRecords;
				}
				set	
				{
					updateReaderRecords = value;
				}
			}

			public long? DeleteReaderRecords
			{
				get
				{
					return deleteReaderRecords;
				}
				set	
				{
					deleteReaderRecords = value;
				}
			}

			public long? InsertWriterRecords
			{
				get
				{
					return insertWriterRecords;
				}
				set	
				{
					insertWriterRecords = value;
				}
			}

			public long? UpdateWriterRecords
			{
				get
				{
					return updateWriterRecords;
				}
				set	
				{
					updateWriterRecords = value;
				}
			}

			public long? DeleteWriterRecords
			{
				get
				{
					return deleteWriterRecords;
				}
				set	
				{
					deleteWriterRecords = value;
				}
			}
		}
	}
}
