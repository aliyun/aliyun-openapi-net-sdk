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
    public class QueryTenantInfoResponseUnmarshaller
    {
        public static QueryTenantInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTenantInfoResponse queryTenantInfoResponse = new QueryTenantInfoResponse();

			queryTenantInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryTenantInfoResponse.Code = _ctx.StringValue("QueryTenantInfo.Code");
			queryTenantInfoResponse.RequestId = _ctx.StringValue("QueryTenantInfo.RequestId");
			queryTenantInfoResponse.Success = _ctx.BooleanValue("QueryTenantInfo.Success");
			queryTenantInfoResponse.Message = _ctx.StringValue("QueryTenantInfo.Message");

			QueryTenantInfoResponse.QueryTenantInfo_Model model = new QueryTenantInfoResponse.QueryTenantInfo_Model();
			model.CreateTime = _ctx.LongValue("QueryTenantInfo.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QueryTenantInfo.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QueryTenantInfo.Model.TenantId");
			model.Business = _ctx.StringValue("QueryTenantInfo.Model.Business");
			model.TenantName = _ctx.StringValue("QueryTenantInfo.Model.TenantName");
			model.TenantDescription = _ctx.StringValue("QueryTenantInfo.Model.TenantDescription");
			model.Status = _ctx.StringValue("QueryTenantInfo.Model.Status");
			model.SettleInfo = _ctx.StringValue("QueryTenantInfo.Model.SettleInfo");
			model.ExtInfo = _ctx.StringValue("QueryTenantInfo.Model.ExtInfo");
			model.Version = _ctx.LongValue("QueryTenantInfo.Model.Version");
			queryTenantInfoResponse.Model = model;
        
			return queryTenantInfoResponse;
        }
    }
}
