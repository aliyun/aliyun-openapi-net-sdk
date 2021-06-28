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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class DescribeStreamPredictsResponse : AcsResponse
	{

		private long? totalNum;

		private long? pageSize;

		private string requestId;

		private long? currentPage;

		private string nextPageToken;

		private List<DescribeStreamPredicts_StreamPredict> streamPredicts;

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

		public List<DescribeStreamPredicts_StreamPredict> StreamPredicts
		{
			get
			{
				return streamPredicts;
			}
			set	
			{
				streamPredicts = value;
			}
		}

		public class DescribeStreamPredicts_StreamPredict
		{

			private string creationTime;

			private string status;

			private string notify;

			private string predictId;

			private string modelUserData;

			private string output;

			private string predictTemplateId;

			private string streamId;

			private string autoStart;

			private string probabilityThresholds;

			private string detectIntervals;

			private string streamType;

			private string userData;

			private string modelIds;

			private string faceGroupId;

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

			public string Notify
			{
				get
				{
					return notify;
				}
				set	
				{
					notify = value;
				}
			}

			public string PredictId
			{
				get
				{
					return predictId;
				}
				set	
				{
					predictId = value;
				}
			}

			public string ModelUserData
			{
				get
				{
					return modelUserData;
				}
				set	
				{
					modelUserData = value;
				}
			}

			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			public string PredictTemplateId
			{
				get
				{
					return predictTemplateId;
				}
				set	
				{
					predictTemplateId = value;
				}
			}

			public string StreamId
			{
				get
				{
					return streamId;
				}
				set	
				{
					streamId = value;
				}
			}

			public string AutoStart
			{
				get
				{
					return autoStart;
				}
				set	
				{
					autoStart = value;
				}
			}

			public string ProbabilityThresholds
			{
				get
				{
					return probabilityThresholds;
				}
				set	
				{
					probabilityThresholds = value;
				}
			}

			public string DetectIntervals
			{
				get
				{
					return detectIntervals;
				}
				set	
				{
					detectIntervals = value;
				}
			}

			public string StreamType
			{
				get
				{
					return streamType;
				}
				set	
				{
					streamType = value;
				}
			}

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string ModelIds
			{
				get
				{
					return modelIds;
				}
				set	
				{
					modelIds = value;
				}
			}

			public string FaceGroupId
			{
				get
				{
					return faceGroupId;
				}
				set	
				{
					faceGroupId = value;
				}
			}
		}
	}
}
