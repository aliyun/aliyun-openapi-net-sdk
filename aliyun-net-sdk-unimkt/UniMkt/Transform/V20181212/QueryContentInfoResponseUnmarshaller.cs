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
    public class QueryContentInfoResponseUnmarshaller
    {
        public static QueryContentInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryContentInfoResponse queryContentInfoResponse = new QueryContentInfoResponse();

			queryContentInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryContentInfoResponse.RequestId = _ctx.StringValue("QueryContentInfo.RequestId");
			queryContentInfoResponse.Code = _ctx.IntegerValue("QueryContentInfo.Code");
			queryContentInfoResponse.Success = _ctx.BooleanValue("QueryContentInfo.Success");
			queryContentInfoResponse.ErrorMessage = _ctx.StringValue("QueryContentInfo.ErrorMessage");

			QueryContentInfoResponse.QueryContentInfo_Data data = new QueryContentInfoResponse.QueryContentInfo_Data();
			data.Id = _ctx.LongValue("QueryContentInfo.Data.Id");
			data.Name = _ctx.StringValue("QueryContentInfo.Data.Name");
			data.BrandUserId = _ctx.LongValue("QueryContentInfo.Data.BrandUserId");
			data.ProxyUserId = _ctx.LongValue("QueryContentInfo.Data.ProxyUserId");
			data.Status = _ctx.IntegerValue("QueryContentInfo.Data.Status");
			data.TemplateType = _ctx.StringValue("QueryContentInfo.Data.TemplateType");
			data.ChainValue = _ctx.StringValue("QueryContentInfo.Data.ChainValue");
			data.OpenScene = _ctx.IntegerValue("QueryContentInfo.Data.OpenScene");
			queryContentInfoResponse.Data = data;
        
			return queryContentInfoResponse;
        }
    }
}
