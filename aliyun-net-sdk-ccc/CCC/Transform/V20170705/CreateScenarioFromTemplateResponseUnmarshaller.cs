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
    public class CreateScenarioFromTemplateResponseUnmarshaller
    {
        public static CreateScenarioFromTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			CreateScenarioFromTemplateResponse createScenarioFromTemplateResponse = new CreateScenarioFromTemplateResponse();

			createScenarioFromTemplateResponse.HttpResponse = context.HttpResponse;
			createScenarioFromTemplateResponse.RequestId = context.StringValue("CreateScenarioFromTemplate.RequestId");
			createScenarioFromTemplateResponse.Success = context.BooleanValue("CreateScenarioFromTemplate.Success");
			createScenarioFromTemplateResponse.Code = context.StringValue("CreateScenarioFromTemplate.Code");
			createScenarioFromTemplateResponse.Message = context.StringValue("CreateScenarioFromTemplate.Message");
			createScenarioFromTemplateResponse.HttpStatusCode = context.IntegerValue("CreateScenarioFromTemplate.HttpStatusCode");

			CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario scenario = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario();
			scenario.ScenarioId = context.StringValue("CreateScenarioFromTemplate.Scenario.ScenarioId");
			scenario.ScenarioName = context.StringValue("CreateScenarioFromTemplate.Scenario.ScenarioName");
			scenario.ScenarioDescription = context.StringValue("CreateScenarioFromTemplate.Scenario.ScenarioDescription");
			scenario.Type = context.StringValue("CreateScenarioFromTemplate.Scenario.Type");
			scenario.IsTemplate = context.BooleanValue("CreateScenarioFromTemplate.Scenario.IsTemplate");

			CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy strategy = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy();
			strategy.StrategyId = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.StrategyId");
			strategy.StrategyName = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.StrategyName");
			strategy.StrategyDescription = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.StrategyDescription");
			strategy.Type = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.Type");
			strategy.StartTime = context.LongValue("CreateScenarioFromTemplate.Scenario.Strategy.StartTime");
			strategy.EndTime = context.LongValue("CreateScenarioFromTemplate.Scenario.Strategy.EndTime");
			strategy.RepeatBy = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = context.IntegerValue("CreateScenarioFromTemplate.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = context.IntegerValue("CreateScenarioFromTemplate.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = context.BooleanValue("CreateScenarioFromTemplate.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < context.Length("CreateScenarioFromTemplate.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame> strategy_workingTime = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame>();
			for (int i = 0; i < context.Length("CreateScenarioFromTemplate.Scenario.Strategy.WorkingTime.Length"); i++) {
				CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame timeFrame = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame();
				timeFrame.BeginTime = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = context.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey> scenario_surveys = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey>();
			for (int i = 0; i < context.Length("CreateScenarioFromTemplate.Scenario.Surveys.Length"); i++) {
				CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey survey = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey();
				survey.SurveyId = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].SurveyId");
				survey.SurveyName = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].SurveyName");
				survey.SurveyDescription = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].SurveyDescription");
				survey.Role = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Role");
				survey.Round = context.IntegerValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].BeebotId");

				List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode> survey_intents = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode>();
				for (int j = 0; j < context.Length("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode intentNode = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode();
					intentNode.NodeId = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = context.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair> scenario_variables = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair>();
			for (int i = 0; i < context.Length("CreateScenarioFromTemplate.Scenario.Variables.Length"); i++) {
				CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair keyValuePair = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair();
				keyValuePair.Key = context.StringValue("CreateScenarioFromTemplate.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = context.StringValue("CreateScenarioFromTemplate.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			createScenarioFromTemplateResponse.Scenario = scenario;
        
			return createScenarioFromTemplateResponse;
        }
    }
}
