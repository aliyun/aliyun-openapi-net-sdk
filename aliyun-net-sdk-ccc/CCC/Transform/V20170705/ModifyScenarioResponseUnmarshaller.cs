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
        public static ModifyScenarioResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyScenarioResponse modifyScenarioResponse = new ModifyScenarioResponse();

			modifyScenarioResponse.HttpResponse = context.HttpResponse;
			modifyScenarioResponse.RequestId = context.StringValue("ModifyScenario.RequestId");
			modifyScenarioResponse.Success = context.BooleanValue("ModifyScenario.Success");
			modifyScenarioResponse.Code = context.StringValue("ModifyScenario.Code");
			modifyScenarioResponse.Message = context.StringValue("ModifyScenario.Message");
			modifyScenarioResponse.HttpStatusCode = context.IntegerValue("ModifyScenario.HttpStatusCode");

			ModifyScenarioResponse.ModifyScenario_Scenario scenario = new ModifyScenarioResponse.ModifyScenario_Scenario();
			scenario.ScenarioId = context.StringValue("ModifyScenario.Scenario.ScenarioId");
			scenario.ScenarioName = context.StringValue("ModifyScenario.Scenario.ScenarioName");
			scenario.ScenarioDescription = context.StringValue("ModifyScenario.Scenario.ScenarioDescription");
			scenario.Type = context.StringValue("ModifyScenario.Scenario.Type");
			scenario.IsTemplate = context.BooleanValue("ModifyScenario.Scenario.IsTemplate");

			ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy strategy = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy();
			strategy.StrategyId = context.StringValue("ModifyScenario.Scenario.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("ModifyScenario.Scenario.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("ModifyScenario.Scenario.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("ModifyScenario.Scenario.Strategy.Type");
			strategy.StartTime = context.LongValue("ModifyScenario.Scenario.Strategy.StartTime");
			strategy.EndTime = context.LongValue("ModifyScenario.Scenario.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("ModifyScenario.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("ModifyScenario.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("ModifyScenario.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("ModifyScenario.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("ModifyScenario.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("ModifyScenario.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("ModifyScenario.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("ModifyScenario.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("ModifyScenario.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame> strategy_workingTime = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame>();
			for (int i = 0; i < context.Length("ModifyScenario.Scenario.Strategy.WorkingTime.Length"); i++) {
				ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame timeFrame = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Strategy.ModifyScenario_TimeFrame();
				timeFrame.BeginTime = context.StringValue("ModifyScenario.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("ModifyScenario.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey> scenario_surveys = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey>();
			for (int i = 0; i < context.Length("ModifyScenario.Scenario.Surveys.Length"); i++) {
				ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey survey = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey();
				survey.SurveyId = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].SurveyId");
				survey.SurveyName = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].SurveyName");
				survey.SurveyDescription = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].SurveyDescription");
				survey.Role = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].Role");
				survey.Round = context.IntegerValue("ModifyScenario.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].BeebotId");

				List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode> survey_intents = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode>();
				for (int j = 0; j < context.Length("ModifyScenario.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode intentNode = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_Survey.ModifyScenario_IntentNode();
					intentNode.NodeId = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = context.StringValue("ModifyScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair> scenario_variables = new List<ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair>();
			for (int i = 0; i < context.Length("ModifyScenario.Scenario.Variables.Length"); i++) {
				ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair keyValuePair = new ModifyScenarioResponse.ModifyScenario_Scenario.ModifyScenario_KeyValuePair();
				keyValuePair.Key = context.StringValue("ModifyScenario.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = context.StringValue("ModifyScenario.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			modifyScenarioResponse.Scenario = scenario;
        
			return modifyScenarioResponse;
        }
    }
}
