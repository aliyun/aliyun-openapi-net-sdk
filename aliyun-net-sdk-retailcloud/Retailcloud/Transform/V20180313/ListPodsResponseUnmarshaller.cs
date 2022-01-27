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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListPodsResponseUnmarshaller
    {
        public static ListPodsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPodsResponse listPodsResponse = new ListPodsResponse();

			listPodsResponse.HttpResponse = _ctx.HttpResponse;
			listPodsResponse.Code = _ctx.IntegerValue("ListPods.Code");
			listPodsResponse.ErrorMsg = _ctx.StringValue("ListPods.ErrorMsg");
			listPodsResponse.PageNumber = _ctx.IntegerValue("ListPods.PageNumber");
			listPodsResponse.PageSize = _ctx.IntegerValue("ListPods.PageSize");
			listPodsResponse.RequestId = _ctx.StringValue("ListPods.RequestId");
			listPodsResponse.TotalCount = _ctx.LongValue("ListPods.TotalCount");

			List<ListPodsResponse.ListPods_PodDetail> listPodsResponse_data = new List<ListPodsResponse.ListPods_PodDetail>();
			for (int i = 0; i < _ctx.Length("ListPods.Data.Length"); i++) {
				ListPodsResponse.ListPods_PodDetail podDetail = new ListPodsResponse.ListPods_PodDetail();
				podDetail.AppInstanceId = _ctx.StringValue("ListPods.Data["+ i +"].AppInstanceId");
				podDetail.DeployOrderId = _ctx.LongValue("ListPods.Data["+ i +"].DeployOrderId");
				podDetail.DeployPartitionNum = _ctx.IntegerValue("ListPods.Data["+ i +"].DeployPartitionNum");
				podDetail.GroupName = _ctx.StringValue("ListPods.Data["+ i +"].GroupName");
				podDetail.HostIp = _ctx.StringValue("ListPods.Data["+ i +"].HostIp");
				podDetail.HostName = _ctx.StringValue("ListPods.Data["+ i +"].HostName");
				podDetail.PodIp = _ctx.StringValue("ListPods.Data["+ i +"].PodIp");
				podDetail.Region = _ctx.StringValue("ListPods.Data["+ i +"].Region");
				podDetail.Result = _ctx.IntegerValue("ListPods.Data["+ i +"].Result");
				podDetail.ResultName = _ctx.StringValue("ListPods.Data["+ i +"].ResultName");
				podDetail.StartTime = _ctx.StringValue("ListPods.Data["+ i +"].StartTime");
				podDetail.Status = _ctx.IntegerValue("ListPods.Data["+ i +"].Status");
				podDetail.StatusName = _ctx.StringValue("ListPods.Data["+ i +"].StatusName");
				podDetail.UpdateTime = _ctx.StringValue("ListPods.Data["+ i +"].UpdateTime");

				List<ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep> podDetail_deploySteps = new List<ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep>();
				for (int j = 0; j < _ctx.Length("ListPods.Data["+ i +"].DeploySteps.Length"); j++) {
					ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep deployStep = new ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep();
					deployStep.Status = _ctx.StringValue("ListPods.Data["+ i +"].DeploySteps["+ j +"].Status");
					deployStep.StepCode = _ctx.StringValue("ListPods.Data["+ i +"].DeploySteps["+ j +"].StepCode");
					deployStep.StepName = _ctx.StringValue("ListPods.Data["+ i +"].DeploySteps["+ j +"].StepName");

					podDetail_deploySteps.Add(deployStep);
				}
				podDetail.DeploySteps = podDetail_deploySteps;

				listPodsResponse_data.Add(podDetail);
			}
			listPodsResponse.Data = listPodsResponse_data;
        
			return listPodsResponse;
        }
    }
}
