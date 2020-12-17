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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class ValidateRoleSetResponseUnmarshaller
    {
        public static ValidateRoleSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateRoleSetResponse validateRoleSetResponse = new ValidateRoleSetResponse();

			validateRoleSetResponse.HttpResponse = _ctx.HttpResponse;
			validateRoleSetResponse.RequestId = _ctx.StringValue("ValidateRoleSet.RequestId");
			validateRoleSetResponse.Success = _ctx.BooleanValue("ValidateRoleSet.Success");
			validateRoleSetResponse.Code = _ctx.StringValue("ValidateRoleSet.Code");
			validateRoleSetResponse.Message = _ctx.StringValue("ValidateRoleSet.Message");

			List<ValidateRoleSetResponse.ValidateRoleSet_SentenceResult> validateRoleSetResponse_data = new List<ValidateRoleSetResponse.ValidateRoleSet_SentenceResult>();
			for (int i = 0; i < _ctx.Length("ValidateRoleSet.Data.Length"); i++) {
				ValidateRoleSetResponse.ValidateRoleSet_SentenceResult sentenceResult = new ValidateRoleSetResponse.ValidateRoleSet_SentenceResult();
				sentenceResult.BeginTime = _ctx.LongValue("ValidateRoleSet.Data["+ i +"].BeginTime");
				sentenceResult.ChannelId = _ctx.IntegerValue("ValidateRoleSet.Data["+ i +"].ChannelId");
				sentenceResult.EndTime = _ctx.LongValue("ValidateRoleSet.Data["+ i +"].EndTime");
				sentenceResult.Text = _ctx.StringValue("ValidateRoleSet.Data["+ i +"].Text");
				sentenceResult.EmotionValue = _ctx.IntegerValue("ValidateRoleSet.Data["+ i +"].EmotionValue");
				sentenceResult.SilenceDuration = _ctx.IntegerValue("ValidateRoleSet.Data["+ i +"].SilenceDuration");
				sentenceResult.SpeechRate = _ctx.IntegerValue("ValidateRoleSet.Data["+ i +"].SpeechRate");

				validateRoleSetResponse_data.Add(sentenceResult);
			}
			validateRoleSetResponse.Data = validateRoleSetResponse_data;
        
			return validateRoleSetResponse;
        }
    }
}
