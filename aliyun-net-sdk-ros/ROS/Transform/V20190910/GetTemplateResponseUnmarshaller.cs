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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class GetTemplateResponseUnmarshaller
    {
        public static GetTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTemplateResponse getTemplateResponse = new GetTemplateResponse();

			getTemplateResponse.HttpResponse = _ctx.HttpResponse;
			getTemplateResponse.RequestId = _ctx.StringValue("GetTemplate.RequestId");
			getTemplateResponse.TemplateBody = _ctx.StringValue("GetTemplate.TemplateBody");
			getTemplateResponse.StackId = _ctx.StringValue("GetTemplate.StackId");
			getTemplateResponse.TemplateId = _ctx.StringValue("GetTemplate.TemplateId");
			getTemplateResponse.StackGroupName = _ctx.StringValue("GetTemplate.StackGroupName");
			getTemplateResponse.ChangeSetId = _ctx.StringValue("GetTemplate.ChangeSetId");
			getTemplateResponse.RegionId = _ctx.StringValue("GetTemplate.RegionId");
			getTemplateResponse.CreateTime = _ctx.StringValue("GetTemplate.CreateTime");
			getTemplateResponse.Description = _ctx.StringValue("GetTemplate.Description");
			getTemplateResponse.TemplateName = _ctx.StringValue("GetTemplate.TemplateName");
			getTemplateResponse.UpdateTime = _ctx.StringValue("GetTemplate.UpdateTime");
			getTemplateResponse.TemplateVersion = _ctx.StringValue("GetTemplate.TemplateVersion");
			getTemplateResponse.ShareType = _ctx.StringValue("GetTemplate.ShareType");
			getTemplateResponse.OwnerId = _ctx.StringValue("GetTemplate.OwnerId");
			getTemplateResponse.TemplateARN = _ctx.StringValue("GetTemplate.TemplateARN");

			List<GetTemplateResponse.GetTemplate_Permission> getTemplateResponse_permissions = new List<GetTemplateResponse.GetTemplate_Permission>();
			for (int i = 0; i < _ctx.Length("GetTemplate.Permissions.Length"); i++) {
				GetTemplateResponse.GetTemplate_Permission permission = new GetTemplateResponse.GetTemplate_Permission();
				permission.ShareOption = _ctx.StringValue("GetTemplate.Permissions["+ i +"].ShareOption");
				permission.VersionOption = _ctx.StringValue("GetTemplate.Permissions["+ i +"].VersionOption");
				permission.TemplateVersion = _ctx.StringValue("GetTemplate.Permissions["+ i +"].TemplateVersion");
				permission.AccountId = _ctx.StringValue("GetTemplate.Permissions["+ i +"].AccountId");

				getTemplateResponse_permissions.Add(permission);
			}
			getTemplateResponse.Permissions = getTemplateResponse_permissions;
        
			return getTemplateResponse;
        }
    }
}
