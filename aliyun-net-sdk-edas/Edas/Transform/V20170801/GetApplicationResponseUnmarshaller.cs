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
    public class GetApplicationResponseUnmarshaller
    {
        public static GetApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetApplicationResponse getApplicationResponse = new GetApplicationResponse();

			getApplicationResponse.HttpResponse = _ctx.HttpResponse;
			getApplicationResponse.Code = _ctx.IntegerValue("GetApplication.Code");
			getApplicationResponse.Message = _ctx.StringValue("GetApplication.Message");
			getApplicationResponse.RequestId = _ctx.StringValue("GetApplication.RequestId");

			GetApplicationResponse.GetApplication_Applcation applcation = new GetApplicationResponse.GetApplication_Applcation();
			applcation.AppId = _ctx.StringValue("GetApplication.Applcation.AppId");
			applcation.Name = _ctx.StringValue("GetApplication.Applcation.Name");
			applcation.RegionId = _ctx.StringValue("GetApplication.Applcation.RegionId");
			applcation.Description = _ctx.StringValue("GetApplication.Applcation.Description");
			applcation.Owner = _ctx.StringValue("GetApplication.Applcation.Owner");
			applcation.InstanceCount = _ctx.IntegerValue("GetApplication.Applcation.InstanceCount");
			applcation.RunningInstanceCount = _ctx.IntegerValue("GetApplication.Applcation.RunningInstanceCount");
			applcation.Port = _ctx.IntegerValue("GetApplication.Applcation.Port");
			applcation.UserId = _ctx.StringValue("GetApplication.Applcation.UserId");
			applcation.SlbId = _ctx.StringValue("GetApplication.Applcation.SlbId");
			applcation.SlbIp = _ctx.StringValue("GetApplication.Applcation.SlbIp");
			applcation.SlbPort = _ctx.IntegerValue("GetApplication.Applcation.SlbPort");
			applcation.ExtSlbId = _ctx.StringValue("GetApplication.Applcation.ExtSlbId");
			applcation.ExtSlbIp = _ctx.StringValue("GetApplication.Applcation.ExtSlbIp");
			applcation.SlbName = _ctx.StringValue("GetApplication.Applcation.SlbName");
			applcation.ExtSlbName = _ctx.StringValue("GetApplication.Applcation.ExtSlbName");
			applcation.ApplicationType = _ctx.StringValue("GetApplication.Applcation.ApplicationType");
			applcation.ClusterType = _ctx.IntegerValue("GetApplication.Applcation.ClusterType");
			applcation.ClusterId = _ctx.StringValue("GetApplication.Applcation.ClusterId");
			applcation.Dockerize = _ctx.BooleanValue("GetApplication.Applcation.Dockerize");
			applcation.Cpu = _ctx.IntegerValue("GetApplication.Applcation.Cpu");
			applcation.Memory = _ctx.IntegerValue("GetApplication.Applcation.Memory");
			applcation.HealthCheckUrl = _ctx.StringValue("GetApplication.Applcation.HealthCheckUrl");
			applcation.BuildPackageId = _ctx.LongValue("GetApplication.Applcation.BuildPackageId");
			applcation.CreateTime = _ctx.LongValue("GetApplication.Applcation.CreateTime");
			applcation._NameSpace = _ctx.StringValue("GetApplication.Applcation.NameSpace");
			applcation.SlbInfo = _ctx.StringValue("GetApplication.Applcation.SlbInfo");
			applcation.Email = _ctx.StringValue("GetApplication.Applcation.Email");
			getApplicationResponse.Applcation = applcation;

			GetApplicationResponse.GetApplication_Application application = new GetApplicationResponse.GetApplication_Application();
			application.AppId = _ctx.StringValue("GetApplication.Application.AppId");
			application.Name = _ctx.StringValue("GetApplication.Application.Name");
			application.RegionId = _ctx.StringValue("GetApplication.Application.RegionId");
			application.Description = _ctx.StringValue("GetApplication.Application.Description");
			application.Owner = _ctx.StringValue("GetApplication.Application.Owner");
			application.InstanceCount = _ctx.IntegerValue("GetApplication.Application.InstanceCount");
			application.RunningInstanceCount = _ctx.IntegerValue("GetApplication.Application.RunningInstanceCount");
			application.Port = _ctx.IntegerValue("GetApplication.Application.Port");
			application.UserId = _ctx.StringValue("GetApplication.Application.UserId");
			application.SlbId = _ctx.StringValue("GetApplication.Application.SlbId");
			application.SlbIp = _ctx.StringValue("GetApplication.Application.SlbIp");
			application.SlbPort = _ctx.IntegerValue("GetApplication.Application.SlbPort");
			application.ExtSlbId = _ctx.StringValue("GetApplication.Application.ExtSlbId");
			application.ExtSlbIp = _ctx.StringValue("GetApplication.Application.ExtSlbIp");
			application.SlbName = _ctx.StringValue("GetApplication.Application.SlbName");
			application.ExtSlbName = _ctx.StringValue("GetApplication.Application.ExtSlbName");
			application.ApplicationType = _ctx.StringValue("GetApplication.Application.ApplicationType");
			application.ClusterType = _ctx.StringValue("GetApplication.Application.ClusterType");
			application.ClusterId = _ctx.StringValue("GetApplication.Application.ClusterId");
			application.Dockerize = _ctx.BooleanValue("GetApplication.Application.Dockerize");
			application.Cpu = _ctx.IntegerValue("GetApplication.Application.Cpu");
			application.Memory = _ctx.IntegerValue("GetApplication.Application.Memory");
			application.HealthCheckUrl = _ctx.StringValue("GetApplication.Application.HealthCheckUrl");
			application.BuildPackageId = _ctx.LongValue("GetApplication.Application.BuildPackageId");
			application.CreateTime = _ctx.LongValue("GetApplication.Application.CreateTime");
			application._NameSpace = _ctx.StringValue("GetApplication.Application.NameSpace");
			application.SlbInfo = _ctx.StringValue("GetApplication.Application.SlbInfo");
			application.Email = _ctx.StringValue("GetApplication.Application.Email");
			getApplicationResponse.Application = application;
        
			return getApplicationResponse;
        }
    }
}
