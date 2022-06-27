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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class PublicSyncAndCreateImageScanTaskResponse : AcsResponse
	{

		private string requestId;

		private PublicSyncAndCreateImageScanTask_Data data;

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

		public PublicSyncAndCreateImageScanTask_Data Data
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

		public class PublicSyncAndCreateImageScanTask_Data
		{

			private string taskId;

			private int? totalCount;

			private int? finishCount;

			private long? collectTime;

			private long? execTime;

			private string status;

			private int? progress;

			private string result;

			private bool? canCreate;

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public int? TotalCount
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

			public int? FinishCount
			{
				get
				{
					return finishCount;
				}
				set	
				{
					finishCount = value;
				}
			}

			public long? CollectTime
			{
				get
				{
					return collectTime;
				}
				set	
				{
					collectTime = value;
				}
			}

			public long? ExecTime
			{
				get
				{
					return execTime;
				}
				set	
				{
					execTime = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string Result
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

			public bool? CanCreate
			{
				get
				{
					return canCreate;
				}
				set	
				{
					canCreate = value;
				}
			}
		}
	}
}
