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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class GetJobOutputStatisticInfoResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private int? pageNumber;

		private int? pageSize;

		private List<GetJobOutputStatisticInfo_ClusterStatJobOutput> jobOutputList;

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

		public List<GetJobOutputStatisticInfo_ClusterStatJobOutput> JobOutputList
		{
			get
			{
				return jobOutputList;
			}
			set	
			{
				jobOutputList = value;
			}
		}

		public class GetJobOutputStatisticInfo_ClusterStatJobOutput
		{

			private string applicationId;

			private string jobId;

			private long? startTime;

			private long? finishTime;

			private string name;

			private string queue;

			private string user;

			private string state;

			private long? bytesOutput;

			public string ApplicationId
			{
				get
				{
					return applicationId;
				}
				set	
				{
					applicationId = value;
				}
			}

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

			public long? FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public long? BytesOutput
			{
				get
				{
					return bytesOutput;
				}
				set	
				{
					bytesOutput = value;
				}
			}
		}
	}
}
