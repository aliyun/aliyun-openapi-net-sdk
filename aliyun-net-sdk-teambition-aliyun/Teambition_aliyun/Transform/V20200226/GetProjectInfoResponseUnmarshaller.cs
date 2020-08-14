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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class GetProjectInfoResponseUnmarshaller
    {
        public static GetProjectInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectInfoResponse getProjectInfoResponse = new GetProjectInfoResponse();

			getProjectInfoResponse.HttpResponse = context.HttpResponse;
			getProjectInfoResponse.Successful = context.BooleanValue("GetProjectInfo.Successful");
			getProjectInfoResponse.ErrorCode = context.StringValue("GetProjectInfo.ErrorCode");
			getProjectInfoResponse.ErrorMsg = context.StringValue("GetProjectInfo.ErrorMsg");
			getProjectInfoResponse.RequestId = context.StringValue("GetProjectInfo.RequestId");

			GetProjectInfoResponse.GetProjectInfo__Object _object = new GetProjectInfoResponse.GetProjectInfo__Object();
			_object.RootCollectionId = context.StringValue("GetProjectInfo.Object.RootCollectionId");
			_object.EndDate = context.StringValue("GetProjectInfo.Object.EndDate");
			_object.IsArchived = context.BooleanValue("GetProjectInfo.Object.IsArchived");
			_object.ModifierId = context.StringValue("GetProjectInfo.Object.ModifierId");
			_object.SourceId = context.StringValue("GetProjectInfo.Object.SourceId");
			_object.Description = context.StringValue("GetProjectInfo.Object.Description");
			_object.Py = context.StringValue("GetProjectInfo.Object.Py");
			_object.DefaultRoleId = context.StringValue("GetProjectInfo.Object.DefaultRoleId");
			_object.Customfields = context.StringValue("GetProjectInfo.Object.Customfields");
			_object.IsDeleted = context.BooleanValue("GetProjectInfo.Object.IsDeleted");
			_object.UniqueIdPrefix = context.StringValue("GetProjectInfo.Object.UniqueIdPrefix");
			_object.NextTaskUniqueId = context.IntegerValue("GetProjectInfo.Object.NextTaskUniqueId");
			_object.CreatorId = context.StringValue("GetProjectInfo.Object.CreatorId");
			_object.Logo = context.StringValue("GetProjectInfo.Object.Logo");
			_object.DefaultCollectionId = context.StringValue("GetProjectInfo.Object.DefaultCollectionId");
			_object.IsSuspended = context.BooleanValue("GetProjectInfo.Object.IsSuspended");
			_object.Visibility = context.StringValue("GetProjectInfo.Object.Visibility");
			_object.NormalType = context.StringValue("GetProjectInfo.Object.NormalType");
			_object.Created = context.StringValue("GetProjectInfo.Object.Created");
			_object.OrganizationId = context.StringValue("GetProjectInfo.Object.OrganizationId");
			_object.SortMethod = context.StringValue("GetProjectInfo.Object.SortMethod");
			_object.Pinyin = context.StringValue("GetProjectInfo.Object.Pinyin");
			_object.SourceType = context.StringValue("GetProjectInfo.Object.SourceType");
			_object.IsTemplate = context.BooleanValue("GetProjectInfo.Object.IsTemplate");
			_object.Name = context.StringValue("GetProjectInfo.Object.Name");
			_object.Id = context.StringValue("GetProjectInfo.Object.Id");
			_object.Category = context.StringValue("GetProjectInfo.Object.Category");
			_object.Updated = context.StringValue("GetProjectInfo.Object.Updated");
			_object.StartDate = context.StringValue("GetProjectInfo.Object.StartDate");
			getProjectInfoResponse._Object = _object;
        
			return getProjectInfoResponse;
        }
    }
}
