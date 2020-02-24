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
        public static DescribeGlobalQuestionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGlobalQuestionResponse describeGlobalQuestionResponse = new DescribeGlobalQuestionResponse();

			describeGlobalQuestionResponse.HttpResponse = context.HttpResponse;
			describeGlobalQuestionResponse.RequestId = context.StringValue("DescribeGlobalQuestion.RequestId");
			describeGlobalQuestionResponse.Success = context.BooleanValue("DescribeGlobalQuestion.Success");
			describeGlobalQuestionResponse.Code = context.StringValue("DescribeGlobalQuestion.Code");
			describeGlobalQuestionResponse.Message = context.StringValue("DescribeGlobalQuestion.Message");
			describeGlobalQuestionResponse.HttpStatusCode = context.IntegerValue("DescribeGlobalQuestion.HttpStatusCode");

			DescribeGlobalQuestionResponse.DescribeGlobalQuestion_GlobalQuestion globalQuestion = new DescribeGlobalQuestionResponse.DescribeGlobalQuestion_GlobalQuestion();
			globalQuestion.GlobalQuestionId = context.StringValue("DescribeGlobalQuestion.GlobalQuestion.GlobalQuestionId");
			globalQuestion.ScriptId = context.StringValue("DescribeGlobalQuestion.GlobalQuestion.ScriptId");
			globalQuestion.GlobalQuestionName = context.StringValue("DescribeGlobalQuestion.GlobalQuestion.GlobalQuestionName");
			globalQuestion.GlobalQuestionType = context.StringValue("DescribeGlobalQuestion.GlobalQuestion.GlobalQuestionType");
			globalQuestion.Questions = context.StringValue("DescribeGlobalQuestion.GlobalQuestion.Questions");
			globalQuestion.Answers = context.StringValue("DescribeGlobalQuestion.GlobalQuestion.Answers");
			describeGlobalQuestionResponse.GlobalQuestion = globalQuestion;
        
			return describeGlobalQuestionResponse;
        }
    }
}
