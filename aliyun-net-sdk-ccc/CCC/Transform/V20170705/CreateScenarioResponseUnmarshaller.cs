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
    public class CreateScenarioResponseUnmarshaller
    {
        public static CreateScenarioResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateScenarioResponse createScenarioResponse = new CreateScenarioResponse();

			createScenarioResponse.HttpResponse = _ctx.HttpResponse;
			createScenarioResponse.RequestId = _ctx.StringValue("CreateScenario.RequestId");
			createScenarioResponse.Success = _ctx.BooleanValue("CreateScenario.Success");
			createScenarioResponse.Code = _ctx.StringValue("CreateScenario.Code");
			createScenarioResponse.Message = _ctx.StringValue("CreateScenario.Message");
			createScenarioResponse.HttpStatusCode = _ctx.IntegerValue("CreateScenario.HttpStatusCode");

			CreateScenarioResponse.CreateScenario_Scenario scenario = new CreateScenarioResponse.CreateScenario_Scenario();
			scenario.ScenarioId = _ctx.StringValue("CreateScenario.Scenario.ScenarioId");
			scenario.ScenarioName = _ctx.StringValue("CreateScenario.Scenario.ScenarioName");
			scenario.ScenarioDescription = _ctx.StringValue("CreateScenario.Scenario.ScenarioDescription");
			scenario.Type = _ctx.StringValue("CreateScenario.Scenario.Type");
			scenario.IsTemplate = _ctx.BooleanValue("CreateScenario.Scenario.IsTemplate");

			CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy strategy = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy();
			strategy.StrategyId = _ctx.StringValue("CreateScenario.Scenario.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("CreateScenario.Scenario.Strategy.StrategyName");
			strategy.StrategyDescription = _ctx.StringValue("CreateScenario.Scenario.Strategy.StrategyDescription");
			strategy.Type = _ctx.StringValue("CreateScenario.Scenario.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("CreateScenario.Scenario.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("CreateScenario.Scenario.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("CreateScenario.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("CreateScenario.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("CreateScenario.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("CreateScenario.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("CreateScenario.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("CreateScenario.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("CreateScenario.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateScenario.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("CreateScenario.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame> strategy_workingTime = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame>();
			for (int i = 0; i < _ctx.Length("CreateScenario.Scenario.Strategy.WorkingTime.Length"); i++) {
				CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame timeFrame = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("CreateScenario.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("CreateScenario.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey> scenario_surveys = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey>();
			for (int i = 0; i < _ctx.Length("CreateScenario.Scenario.Surveys.Length"); i++) {
				CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey survey = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey();
				survey.SurveyId = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].SurveyId");
				survey.SurveyName = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].SurveyName");
				survey.SurveyDescription = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].SurveyDescription");
				survey.Role = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].Role");
				survey.Round = _ctx.IntegerValue("CreateScenario.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].BeebotId");

				List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode> survey_intents = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode>();
				for (int j = 0; j < _ctx.Length("CreateScenario.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode intentNode = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode();
					intentNode.NodeId = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = _ctx.StringValue("CreateScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair> scenario_variables = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("CreateScenario.Scenario.Variables.Length"); i++) {
				CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair keyValuePair = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("CreateScenario.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("CreateScenario.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			createScenarioResponse.Scenario = scenario;
        
			return createScenarioResponse;
        }
    }
}
