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
    public class CheckTenantBizResponseUnmarshaller
    {
        public static CheckTenantBizResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckTenantBizResponse checkTenantBizResponse = new CheckTenantBizResponse();

			checkTenantBizResponse.HttpResponse = _ctx.HttpResponse;
			checkTenantBizResponse.Code = _ctx.StringValue("CheckTenantBiz.Code");
			checkTenantBizResponse.Success = _ctx.BooleanValue("CheckTenantBiz.Success");
			checkTenantBizResponse.Message = _ctx.StringValue("CheckTenantBiz.Message");
			checkTenantBizResponse.RequestId = _ctx.StringValue("CheckTenantBiz.RequestId");

			CheckTenantBizResponse.CheckTenantBiz_Model model = new CheckTenantBizResponse.CheckTenantBiz_Model();
			model.CanAccessMedia = _ctx.BooleanValue("CheckTenantBiz.Model.CanAccessMedia");
			model.CanAccessAdSlot = _ctx.BooleanValue("CheckTenantBiz.Model.CanAccessAdSlot");
			checkTenantBizResponse.Model = model;
        
			return checkTenantBizResponse;
        }
    }
}
