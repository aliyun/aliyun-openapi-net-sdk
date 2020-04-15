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
        public static GetClusterDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			GetClusterDetailsResponse getClusterDetailsResponse = new GetClusterDetailsResponse();

			getClusterDetailsResponse.HttpResponse = context.HttpResponse;
			getClusterDetailsResponse.RequestId = context.StringValue("GetClusterDetails.RequestId");

			GetClusterDetailsResponse.GetClusterDetails_Details details = new GetClusterDetailsResponse.GetClusterDetails_Details();
			details.ClusterId = context.StringValue("GetClusterDetails.Details.ClusterId");
			details.RegionId = context.StringValue("GetClusterDetails.Details.RegionId");
			details.ZoneId = context.StringValue("GetClusterDetails.Details.ZoneId");
			details.State = context.StringValue("GetClusterDetails.Details.State");
			details.Description = context.StringValue("GetClusterDetails.Details.Description");
			details.DisplayName = context.StringValue("GetClusterDetails.Details.DisplayName");
			details.OwnerId = context.StringValue("GetClusterDetails.Details.OwnerId");
			details._Operator = context.StringValue("GetClusterDetails.Details.Operator");
			details.StorageType = context.StringValue("GetClusterDetails.Details.StorageType");
			details.GmtCreate = context.LongValue("GetClusterDetails.Details.GmtCreate");
			details.GmtModified = context.LongValue("GetClusterDetails.Details.GmtModified");
			details.UserOssInfo = context.StringValue("GetClusterDetails.Details.UserOssInfo");
			details.UserVpcId = context.StringValue("GetClusterDetails.Details.UserVpcId");
			details.UserSGId = context.StringValue("GetClusterDetails.Details.UserSGId");
			details.UserVSwitchList = context.StringValue("GetClusterDetails.Details.UserVSwitchList");
			details.IsMixDeploy = context.BooleanValue("GetClusterDetails.Details.IsMixDeploy");
			details.InstanceInfos = context.StringValue("GetClusterDetails.Details.InstanceInfos");
			getClusterDetailsResponse.Details = details;
        
			return getClusterDetailsResponse;
        }
    }
}
