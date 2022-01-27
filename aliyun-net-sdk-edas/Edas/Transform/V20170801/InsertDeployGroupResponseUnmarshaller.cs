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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class InsertDeployGroupResponseUnmarshaller
    {
        public static InsertDeployGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertDeployGroupResponse insertDeployGroupResponse = new InsertDeployGroupResponse();

			insertDeployGroupResponse.HttpResponse = _ctx.HttpResponse;
			insertDeployGroupResponse.Code = _ctx.IntegerValue("InsertDeployGroup.Code");
			insertDeployGroupResponse.Message = _ctx.StringValue("InsertDeployGroup.Message");
			insertDeployGroupResponse.RequestId = _ctx.StringValue("InsertDeployGroup.RequestId");

			InsertDeployGroupResponse.InsertDeployGroup_DeployGroupEntity deployGroupEntity = new InsertDeployGroupResponse.InsertDeployGroup_DeployGroupEntity();
			deployGroupEntity.Id = _ctx.StringValue("InsertDeployGroup.DeployGroupEntity.Id");
			deployGroupEntity.GroupName = _ctx.StringValue("InsertDeployGroup.DeployGroupEntity.GroupName");
			deployGroupEntity.GroupType = _ctx.IntegerValue("InsertDeployGroup.DeployGroupEntity.GroupType");
			deployGroupEntity.AppId = _ctx.StringValue("InsertDeployGroup.DeployGroupEntity.AppId");
			deployGroupEntity.ClusterId = _ctx.StringValue("InsertDeployGroup.DeployGroupEntity.ClusterId");
			deployGroupEntity.PackageVersionId = _ctx.StringValue("InsertDeployGroup.DeployGroupEntity.PackageVersionId");
			deployGroupEntity.AppVersionId = _ctx.StringValue("InsertDeployGroup.DeployGroupEntity.AppVersionId");
			deployGroupEntity.CreateTime = _ctx.LongValue("InsertDeployGroup.DeployGroupEntity.CreateTime");
			deployGroupEntity.UpdateTime = _ctx.LongValue("InsertDeployGroup.DeployGroupEntity.UpdateTime");
			insertDeployGroupResponse.DeployGroupEntity = deployGroupEntity;
        
			return insertDeployGroupResponse;
        }
    }
}
