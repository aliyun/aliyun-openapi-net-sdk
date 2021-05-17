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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetScenarioResponseUnmarshaller
    {
        public static GetScenarioResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetScenarioResponse getScenarioResponse = new GetScenarioResponse();

			getScenarioResponse.HttpResponse = _ctx.HttpResponse;
			getScenarioResponse.RequestId = _ctx.StringValue("GetScenario.RequestId");
			getScenarioResponse.Success = _ctx.BooleanValue("GetScenario.Success");
			getScenarioResponse.Code = _ctx.StringValue("GetScenario.Code");
			getScenarioResponse.Message = _ctx.StringValue("GetScenario.Message");
			getScenarioResponse.HttpStatusCode = _ctx.IntegerValue("GetScenario.HttpStatusCode");

			GetScenarioResponse.GetScenario_Scenario scenario = new GetScenarioResponse.GetScenario_Scenario();
			scenario.Id = _ctx.StringValue("GetScenario.Scenario.Id");
			scenario.Name = _ctx.StringValue("GetScenario.Scenario.Name");
			scenario.Description = _ctx.StringValue("GetScenario.Scenario.Description");
			scenario.Type = _ctx.StringValue("GetScenario.Scenario.Type");
			scenario.IsTemplate = _ctx.BooleanValue("GetScenario.Scenario.IsTemplate");

			GetScenarioResponse.GetScenario_Scenario.GetScenario_Strategy strategy = new GetScenarioResponse.GetScenario_Scenario.GetScenario_Strategy();
			strategy.Id = _ctx.StringValue("GetScenario.Scenario.Strategy.Id");
			strategy.Name = _ctx.StringValue("GetScenario.Scenario.Strategy.Name");
			strategy.Description = _ctx.StringValue("GetScenario.Scenario.Strategy.Description");
			strategy.Type = _ctx.StringValue("GetScenario.Scenario.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("GetScenario.Scenario.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("GetScenario.Scenario.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("GetScenario.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("GetScenario.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("GetScenario.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("GetScenario.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("GetScenario.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("GetScenario.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("GetScenario.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("GetScenario.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("GetScenario.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<GetScenarioResponse.GetScenario_Scenario.GetScenario_Strategy.GetScenario_TimeFrame> strategy_workingTime = new List<GetScenarioResponse.GetScenario_Scenario.GetScenario_Strategy.GetScenario_TimeFrame>();
			for (int i = 0; i < _ctx.Length("GetScenario.Scenario.Strategy.WorkingTime.Length"); i++) {
				GetScenarioResponse.GetScenario_Scenario.GetScenario_Strategy.GetScenario_TimeFrame timeFrame = new GetScenarioResponse.GetScenario_Scenario.GetScenario_Strategy.GetScenario_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("GetScenario.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("GetScenario.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey> scenario_surveys = new List<GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey>();
			for (int i = 0; i < _ctx.Length("GetScenario.Scenario.Surveys.Length"); i++) {
				GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey survey = new GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey();
				survey.Id = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].Id");
				survey.Name = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].Name");
				survey.Description = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].Description");
				survey.Role = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].Role");
				survey.Round = _ctx.IntegerValue("GetScenario.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].BeebotId");

				List<GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey.GetScenario_IntentNode> survey_intents = new List<GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey.GetScenario_IntentNode>();
				for (int j = 0; j < _ctx.Length("GetScenario.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey.GetScenario_IntentNode intentNode = new GetScenarioResponse.GetScenario_Scenario.GetScenario_Survey.GetScenario_IntentNode();
					intentNode.NodeId = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = _ctx.StringValue("GetScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<GetScenarioResponse.GetScenario_Scenario.GetScenario_KeyValuePair> scenario_variables = new List<GetScenarioResponse.GetScenario_Scenario.GetScenario_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("GetScenario.Scenario.Variables.Length"); i++) {
				GetScenarioResponse.GetScenario_Scenario.GetScenario_KeyValuePair keyValuePair = new GetScenarioResponse.GetScenario_Scenario.GetScenario_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("GetScenario.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("GetScenario.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			getScenarioResponse.Scenario = scenario;
        
			return getScenarioResponse;
        }
    }
}
