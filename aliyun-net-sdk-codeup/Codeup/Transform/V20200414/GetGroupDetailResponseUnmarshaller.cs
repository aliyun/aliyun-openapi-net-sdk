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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class GetGroupDetailResponseUnmarshaller
    {
        public static GetGroupDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGroupDetailResponse getGroupDetailResponse = new GetGroupDetailResponse();

			getGroupDetailResponse.HttpResponse = _ctx.HttpResponse;
			getGroupDetailResponse.RequestId = _ctx.StringValue("GetGroupDetail.RequestId");
			getGroupDetailResponse.ErrorCode = _ctx.StringValue("GetGroupDetail.ErrorCode");
			getGroupDetailResponse.Success = _ctx.BooleanValue("GetGroupDetail.Success");
			getGroupDetailResponse.ErrorMessage = _ctx.StringValue("GetGroupDetail.ErrorMessage");

			GetGroupDetailResponse.GetGroupDetail_Result result = new GetGroupDetailResponse.GetGroupDetail_Result();
			result.Id = _ctx.LongValue("GetGroupDetail.Result.Id");
			result.Name = _ctx.StringValue("GetGroupDetail.Result.Name");
			result.Path = _ctx.StringValue("GetGroupDetail.Result.Path");
			result.Description = _ctx.StringValue("GetGroupDetail.Result.Description");
			result.AvatarUrl = _ctx.StringValue("GetGroupDetail.Result.AvatarUrl");
			result.WebUrl = _ctx.StringValue("GetGroupDetail.Result.WebUrl");
			result.PathWithNamespace = _ctx.StringValue("GetGroupDetail.Result.PathWithNamespace");
			result.NameWithNamespace = _ctx.StringValue("GetGroupDetail.Result.NameWithNamespace");
			result.Type = _ctx.StringValue("GetGroupDetail.Result.Type");
			result.VisibilityLevel = _ctx.StringValue("GetGroupDetail.Result.VisibilityLevel");
			result.ParentId = _ctx.LongValue("GetGroupDetail.Result.ParentId");
			result.OwnerId = _ctx.LongValue("GetGroupDetail.Result.OwnerId");
			getGroupDetailResponse.Result = result;
        
			return getGroupDetailResponse;
        }
    }
}
