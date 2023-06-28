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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class GetTranslateImageBatchResultResponseUnmarshaller
    {
        public static GetTranslateImageBatchResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTranslateImageBatchResultResponse getTranslateImageBatchResultResponse = new GetTranslateImageBatchResultResponse();

			getTranslateImageBatchResultResponse.HttpResponse = _ctx.HttpResponse;
			getTranslateImageBatchResultResponse.Code = _ctx.IntegerValue("GetTranslateImageBatchResult.Code");
			getTranslateImageBatchResultResponse.Message = _ctx.StringValue("GetTranslateImageBatchResult.Message");
			getTranslateImageBatchResultResponse.RequestId = _ctx.StringValue("GetTranslateImageBatchResult.RequestId");

			GetTranslateImageBatchResultResponse.GetTranslateImageBatchResult_Data data = new GetTranslateImageBatchResultResponse.GetTranslateImageBatchResult_Data();
			data.Status = _ctx.StringValue("GetTranslateImageBatchResult.Data.Status");

			List<GetTranslateImageBatchResultResponse.GetTranslateImageBatchResult_Data.GetTranslateImageBatchResult_CertificateImageTranslateResult> data_result = new List<GetTranslateImageBatchResultResponse.GetTranslateImageBatchResult_Data.GetTranslateImageBatchResult_CertificateImageTranslateResult>();
			for (int i = 0; i < _ctx.Length("GetTranslateImageBatchResult.Data.Result.Length"); i++) {
				GetTranslateImageBatchResultResponse.GetTranslateImageBatchResult_Data.GetTranslateImageBatchResult_CertificateImageTranslateResult certificateImageTranslateResult = new GetTranslateImageBatchResultResponse.GetTranslateImageBatchResult_Data.GetTranslateImageBatchResult_CertificateImageTranslateResult();
				certificateImageTranslateResult.InPaintingUrl = _ctx.StringValue("GetTranslateImageBatchResult.Data.Result["+ i +"].InPaintingUrl");
				certificateImageTranslateResult.FinalImageUrl = _ctx.StringValue("GetTranslateImageBatchResult.Data.Result["+ i +"].FinalImageUrl");
				certificateImageTranslateResult.TemplateJson = _ctx.StringValue("GetTranslateImageBatchResult.Data.Result["+ i +"].TemplateJson");
				certificateImageTranslateResult.SourceImageUrl = _ctx.StringValue("GetTranslateImageBatchResult.Data.Result["+ i +"].SourceImageUrl");
				certificateImageTranslateResult.Code = _ctx.IntegerValue("GetTranslateImageBatchResult.Data.Result["+ i +"].Code");
				certificateImageTranslateResult.Message = _ctx.StringValue("GetTranslateImageBatchResult.Data.Result["+ i +"].Message");
				certificateImageTranslateResult.Success = _ctx.BooleanValue("GetTranslateImageBatchResult.Data.Result["+ i +"].Success");

				data_result.Add(certificateImageTranslateResult);
			}
			data.Result = data_result;
			getTranslateImageBatchResultResponse.Data = data;
        
			return getTranslateImageBatchResultResponse;
        }
    }
}
