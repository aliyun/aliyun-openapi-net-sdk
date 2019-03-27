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
	public class DescribeStreamPredictResultResponse : AcsResponse
	{

		private string requestId;

		private long? totalNum;

		private long? currentPage;

		private long? pageSize;

		private string nextPageToken;

		private List<DescribeStreamPredictResult_StreamPredictData> streamPredictDatas;

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

			private string predictId;

			private string modelId;

			private string dataUrl;

			private string streamTimestamp;

			private string predictTime;

			private string status;

			private List<DescribeStreamPredictResult_ResultStatisticsItem> resultStatistics;

			private List<DescribeStreamPredictResult_PredictionResult> predictionResults;

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

			public string StreamTimestamp
			{
				get
				{
					return streamTimestamp;
				}
				set	
				{
					streamTimestamp = value;
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

			public List<DescribeStreamPredictResult_ResultStatisticsItem> ResultStatistics
			{
				get
				{
					return resultStatistics;
				}
				set	
				{
					resultStatistics = value;
				}
			}

			public List<DescribeStreamPredictResult_PredictionResult> PredictionResults
			{
				get
				{
					return predictionResults;
				}
				set	
				{
					predictionResults = value;
				}
			}

			public class DescribeStreamPredictResult_ResultStatisticsItem
			{

				private string tagId;

				private string tagName;

				private long? count;

				public string TagId
				{
					get
					{
						return tagId;
					}
					set	
					{
						tagId = value;
					}
				}

				public string TagName
				{
					get
					{
						return tagName;
					}
					set	
					{
						tagName = value;
					}
				}

				public long? Count
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
			}

			public class DescribeStreamPredictResult_PredictionResult
			{

				private string tagId;

				private string tagName;

				private string probability;

				private string overlap;

				private string regionType;

				private DescribeStreamPredictResult_Region region;

				private DescribeStreamPredictResult_Properties properties;

				public string TagId
				{
					get
					{
						return tagId;
					}
					set	
					{
						tagId = value;
					}
				}

				public string TagName
				{
					get
					{
						return tagName;
					}
					set	
					{
						tagName = value;
					}
				}

				public string Probability
				{
					get
					{
						return probability;
					}
					set	
					{
						probability = value;
					}
				}

				public string Overlap
				{
					get
					{
						return overlap;
					}
					set	
					{
						overlap = value;
					}
				}

				public string RegionType
				{
					get
					{
						return regionType;
					}
					set	
					{
						regionType = value;
					}
				}

				public DescribeStreamPredictResult_Region Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public DescribeStreamPredictResult_Properties Properties
				{
					get
					{
						return properties;
					}
					set	
					{
						properties = value;
					}
				}

				public class DescribeStreamPredictResult_Region
				{

					private string left;

					private string top;

					private string width;

					private string height;

					public string Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public string Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public string Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public string Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}

				public class DescribeStreamPredictResult_Properties
				{

					private string withGloves;

					private string withGlovesProbability;

					public string WithGloves
					{
						get
						{
							return withGloves;
						}
						set	
						{
							withGloves = value;
						}
					}

					public string WithGlovesProbability
					{
						get
						{
							return withGlovesProbability;
						}
						set	
						{
							withGlovesProbability = value;
						}
					}
				}
			}
		}
	}
}
