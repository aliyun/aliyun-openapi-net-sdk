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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListGlobalQuestionsResponseUnmarshaller
    {
        public static ListGlobalQuestionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListGlobalQuestionsResponse listGlobalQuestionsResponse = new ListGlobalQuestionsResponse();

			listGlobalQuestionsResponse.HttpResponse = context.HttpResponse;
			listGlobalQuestionsResponse.RequestId = context.StringValue("ListGlobalQuestions.RequestId");
			listGlobalQuestionsResponse.Success = context.BooleanValue("ListGlobalQuestions.Success");
			listGlobalQuestionsResponse.Code = context.StringValue("ListGlobalQuestions.Code");
			listGlobalQuestionsResponse.Message = context.StringValue("ListGlobalQuestions.Message");
			listGlobalQuestionsResponse.HttpStatusCode = context.IntegerValue("ListGlobalQuestions.HttpStatusCode");

			ListGlobalQuestionsResponse.ListGlobalQuestions_GlobalQuestions globalQuestions = new ListGlobalQuestionsResponse.ListGlobalQuestions_GlobalQuestions();
			globalQuestions.TotalCount = context.IntegerValue("ListGlobalQuestions.GlobalQuestions.TotalCount");
			globalQuestions.PageNumber = context.IntegerValue("ListGlobalQuestions.GlobalQuestions.PageNumber");
			globalQuestions.PageSize = context.IntegerValue("ListGlobalQuestions.GlobalQuestions.PageSize");

			List<ListGlobalQuestionsResponse.ListGlobalQuestions_GlobalQuestions.ListGlobalQuestions_GlobalQuestion> globalQuestions_list = new List<ListGlobalQuestionsResponse.ListGlobalQuestions_GlobalQuestions.ListGlobalQuestions_GlobalQuestion>();
			for (int i = 0; i < context.Length("ListGlobalQuestions.GlobalQuestions.List.Length"); i++) {
				ListGlobalQuestionsResponse.ListGlobalQuestions_GlobalQuestions.ListGlobalQuestions_GlobalQuestion globalQuestion = new ListGlobalQuestionsResponse.ListGlobalQuestions_GlobalQuestions.ListGlobalQuestions_GlobalQuestion();
				globalQuestion.GlobalQuestionId = context.StringValue("ListGlobalQuestions.GlobalQuestions.List["+ i +"].GlobalQuestionId");
				globalQuestion.ScriptId = context.StringValue("ListGlobalQuestions.GlobalQuestions.List["+ i +"].ScriptId");
				globalQuestion.GlobalQuestionName = context.StringValue("ListGlobalQuestions.GlobalQuestions.List["+ i +"].GlobalQuestionName");
				globalQuestion.GlobalQuestionType = context.StringValue("ListGlobalQuestions.GlobalQuestions.List["+ i +"].GlobalQuestionType");
				globalQuestion.Questions = context.StringValue("ListGlobalQuestions.GlobalQuestions.List["+ i +"].Questions");
				globalQuestion.Answers = context.StringValue("ListGlobalQuestions.GlobalQuestions.List["+ i +"].Answers");

				globalQuestions_list.Add(globalQuestion);
			}
			globalQuestions.List = globalQuestions_list;
			listGlobalQuestionsResponse.GlobalQuestions = globalQuestions;
        
			return listGlobalQuestionsResponse;
        }
    }
}
