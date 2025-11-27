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
using Aliyun.Acs.AiContent.Model.V20240611;

namespace Aliyun.Acs.AiContent.Transform.V20240611
{
    public class Personalizedtxt2imgQueryInferenceJobInfoResponseUnmarshaller
    {
        public static Personalizedtxt2imgQueryInferenceJobInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Personalizedtxt2imgQueryInferenceJobInfoResponse personalizedtxt2imgQueryInferenceJobInfoResponse = new Personalizedtxt2imgQueryInferenceJobInfoResponse();

			personalizedtxt2imgQueryInferenceJobInfoResponse.HttpResponse = _ctx.HttpResponse;
			personalizedtxt2imgQueryInferenceJobInfoResponse.RequestId = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.requestId");
			personalizedtxt2imgQueryInferenceJobInfoResponse.Success = _ctx.BooleanValue("Personalizedtxt2imgQueryInferenceJobInfo.success");
			personalizedtxt2imgQueryInferenceJobInfoResponse.ErrCode = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.errCode");
			personalizedtxt2imgQueryInferenceJobInfoResponse.ErrMessage = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.errMessage");
			personalizedtxt2imgQueryInferenceJobInfoResponse.HttpStatusCode = _ctx.IntegerValue("Personalizedtxt2imgQueryInferenceJobInfo.httpStatusCode");

			Personalizedtxt2imgQueryInferenceJobInfoResponse.Personalizedtxt2imgQueryInferenceJobInfo_Data data = new Personalizedtxt2imgQueryInferenceJobInfoResponse.Personalizedtxt2imgQueryInferenceJobInfo_Data();
			data.Id = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.id");
			data.PromptId = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.promptId");
			data.ModelId = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.modelId");
			data.JobStatus = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.jobStatus");
			data.JobTrainProgress = _ctx.DoubleValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.jobTrainProgress");
			data.CreateTime = _ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.createTime");

			List<string> data_resultImageUrl = new List<string>();
			for (int i = 0; i < _ctx.Length("Personalizedtxt2imgQueryInferenceJobInfo.Data.ResultImageUrl.Length"); i++) {
				data_resultImageUrl.Add(_ctx.StringValue("Personalizedtxt2imgQueryInferenceJobInfo.Data.ResultImageUrl["+ i +"]"));
			}
			data.ResultImageUrl = data_resultImageUrl;
			personalizedtxt2imgQueryInferenceJobInfoResponse.Data = data;
        
			return personalizedtxt2imgQueryInferenceJobInfoResponse;
        }
    }
}
