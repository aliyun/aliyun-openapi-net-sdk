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
    public class ListScenariosResponseUnmarshaller
    {
        public static ListScenariosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScenariosResponse listScenariosResponse = new ListScenariosResponse();

			listScenariosResponse.HttpResponse = _ctx.HttpResponse;
			listScenariosResponse.RequestId = _ctx.StringValue("ListScenarios.RequestId");
			listScenariosResponse.Success = _ctx.BooleanValue("ListScenarios.Success");
			listScenariosResponse.Code = _ctx.StringValue("ListScenarios.Code");
			listScenariosResponse.Message = _ctx.StringValue("ListScenarios.Message");
			listScenariosResponse.HttpStatusCode = _ctx.IntegerValue("ListScenarios.HttpStatusCode");

			List<ListScenariosResponse.ListScenarios_Scenario> listScenariosResponse_scenarios = new List<ListScenariosResponse.ListScenarios_Scenario>();
			for (int i = 0; i < _ctx.Length("ListScenarios.Scenarios.Length"); i++) {
				ListScenariosResponse.ListScenarios_Scenario scenario = new ListScenariosResponse.ListScenarios_Scenario();
				scenario.Id = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Id");
				scenario.Name = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Name");
				scenario.Description = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Description");
				scenario.Type = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Type");
				scenario.IsTemplate = _ctx.BooleanValue("ListScenarios.Scenarios["+ i +"].IsTemplate");

				ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy strategy = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy();
				strategy.Id = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Id");
				strategy.Name = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Name");
				strategy.Description = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Description");
				strategy.Type = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Type");
				strategy.StartTime = _ctx.LongValue("ListScenarios.Scenarios["+ i +"].Strategy.StartTime");
				strategy.EndTime = _ctx.LongValue("ListScenarios.Scenarios["+ i +"].Strategy.EndTime");
				strategy.RepeatBy = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.RepeatBy");
				strategy.MaxAttemptsPerDay = _ctx.IntegerValue("ListScenarios.Scenarios["+ i +"].Strategy.MaxAttemptsPerDay");
				strategy.MinAttemptInterval = _ctx.IntegerValue("ListScenarios.Scenarios["+ i +"].Strategy.MinAttemptInterval");
				strategy.Customized = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Customized");
				strategy.RoutingStrategy = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.RoutingStrategy");
				strategy.FollowUpStrategy = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.FollowUpStrategy");
				strategy.IsTemplate = _ctx.BooleanValue("ListScenarios.Scenarios["+ i +"].Strategy.IsTemplate");

				List<string> strategy_repeatDays = new List<string>();
				for (int j = 0; j < _ctx.Length("ListScenarios.Scenarios["+ i +"].Strategy.RepeatDays.Length"); j++) {
					strategy_repeatDays.Add(_ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.RepeatDays["+ j +"]"));
				}
				strategy.RepeatDays = strategy_repeatDays;

				List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame> strategy_workingTime = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame>();
				for (int j = 0; j < _ctx.Length("ListScenarios.Scenarios["+ i +"].Strategy.WorkingTime.Length"); j++) {
					ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame timeFrame = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame();
					timeFrame.BeginTime = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.WorkingTime["+ j +"].BeginTime");
					timeFrame.EndTime = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.WorkingTime["+ j +"].EndTime");

					strategy_workingTime.Add(timeFrame);
				}
				strategy.WorkingTime = strategy_workingTime;
				scenario.Strategy = strategy;

				List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey> scenario_surveys = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey>();
				for (int j = 0; j < _ctx.Length("ListScenarios.Scenarios["+ i +"].Surveys.Length"); j++) {
					ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey survey = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey();
					survey.Id = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Id");
					survey.Name = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Name");
					survey.Description = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Description");
					survey.Role = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Role");
					survey.Round = _ctx.IntegerValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Round");
					survey.BeebotId = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].BeebotId");

					List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode> survey_intents = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode>();
					for (int k = 0; k < _ctx.Length("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Intents.Length"); k++) {
						ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode intentNode = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode();
						intentNode.NodeId = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Intents["+ k +"].NodeId");
						intentNode.IntentId = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Intents["+ k +"].IntentId");

						survey_intents.Add(intentNode);
					}
					survey.Intents = survey_intents;

					scenario_surveys.Add(survey);
				}
				scenario.Surveys = scenario_surveys;

				List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair> scenario_variables = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListScenarios.Scenarios["+ i +"].Variables.Length"); j++) {
					ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair keyValuePair = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Variables["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListScenarios.Scenarios["+ i +"].Variables["+ j +"].Value");

					scenario_variables.Add(keyValuePair);
				}
				scenario.Variables = scenario_variables;

				listScenariosResponse_scenarios.Add(scenario);
			}
			listScenariosResponse.Scenarios = listScenariosResponse_scenarios;
        
			return listScenariosResponse;
        }
    }
}
