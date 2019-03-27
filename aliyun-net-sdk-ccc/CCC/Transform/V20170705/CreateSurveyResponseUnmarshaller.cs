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
    public class CreateSurveyResponseUnmarshaller
    {
        public static CreateSurveyResponse Unmarshall(UnmarshallerContext context)
        {
			CreateSurveyResponse createSurveyResponse = new CreateSurveyResponse();

			createSurveyResponse.HttpResponse = context.HttpResponse;
			createSurveyResponse.RequestId = context.StringValue("CreateSurvey.RequestId");
			createSurveyResponse.Success = context.BooleanValue("CreateSurvey.Success");
			createSurveyResponse.Code = context.StringValue("CreateSurvey.Code");
			createSurveyResponse.Message = context.StringValue("CreateSurvey.Message");
			createSurveyResponse.HttpStatusCode = context.IntegerValue("CreateSurvey.HttpStatusCode");

			CreateSurveyResponse.CreateSurvey_Survey survey = new CreateSurveyResponse.CreateSurvey_Survey();
			survey.Id = context.StringValue("CreateSurvey.Survey.Id");
			survey.ScenarioUuid = context.StringValue("CreateSurvey.Survey.ScenarioUuid");
			survey.Name = context.StringValue("CreateSurvey.Survey.Name");
			survey.Description = context.StringValue("CreateSurvey.Survey.Description");
			survey.Role = context.StringValue("CreateSurvey.Survey.Role");
			survey.Round = context.IntegerValue("CreateSurvey.Survey.Round");
			survey.HotWords = context.StringValue("CreateSurvey.Survey.HotWords");
			survey.SpeechOptimizationParam = context.StringValue("CreateSurvey.Survey.SpeechOptimizationParam");
			survey.GlobalQuestions = context.StringValue("CreateSurvey.Survey.GlobalQuestions");

			CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_Flow flow = new CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_Flow();
			flow.FlowId = context.StringValue("CreateSurvey.Survey.Flow.FlowId");
			flow.IsPublished = context.BooleanValue("CreateSurvey.Survey.Flow.IsPublished");
			flow.FlowJson = context.StringValue("CreateSurvey.Survey.Flow.FlowJson");
			survey.Flow = flow;

			CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_AsrCustomModel asrCustomModel = new CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_AsrCustomModel();
			asrCustomModel.Corpora = context.StringValue("CreateSurvey.Survey.AsrCustomModel.Corpora");
			asrCustomModel.CustomModelStatus = context.IntegerValue("CreateSurvey.Survey.AsrCustomModel.CustomModelStatus");
			survey.AsrCustomModel = asrCustomModel;
			createSurveyResponse.Survey = survey;
        
			return createSurveyResponse;
        }
    }
}
