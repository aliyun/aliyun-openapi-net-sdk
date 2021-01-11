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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class ModifyDtsJobPasswordResponseUnmarshaller
    {
        public static ModifyDtsJobPasswordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDtsJobPasswordResponse modifyDtsJobPasswordResponse = new ModifyDtsJobPasswordResponse();

			modifyDtsJobPasswordResponse.HttpResponse = _ctx.HttpResponse;
			modifyDtsJobPasswordResponse.Code = _ctx.StringValue("ModifyDtsJobPassword.Code");
			modifyDtsJobPasswordResponse.DynamicMessage = _ctx.StringValue("ModifyDtsJobPassword.DynamicMessage");
			modifyDtsJobPasswordResponse.ErrCode = _ctx.StringValue("ModifyDtsJobPassword.ErrCode");
			modifyDtsJobPasswordResponse.ErrMessage = _ctx.StringValue("ModifyDtsJobPassword.ErrMessage");
			modifyDtsJobPasswordResponse.HttpStatusCode = _ctx.IntegerValue("ModifyDtsJobPassword.HttpStatusCode");
			modifyDtsJobPasswordResponse.RequestId = _ctx.StringValue("ModifyDtsJobPassword.RequestId");
			modifyDtsJobPasswordResponse.Success = _ctx.BooleanValue("ModifyDtsJobPassword.Success");
        
			return modifyDtsJobPasswordResponse;
        }
    }
}
