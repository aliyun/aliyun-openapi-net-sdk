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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class ModifyWhitelistTemplateResponseUnmarshaller
    {
        public static ModifyWhitelistTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyWhitelistTemplateResponse modifyWhitelistTemplateResponse = new ModifyWhitelistTemplateResponse();

			modifyWhitelistTemplateResponse.HttpResponse = _ctx.HttpResponse;
			modifyWhitelistTemplateResponse.RequestId = _ctx.StringValue("ModifyWhitelistTemplate.RequestId");
			modifyWhitelistTemplateResponse.Success = _ctx.BooleanValue("ModifyWhitelistTemplate.Success");
			modifyWhitelistTemplateResponse.Code = _ctx.StringValue("ModifyWhitelistTemplate.Code");
			modifyWhitelistTemplateResponse.Message = _ctx.StringValue("ModifyWhitelistTemplate.Message");
			modifyWhitelistTemplateResponse.HttpStatusCode = _ctx.IntegerValue("ModifyWhitelistTemplate.HttpStatusCode");

			ModifyWhitelistTemplateResponse.ModifyWhitelistTemplate_Data data = new ModifyWhitelistTemplateResponse.ModifyWhitelistTemplate_Data();
			data.Status = _ctx.StringValue("ModifyWhitelistTemplate.Data.Status");
			modifyWhitelistTemplateResponse.Data = data;
        
			return modifyWhitelistTemplateResponse;
        }
    }
}
