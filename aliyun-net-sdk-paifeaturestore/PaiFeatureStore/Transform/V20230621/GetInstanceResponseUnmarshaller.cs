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
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceResponse.RequestId = _ctx.StringValue("GetInstance.RequestId");
			getInstanceResponse.Status = _ctx.StringValue("GetInstance.Status");
			getInstanceResponse.RegionId = _ctx.StringValue("GetInstance.RegionId");
			getInstanceResponse.GmtCreateTime = _ctx.StringValue("GetInstance.GmtCreateTime");
			getInstanceResponse.GmtModifiedTime = _ctx.StringValue("GetInstance.GmtModifiedTime");
			getInstanceResponse.Progress = _ctx.DoubleValue("GetInstance.Progress");
			getInstanceResponse.Message = _ctx.StringValue("GetInstance.Message");
			getInstanceResponse.Type = _ctx.StringValue("GetInstance.Type");

			GetInstanceResponse.GetInstance_FeatureDBInstanceInfo featureDBInstanceInfo = new GetInstanceResponse.GetInstance_FeatureDBInstanceInfo();
			featureDBInstanceInfo.Status = _ctx.StringValue("GetInstance.FeatureDBInstanceInfo.Status");
			getInstanceResponse.FeatureDBInstanceInfo = featureDBInstanceInfo;
        
			return getInstanceResponse;
        }
    }
}
