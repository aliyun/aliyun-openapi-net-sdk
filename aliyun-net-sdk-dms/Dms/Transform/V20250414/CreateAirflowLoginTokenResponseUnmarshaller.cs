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
using Aliyun.Acs.Dms.Model.V20250414;

namespace Aliyun.Acs.Dms.Transform.V20250414
{
    public class CreateAirflowLoginTokenResponseUnmarshaller
    {
        public static CreateAirflowLoginTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAirflowLoginTokenResponse createAirflowLoginTokenResponse = new CreateAirflowLoginTokenResponse();

			createAirflowLoginTokenResponse.HttpResponse = _ctx.HttpResponse;
			createAirflowLoginTokenResponse.RequestId = _ctx.StringValue("CreateAirflowLoginToken.RequestId");
			createAirflowLoginTokenResponse.HttpStatusCode = _ctx.IntegerValue("CreateAirflowLoginToken.HttpStatusCode");
			createAirflowLoginTokenResponse.Success = _ctx.BooleanValue("CreateAirflowLoginToken.Success");
			createAirflowLoginTokenResponse.Message = _ctx.StringValue("CreateAirflowLoginToken.Message");
			createAirflowLoginTokenResponse.ErrorCode = _ctx.StringValue("CreateAirflowLoginToken.ErrorCode");
			createAirflowLoginTokenResponse.Code = _ctx.StringValue("CreateAirflowLoginToken.Code");

			CreateAirflowLoginTokenResponse.CreateAirflowLoginToken_Data data = new CreateAirflowLoginTokenResponse.CreateAirflowLoginToken_Data();
			data.Token = _ctx.StringValue("CreateAirflowLoginToken.Data.Token");
			data.Host = _ctx.StringValue("CreateAirflowLoginToken.Data.Host");
			createAirflowLoginTokenResponse.Data = data;
        
			return createAirflowLoginTokenResponse;
        }
    }
}
