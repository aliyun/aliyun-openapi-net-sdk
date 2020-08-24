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
        public static GetDevopsProjectInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetDevopsProjectInfoResponse getDevopsProjectInfoResponse = new GetDevopsProjectInfoResponse();

			getDevopsProjectInfoResponse.HttpResponse = context.HttpResponse;
			getDevopsProjectInfoResponse.Successful = context.BooleanValue("GetDevopsProjectInfo.Successful");
			getDevopsProjectInfoResponse.ErrorCode = context.StringValue("GetDevopsProjectInfo.ErrorCode");
			getDevopsProjectInfoResponse.ErrorMsg = context.StringValue("GetDevopsProjectInfo.ErrorMsg");
			getDevopsProjectInfoResponse.RequestId = context.StringValue("GetDevopsProjectInfo.RequestId");

			GetDevopsProjectInfoResponse.GetDevopsProjectInfo__Object _object = new GetDevopsProjectInfoResponse.GetDevopsProjectInfo__Object();
			_object.RootCollectionId = context.StringValue("GetDevopsProjectInfo.Object.RootCollectionId");
			_object.EndDate = context.StringValue("GetDevopsProjectInfo.Object.EndDate");
			_object.IsArchived = context.BooleanValue("GetDevopsProjectInfo.Object.IsArchived");
			_object.ModifierId = context.StringValue("GetDevopsProjectInfo.Object.ModifierId");
			_object.SourceId = context.StringValue("GetDevopsProjectInfo.Object.SourceId");
			_object.Description = context.StringValue("GetDevopsProjectInfo.Object.Description");
			_object.Py = context.StringValue("GetDevopsProjectInfo.Object.Py");
			_object.DefaultRoleId = context.StringValue("GetDevopsProjectInfo.Object.DefaultRoleId");
			_object.Customfields = context.StringValue("GetDevopsProjectInfo.Object.Customfields");
			_object.IsDeleted = context.BooleanValue("GetDevopsProjectInfo.Object.IsDeleted");
			_object.UniqueIdPrefix = context.StringValue("GetDevopsProjectInfo.Object.UniqueIdPrefix");
			_object.NextTaskUniqueId = context.IntegerValue("GetDevopsProjectInfo.Object.NextTaskUniqueId");
			_object.CreatorId = context.StringValue("GetDevopsProjectInfo.Object.CreatorId");
			_object.Logo = context.StringValue("GetDevopsProjectInfo.Object.Logo");
			_object.DefaultCollectionId = context.StringValue("GetDevopsProjectInfo.Object.DefaultCollectionId");
			_object.IsSuspended = context.BooleanValue("GetDevopsProjectInfo.Object.IsSuspended");
			_object.Visibility = context.StringValue("GetDevopsProjectInfo.Object.Visibility");
			_object.NormalType = context.StringValue("GetDevopsProjectInfo.Object.NormalType");
			_object.Created = context.StringValue("GetDevopsProjectInfo.Object.Created");
			_object.OrganizationId = context.StringValue("GetDevopsProjectInfo.Object.OrganizationId");
			_object.SortMethod = context.StringValue("GetDevopsProjectInfo.Object.SortMethod");
			_object.Pinyin = context.StringValue("GetDevopsProjectInfo.Object.Pinyin");
			_object.SourceType = context.StringValue("GetDevopsProjectInfo.Object.SourceType");
			_object.IsTemplate = context.BooleanValue("GetDevopsProjectInfo.Object.IsTemplate");
			_object.Name = context.StringValue("GetDevopsProjectInfo.Object.Name");
			_object.Id = context.StringValue("GetDevopsProjectInfo.Object.Id");
			_object.Category = context.StringValue("GetDevopsProjectInfo.Object.Category");
			_object.Updated = context.StringValue("GetDevopsProjectInfo.Object.Updated");
			_object.StartDate = context.StringValue("GetDevopsProjectInfo.Object.StartDate");
			getDevopsProjectInfoResponse._Object = _object;
        
			return getDevopsProjectInfoResponse;
        }
    }
}
