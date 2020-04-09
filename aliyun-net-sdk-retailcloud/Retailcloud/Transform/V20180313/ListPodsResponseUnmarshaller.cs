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
        public static ListPodsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPodsResponse listPodsResponse = new ListPodsResponse();

			listPodsResponse.HttpResponse = context.HttpResponse;
			listPodsResponse.Code = context.IntegerValue("ListPods.Code");
			listPodsResponse.ErrorMsg = context.StringValue("ListPods.ErrorMsg");
			listPodsResponse.PageNumber = context.IntegerValue("ListPods.PageNumber");
			listPodsResponse.PageSize = context.IntegerValue("ListPods.PageSize");
			listPodsResponse.RequestId = context.StringValue("ListPods.RequestId");
			listPodsResponse.TotalCount = context.LongValue("ListPods.TotalCount");

			List<ListPodsResponse.ListPods_PodDetail> listPodsResponse_data = new List<ListPodsResponse.ListPods_PodDetail>();
			for (int i = 0; i < context.Length("ListPods.Data.Length"); i++) {
				ListPodsResponse.ListPods_PodDetail podDetail = new ListPodsResponse.ListPods_PodDetail();
				podDetail.AppInstanceId = context.StringValue("ListPods.Data["+ i +"].AppInstanceId");
				podDetail.DeployOrderId = context.LongValue("ListPods.Data["+ i +"].DeployOrderId");
				podDetail.DeployPartitionNum = context.IntegerValue("ListPods.Data["+ i +"].DeployPartitionNum");
				podDetail.GroupName = context.StringValue("ListPods.Data["+ i +"].GroupName");
				podDetail.HostIp = context.StringValue("ListPods.Data["+ i +"].HostIp");
				podDetail.HostName = context.StringValue("ListPods.Data["+ i +"].HostName");
				podDetail.PodIp = context.StringValue("ListPods.Data["+ i +"].PodIp");
				podDetail.Region = context.StringValue("ListPods.Data["+ i +"].Region");
				podDetail.Result = context.IntegerValue("ListPods.Data["+ i +"].Result");
				podDetail.ResultName = context.StringValue("ListPods.Data["+ i +"].ResultName");
				podDetail.StartTime = context.StringValue("ListPods.Data["+ i +"].StartTime");
				podDetail.Status = context.IntegerValue("ListPods.Data["+ i +"].Status");
				podDetail.StatusName = context.StringValue("ListPods.Data["+ i +"].StatusName");
				podDetail.UpdateTime = context.StringValue("ListPods.Data["+ i +"].UpdateTime");

				List<ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep> podDetail_deploySteps = new List<ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep>();
				for (int j = 0; j < context.Length("ListPods.Data["+ i +"].DeploySteps.Length"); j++) {
					ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep deployStep = new ListPodsResponse.ListPods_PodDetail.ListPods_DeployStep();
					deployStep.Status = context.StringValue("ListPods.Data["+ i +"].DeploySteps["+ j +"].Status");
					deployStep.StepCode = context.StringValue("ListPods.Data["+ i +"].DeploySteps["+ j +"].StepCode");
					deployStep.StepName = context.StringValue("ListPods.Data["+ i +"].DeploySteps["+ j +"].StepName");

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
