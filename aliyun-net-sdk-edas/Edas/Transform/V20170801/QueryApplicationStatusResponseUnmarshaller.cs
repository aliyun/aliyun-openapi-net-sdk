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
    public class QueryApplicationStatusResponseUnmarshaller
    {
        public static QueryApplicationStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryApplicationStatusResponse queryApplicationStatusResponse = new QueryApplicationStatusResponse();

			queryApplicationStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryApplicationStatusResponse.Code = _ctx.IntegerValue("QueryApplicationStatus.Code");
			queryApplicationStatusResponse.Message = _ctx.StringValue("QueryApplicationStatus.Message");
			queryApplicationStatusResponse.RequestId = _ctx.StringValue("QueryApplicationStatus.RequestId");

			QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo appInfo = new QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo();

			QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Application application = new QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Application();
			application.ApplicationId = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.ApplicationId");
			application.BuildPackageId = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.Application.BuildPackageId");
			application.ClusterId = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.ClusterId");
			application.Cpu = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.Application.Cpu");
			application.CreateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.Application.CreateTime");
			application.Dockerize = _ctx.BooleanValue("QueryApplicationStatus.AppInfo.Application.Dockerize");
			application.Email = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.Email");
			application.HealthCheckUrl = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.HealthCheckUrl");
			application.InstanceCount = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.Application.InstanceCount");
			application.LaunchTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.Application.LaunchTime");
			application.Memory = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.Application.Memory");
			application.Name = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.Name");
			application.Owner = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.Owner");
			application.Phone = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.Phone");
			application.Port = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.Application.Port");
			application.RegionId = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.RegionId");
			application.RunningInstanceCount = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.Application.RunningInstanceCount");
			application.UserId = _ctx.StringValue("QueryApplicationStatus.AppInfo.Application.UserId");
			appInfo.Application = application;

			List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecu> appInfo_ecuList = new List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecu>();
			for (int i = 0; i < _ctx.Length("QueryApplicationStatus.AppInfo.EcuList.Length"); i++) {
				QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecu ecu = new QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecu();
				ecu.EcuId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].EcuId");
				ecu.Online = _ctx.BooleanValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].Online");
				ecu.DockerEnv = _ctx.BooleanValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].DockerEnv");
				ecu.CreateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].CreateTime");
				ecu.UpdateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].UpdateTime");
				ecu.IpAddr = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].IpAddr");
				ecu.HeartbeatTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].HeartbeatTime");
				ecu.UserId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].UserId");
				ecu.GroupId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].GroupId");
				ecu.Name = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].Name");
				ecu.ZoneId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].ZoneId");
				ecu.RegionId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].RegionId");
				ecu.InstanceId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].InstanceId");
				ecu.VpcId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].VpcId");
				ecu.RegionId1 = _ctx.StringValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].RegionId");
				ecu.AvailableCpu = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].AvailableCpu");
				ecu.AvailableMem = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.EcuList["+ i +"].AvailableMem");

				appInfo_ecuList.Add(ecu);
			}
			appInfo.EcuList = appInfo_ecuList;

			List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecc> appInfo_eccList = new List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecc>();
			for (int i = 0; i < _ctx.Length("QueryApplicationStatus.AppInfo.EccList.Length"); i++) {
				QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecc ecc = new QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Ecc();
				ecc.EccId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].EccId");
				ecc.EcuId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].EcuId");
				ecc.AppId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].AppId");
				ecc.AppState = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].AppState");
				ecc.TaskState = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].TaskState");
				ecc.CreateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].CreateTime");
				ecc.UpdateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].UpdateTime");
				ecc.Ip = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].Ip");
				ecc.VpcId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].VpcId");
				ecc.GroupId = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].GroupId");
				ecc.ContainerStatus = _ctx.StringValue("QueryApplicationStatus.AppInfo.EccList["+ i +"].ContainerStatus");

				appInfo_eccList.Add(ecc);
			}
			appInfo.EccList = appInfo_eccList;

			List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Group> appInfo_groupList = new List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Group>();
			for (int i = 0; i < _ctx.Length("QueryApplicationStatus.AppInfo.GroupList.Length"); i++) {
				QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Group group = new QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_Group();
				group.GroupId = _ctx.StringValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].GroupId");
				group.GroupName = _ctx.StringValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].GroupName");
				group.AppId = _ctx.StringValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].AppId");
				group.PackageVersionId = _ctx.StringValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].PackageVersionId");
				group.AppVersionId = _ctx.StringValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].AppVersionId");
				group.GroupType = _ctx.IntegerValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].GroupType");
				group.ClusterId = _ctx.StringValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].ClusterId");
				group.CreateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].CreateTime");
				group.UpdateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.GroupList["+ i +"].UpdateTime");

				appInfo_groupList.Add(group);
			}
			appInfo.GroupList = appInfo_groupList;

			List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_DeployRecord> appInfo_deployRecordList = new List<QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_DeployRecord>();
			for (int i = 0; i < _ctx.Length("QueryApplicationStatus.AppInfo.DeployRecordList.Length"); i++) {
				QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_DeployRecord deployRecord = new QueryApplicationStatusResponse.QueryApplicationStatus_AppInfo.QueryApplicationStatus_DeployRecord();
				deployRecord.DeployRecordId = _ctx.StringValue("QueryApplicationStatus.AppInfo.DeployRecordList["+ i +"].DeployRecordId");
				deployRecord.EccId = _ctx.StringValue("QueryApplicationStatus.AppInfo.DeployRecordList["+ i +"].EccId");
				deployRecord.EcuId = _ctx.StringValue("QueryApplicationStatus.AppInfo.DeployRecordList["+ i +"].EcuId");
				deployRecord.PackageVersionId = _ctx.StringValue("QueryApplicationStatus.AppInfo.DeployRecordList["+ i +"].PackageVersionId");
				deployRecord.PackageMd5 = _ctx.StringValue("QueryApplicationStatus.AppInfo.DeployRecordList["+ i +"].PackageMd5");
				deployRecord.CreateTime = _ctx.LongValue("QueryApplicationStatus.AppInfo.DeployRecordList["+ i +"].CreateTime");

				appInfo_deployRecordList.Add(deployRecord);
			}
			appInfo.DeployRecordList = appInfo_deployRecordList;
			queryApplicationStatusResponse.AppInfo = appInfo;
        
			return queryApplicationStatusResponse;
        }
    }
}
