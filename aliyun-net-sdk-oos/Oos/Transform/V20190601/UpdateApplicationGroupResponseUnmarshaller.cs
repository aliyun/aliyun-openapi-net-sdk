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
    public class UpdateApplicationGroupResponseUnmarshaller
    {
        public static UpdateApplicationGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateApplicationGroupResponse updateApplicationGroupResponse = new UpdateApplicationGroupResponse();

			updateApplicationGroupResponse.HttpResponse = _ctx.HttpResponse;
			updateApplicationGroupResponse.RequestId = _ctx.StringValue("UpdateApplicationGroup.RequestId");

			UpdateApplicationGroupResponse.UpdateApplicationGroup_ApplicationGroup applicationGroup = new UpdateApplicationGroupResponse.UpdateApplicationGroup_ApplicationGroup();
			applicationGroup.DeployRegionId = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.DeployRegionId");
			applicationGroup.Description = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.Description");
			applicationGroup.ImportTagKey = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.ImportTagKey");
			applicationGroup.UpdatedDate = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.UpdatedDate");
			applicationGroup.ApplicationName = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.ApplicationName");
			applicationGroup.CreatedDate = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.CreatedDate");
			applicationGroup.ImportTagValue = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.ImportTagValue");
			applicationGroup.Name = _ctx.StringValue("UpdateApplicationGroup.ApplicationGroup.Name");
			updateApplicationGroupResponse.ApplicationGroup = applicationGroup;
        
			return updateApplicationGroupResponse;
        }
    }
}
