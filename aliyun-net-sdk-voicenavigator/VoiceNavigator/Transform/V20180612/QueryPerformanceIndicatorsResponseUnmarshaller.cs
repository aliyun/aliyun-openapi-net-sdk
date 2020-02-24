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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class QueryPerformanceIndicatorsResponseUnmarshaller
    {
        public static QueryPerformanceIndicatorsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPerformanceIndicatorsResponse queryPerformanceIndicatorsResponse = new QueryPerformanceIndicatorsResponse();

			queryPerformanceIndicatorsResponse.HttpResponse = context.HttpResponse;
			queryPerformanceIndicatorsResponse.RequestId = context.StringValue("QueryPerformanceIndicators.RequestId");

			QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ResolutionRate resolutionRate = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ResolutionRate();
			resolutionRate.TotalRateValue = context.FloatValue("QueryPerformanceIndicators.ResolutionRate.TotalRateValue");

			List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ResolutionRate.QueryPerformanceIndicators_ValuePerDateUnit> resolutionRate_valuePerDateUnits = new List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ResolutionRate.QueryPerformanceIndicators_ValuePerDateUnit>();
			for (int i = 0; i < context.Length("QueryPerformanceIndicators.ResolutionRate.ValuePerDateUnits.Length"); i++) {
				QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ResolutionRate.QueryPerformanceIndicators_ValuePerDateUnit valuePerDateUnit = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ResolutionRate.QueryPerformanceIndicators_ValuePerDateUnit();
				valuePerDateUnit.Date = context.LongValue("QueryPerformanceIndicators.ResolutionRate.ValuePerDateUnits["+ i +"].Date");
				valuePerDateUnit.RateValue = context.FloatValue("QueryPerformanceIndicators.ResolutionRate.ValuePerDateUnits["+ i +"].RateValue");

				resolutionRate_valuePerDateUnits.Add(valuePerDateUnit);
			}
			resolutionRate.ValuePerDateUnits = resolutionRate_valuePerDateUnits;
			queryPerformanceIndicatorsResponse.ResolutionRate = resolutionRate;

			QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ValidAnswerRate validAnswerRate = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ValidAnswerRate();
			validAnswerRate.TotalRateValue = context.FloatValue("QueryPerformanceIndicators.ValidAnswerRate.TotalRateValue");

			List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ValidAnswerRate.QueryPerformanceIndicators_ValuePerDateUnit2> validAnswerRate_valuePerDateUnits1 = new List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ValidAnswerRate.QueryPerformanceIndicators_ValuePerDateUnit2>();
			for (int i = 0; i < context.Length("QueryPerformanceIndicators.ValidAnswerRate.ValuePerDateUnits.Length"); i++) {
				QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ValidAnswerRate.QueryPerformanceIndicators_ValuePerDateUnit2 valuePerDateUnit2 = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_ValidAnswerRate.QueryPerformanceIndicators_ValuePerDateUnit2();
				valuePerDateUnit2.Date = context.LongValue("QueryPerformanceIndicators.ValidAnswerRate.ValuePerDateUnits["+ i +"].Date");
				valuePerDateUnit2.RateValue = context.FloatValue("QueryPerformanceIndicators.ValidAnswerRate.ValuePerDateUnits["+ i +"].RateValue");

				validAnswerRate_valuePerDateUnits1.Add(valuePerDateUnit2);
			}
			validAnswerRate.ValuePerDateUnits1 = validAnswerRate_valuePerDateUnits1;
			queryPerformanceIndicatorsResponse.ValidAnswerRate = validAnswerRate;

			QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_DialoguePassRate dialoguePassRate = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_DialoguePassRate();
			dialoguePassRate.TotalRateValue = context.FloatValue("QueryPerformanceIndicators.DialoguePassRate.TotalRateValue");

			List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_DialoguePassRate.QueryPerformanceIndicators_ValuePerDateUnit4> dialoguePassRate_valuePerDateUnits3 = new List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_DialoguePassRate.QueryPerformanceIndicators_ValuePerDateUnit4>();
			for (int i = 0; i < context.Length("QueryPerformanceIndicators.DialoguePassRate.ValuePerDateUnits.Length"); i++) {
				QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_DialoguePassRate.QueryPerformanceIndicators_ValuePerDateUnit4 valuePerDateUnit4 = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_DialoguePassRate.QueryPerformanceIndicators_ValuePerDateUnit4();
				valuePerDateUnit4.Date = context.LongValue("QueryPerformanceIndicators.DialoguePassRate.ValuePerDateUnits["+ i +"].Date");
				valuePerDateUnit4.RateValue = context.FloatValue("QueryPerformanceIndicators.DialoguePassRate.ValuePerDateUnits["+ i +"].RateValue");

				dialoguePassRate_valuePerDateUnits3.Add(valuePerDateUnit4);
			}
			dialoguePassRate.ValuePerDateUnits3 = dialoguePassRate_valuePerDateUnits3;
			queryPerformanceIndicatorsResponse.DialoguePassRate = dialoguePassRate;

			QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_KnowledgeHitRate knowledgeHitRate = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_KnowledgeHitRate();
			knowledgeHitRate.TotalRateValue = context.FloatValue("QueryPerformanceIndicators.KnowledgeHitRate.TotalRateValue");

			List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_KnowledgeHitRate.QueryPerformanceIndicators_ValuePerDateUnit6> knowledgeHitRate_valuePerDateUnits5 = new List<QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_KnowledgeHitRate.QueryPerformanceIndicators_ValuePerDateUnit6>();
			for (int i = 0; i < context.Length("QueryPerformanceIndicators.KnowledgeHitRate.ValuePerDateUnits.Length"); i++) {
				QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_KnowledgeHitRate.QueryPerformanceIndicators_ValuePerDateUnit6 valuePerDateUnit6 = new QueryPerformanceIndicatorsResponse.QueryPerformanceIndicators_KnowledgeHitRate.QueryPerformanceIndicators_ValuePerDateUnit6();
				valuePerDateUnit6.Date = context.LongValue("QueryPerformanceIndicators.KnowledgeHitRate.ValuePerDateUnits["+ i +"].Date");
				valuePerDateUnit6.RateValue = context.FloatValue("QueryPerformanceIndicators.KnowledgeHitRate.ValuePerDateUnits["+ i +"].RateValue");

				knowledgeHitRate_valuePerDateUnits5.Add(valuePerDateUnit6);
			}
			knowledgeHitRate.ValuePerDateUnits5 = knowledgeHitRate_valuePerDateUnits5;
			queryPerformanceIndicatorsResponse.KnowledgeHitRate = knowledgeHitRate;
        
			return queryPerformanceIndicatorsResponse;
        }
    }
}
