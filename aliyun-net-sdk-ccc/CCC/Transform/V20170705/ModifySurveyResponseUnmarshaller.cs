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
        public static ModifySurveyResponse Unmarshall(UnmarshallerContext context)
        {
			ModifySurveyResponse modifySurveyResponse = new ModifySurveyResponse();

			modifySurveyResponse.HttpResponse = context.HttpResponse;
			modifySurveyResponse.RequestId = context.StringValue("ModifySurvey.RequestId");
			modifySurveyResponse.Success = context.BooleanValue("ModifySurvey.Success");
			modifySurveyResponse.Code = context.StringValue("ModifySurvey.Code");
			modifySurveyResponse.Message = context.StringValue("ModifySurvey.Message");
			modifySurveyResponse.HttpStatusCode = context.IntegerValue("ModifySurvey.HttpStatusCode");

			ModifySurveyResponse.ModifySurvey_Survey survey = new ModifySurveyResponse.ModifySurvey_Survey();
			survey.Id = context.StringValue("ModifySurvey.Survey.Id");
			survey.ScenarioUuid = context.StringValue("ModifySurvey.Survey.ScenarioUuid");
			survey.Name = context.StringValue("ModifySurvey.Survey.Name");
			survey.Description = context.StringValue("ModifySurvey.Survey.Description");
			survey.Role = context.StringValue("ModifySurvey.Survey.Role");
			survey.Round = context.IntegerValue("ModifySurvey.Survey.Round");
			survey.HotWords = context.StringValue("ModifySurvey.Survey.HotWords");
			survey.SpeechOptimizationParam = context.StringValue("ModifySurvey.Survey.SpeechOptimizationParam");
			survey.GlobalQuestions = context.StringValue("ModifySurvey.Survey.GlobalQuestions");

			ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_Flow flow = new ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_Flow();
			flow.FlowId = context.StringValue("ModifySurvey.Survey.Flow.FlowId");
			flow.IsPublished = context.BooleanValue("ModifySurvey.Survey.Flow.IsPublished");
			flow.FlowJson = context.StringValue("ModifySurvey.Survey.Flow.FlowJson");
			survey.Flow = flow;

			ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_AsrCustomModel asrCustomModel = new ModifySurveyResponse.ModifySurvey_Survey.ModifySurvey_AsrCustomModel();
			asrCustomModel.Corpora = context.StringValue("ModifySurvey.Survey.AsrCustomModel.Corpora");
			asrCustomModel.CustomModelStatus = context.IntegerValue("ModifySurvey.Survey.AsrCustomModel.CustomModelStatus");
			survey.AsrCustomModel = asrCustomModel;
			modifySurveyResponse.Survey = survey;
        
			return modifySurveyResponse;
        }
    }
}
