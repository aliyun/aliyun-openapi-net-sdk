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
    public class GetSurveyResponseUnmarshaller
    {
        public static GetSurveyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSurveyResponse getSurveyResponse = new GetSurveyResponse();

			getSurveyResponse.HttpResponse = _ctx.HttpResponse;
			getSurveyResponse.RequestId = _ctx.StringValue("GetSurvey.RequestId");
			getSurveyResponse.Success = _ctx.BooleanValue("GetSurvey.Success");
			getSurveyResponse.Code = _ctx.StringValue("GetSurvey.Code");
			getSurveyResponse.Message = _ctx.StringValue("GetSurvey.Message");
			getSurveyResponse.HttpStatusCode = _ctx.IntegerValue("GetSurvey.HttpStatusCode");

			GetSurveyResponse.GetSurvey_Survey survey = new GetSurveyResponse.GetSurvey_Survey();
			survey.Id = _ctx.StringValue("GetSurvey.Survey.Id");
			survey.ScenarioUuid = _ctx.StringValue("GetSurvey.Survey.ScenarioUuid");
			survey.Name = _ctx.StringValue("GetSurvey.Survey.Name");
			survey.Description = _ctx.StringValue("GetSurvey.Survey.Description");
			survey.Role = _ctx.StringValue("GetSurvey.Survey.Role");
			survey.Round = _ctx.IntegerValue("GetSurvey.Survey.Round");
			survey.HotWords = _ctx.StringValue("GetSurvey.Survey.HotWords");
			survey.SpeechOptimizationParam = _ctx.StringValue("GetSurvey.Survey.SpeechOptimizationParam");
			survey.GlobalQuestions = _ctx.StringValue("GetSurvey.Survey.GlobalQuestions");

			GetSurveyResponse.GetSurvey_Survey.GetSurvey_Flow flow = new GetSurveyResponse.GetSurvey_Survey.GetSurvey_Flow();
			flow.FlowId = _ctx.StringValue("GetSurvey.Survey.Flow.FlowId");
			flow.IsPublished = _ctx.BooleanValue("GetSurvey.Survey.Flow.IsPublished");
			flow.FlowJson = _ctx.StringValue("GetSurvey.Survey.Flow.FlowJson");
			survey.Flow = flow;

			GetSurveyResponse.GetSurvey_Survey.GetSurvey_AsrCustomModel asrCustomModel = new GetSurveyResponse.GetSurvey_Survey.GetSurvey_AsrCustomModel();
			asrCustomModel.Corpora = _ctx.StringValue("GetSurvey.Survey.AsrCustomModel.Corpora");
			asrCustomModel.CustomModelStatus = _ctx.IntegerValue("GetSurvey.Survey.AsrCustomModel.CustomModelStatus");
			survey.AsrCustomModel = asrCustomModel;
			getSurveyResponse.Survey = survey;
        
			return getSurveyResponse;
        }
    }
}
