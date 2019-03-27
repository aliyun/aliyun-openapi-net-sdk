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
	public class DescribePredictDatasResponse : AcsResponse
	{

		private string requestId;

		private long? totalNum;

		private long? currentPage;

		private long? pageSize;

		private string nextPageToken;

		private List<DescribePredictDatas_PredictData> predictDatas;

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

		public List<DescribePredictDatas_PredictData> PredictDatas
		{
			get
			{
				return predictDatas;
			}
			set	
			{
				predictDatas = value;
			}
		}

		public class DescribePredictDatas_PredictData
		{

			private string projectId;

			private string iterationId;

			private string dataId;

			private string dataName;

			private string dataUrl;

			private string creationTime;

			private string status;

			private string errorCode;

			private string errorMessage;

			private List<DescribePredictDatas_PredictionResult> predictionResults;

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

			public string DataId
			{
				get
				{
					return dataId;
				}
				set	
				{
					dataId = value;
				}
			}

			public string DataName
			{
				get
				{
					return dataName;
				}
				set	
				{
					dataName = value;
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

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public List<DescribePredictDatas_PredictionResult> PredictionResults
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

			public class DescribePredictDatas_PredictionResult
			{

				private string tagId;

				private string tagName;

				private string probability;

				private string overlap;

				private string regionType;

				private string properties;

				private DescribePredictDatas_Region region;

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

				public string Properties
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

				public DescribePredictDatas_Region Region
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

				public class DescribePredictDatas_Region
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
			}
		}
	}
}
