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
        public static ListScenariosResponse Unmarshall(UnmarshallerContext context)
        {
			ListScenariosResponse listScenariosResponse = new ListScenariosResponse();

			listScenariosResponse.HttpResponse = context.HttpResponse;
			listScenariosResponse.RequestId = context.StringValue("ListScenarios.RequestId");
			listScenariosResponse.Success = context.BooleanValue("ListScenarios.Success");
			listScenariosResponse.Code = context.StringValue("ListScenarios.Code");
			listScenariosResponse.Message = context.StringValue("ListScenarios.Message");
			listScenariosResponse.HttpStatusCode = context.IntegerValue("ListScenarios.HttpStatusCode");

			List<ListScenariosResponse.ListScenarios_Scenario> listScenariosResponse_scenarios = new List<ListScenariosResponse.ListScenarios_Scenario>();
			for (int i = 0; i < context.Length("ListScenarios.Scenarios.Length"); i++) {
				ListScenariosResponse.ListScenarios_Scenario scenario = new ListScenariosResponse.ListScenarios_Scenario();
				scenario.Id = context.StringValue("ListScenarios.Scenarios["+ i +"].Id");
				scenario.Name = context.StringValue("ListScenarios.Scenarios["+ i +"].Name");
				scenario.Description = context.StringValue("ListScenarios.Scenarios["+ i +"].Description");
				scenario.Type = context.StringValue("ListScenarios.Scenarios["+ i +"].Type");
				scenario.IsTemplate = context.BooleanValue("ListScenarios.Scenarios["+ i +"].IsTemplate");

				ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy strategy = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy();
				strategy.Id = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Id");
				strategy.Name = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Name");
				strategy.Description = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Description");
				strategy.Type = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Type");
				strategy.StartTime = context.LongValue("ListScenarios.Scenarios["+ i +"].Strategy.StartTime");
				strategy.EndTime = context.LongValue("ListScenarios.Scenarios["+ i +"].Strategy.EndTime");
				strategy.RepeatBy = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.RepeatBy");
				strategy.MaxAttemptsPerDay = context.IntegerValue("ListScenarios.Scenarios["+ i +"].Strategy.MaxAttemptsPerDay");
				strategy.MinAttemptInterval = context.IntegerValue("ListScenarios.Scenarios["+ i +"].Strategy.MinAttemptInterval");
				strategy.Customized = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.Customized");
				strategy.RoutingStrategy = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.RoutingStrategy");
				strategy.FollowUpStrategy = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.FollowUpStrategy");
				strategy.IsTemplate = context.BooleanValue("ListScenarios.Scenarios["+ i +"].Strategy.IsTemplate");

				List<string> strategy_repeatDays = new List<string>();
				for (int j = 0; j < context.Length("ListScenarios.Scenarios["+ i +"].Strategy.RepeatDays.Length"); j++) {
					strategy_repeatDays.Add(context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.RepeatDays["+ j +"]"));
				}
				strategy.RepeatDays = strategy_repeatDays;

				List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame> strategy_workingTime = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame>();
				for (int j = 0; j < context.Length("ListScenarios.Scenarios["+ i +"].Strategy.WorkingTime.Length"); j++) {
					ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame timeFrame = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Strategy.ListScenarios_TimeFrame();
					timeFrame.BeginTime = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.WorkingTime["+ j +"].BeginTime");
					timeFrame.EndTime = context.StringValue("ListScenarios.Scenarios["+ i +"].Strategy.WorkingTime["+ j +"].EndTime");

					strategy_workingTime.Add(timeFrame);
				}
				strategy.WorkingTime = strategy_workingTime;
				scenario.Strategy = strategy;

				List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey> scenario_surveys = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey>();
				for (int j = 0; j < context.Length("ListScenarios.Scenarios["+ i +"].Surveys.Length"); j++) {
					ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey survey = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey();
					survey.Id = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Id");
					survey.Name = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Name");
					survey.Description = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Description");
					survey.Role = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Role");
					survey.Round = context.IntegerValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Round");
					survey.BeebotId = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].BeebotId");

					List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode> survey_intents = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode>();
					for (int k = 0; k < context.Length("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Intents.Length"); k++) {
						ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode intentNode = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_Survey.ListScenarios_IntentNode();
						intentNode.NodeId = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Intents["+ k +"].NodeId");
						intentNode.IntentId = context.StringValue("ListScenarios.Scenarios["+ i +"].Surveys["+ j +"].Intents["+ k +"].IntentId");

						survey_intents.Add(intentNode);
					}
					survey.Intents = survey_intents;

					scenario_surveys.Add(survey);
				}
				scenario.Surveys = scenario_surveys;

				List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair> scenario_variables = new List<ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair>();
				for (int j = 0; j < context.Length("ListScenarios.Scenarios["+ i +"].Variables.Length"); j++) {
					ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair keyValuePair = new ListScenariosResponse.ListScenarios_Scenario.ListScenarios_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListScenarios.Scenarios["+ i +"].Variables["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListScenarios.Scenarios["+ i +"].Variables["+ j +"].Value");

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
