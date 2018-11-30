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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListAIVideoSummaryJobResponse : AcsResponse
	{

		private string requestId;

		private List<ListAIVideoSummaryJob_AIVideoSummaryJob> aIVideoSummaryJobList;

		private List<string> nonExistAIVideoSummaryJobIds;

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

		public List<ListAIVideoSummaryJob_AIVideoSummaryJob> AIVideoSummaryJobList
		{
			get
			{
				return aIVideoSummaryJobList;
			}
			set	
			{
				aIVideoSummaryJobList = value;
			}
		}

		public List<string> NonExistAIVideoSummaryJobIds
		{
			get
			{
				return nonExistAIVideoSummaryJobIds;
			}
			set	
			{
				nonExistAIVideoSummaryJobIds = value;
			}
		}

		public class ListAIVideoSummaryJob_AIVideoSummaryJob
		{

			private string jobId;

			private string mediaId;

			private string status;

			private string code;

			private string message;

			private string creationTime;

			private string data;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Data
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
		}
	}
}