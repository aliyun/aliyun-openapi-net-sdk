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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class CreateApplicationGroupResponseUnmarshaller
    {
        public static CreateApplicationGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationGroupResponse createApplicationGroupResponse = new CreateApplicationGroupResponse();

			createApplicationGroupResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationGroupResponse.RequestId = _ctx.StringValue("CreateApplicationGroup.RequestId");

			CreateApplicationGroupResponse.CreateApplicationGroup_ApplicationGroup applicationGroup = new CreateApplicationGroupResponse.CreateApplicationGroup_ApplicationGroup();
			applicationGroup.CmsGroupId = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.CmsGroupId");
			applicationGroup.DeployRegionId = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.DeployRegionId");
			applicationGroup.Description = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.Description");
			applicationGroup.UpdateDate = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.UpdateDate");
			applicationGroup.ImportTagKey = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.ImportTagKey");
			applicationGroup.ApplicationName = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.ApplicationName");
			applicationGroup.ImportTagValue = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.ImportTagValue");
			applicationGroup.Name = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.Name");
			applicationGroup.CreateDate = _ctx.StringValue("CreateApplicationGroup.ApplicationGroup.CreateDate");
			createApplicationGroupResponse.ApplicationGroup = applicationGroup;
        
			return createApplicationGroupResponse;
        }
    }
}
