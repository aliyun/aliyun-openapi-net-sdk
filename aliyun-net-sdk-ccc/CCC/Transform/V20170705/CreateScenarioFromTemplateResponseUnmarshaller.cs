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
        public static CreateScenarioFromTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateScenarioFromTemplateResponse createScenarioFromTemplateResponse = new CreateScenarioFromTemplateResponse();

			createScenarioFromTemplateResponse.HttpResponse = _ctx.HttpResponse;
			createScenarioFromTemplateResponse.RequestId = _ctx.StringValue("CreateScenarioFromTemplate.RequestId");
			createScenarioFromTemplateResponse.Success = _ctx.BooleanValue("CreateScenarioFromTemplate.Success");
			createScenarioFromTemplateResponse.Code = _ctx.StringValue("CreateScenarioFromTemplate.Code");
			createScenarioFromTemplateResponse.Message = _ctx.StringValue("CreateScenarioFromTemplate.Message");
			createScenarioFromTemplateResponse.HttpStatusCode = _ctx.IntegerValue("CreateScenarioFromTemplate.HttpStatusCode");

			CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario scenario = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario();
			scenario.ScenarioId = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.ScenarioId");
			scenario.ScenarioName = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.ScenarioName");
			scenario.ScenarioDescription = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.ScenarioDescription");
			scenario.Type = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Type");
			scenario.IsTemplate = _ctx.BooleanValue("CreateScenarioFromTemplate.Scenario.IsTemplate");

			CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy strategy = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy();
			strategy.StrategyId = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.StrategyName");
			strategy.StrategyDescription = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.StrategyDescription");
			strategy.Type = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.Type");
			strategy.StartTime = _ctx.LongValue("CreateScenarioFromTemplate.Scenario.Strategy.StartTime");
			strategy.EndTime = _ctx.LongValue("CreateScenarioFromTemplate.Scenario.Strategy.EndTime");
			strategy.RepeatBy = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.RepeatBy");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("CreateScenarioFromTemplate.Scenario.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("CreateScenarioFromTemplate.Scenario.Strategy.MinAttemptInterval");
			strategy.Customized = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.Customized");
			strategy.RoutingStrategy = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.RoutingStrategy");
			strategy.FollowUpStrategy = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("CreateScenarioFromTemplate.Scenario.Strategy.IsTemplate");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateScenarioFromTemplate.Scenario.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame> strategy_workingTime = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame>();
			for (int i = 0; i < _ctx.Length("CreateScenarioFromTemplate.Scenario.Strategy.WorkingTime.Length"); i++) {
				CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame timeFrame = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Strategy.CreateScenarioFromTemplate_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			scenario.Strategy = strategy;

			List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey> scenario_surveys = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey>();
			for (int i = 0; i < _ctx.Length("CreateScenarioFromTemplate.Scenario.Surveys.Length"); i++) {
				CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey survey = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey();
				survey.SurveyId = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].SurveyId");
				survey.SurveyName = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].SurveyName");
				survey.SurveyDescription = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].SurveyDescription");
				survey.Role = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Role");
				survey.Round = _ctx.IntegerValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Round");
				survey.BeebotId = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].BeebotId");

				List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode> survey_intents = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode>();
				for (int j = 0; j < _ctx.Length("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Intents.Length"); j++) {
					CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode intentNode = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_Survey.CreateScenarioFromTemplate_IntentNode();
					intentNode.NodeId = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Intents["+ j +"].NodeId");
					intentNode.IntentId = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Surveys["+ i +"].Intents["+ j +"].IntentId");

					survey_intents.Add(intentNode);
				}
				survey.Intents = survey_intents;

				scenario_surveys.Add(survey);
			}
			scenario.Surveys = scenario_surveys;

			List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair> scenario_variables = new List<CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("CreateScenarioFromTemplate.Scenario.Variables.Length"); i++) {
				CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair keyValuePair = new CreateScenarioFromTemplateResponse.CreateScenarioFromTemplate_Scenario.CreateScenarioFromTemplate_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Variables["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("CreateScenarioFromTemplate.Scenario.Variables["+ i +"].Value");

				scenario_variables.Add(keyValuePair);
			}
			scenario.Variables = scenario_variables;
			createScenarioFromTemplateResponse.Scenario = scenario;
        
			return createScenarioFromTemplateResponse;
        }
    }
}
