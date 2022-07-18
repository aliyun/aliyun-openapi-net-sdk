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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class QueryLayoutDetailResponseUnmarshaller
    {
        public static QueryLayoutDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryLayoutDetailResponse queryLayoutDetailResponse = new QueryLayoutDetailResponse();

			queryLayoutDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryLayoutDetailResponse.RequestId = _ctx.StringValue("QueryLayoutDetail.RequestId");
			queryLayoutDetailResponse.Success = _ctx.BooleanValue("QueryLayoutDetail.Success");
			queryLayoutDetailResponse.Message = _ctx.StringValue("QueryLayoutDetail.Message");
			queryLayoutDetailResponse.ErrorCode = _ctx.StringValue("QueryLayoutDetail.ErrorCode");
			queryLayoutDetailResponse.ErrorMessage = _ctx.StringValue("QueryLayoutDetail.ErrorMessage");
			queryLayoutDetailResponse.Code = _ctx.StringValue("QueryLayoutDetail.Code");
			queryLayoutDetailResponse.DynamicCode = _ctx.StringValue("QueryLayoutDetail.DynamicCode");
			queryLayoutDetailResponse.DynamicMessage = _ctx.StringValue("QueryLayoutDetail.DynamicMessage");
			queryLayoutDetailResponse.LayoutId = _ctx.LongValue("QueryLayoutDetail.LayoutId");
			queryLayoutDetailResponse.LayoutName = _ctx.StringValue("QueryLayoutDetail.LayoutName");
			queryLayoutDetailResponse.Description = _ctx.StringValue("QueryLayoutDetail.Description");
			queryLayoutDetailResponse.LayoutTemplateId = _ctx.LongValue("QueryLayoutDetail.LayoutTemplateId");
			queryLayoutDetailResponse.EslModelId = _ctx.StringValue("QueryLayoutDetail.EslModelId");
			queryLayoutDetailResponse.TemplateVersion = _ctx.StringValue("QueryLayoutDetail.TemplateVersion");
			queryLayoutDetailResponse.BrandId = _ctx.StringValue("QueryLayoutDetail.BrandId");
        
			return queryLayoutDetailResponse;
        }
    }
}
