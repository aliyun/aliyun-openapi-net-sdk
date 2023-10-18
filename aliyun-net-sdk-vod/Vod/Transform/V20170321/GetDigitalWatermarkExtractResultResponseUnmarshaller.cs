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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetDigitalWatermarkExtractResultResponseUnmarshaller
    {
        public static GetDigitalWatermarkExtractResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDigitalWatermarkExtractResultResponse getDigitalWatermarkExtractResultResponse = new GetDigitalWatermarkExtractResultResponse();

			getDigitalWatermarkExtractResultResponse.HttpResponse = _ctx.HttpResponse;
			getDigitalWatermarkExtractResultResponse.RequestId = _ctx.StringValue("GetDigitalWatermarkExtractResult.RequestId");

			List<GetDigitalWatermarkExtractResultResponse.GetDigitalWatermarkExtractResult_AiExtractResult> getDigitalWatermarkExtractResultResponse_aiExtractResultList = new List<GetDigitalWatermarkExtractResultResponse.GetDigitalWatermarkExtractResult_AiExtractResult>();
			for (int i = 0; i < _ctx.Length("GetDigitalWatermarkExtractResult.AiExtractResultList.Length"); i++) {
				GetDigitalWatermarkExtractResultResponse.GetDigitalWatermarkExtractResult_AiExtractResult aiExtractResult = new GetDigitalWatermarkExtractResultResponse.GetDigitalWatermarkExtractResult_AiExtractResult();
				aiExtractResult.JobId = _ctx.StringValue("GetDigitalWatermarkExtractResult.AiExtractResultList["+ i +"].JobId");
				aiExtractResult.CreateTime = _ctx.StringValue("GetDigitalWatermarkExtractResult.AiExtractResultList["+ i +"].CreateTime");
				aiExtractResult.ModifyTime = _ctx.StringValue("GetDigitalWatermarkExtractResult.AiExtractResultList["+ i +"].ModifyTime");
				aiExtractResult.Status = _ctx.StringValue("GetDigitalWatermarkExtractResult.AiExtractResultList["+ i +"].Status");
				aiExtractResult.ErrorMessage = _ctx.StringValue("GetDigitalWatermarkExtractResult.AiExtractResultList["+ i +"].ErrorMessage");
				aiExtractResult.WaterMarkText = _ctx.StringValue("GetDigitalWatermarkExtractResult.AiExtractResultList["+ i +"].WaterMarkText");

				getDigitalWatermarkExtractResultResponse_aiExtractResultList.Add(aiExtractResult);
			}
			getDigitalWatermarkExtractResultResponse.AiExtractResultList = getDigitalWatermarkExtractResultResponse_aiExtractResultList;
        
			return getDigitalWatermarkExtractResultResponse;
        }
    }
}
