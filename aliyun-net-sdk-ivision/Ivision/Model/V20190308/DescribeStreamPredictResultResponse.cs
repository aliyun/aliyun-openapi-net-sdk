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
	public class DescribeStreamPredictResultResponse : AcsResponse
	{

		private long? totalNum;

		private long? pageSize;

		private string requestId;

		private long? currentPage;

		private string nextPageToken;

		private List<DescribeStreamPredictResult_StreamPredictData> streamPredictDatas;

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

		public List<DescribeStreamPredictResult_StreamPredictData> StreamPredictDatas
		{
			get
			{
				return streamPredictDatas;
			}
			set	
			{
				streamPredictDatas = value;
			}
		}

		public class DescribeStreamPredictResult_StreamPredictData
		{

			private string status;

			private string predictResult;

			private string predictId;

			private string predictTime;

			private string dataUrl;

			private long? timestamp;

			private string modelId;

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

			public string PredictResult
			{
				get
				{
					return predictResult;
				}
				set	
				{
					predictResult = value;
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

			public string PredictTime
			{
				get
				{
					return predictTime;
				}
				set	
				{
					predictTime = value;
				}
			}

			public string DataUrl
			{
				get
				{
					return dataUrl;
				}
				set	
				{
					dataUrl = value;
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
		}
	}
}
