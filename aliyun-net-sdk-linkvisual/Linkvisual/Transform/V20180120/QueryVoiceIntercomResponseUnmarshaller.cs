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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryVoiceIntercomResponseUnmarshaller
    {
        public static QueryVoiceIntercomResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryVoiceIntercomResponse queryVoiceIntercomResponse = new QueryVoiceIntercomResponse();

			queryVoiceIntercomResponse.HttpResponse = _ctx.HttpResponse;
			queryVoiceIntercomResponse.Code = _ctx.StringValue("QueryVoiceIntercom.Code");
			queryVoiceIntercomResponse.RequestId = _ctx.StringValue("QueryVoiceIntercom.RequestId");
			queryVoiceIntercomResponse.ErrorMessage = _ctx.StringValue("QueryVoiceIntercom.ErrorMessage");
			queryVoiceIntercomResponse.Success = _ctx.BooleanValue("QueryVoiceIntercom.Success");

			QueryVoiceIntercomResponse.QueryVoiceIntercom_Data data = new QueryVoiceIntercomResponse.QueryVoiceIntercom_Data();
			data.Url = _ctx.StringValue("QueryVoiceIntercom.Data.Url");

			QueryVoiceIntercomResponse.QueryVoiceIntercom_Data.QueryVoiceIntercom_CryptoKey cryptoKey = new QueryVoiceIntercomResponse.QueryVoiceIntercom_Data.QueryVoiceIntercom_CryptoKey();
			cryptoKey.Key = _ctx.StringValue("QueryVoiceIntercom.Data.CryptoKey.Key");
			cryptoKey.Iv = _ctx.StringValue("QueryVoiceIntercom.Data.CryptoKey.Iv");
			data.CryptoKey = cryptoKey;
			queryVoiceIntercomResponse.Data = data;
        
			return queryVoiceIntercomResponse;
        }
    }
}
