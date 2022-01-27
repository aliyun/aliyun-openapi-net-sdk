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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class RunMedQAResponseUnmarshaller
    {
        public static RunMedQAResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RunMedQAResponse runMedQAResponse = new RunMedQAResponse();

			runMedQAResponse.HttpResponse = _ctx.HttpResponse;
			runMedQAResponse.Message = _ctx.StringValue("RunMedQA.Message");
			runMedQAResponse.RequestId = _ctx.StringValue("RunMedQA.RequestId");
			runMedQAResponse.Code = _ctx.StringValue("RunMedQA.Code");

			RunMedQAResponse.RunMedQA_Data data = new RunMedQAResponse.RunMedQA_Data();
			data.Reports = _ctx.StringValue("RunMedQA.Data.Reports");
			data.QuestionType = _ctx.StringValue("RunMedQA.Data.QuestionType");
			data.AnswerType = _ctx.StringValue("RunMedQA.Data.AnswerType");
			data.Question = _ctx.StringValue("RunMedQA.Data.Question");
			data.SessionId = _ctx.StringValue("RunMedQA.Data.SessionId");

			List<string> data_options = new List<string>();
			for (int i = 0; i < _ctx.Length("RunMedQA.Data.Options.Length"); i++) {
				data_options.Add(_ctx.StringValue("RunMedQA.Data.Options["+ i +"]"));
			}
			data.Options = data_options;
			runMedQAResponse.Data = data;
        
			return runMedQAResponse;
        }
    }
}
