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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class ValidateExpressSyncConfigResponseUnmarshaller
    {
        public static ValidateExpressSyncConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateExpressSyncConfigResponse validateExpressSyncConfigResponse = new ValidateExpressSyncConfigResponse();

			validateExpressSyncConfigResponse.HttpResponse = _ctx.HttpResponse;
			validateExpressSyncConfigResponse.RequestId = _ctx.StringValue("ValidateExpressSyncConfig.RequestId");
			validateExpressSyncConfigResponse.Success = _ctx.BooleanValue("ValidateExpressSyncConfig.Success");
			validateExpressSyncConfigResponse.Code = _ctx.StringValue("ValidateExpressSyncConfig.Code");
			validateExpressSyncConfigResponse.Message = _ctx.StringValue("ValidateExpressSyncConfig.Message");
			validateExpressSyncConfigResponse.IsValid = _ctx.BooleanValue("ValidateExpressSyncConfig.IsValid");
			validateExpressSyncConfigResponse.ValidateMessage = _ctx.StringValue("ValidateExpressSyncConfig.ValidateMessage");
        
			return validateExpressSyncConfigResponse;
        }
    }
}
