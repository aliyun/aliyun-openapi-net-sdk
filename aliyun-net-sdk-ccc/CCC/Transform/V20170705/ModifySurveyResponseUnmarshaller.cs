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
    public class ModifySurveyResponseUnmarshaller
    {
        public static ModifySurveyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySurveyResponse modifySurveyResponse = new ModifySurveyResponse();

			modifySurveyResponse.HttpResponse = _ctx.HttpResponse;
			modifySurveyResponse.RequestId = _ctx.StringValue("ModifySurvey.RequestId");
			modifySurveyResponse.Success = _ctx.BooleanValue("ModifySurvey.Success");
			modifySurveyResponse.Code = _ctx.StringValue("ModifySurvey.Code");
			modifySurveyResponse.Message = _ctx.StringValue("ModifySurvey.Message");
			modifySurveyResponse.HttpStatusCode = _ctx.IntegerValue("ModifySurvey.HttpStatusCode");

			ModifySurveyResponse.ModifySurvey_Survey survey = new ModifySurveyResponse.ModifySurvey_Survey();
			survey.Id = _ctx.StringValue("ModifySurvey.Survey.Id");
			survey.ScenarioUuid = _ctx.StringValue("ModifySurvey.Survey.ScenarioUuid");
			survey.Name = _ctx.StringValue("ModifySurvey.Survey.Name");
			survey.Description = _ctx.StringValue("ModifySurvey.Survey.Description");
			survey.Role = _ctx.StringValue("ModifySurvey.Survey.Role");
			survey.Round = _ctx.IntegerValue("ModifySurvey.Survey.Round");
			survey.HotWords = _ctx.StringValue("ModifySurvey.Survey.HotWords");
			survey.SpeechOptimizationParam = _ctx.StringValue("ModifySurvey.Survey.SpeechOptimizationParam");
			survey.GlobalQuestions = _ctx.StringValue("ModifySurvey.Survey.GlobalQuestions");

			ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_Flow flow = new ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_Flow();
			flow.FlowId = _ctx.StringValue("ModifySurvey.Survey.Flow.FlowId");
			flow.IsPublished = _ctx.BooleanValue("ModifySurvey.Survey.Flow.IsPublished");
			flow.FlowJson = _ctx.StringValue("ModifySurvey.Survey.Flow.FlowJson");
			survey.Flow = flow;

			ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_AsrCustomModel asrCustomModel = new ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_AsrCustomModel();
			asrCustomModel.Corpora = _ctx.StringValue("ModifySurvey.Survey.AsrCustomModel.Corpora");
			asrCustomModel.CustomModelStatus = _ctx.IntegerValue("ModifySurvey.Survey.AsrCustomModel.CustomModelStatus");
			survey.AsrCustomModel = asrCustomModel;
			modifySurveyResponse.Survey = survey;
        
			return modifySurveyResponse;
        }
    }
}
