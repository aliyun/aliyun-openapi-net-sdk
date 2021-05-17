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
        public static CreateSurveyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSurveyResponse createSurveyResponse = new CreateSurveyResponse();

			createSurveyResponse.HttpResponse = _ctx.HttpResponse;
			createSurveyResponse.RequestId = _ctx.StringValue("CreateSurvey.RequestId");
			createSurveyResponse.Success = _ctx.BooleanValue("CreateSurvey.Success");
			createSurveyResponse.Code = _ctx.StringValue("CreateSurvey.Code");
			createSurveyResponse.Message = _ctx.StringValue("CreateSurvey.Message");
			createSurveyResponse.HttpStatusCode = _ctx.IntegerValue("CreateSurvey.HttpStatusCode");

			CreateSurveyResponse.CreateSurvey_Survey survey = new CreateSurveyResponse.CreateSurvey_Survey();
			survey.Id = _ctx.StringValue("CreateSurvey.Survey.Id");
			survey.ScenarioUuid = _ctx.StringValue("CreateSurvey.Survey.ScenarioUuid");
			survey.Name = _ctx.StringValue("CreateSurvey.Survey.Name");
			survey.Description = _ctx.StringValue("CreateSurvey.Survey.Description");
			survey.Role = _ctx.StringValue("CreateSurvey.Survey.Role");
			survey.Round = _ctx.IntegerValue("CreateSurvey.Survey.Round");
			survey.HotWords = _ctx.StringValue("CreateSurvey.Survey.HotWords");
			survey.SpeechOptimizationParam = _ctx.StringValue("CreateSurvey.Survey.SpeechOptimizationParam");
			survey.GlobalQuestions = _ctx.StringValue("CreateSurvey.Survey.GlobalQuestions");

			CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_Flow flow = new CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_Flow();
			flow.FlowId = _ctx.StringValue("CreateSurvey.Survey.Flow.FlowId");
			flow.IsPublished = _ctx.BooleanValue("CreateSurvey.Survey.Flow.IsPublished");
			flow.FlowJson = _ctx.StringValue("CreateSurvey.Survey.Flow.FlowJson");
			survey.Flow = flow;

			CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_AsrCustomModel asrCustomModel = new CreateSurveyResponse.CreateSurvey_Survey.CreateSurvey_AsrCustomModel();
			asrCustomModel.Corpora = _ctx.StringValue("CreateSurvey.Survey.AsrCustomModel.Corpora");
			asrCustomModel.CustomModelStatus = _ctx.IntegerValue("CreateSurvey.Survey.AsrCustomModel.CustomModelStatus");
			survey.AsrCustomModel = asrCustomModel;
			createSurveyResponse.Survey = survey;
        
			return createSurveyResponse;
        }
    }
}
