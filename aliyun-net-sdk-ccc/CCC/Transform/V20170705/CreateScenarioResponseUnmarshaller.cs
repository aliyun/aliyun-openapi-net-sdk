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
        public static CreateScenarioResponse Unmarshall(UnmarshallerContext context)
        {
			CreateScenarioResponse createScenarioResponse = new CreateScenarioResponse();

			createScenarioResponse.HttpResponse = context.HttpResponse;
			createScenarioResponse.RequestId = context.StringValue("CreateScenario.RequestId");
			createScenarioResponse.Success = context.BooleanValue("CreateScenario.Success");
			createScenarioResponse.Code = context.StringValue("CreateScenario.Code");
			createScenarioResponse.Message = context.StringValue("CreateScenario.Message");
			createScenarioResponse.HttpStatusCode = context.IntegerValue("CreateScenario.HttpStatusCode");

			CreateScenarioResponse.CreateScenario_Scenario scenario = new CreateScenarioResponse.CreateScenario_Scenario();
			scenario.ScenarioId = context.StringValue("CreateScenario.Scenario.ScenarioId");
			scenario.ScenarioName = context.StringValue("CreateScenario.Scenario.ScenarioName");
			scenario.ScenarioDescription = context.StringValue("CreateScenario.Scenario.ScenarioDescription");
			scenario.Type = context.StringValue("CreateScenario.Scenario.Type");
			scenario.IsTemplate = context.BooleanValue("CreateScenario.Scenario.IsTemplate");

			CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy strategy = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy();
			strategy.StrategyId = context.StringValue("CreateScenario.Scenario.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("CreateScenario.Scenario.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("CreateScenario.Scenario.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("CreateScenario.Scenario.Strategy.Type");
			strategy.StartTime = context.LongValue("CreateScenario.Scenario.Strategy.StartTime");
			strategy.EndTime = context.LongValue("CreateScenario.Scenario.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("CreateScenario.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("CreateScenario.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("CreateScenario.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("CreateScenario.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("CreateScenario.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("CreateScenario.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("CreateScenario.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("CreateScenario.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("CreateScenario.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame> strategy_workingTime = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame>();
			for (int i = 0; i < context.Length("CreateScenario.Scenario.Strategy.WorkingTime.Length"); i++) {
				CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame timeFrame = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Strategy.CreateScenario_TimeFrame();
				timeFrame.BeginTime = context.StringValue("CreateScenario.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("CreateScenario.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey> scenario_surveys = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey>();
			for (int i = 0; i < context.Length("CreateScenario.Scenario.Surveys.Length"); i++) {
				CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey survey = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey();
				survey.SurveyId = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].SurveyId");
				survey.SurveyName = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].SurveyName");
				survey.SurveyDescription = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].SurveyDescription");
				survey.Role = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].Role");
				survey.Round = context.IntegerValue("CreateScenario.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].BeebotId");

				List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode> survey_intents = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode>();
				for (int j = 0; j < context.Length("CreateScenario.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode intentNode = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_Survey.CreateScenario_IntentNode();
					intentNode.NodeId = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = context.StringValue("CreateScenario.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair> scenario_variables = new List<CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair>();
			for (int i = 0; i < context.Length("CreateScenario.Scenario.Variables.Length"); i++) {
				CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair keyValuePair = new CreateScenarioResponse.CreateScenario_Scenario.CreateScenario_KeyValuePair();
				keyValuePair.Key = context.StringValue("CreateScenario.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = context.StringValue("CreateScenario.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			createScenarioResponse.Scenario = scenario;
        
			return createScenarioResponse;
        }
    }
}
