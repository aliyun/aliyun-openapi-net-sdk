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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class SaveUserCreditResponseUnmarshaller
    {
        public static SaveUserCreditResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveUserCreditResponse saveUserCreditResponse = new SaveUserCreditResponse();

			saveUserCreditResponse.HttpResponse = _ctx.HttpResponse;
			saveUserCreditResponse.Code = _ctx.StringValue("SaveUserCredit.Code");
			saveUserCreditResponse.Success = _ctx.BooleanValue("SaveUserCredit.Success");
			saveUserCreditResponse.RequestId = _ctx.StringValue("SaveUserCredit.RequestId");
			saveUserCreditResponse.Message = _ctx.StringValue("SaveUserCredit.Message");
        
			return saveUserCreditResponse;
        }
    }
}
