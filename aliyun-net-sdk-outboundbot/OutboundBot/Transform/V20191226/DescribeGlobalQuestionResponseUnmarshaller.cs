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
    public class DescribeGlobalQuestionResponseUnmarshaller
    {
        public static DescribeGlobalQuestionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalQuestionResponse describeGlobalQuestionResponse = new DescribeGlobalQuestionResponse();

			describeGlobalQuestionResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalQuestionResponse.Code = _ctx.StringValue("DescribeGlobalQuestion.Code");
			describeGlobalQuestionResponse.HttpStatusCode = _ctx.IntegerValue("DescribeGlobalQuestion.HttpStatusCode");
			describeGlobalQuestionResponse.Message = _ctx.StringValue("DescribeGlobalQuestion.Message");
			describeGlobalQuestionResponse.RequestId = _ctx.StringValue("DescribeGlobalQuestion.RequestId");
			describeGlobalQuestionResponse.Success = _ctx.BooleanValue("DescribeGlobalQuestion.Success");

			DescribeGlobalQuestionResponse.DescribeGlobalQuestion_GlobalQuestion globalQuestion = new DescribeGlobalQuestionResponse.DescribeGlobalQuestion_GlobalQuestion();
			globalQuestion.Answers = _ctx.StringValue("DescribeGlobalQuestion.GlobalQuestion.Answers");
			globalQuestion.GlobalQuestionId = _ctx.StringValue("DescribeGlobalQuestion.GlobalQuestion.GlobalQuestionId");
			globalQuestion.GlobalQuestionName = _ctx.StringValue("DescribeGlobalQuestion.GlobalQuestion.GlobalQuestionName");
			globalQuestion.GlobalQuestionType = _ctx.StringValue("DescribeGlobalQuestion.GlobalQuestion.GlobalQuestionType");
			globalQuestion.Questions = _ctx.StringValue("DescribeGlobalQuestion.GlobalQuestion.Questions");
			globalQuestion.ScriptId = _ctx.StringValue("DescribeGlobalQuestion.GlobalQuestion.ScriptId");
			describeGlobalQuestionResponse.GlobalQuestion = globalQuestion;
        
			return describeGlobalQuestionResponse;
        }
    }
}
