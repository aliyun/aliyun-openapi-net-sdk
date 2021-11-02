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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class GetClusterDetailsResponseUnmarshaller
    {
        public static GetClusterDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetClusterDetailsResponse getClusterDetailsResponse = new GetClusterDetailsResponse();

			getClusterDetailsResponse.HttpResponse = _ctx.HttpResponse;
			getClusterDetailsResponse.RequestId = _ctx.StringValue("GetClusterDetails.RequestId");

			GetClusterDetailsResponse.GetClusterDetails_Details details = new GetClusterDetailsResponse.GetClusterDetails_Details();
			details.ClusterId = _ctx.StringValue("GetClusterDetails.Details.ClusterId");
			details.RegionId = _ctx.StringValue("GetClusterDetails.Details.RegionId");
			details.ZoneId = _ctx.StringValue("GetClusterDetails.Details.ZoneId");
			details.State = _ctx.StringValue("GetClusterDetails.Details.State");
			details.Description = _ctx.StringValue("GetClusterDetails.Details.Description");
			details.DisplayName = _ctx.StringValue("GetClusterDetails.Details.DisplayName");
			details.OwnerId = _ctx.StringValue("GetClusterDetails.Details.OwnerId");
			details._Operator = _ctx.StringValue("GetClusterDetails.Details.Operator");
			details.StorageType = _ctx.StringValue("GetClusterDetails.Details.StorageType");
			details.GmtCreate = _ctx.LongValue("GetClusterDetails.Details.GmtCreate");
			details.GmtModified = _ctx.LongValue("GetClusterDetails.Details.GmtModified");
			details.UserOssInfo = _ctx.StringValue("GetClusterDetails.Details.UserOssInfo");
			details.UserVpcId = _ctx.StringValue("GetClusterDetails.Details.UserVpcId");
			details.UserSGId = _ctx.StringValue("GetClusterDetails.Details.UserSGId");
			details.UserVSwitchList = _ctx.StringValue("GetClusterDetails.Details.UserVSwitchList");
			details.IsMixDeploy = _ctx.BooleanValue("GetClusterDetails.Details.IsMixDeploy");
			details.InstanceInfos = _ctx.StringValue("GetClusterDetails.Details.InstanceInfos");
			getClusterDetailsResponse.Details = details;
        
			return getClusterDetailsResponse;
        }
    }
}
