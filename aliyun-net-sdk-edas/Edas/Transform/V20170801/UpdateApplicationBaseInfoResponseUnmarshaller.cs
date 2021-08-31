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
    public class UpdateApplicationBaseInfoResponseUnmarshaller
    {
        public static UpdateApplicationBaseInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateApplicationBaseInfoResponse updateApplicationBaseInfoResponse = new UpdateApplicationBaseInfoResponse();

			updateApplicationBaseInfoResponse.HttpResponse = _ctx.HttpResponse;
			updateApplicationBaseInfoResponse.Code = _ctx.IntegerValue("UpdateApplicationBaseInfo.Code");
			updateApplicationBaseInfoResponse.Message = _ctx.StringValue("UpdateApplicationBaseInfo.Message");
			updateApplicationBaseInfoResponse.RequestId = _ctx.StringValue("UpdateApplicationBaseInfo.RequestId");

			UpdateApplicationBaseInfoResponse.UpdateApplicationBaseInfo_Applcation applcation = new UpdateApplicationBaseInfoResponse.UpdateApplicationBaseInfo_Applcation();
			applcation.AppId = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.AppId");
			applcation.Name = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.Name");
			applcation.RegionId = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.RegionId");
			applcation.Description = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.Description");
			applcation.Owner = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.Owner");
			applcation.InstanceCount = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.InstanceCount");
			applcation.RunningInstanceCount = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.RunningInstanceCount");
			applcation.Port = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.Port");
			applcation.UserId = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.UserId");
			applcation.SlbId = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.SlbId");
			applcation.SlbIp = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.SlbIp");
			applcation.SlbPort = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.SlbPort");
			applcation.ExtSlbId = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.ExtSlbId");
			applcation.ExtSlbIp = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.ExtSlbIp");
			applcation.SlbName = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.SlbName");
			applcation.ExtSlbName = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.ExtSlbName");
			applcation.ApplicationType = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.ApplicationType");
			applcation.ClusterType = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.ClusterType");
			applcation.ClusterId = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.ClusterId");
			applcation.Dockerize = _ctx.BooleanValue("UpdateApplicationBaseInfo.Applcation.Dockerize");
			applcation.Cpu = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.Cpu");
			applcation.Memory = _ctx.IntegerValue("UpdateApplicationBaseInfo.Applcation.Memory");
			applcation.HealthCheckUrl = _ctx.StringValue("UpdateApplicationBaseInfo.Applcation.HealthCheckUrl");
			applcation.BuildPackageId = _ctx.LongValue("UpdateApplicationBaseInfo.Applcation.BuildPackageId");
			applcation.CreateTime = _ctx.LongValue("UpdateApplicationBaseInfo.Applcation.CreateTime");
			updateApplicationBaseInfoResponse.Applcation = applcation;
        
			return updateApplicationBaseInfoResponse;
        }
    }
}
