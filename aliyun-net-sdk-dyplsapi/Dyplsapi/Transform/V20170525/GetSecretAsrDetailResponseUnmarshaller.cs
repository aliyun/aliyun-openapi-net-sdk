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
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Aliyun.Acs.Dyplsapi.Transform.V20170525
{
    public class GetSecretAsrDetailResponseUnmarshaller
    {
        public static GetSecretAsrDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSecretAsrDetailResponse getSecretAsrDetailResponse = new GetSecretAsrDetailResponse();

			getSecretAsrDetailResponse.HttpResponse = _ctx.HttpResponse;
			getSecretAsrDetailResponse.Code = _ctx.StringValue("GetSecretAsrDetail.Code");
			getSecretAsrDetailResponse.Message = _ctx.StringValue("GetSecretAsrDetail.Message");
			getSecretAsrDetailResponse.RequestId = _ctx.StringValue("GetSecretAsrDetail.RequestId");

			GetSecretAsrDetailResponse.GetSecretAsrDetail_Data data = new GetSecretAsrDetailResponse.GetSecretAsrDetail_Data();
			data.RequestId = _ctx.StringValue("GetSecretAsrDetail.Data.RequestId");
			data.BusinessId = _ctx.StringValue("GetSecretAsrDetail.Data.BusinessId");
			data.BusinessKey = _ctx.StringValue("GetSecretAsrDetail.Data.BusinessKey");
			data.Code = _ctx.StringValue("GetSecretAsrDetail.Data.Code");
			data.Msg = _ctx.StringValue("GetSecretAsrDetail.Data.Msg");
			data.BizDuration = _ctx.LongValue("GetSecretAsrDetail.Data.BizDuration");
			data.Type = _ctx.StringValue("GetSecretAsrDetail.Data.Type");

			List<GetSecretAsrDetailResponse.GetSecretAsrDetail_Data.GetSecretAsrDetail_SecretAsrSentenceDTO> data_sentences = new List<GetSecretAsrDetailResponse.GetSecretAsrDetail_Data.GetSecretAsrDetail_SecretAsrSentenceDTO>();
			for (int i = 0; i < _ctx.Length("GetSecretAsrDetail.Data.Sentences.Length"); i++) {
				GetSecretAsrDetailResponse.GetSecretAsrDetail_Data.GetSecretAsrDetail_SecretAsrSentenceDTO secretAsrSentenceDTO = new GetSecretAsrDetailResponse.GetSecretAsrDetail_Data.GetSecretAsrDetail_SecretAsrSentenceDTO();
				secretAsrSentenceDTO.EndTime = _ctx.LongValue("GetSecretAsrDetail.Data.Sentences["+ i +"].EndTime");
				secretAsrSentenceDTO.SilenceDuration = _ctx.LongValue("GetSecretAsrDetail.Data.Sentences["+ i +"].SilenceDuration");
				secretAsrSentenceDTO.BeginTime = _ctx.LongValue("GetSecretAsrDetail.Data.Sentences["+ i +"].BeginTime");
				secretAsrSentenceDTO.Text = _ctx.StringValue("GetSecretAsrDetail.Data.Sentences["+ i +"].Text");
				secretAsrSentenceDTO.ChannelId = _ctx.IntegerValue("GetSecretAsrDetail.Data.Sentences["+ i +"].ChannelId");
				secretAsrSentenceDTO.SpeechRate = _ctx.IntegerValue("GetSecretAsrDetail.Data.Sentences["+ i +"].SpeechRate");
				secretAsrSentenceDTO.EmotionValue = _ctx.StringValue("GetSecretAsrDetail.Data.Sentences["+ i +"].EmotionValue");

				data_sentences.Add(secretAsrSentenceDTO);
			}
			data.Sentences = data_sentences;
			getSecretAsrDetailResponse.Data = data;
        
			return getSecretAsrDetailResponse;
        }
    }
}
