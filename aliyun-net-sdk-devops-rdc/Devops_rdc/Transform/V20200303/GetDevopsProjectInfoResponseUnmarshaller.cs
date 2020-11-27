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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetDevopsProjectInfoResponseUnmarshaller
    {
        public static GetDevopsProjectInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDevopsProjectInfoResponse getDevopsProjectInfoResponse = new GetDevopsProjectInfoResponse();

			getDevopsProjectInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDevopsProjectInfoResponse.Successful = _ctx.BooleanValue("GetDevopsProjectInfo.Successful");
			getDevopsProjectInfoResponse.ErrorCode = _ctx.StringValue("GetDevopsProjectInfo.ErrorCode");
			getDevopsProjectInfoResponse.ErrorMsg = _ctx.StringValue("GetDevopsProjectInfo.ErrorMsg");
			getDevopsProjectInfoResponse.RequestId = _ctx.StringValue("GetDevopsProjectInfo.RequestId");

			GetDevopsProjectInfoResponse.GetDevopsProjectInfo__Object _object = new GetDevopsProjectInfoResponse.GetDevopsProjectInfo__Object();
			_object.RootCollectionId = _ctx.StringValue("GetDevopsProjectInfo.Object.RootCollectionId");
			_object.EndDate = _ctx.StringValue("GetDevopsProjectInfo.Object.EndDate");
			_object.IsArchived = _ctx.BooleanValue("GetDevopsProjectInfo.Object.IsArchived");
			_object.ModifierId = _ctx.StringValue("GetDevopsProjectInfo.Object.ModifierId");
			_object.SourceId = _ctx.StringValue("GetDevopsProjectInfo.Object.SourceId");
			_object.Description = _ctx.StringValue("GetDevopsProjectInfo.Object.Description");
			_object.Py = _ctx.StringValue("GetDevopsProjectInfo.Object.Py");
			_object.DefaultRoleId = _ctx.StringValue("GetDevopsProjectInfo.Object.DefaultRoleId");
			_object.Customfields = _ctx.StringValue("GetDevopsProjectInfo.Object.Customfields");
			_object.IsDeleted = _ctx.BooleanValue("GetDevopsProjectInfo.Object.IsDeleted");
			_object.UniqueIdPrefix = _ctx.StringValue("GetDevopsProjectInfo.Object.UniqueIdPrefix");
			_object.NextTaskUniqueId = _ctx.IntegerValue("GetDevopsProjectInfo.Object.NextTaskUniqueId");
			_object.CreatorId = _ctx.StringValue("GetDevopsProjectInfo.Object.CreatorId");
			_object.Logo = _ctx.StringValue("GetDevopsProjectInfo.Object.Logo");
			_object.DefaultCollectionId = _ctx.StringValue("GetDevopsProjectInfo.Object.DefaultCollectionId");
			_object.IsSuspended = _ctx.BooleanValue("GetDevopsProjectInfo.Object.IsSuspended");
			_object.Visibility = _ctx.StringValue("GetDevopsProjectInfo.Object.Visibility");
			_object.NormalType = _ctx.StringValue("GetDevopsProjectInfo.Object.NormalType");
			_object.Created = _ctx.StringValue("GetDevopsProjectInfo.Object.Created");
			_object.OrganizationId = _ctx.StringValue("GetDevopsProjectInfo.Object.OrganizationId");
			_object.SortMethod = _ctx.StringValue("GetDevopsProjectInfo.Object.SortMethod");
			_object.Pinyin = _ctx.StringValue("GetDevopsProjectInfo.Object.Pinyin");
			_object.SourceType = _ctx.StringValue("GetDevopsProjectInfo.Object.SourceType");
			_object.IsTemplate = _ctx.BooleanValue("GetDevopsProjectInfo.Object.IsTemplate");
			_object.Name = _ctx.StringValue("GetDevopsProjectInfo.Object.Name");
			_object.Id = _ctx.StringValue("GetDevopsProjectInfo.Object.Id");
			_object.Category = _ctx.StringValue("GetDevopsProjectInfo.Object.Category");
			_object.Updated = _ctx.StringValue("GetDevopsProjectInfo.Object.Updated");
			_object.StartDate = _ctx.StringValue("GetDevopsProjectInfo.Object.StartDate");
			getDevopsProjectInfoResponse._Object = _object;
        
			return getDevopsProjectInfoResponse;
        }
    }
}
