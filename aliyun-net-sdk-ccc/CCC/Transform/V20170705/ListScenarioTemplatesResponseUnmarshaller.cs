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
    public class ListScenarioTemplatesResponseUnmarshaller
    {
        public static ListScenarioTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScenarioTemplatesResponse listScenarioTemplatesResponse = new ListScenarioTemplatesResponse();

			listScenarioTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listScenarioTemplatesResponse.RequestId = _ctx.StringValue("ListScenarioTemplates.RequestId");
			listScenarioTemplatesResponse.Success = _ctx.BooleanValue("ListScenarioTemplates.Success");
			listScenarioTemplatesResponse.Code = _ctx.StringValue("ListScenarioTemplates.Code");
			listScenarioTemplatesResponse.Message = _ctx.StringValue("ListScenarioTemplates.Message");
			listScenarioTemplatesResponse.HttpStatusCode = _ctx.IntegerValue("ListScenarioTemplates.HttpStatusCode");

			List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario> listScenarioTemplatesResponse_scenarioTemplates = new List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario>();
			for (int i = 0; i < _ctx.Length("ListScenarioTemplates.ScenarioTemplates.Length"); i++) {
				ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario scenario = new ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario();
				scenario.Id = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Id");
				scenario.Name = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Name");
				scenario.Description = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Description");
				scenario.Type = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Type");
				scenario.IsTemplate = _ctx.BooleanValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].IsTemplate");

				List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey> scenario_surveys = new List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey>();
				for (int j = 0; j < _ctx.Length("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys.Length"); j++) {
					ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey survey = new ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey();
					survey.Id = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Id");
					survey.Name = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Name");
					survey.Description = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Description");
					survey.Role = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Role");
					survey.Round = _ctx.IntegerValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Round");
					survey.BeebotId = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].BeebotId");
					survey.GlobalQuestions = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].GlobalQuestions");

					ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey.ListScenarioTemplates_Flow flow = new ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey.ListScenarioTemplates_Flow();
					flow.FlowId = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Flow.FlowId");
					flow.IsPublished = _ctx.BooleanValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Flow.IsPublished");
					flow.FlowJson = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Flow.FlowJson");
					survey.Flow = flow;

					List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey.ListScenarioTemplates_IntentNode> survey_intents = new List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey.ListScenarioTemplates_IntentNode>();
					for (int k = 0; k < _ctx.Length("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Intents.Length"); k++) {
						ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey.ListScenarioTemplates_IntentNode intentNode = new ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_Survey.ListScenarioTemplates_IntentNode();
						intentNode.NodeId = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Intents["+ k +"].NodeId");
						intentNode.IntentId = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Surveys["+ j +"].Intents["+ k +"].IntentId");

						survey_intents.Add(intentNode);
					}
					survey.Intents = survey_intents;

					scenario_surveys.Add(survey);
				}
				scenario.Surveys = scenario_surveys;

				List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_KeyValuePair> scenario_variables = new List<ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListScenarioTemplates.ScenarioTemplates["+ i +"].Variables.Length"); j++) {
					ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_KeyValuePair keyValuePair = new ListScenarioTemplatesResponse.ListScenarioTemplates_Scenario.ListScenarioTemplates_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Variables["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListScenarioTemplates.ScenarioTemplates["+ i +"].Variables["+ j +"].Value");

					scenario_variables.Add(keyValuePair);
				}
				scenario.Variables = scenario_variables;

				listScenarioTemplatesResponse_scenarioTemplates.Add(scenario);
			}
			listScenarioTemplatesResponse.ScenarioTemplates = listScenarioTemplatesResponse_scenarioTemplates;
        
			return listScenarioTemplatesResponse;
        }
    }
}
