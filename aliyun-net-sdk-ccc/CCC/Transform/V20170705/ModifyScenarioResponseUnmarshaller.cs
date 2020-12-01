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
    public class ModifyScenarioResponseUnmarshaller
    {
        public static ModifyScenarioResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyScenarioResponse modifyScenarioResponse = new ModifyScenarioResponse();

			modifyScenarioResponse.HttpResponse = _ctx.HttpResponse;
			modifyScenarioResponse.RequestId = _ctx.StringValue("ModifyScenario.RequestId");
			modifyScenarioResponse.Success = _ctx.BooleanValue("ModifyScenario.Success");
			modifyScenarioResponse.Code = _ctx.StringValue("ModifyScenario.Code");
			modifyScenarioResponse.Message = _ctx.StringValue("ModifyScenario.Message");
			modifyScenarioResponse.HttpStatusCode = _ctx.IntegerValue("ModifyScenario.HttpStatusCode");

			ModifyScenarioResponse.ModifyScenario_Scenario scenario = new ModifyScenarioResponse.ModifyScenario_Scenario();
			scenario.ScenarioId = _ctx.StringValue("ModifyScenario.Scenario.ScenarioId");
			scenario.ScenarioName = _ctx.StringValue("ModifyScenario.Scenario.ScenarioName");
			scenario.ScenarioDescription = _ctx.StringValue("ModifyScenario.Scenario.ScenarioDescription");
			scenario.Type = _ctx.StringValue("ModifyScenario.Scenario.Type");
			scenario.IsTemplate = _ctx.BooleanValue("ModifyScenario.Scenario.IsTemplate");

			ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy strategy = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy();
			strategy.StrategyId = _ctx.StringValue("ModifyScenario.Scenario.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("ModifyScenario.Scenario.Strategy.StrategyName");
			strategy.StrategyDescription = _ctx.StringValue("ModifyScenario.Scenario.Strategy.StrategyDescription");
			strategy.Type = _ctx.StringValue("ModifyScenario.Scenario.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("ModifyScenario.Scenario.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("ModifyScenario.Scenario.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("ModifyScenario.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("ModifyScenario.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("ModifyScenario.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("ModifyScenario.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("ModifyScenario.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("ModifyScenario.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("ModifyScenario.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyScenario.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("ModifyScenario.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame> strategy_workingTime = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame>();
			for (int i = 0; i < _ctx.Length("ModifyScenario.Scenario.Strategy.WorkingTime.Length"); i++) {
				ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame timeFrame = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("ModifyScenario.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("ModifyScenario.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey> scenario_surveys = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey>();
			for (int i = 0; i < _ctx.Length("ModifyScenario.Scenario.Surveys.Length"); i++) {
				ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey survey = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey();
				survey.SurveyId = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].SurveyId");
				survey.SurveyName = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].SurveyName");
				survey.SurveyDescription = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].SurveyDescription");
				survey.Role = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].Role");
				survey.Round = _ctx.IntegerValue("ModifyScenario.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].BeebotId");

				List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode> survey_intents = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode>();
				for (int j = 0; j < _ctx.Length("ModifyScenario.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode intentNode = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode();
					intentNode.NodeId = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = _ctx.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair> scenario_variables = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("ModifyScenario.Scenario.Variables.Length"); i++) {
				ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair keyValuePair = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("ModifyScenario.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("ModifyScenario.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			modifyScenarioResponse.Scenario = scenario;
        
			return modifyScenarioResponse;
        }
    }
}
