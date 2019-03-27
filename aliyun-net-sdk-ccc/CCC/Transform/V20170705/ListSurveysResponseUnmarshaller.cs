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
    public class ListSurveysResponseUnmarshaller
    {
        public static ListSurveysResponse Unmarshall(UnmarshallerContext context)
        {
			ListSurveysResponse listSurveysResponse = new ListSurveysResponse();

			listSurveysResponse.HttpResponse = context.HttpResponse;
			listSurveysResponse.RequestId = context.StringValue("ListSurveys.RequestId");
			listSurveysResponse.Success = context.BooleanValue("ListSurveys.Success");
			listSurveysResponse.Code = context.StringValue("ListSurveys.Code");
			listSurveysResponse.Message = context.StringValue("ListSurveys.Message");
			listSurveysResponse.HttpStatusCode = context.IntegerValue("ListSurveys.HttpStatusCode");

			List<ListSurveysResponse.ListSurveys_Survey> listSurveysResponse_surveys = new List<ListSurveysResponse.ListSurveys_Survey>();
			for (int i = 0; i < context.Length("ListSurveys.Surveys.Length"); i++) {
				ListSurveysResponse.ListSurveys_Survey survey = new ListSurveysResponse.ListSurveys_Survey();
				survey.Id = context.StringValue("ListSurveys.Surveys["+ i +"].Id");
				survey.ScenarioUuid = context.StringValue("ListSurveys.Surveys["+ i +"].ScenarioUuid");
				survey.Name = context.StringValue("ListSurveys.Surveys["+ i +"].Name");
				survey.Description = context.StringValue("ListSurveys.Surveys["+ i +"].Description");
				survey.Role = context.StringValue("ListSurveys.Surveys["+ i +"].Role");
				survey.Round = context.IntegerValue("ListSurveys.Surveys["+ i +"].Round");
				survey.HotWords = context.StringValue("ListSurveys.Surveys["+ i +"].HotWords");
				survey.SpeechOptimizationParam = context.StringValue("ListSurveys.Surveys["+ i +"].SpeechOptimizationParam");
				survey.GlobalQuestions = context.StringValue("ListSurveys.Surveys["+ i +"].GlobalQuestions");

				ListSurveysResponse.ListSurveys_Survey.ListSurveys_Flow flow = new ListSurveysResponse.ListSurveys_Survey.ListSurveys_Flow();
				flow.FlowId = context.StringValue("ListSurveys.Surveys["+ i +"].Flow.FlowId");
				flow.IsPublished = context.BooleanValue("ListSurveys.Surveys["+ i +"].Flow.IsPublished");
				flow.FlowJson = context.StringValue("ListSurveys.Surveys["+ i +"].Flow.FlowJson");
				survey.Flow = flow;

				ListSurveysResponse.ListSurveys_Survey.ListSurveys_AsrCustomModel asrCustomModel = new ListSurveysResponse.ListSurveys_Survey.ListSurveys_AsrCustomModel();
				asrCustomModel.Corpora = context.StringValue("ListSurveys.Surveys["+ i +"].AsrCustomModel.Corpora");
				asrCustomModel.CustomModelStatus = context.IntegerValue("ListSurveys.Surveys["+ i +"].AsrCustomModel.CustomModelStatus");
				survey.AsrCustomModel = asrCustomModel;

				listSurveysResponse_surveys.Add(survey);
			}
			listSurveysResponse.Surveys = listSurveysResponse_surveys;
        
			return listSurveysResponse;
        }
    }
}
