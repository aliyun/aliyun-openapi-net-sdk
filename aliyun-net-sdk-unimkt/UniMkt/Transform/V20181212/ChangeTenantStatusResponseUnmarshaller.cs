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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ChangeTenantStatusResponseUnmarshaller
    {
        public static ChangeTenantStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChangeTenantStatusResponse changeTenantStatusResponse = new ChangeTenantStatusResponse();

			changeTenantStatusResponse.HttpResponse = _ctx.HttpResponse;
			changeTenantStatusResponse.Code = _ctx.StringValue("ChangeTenantStatus.Code");
			changeTenantStatusResponse.Success = _ctx.BooleanValue("ChangeTenantStatus.Success");
			changeTenantStatusResponse.Message = _ctx.StringValue("ChangeTenantStatus.Message");
			changeTenantStatusResponse.RequestId = _ctx.StringValue("ChangeTenantStatus.RequestId");

			ChangeTenantStatusResponse.ChangeTenantStatus_Model model = new ChangeTenantStatusResponse.ChangeTenantStatus_Model();
			model.CreateTime = _ctx.LongValue("ChangeTenantStatus.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ChangeTenantStatus.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ChangeTenantStatus.Model.TenantId");
			model.TenantName = _ctx.StringValue("ChangeTenantStatus.Model.TenantName");
			model.Business = _ctx.StringValue("ChangeTenantStatus.Model.Business");
			model.TenantDescription = _ctx.StringValue("ChangeTenantStatus.Model.TenantDescription");
			model.UserName = _ctx.StringValue("ChangeTenantStatus.Model.UserName");
			model.SettleInfo = _ctx.StringValue("ChangeTenantStatus.Model.SettleInfo");
			model.ExtInfo = _ctx.StringValue("ChangeTenantStatus.Model.ExtInfo");
			model.Status = _ctx.StringValue("ChangeTenantStatus.Model.Status");
			changeTenantStatusResponse.Model = model;
        
			return changeTenantStatusResponse;
        }
    }
}
