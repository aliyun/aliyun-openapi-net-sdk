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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class QueryPerformanceIndicatorsResponse : AcsResponse
	{

		private string requestId;

		private QueryPerformanceIndicators_ResolutionRate resolutionRate;

		private QueryPerformanceIndicators_ValidAnswerRate validAnswerRate;

		private QueryPerformanceIndicators_DialoguePassRate dialoguePassRate;

		private QueryPerformanceIndicators_KnowledgeHitRate knowledgeHitRate;

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

		public QueryPerformanceIndicators_ResolutionRate ResolutionRate
		{
			get
			{
				return resolutionRate;
			}
			set	
			{
				resolutionRate = value;
			}
		}

		public QueryPerformanceIndicators_ValidAnswerRate ValidAnswerRate
		{
			get
			{
				return validAnswerRate;
			}
			set	
			{
				validAnswerRate = value;
			}
		}

		public QueryPerformanceIndicators_DialoguePassRate DialoguePassRate
		{
			get
			{
				return dialoguePassRate;
			}
			set	
			{
				dialoguePassRate = value;
			}
		}

		public QueryPerformanceIndicators_KnowledgeHitRate KnowledgeHitRate
		{
			get
			{
				return knowledgeHitRate;
			}
			set	
			{
				knowledgeHitRate = value;
			}
		}

		public class QueryPerformanceIndicators_ResolutionRate
		{

			private float? totalRateValue;

			private List<QueryPerformanceIndicators_ValuePerDateUnit> valuePerDateUnits;

			public float? TotalRateValue
			{
				get
				{
					return totalRateValue;
				}
				set	
				{
					totalRateValue = value;
				}
			}

			public List<QueryPerformanceIndicators_ValuePerDateUnit> ValuePerDateUnits
			{
				get
				{
					return valuePerDateUnits;
				}
				set	
				{
					valuePerDateUnits = value;
				}
			}

			public class QueryPerformanceIndicators_ValuePerDateUnit
			{

				private long? date;

				private float? rateValue;

				public long? Date
				{
					get
					{
						return date;
					}
					set	
					{
						date = value;
					}
				}

				public float? RateValue
				{
					get
					{
						return rateValue;
					}
					set	
					{
						rateValue = value;
					}
				}
			}
		}

		public class QueryPerformanceIndicators_ValidAnswerRate
		{

			private float? totalRateValue;

			private List<QueryPerformanceIndicators_ValuePerDateUnit2> valuePerDateUnits1;

			public float? TotalRateValue
			{
				get
				{
					return totalRateValue;
				}
				set	
				{
					totalRateValue = value;
				}
			}

			public List<QueryPerformanceIndicators_ValuePerDateUnit2> ValuePerDateUnits1
			{
				get
				{
					return valuePerDateUnits1;
				}
				set	
				{
					valuePerDateUnits1 = value;
				}
			}

			public class QueryPerformanceIndicators_ValuePerDateUnit2
			{

				private long? date;

				private float? rateValue;

				public long? Date
				{
					get
					{
						return date;
					}
					set	
					{
						date = value;
					}
				}

				public float? RateValue
				{
					get
					{
						return rateValue;
					}
					set	
					{
						rateValue = value;
					}
				}
			}
		}

		public class QueryPerformanceIndicators_DialoguePassRate
		{

			private float? totalRateValue;

			private List<QueryPerformanceIndicators_ValuePerDateUnit4> valuePerDateUnits3;

			public float? TotalRateValue
			{
				get
				{
					return totalRateValue;
				}
				set	
				{
					totalRateValue = value;
				}
			}

			public List<QueryPerformanceIndicators_ValuePerDateUnit4> ValuePerDateUnits3
			{
				get
				{
					return valuePerDateUnits3;
				}
				set	
				{
					valuePerDateUnits3 = value;
				}
			}

			public class QueryPerformanceIndicators_ValuePerDateUnit4
			{

				private long? date;

				private float? rateValue;

				public long? Date
				{
					get
					{
						return date;
					}
					set	
					{
						date = value;
					}
				}

				public float? RateValue
				{
					get
					{
						return rateValue;
					}
					set	
					{
						rateValue = value;
					}
				}
			}
		}

		public class QueryPerformanceIndicators_KnowledgeHitRate
		{

			private float? totalRateValue;

			private List<QueryPerformanceIndicators_ValuePerDateUnit6> valuePerDateUnits5;

			public float? TotalRateValue
			{
				get
				{
					return totalRateValue;
				}
				set	
				{
					totalRateValue = value;
				}
			}

			public List<QueryPerformanceIndicators_ValuePerDateUnit6> ValuePerDateUnits5
			{
				get
				{
					return valuePerDateUnits5;
				}
				set	
				{
					valuePerDateUnits5 = value;
				}
			}

			public class QueryPerformanceIndicators_ValuePerDateUnit6
			{

				private long? date;

				private float? rateValue;

				public long? Date
				{
					get
					{
						return date;
					}
					set	
					{
						date = value;
					}
				}

				public float? RateValue
				{
					get
					{
						return rateValue;
					}
					set	
					{
						rateValue = value;
					}
				}
			}
		}
	}
}
