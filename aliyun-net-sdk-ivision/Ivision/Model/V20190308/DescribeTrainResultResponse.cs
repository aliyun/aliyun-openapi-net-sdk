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
	public class DescribeTrainResultResponse : AcsResponse
	{

		private string requestId;

		private DescribeTrainResult_TrainResult trainResult;

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

		public DescribeTrainResult_TrainResult TrainResult
		{
			get
			{
				return trainResult;
			}
			set	
			{
				trainResult = value;
			}
		}

		public class DescribeTrainResult_TrainResult
		{

			private string projectId;

			private string iterationId;

			private string iterationName;

			private string precision;

			private string recall;

			private string mAP;

			private string threshold;

			private string status;

			private string startTime;

			private string endTime;

			private string errorCode;

			private string errorMessage;

			private List<DescribeTrainResult_TagResult> tagResults;

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

			public string Threshold
			{
				get
				{
					return threshold;
				}
				set	
				{
					threshold = value;
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

			public string StartTime
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

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
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

			public List<DescribeTrainResult_TagResult> TagResults
			{
				get
				{
					return tagResults;
				}
				set	
				{
					tagResults = value;
				}
			}

			public class DescribeTrainResult_TagResult
			{

				private string tagId;

				private string tagName;

				private string precision;

				private string recall;

				private string aP;

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

				public string AP
				{
					get
					{
						return aP;
					}
					set	
					{
						aP = value;
					}
				}
			}
		}
	}
}
