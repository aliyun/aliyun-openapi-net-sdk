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
    public class GetProjectFeatureEntityResponseUnmarshaller
    {
        public static GetProjectFeatureEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectFeatureEntityResponse getProjectFeatureEntityResponse = new GetProjectFeatureEntityResponse();

			getProjectFeatureEntityResponse.HttpResponse = _ctx.HttpResponse;
			getProjectFeatureEntityResponse.RequestId = _ctx.StringValue("GetProjectFeatureEntity.RequestId");
			getProjectFeatureEntityResponse.Name = _ctx.StringValue("GetProjectFeatureEntity.Name");
			getProjectFeatureEntityResponse.FeatureEntityId = _ctx.StringValue("GetProjectFeatureEntity.FeatureEntityId");
			getProjectFeatureEntityResponse.ProjectName = _ctx.StringValue("GetProjectFeatureEntity.ProjectName");
			getProjectFeatureEntityResponse.WorkspaceId = _ctx.StringValue("GetProjectFeatureEntity.WorkspaceId");
			getProjectFeatureEntityResponse.JoinId = _ctx.StringValue("GetProjectFeatureEntity.JoinId");
        
			return getProjectFeatureEntityResponse;
        }
    }
}
