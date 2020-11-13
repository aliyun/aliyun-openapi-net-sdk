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
        public static GetGroupDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetGroupDetailResponse getGroupDetailResponse = new GetGroupDetailResponse();

			getGroupDetailResponse.HttpResponse = context.HttpResponse;
			getGroupDetailResponse.RequestId = context.StringValue("GetGroupDetail.RequestId");
			getGroupDetailResponse.ErrorCode = context.StringValue("GetGroupDetail.ErrorCode");
			getGroupDetailResponse.Success = context.BooleanValue("GetGroupDetail.Success");
			getGroupDetailResponse.ErrorMessage = context.StringValue("GetGroupDetail.ErrorMessage");

			GetGroupDetailResponse.GetGroupDetail_Result result = new GetGroupDetailResponse.GetGroupDetail_Result();
			result.Id = context.LongValue("GetGroupDetail.Result.Id");
			result.Name = context.StringValue("GetGroupDetail.Result.Name");
			result.Path = context.StringValue("GetGroupDetail.Result.Path");
			result.Description = context.StringValue("GetGroupDetail.Result.Description");
			result.AvatarUrl = context.StringValue("GetGroupDetail.Result.AvatarUrl");
			result.WebUrl = context.StringValue("GetGroupDetail.Result.WebUrl");
			result.PathWithNamespace = context.StringValue("GetGroupDetail.Result.PathWithNamespace");
			result.NameWithNamespace = context.StringValue("GetGroupDetail.Result.NameWithNamespace");
			result.Type = context.StringValue("GetGroupDetail.Result.Type");
			result.VisibilityLevel = context.StringValue("GetGroupDetail.Result.VisibilityLevel");
			result.ParentId = context.LongValue("GetGroupDetail.Result.ParentId");
			result.OwnerId = context.LongValue("GetGroupDetail.Result.OwnerId");
			getGroupDetailResponse.Result = result;
        
			return getGroupDetailResponse;
        }
    }
}
