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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class DescribeIterationsResponse : AcsResponse
	{

		private string requestId;

		private long? totalNum;

		private long? currentPage;

		private long? pageSize;

		private string nextPageToken;

		private List<DescribeIterations_Iteration> iterations;

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

		public long? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public long? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		public List<DescribeIterations_Iteration> Iterations
		{
			get
			{
				return iterations;
			}
			set	
			{
				iterations = value;
			}
		}

		public class DescribeIterations_Iteration
		{

			private string projectId;

			private string iterationId;

			private string iterationName;

			private string status;

			private string creationTime;

			private string finishTime;

			private string modelId;

			private string precision;

			private string recall;

			private string mAP;

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public string IterationId
			{
				get
				{
					return iterationId;
				}
				set	
				{
					iterationId = value;
				}
			}

			public string IterationName
			{
				get
				{
					return iterationName;
				}
				set	
				{
					iterationName = value;
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

			public string FinishTime
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

			public string ModelId
			{
				get
				{
					return modelId;
				}
				set	
				{
					modelId = value;
				}
			}

			public string Precision
			{
				get
				{
					return precision;
				}
				set	
				{
					precision = value;
				}
			}

			public string Recall
			{
				get
				{
					return recall;
				}
				set	
				{
					recall = value;
				}
			}

			public string MAP
			{
				get
				{
					return mAP;
				}
				set	
				{
					mAP = value;
				}
			}
		}
	}
}
