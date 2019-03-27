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
        public static GetSurveyResponse Unmarshall(UnmarshallerContext context)
        {
			GetSurveyResponse getSurveyResponse = new GetSurveyResponse();

			getSurveyResponse.HttpResponse = context.HttpResponse;
			getSurveyResponse.RequestId = context.StringValue("GetSurvey.RequestId");
			getSurveyResponse.Success = context.BooleanValue("GetSurvey.Success");
			getSurveyResponse.Code = context.StringValue("GetSurvey.Code");
			getSurveyResponse.Message = context.StringValue("GetSurvey.Message");
			getSurveyResponse.HttpStatusCode = context.IntegerValue("GetSurvey.HttpStatusCode");

			GetSurveyResponse.GetSurvey_Survey survey = new GetSurveyResponse.GetSurvey_Survey();
			survey.Id = context.StringValue("GetSurvey.Survey.Id");
			survey.ScenarioUuid = context.StringValue("GetSurvey.Survey.ScenarioUuid");
			survey.Name = context.StringValue("GetSurvey.Survey.Name");
			survey.Description = context.StringValue("GetSurvey.Survey.Description");
			survey.Role = context.StringValue("GetSurvey.Survey.Role");
			survey.Round = context.IntegerValue("GetSurvey.Survey.Round");
			survey.HotWords = context.StringValue("GetSurvey.Survey.HotWords");
			survey.SpeechOptimizationParam = context.StringValue("GetSurvey.Survey.SpeechOptimizationParam");
			survey.GlobalQuestions = context.StringValue("GetSurvey.Survey.GlobalQuestions");

			GetSurveyResponse.GetSurvey_Survey.GetSurvey_Flow flow = new GetSurveyResponse.GetSurvey_Survey.GetSurvey_Flow();
			flow.FlowId = context.StringValue("GetSurvey.Survey.Flow.FlowId");
			flow.IsPublished = context.BooleanValue("GetSurvey.Survey.Flow.IsPublished");
			flow.FlowJson = context.StringValue("GetSurvey.Survey.Flow.FlowJson");
			survey.Flow = flow;

			GetSurveyResponse.GetSurvey_Survey.GetSurvey_AsrCustomModel asrCustomModel = new GetSurveyResponse.GetSurvey_Survey.GetSurvey_AsrCustomModel();
			asrCustomModel.Corpora = context.StringValue("GetSurvey.Survey.AsrCustomModel.Corpora");
			asrCustomModel.CustomModelStatus = context.IntegerValue("GetSurvey.Survey.AsrCustomModel.CustomModelStatus");
			survey.AsrCustomModel = asrCustomModel;
			getSurveyResponse.Survey = survey;
        
			return getSurveyResponse;
        }
    }
}
