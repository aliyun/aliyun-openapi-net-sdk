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
    public class GetFeatureEntityResponseUnmarshaller
    {
        public static GetFeatureEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFeatureEntityResponse getFeatureEntityResponse = new GetFeatureEntityResponse();

			getFeatureEntityResponse.HttpResponse = _ctx.HttpResponse;
			getFeatureEntityResponse.RequestId = _ctx.StringValue("GetFeatureEntity.RequestId");
			getFeatureEntityResponse.Name = _ctx.StringValue("GetFeatureEntity.Name");
			getFeatureEntityResponse.ProjectId = _ctx.StringValue("GetFeatureEntity.ProjectId");
			getFeatureEntityResponse.ProjectName = _ctx.StringValue("GetFeatureEntity.ProjectName");
			getFeatureEntityResponse.JoinId = _ctx.StringValue("GetFeatureEntity.JoinId");
			getFeatureEntityResponse.Owner = _ctx.StringValue("GetFeatureEntity.Owner");
			getFeatureEntityResponse.GmtCreateTime = _ctx.StringValue("GetFeatureEntity.GmtCreateTime");
			getFeatureEntityResponse.ParentFeatureEntityId = _ctx.StringValue("GetFeatureEntity.ParentFeatureEntityId");
			getFeatureEntityResponse.ParentFeatureEntityName = _ctx.StringValue("GetFeatureEntity.ParentFeatureEntityName");
			getFeatureEntityResponse.ParentJoinId = _ctx.StringValue("GetFeatureEntity.ParentJoinId");
        
			return getFeatureEntityResponse;
        }
    }
}
