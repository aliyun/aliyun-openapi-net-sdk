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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class GetDetectEvaluationResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<GetDetectEvaluation_DataItem> data;

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

		public List<GetDetectEvaluation_DataItem> Data
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

		public class GetDetectEvaluation_DataItem
		{

			private string day;

			private List<GetDetectEvaluation_EvaluationItemListItem> evaluationItemList;

			public string Day
			{
				get
				{
					return day;
				}
				set	
				{
					day = value;
				}
			}

			public List<GetDetectEvaluation_EvaluationItemListItem> EvaluationItemList
			{
				get
				{
					return evaluationItemList;
				}
				set	
				{
					evaluationItemList = value;
				}
			}

			public class GetDetectEvaluation_EvaluationItemListItem
			{

				private string name;

				private int? handleCount;

				private int? successCount;

				private string successRate;

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

				public int? HandleCount
				{
					get
					{
						return handleCount;
					}
					set	
					{
						handleCount = value;
					}
				}

				public int? SuccessCount
				{
					get
					{
						return successCount;
					}
					set	
					{
						successCount = value;
					}
				}

				public string SuccessRate
				{
					get
					{
						return successRate;
					}
					set	
					{
						successRate = value;
					}
				}
			}
		}
	}
}
