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
    public class GetApplicationGroupResponseUnmarshaller
    {
        public static GetApplicationGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetApplicationGroupResponse getApplicationGroupResponse = new GetApplicationGroupResponse();

			getApplicationGroupResponse.HttpResponse = _ctx.HttpResponse;
			getApplicationGroupResponse.RequestId = _ctx.StringValue("GetApplicationGroup.RequestId");

			GetApplicationGroupResponse.GetApplicationGroup_ApplicationGroup applicationGroup = new GetApplicationGroupResponse.GetApplicationGroup_ApplicationGroup();
			applicationGroup.CmsGroupId = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.CmsGroupId");
			applicationGroup.DeployRegionId = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.DeployRegionId");
			applicationGroup.Description = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.Description");
			applicationGroup.UpdateDate = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.UpdateDate");
			applicationGroup.ImportTagKey = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.ImportTagKey");
			applicationGroup.ApplicationName = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.ApplicationName");
			applicationGroup.ImportTagValue = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.ImportTagValue");
			applicationGroup.Name = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.Name");
			applicationGroup.CreateDate = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.CreateDate");
			applicationGroup.DeployParameters = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.DeployParameters");
			applicationGroup.Status = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.Status");
			applicationGroup.StatusReason = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.StatusReason");
			applicationGroup.DeployOutputs = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.DeployOutputs");
			applicationGroup.Progress = _ctx.StringValue("GetApplicationGroup.ApplicationGroup.Progress");
			getApplicationGroupResponse.ApplicationGroup = applicationGroup;
        
			return getApplicationGroupResponse;
        }
    }
}
