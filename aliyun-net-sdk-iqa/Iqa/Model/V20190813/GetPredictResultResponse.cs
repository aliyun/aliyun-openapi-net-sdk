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

namespace Aliyun.Acs.iqa.Model.V20190813
{
	public class GetPredictResultResponse : AcsResponse
	{

		private string requestId;

		private string projectId;

		private string question;

		private int? topK;

		private string traceTag;

		private long? costTime;

		private string trace;

		private List<GetPredictResult_PredictResult> predictResults;

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

		public string Question
		{
			get
			{
				return question;
			}
			set	
			{
				question = value;
			}
		}

		public int? TopK
		{
			get
			{
				return topK;
			}
			set	
			{
				topK = value;
			}
		}

		public string TraceTag
		{
			get
			{
				return traceTag;
			}
			set	
			{
				traceTag = value;
			}
		}

		public long? CostTime
		{
			get
			{
				return costTime;
			}
			set	
			{
				costTime = value;
			}
		}

		public string Trace
		{
			get
			{
				return trace;
			}
			set	
			{
				trace = value;
			}
		}

		public List<GetPredictResult_PredictResult> PredictResults
		{
			get
			{
				return predictResults;
			}
			set	
			{
				predictResults = value;
			}
		}

		public class GetPredictResult_PredictResult
		{

			private int? rank;

			private string questionId;

			private string question;

			private float? score;

			private string answer;

			public int? Rank
			{
				get
				{
					return rank;
				}
				set	
				{
					rank = value;
				}
			}

			public string QuestionId
			{
				get
				{
					return questionId;
				}
				set	
				{
					questionId = value;
				}
			}

			public string Question
			{
				get
				{
					return question;
				}
				set	
				{
					question = value;
				}
			}

			public float? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string Answer
			{
				get
				{
					return answer;
				}
				set	
				{
					answer = value;
				}
			}
		}
	}
}
