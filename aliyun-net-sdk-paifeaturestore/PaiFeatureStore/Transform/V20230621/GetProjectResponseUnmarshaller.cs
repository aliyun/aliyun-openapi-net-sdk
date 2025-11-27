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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class GetProjectResponseUnmarshaller
    {
        public static GetProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = _ctx.HttpResponse;
			getProjectResponse.RequestId = _ctx.StringValue("GetProject.RequestId");
			getProjectResponse.Name = _ctx.StringValue("GetProject.Name");
			getProjectResponse.Description = _ctx.StringValue("GetProject.Description");
			getProjectResponse.OfflineDatasourceType = _ctx.StringValue("GetProject.OfflineDatasourceType");
			getProjectResponse.OfflineDatasourceId = _ctx.StringValue("GetProject.OfflineDatasourceId");
			getProjectResponse.OfflineDatasourceName = _ctx.StringValue("GetProject.OfflineDatasourceName");
			getProjectResponse.OnlineDatasourceType = _ctx.StringValue("GetProject.OnlineDatasourceType");
			getProjectResponse.OnlineDatasourceId = _ctx.StringValue("GetProject.OnlineDatasourceId");
			getProjectResponse.OnlineDatasourceName = _ctx.StringValue("GetProject.OnlineDatasourceName");
			getProjectResponse.OfflineLifecycle = _ctx.IntegerValue("GetProject.OfflineLifecycle");
			getProjectResponse.FeatureEntityCount = _ctx.IntegerValue("GetProject.FeatureEntityCount");
			getProjectResponse.FeatureViewCount = _ctx.IntegerValue("GetProject.FeatureViewCount");
			getProjectResponse.ModelCount = _ctx.IntegerValue("GetProject.ModelCount");
			getProjectResponse.Owner = _ctx.StringValue("GetProject.Owner");
			getProjectResponse.GmtCreateTime = _ctx.StringValue("GetProject.GmtCreateTime");
			getProjectResponse.GmtModifiedTime = _ctx.StringValue("GetProject.GmtModifiedTime");
        
			return getProjectResponse;
        }
    }
}
