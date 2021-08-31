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
    public class ListDeployGroupResponseUnmarshaller
    {
        public static ListDeployGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeployGroupResponse listDeployGroupResponse = new ListDeployGroupResponse();

			listDeployGroupResponse.HttpResponse = _ctx.HttpResponse;
			listDeployGroupResponse.Code = _ctx.IntegerValue("ListDeployGroup.Code");
			listDeployGroupResponse.Message = _ctx.StringValue("ListDeployGroup.Message");
			listDeployGroupResponse.RequestId = _ctx.StringValue("ListDeployGroup.RequestId");

			List<ListDeployGroupResponse.ListDeployGroup_DeployGroup> listDeployGroupResponse_deployGroupList = new List<ListDeployGroupResponse.ListDeployGroup_DeployGroup>();
			for (int i = 0; i < _ctx.Length("ListDeployGroup.DeployGroupList.Length"); i++) {
				ListDeployGroupResponse.ListDeployGroup_DeployGroup deployGroup = new ListDeployGroupResponse.ListDeployGroup_DeployGroup();
				deployGroup.GroupId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].GroupId");
				deployGroup.GroupName = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].GroupName");
				deployGroup.AppId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].AppId");
				deployGroup.PackageVersionId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].PackageVersionId");
				deployGroup.AppVersionId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].AppVersionId");
				deployGroup.GroupType = _ctx.IntegerValue("ListDeployGroup.DeployGroupList["+ i +"].GroupType");
				deployGroup.ClusterId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].ClusterId");
				deployGroup.CreateTime = _ctx.LongValue("ListDeployGroup.DeployGroupList["+ i +"].CreateTime");
				deployGroup.UpdateTime = _ctx.LongValue("ListDeployGroup.DeployGroupList["+ i +"].UpdateTime");
				deployGroup._NameSpace = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].NameSpace");
				deployGroup.ClusterName = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].ClusterName");
				deployGroup.LastUpdateTime = _ctx.LongValue("ListDeployGroup.DeployGroupList["+ i +"].LastUpdateTime");
				deployGroup.PreStop = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].PreStop");
				deployGroup.PostStart = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].PostStart");
				deployGroup.PackageUrl = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].PackageUrl");
				deployGroup.Env = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].Env");
				deployGroup.Labels = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].Labels");
				deployGroup.Selector = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].Selector");
				deployGroup.Strategy = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].Strategy");
				deployGroup.Status = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].Status");
				deployGroup.Reversion = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].Reversion");
				deployGroup.CsClusterId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].CsClusterId");
				deployGroup.BaseComponentMetaName = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].BaseComponentMetaName");
				deployGroup.DeploymentName = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].DeploymentName");
				deployGroup.CpuLimit = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].CpuLimit");
				deployGroup.MemoryLimit = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].MemoryLimit");
				deployGroup.PackagePublicUrl = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].PackagePublicUrl");
				deployGroup.PackageVersion = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].PackageVersion");
				deployGroup.CpuRequest = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].CpuRequest");
				deployGroup.MemoryRequest = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].MemoryRequest");
				deployGroup.VServerGroupId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].VServerGroupId");
				deployGroup.VExtServerGroupId = _ctx.StringValue("ListDeployGroup.DeployGroupList["+ i +"].VExtServerGroupId");

				listDeployGroupResponse_deployGroupList.Add(deployGroup);
			}
			listDeployGroupResponse.DeployGroupList = listDeployGroupResponse_deployGroupList;
        
			return listDeployGroupResponse;
        }
    }
}
