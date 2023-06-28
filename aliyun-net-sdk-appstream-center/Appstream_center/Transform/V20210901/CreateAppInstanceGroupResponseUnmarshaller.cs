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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class CreateAppInstanceGroupResponseUnmarshaller
    {
        public static CreateAppInstanceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAppInstanceGroupResponse createAppInstanceGroupResponse = new CreateAppInstanceGroupResponse();

			createAppInstanceGroupResponse.HttpResponse = _ctx.HttpResponse;
			createAppInstanceGroupResponse.RequestId = _ctx.StringValue("CreateAppInstanceGroup.RequestId");

			CreateAppInstanceGroupResponse.CreateAppInstanceGroup_AppInstanceGroupModel appInstanceGroupModel = new CreateAppInstanceGroupResponse.CreateAppInstanceGroup_AppInstanceGroupModel();
			appInstanceGroupModel.AppInstanceGroupId = _ctx.StringValue("CreateAppInstanceGroup.AppInstanceGroupModel.AppInstanceGroupId");
			appInstanceGroupModel.OrderId = _ctx.StringValue("CreateAppInstanceGroup.AppInstanceGroupModel.OrderId");
			appInstanceGroupModel.SpecId = _ctx.StringValue("CreateAppInstanceGroup.AppInstanceGroupModel.SpecId");
			appInstanceGroupModel.NodePoolId = _ctx.StringValue("CreateAppInstanceGroup.AppInstanceGroupModel.NodePoolId");
			createAppInstanceGroupResponse.AppInstanceGroupModel = appInstanceGroupModel;
        
			return createAppInstanceGroupResponse;
        }
    }
}
