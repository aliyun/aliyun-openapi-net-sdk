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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetDeploymentResponseUnmarshaller
    {
        public static GetDeploymentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDeploymentResponse getDeploymentResponse = new GetDeploymentResponse();

			getDeploymentResponse.HttpResponse = _ctx.HttpResponse;
			getDeploymentResponse.HttpStatusCode = _ctx.IntegerValue("GetDeployment.HttpStatusCode");
			getDeploymentResponse.ErrorMessage = _ctx.StringValue("GetDeployment.ErrorMessage");
			getDeploymentResponse.RequestId = _ctx.StringValue("GetDeployment.RequestId");
			getDeploymentResponse.ErrorCode = _ctx.StringValue("GetDeployment.ErrorCode");
			getDeploymentResponse.Success = _ctx.BooleanValue("GetDeployment.Success");

			GetDeploymentResponse.GetDeployment_Data data = new GetDeploymentResponse.GetDeployment_Data();

			GetDeploymentResponse.GetDeployment_Data.GetDeployment_Deployment deployment = new GetDeploymentResponse.GetDeployment_Data.GetDeployment_Deployment();
			deployment.Status = _ctx.IntegerValue("GetDeployment.Data.Deployment.Status");
			deployment.ErrorMessage = _ctx.StringValue("GetDeployment.Data.Deployment.ErrorMessage");
			deployment.FromEnvironment = _ctx.IntegerValue("GetDeployment.Data.Deployment.FromEnvironment");
			deployment.ToEnvironment = _ctx.IntegerValue("GetDeployment.Data.Deployment.ToEnvironment");
			deployment.CheckingStatus = _ctx.IntegerValue("GetDeployment.Data.Deployment.CheckingStatus");
			deployment.CreateTime = _ctx.LongValue("GetDeployment.Data.Deployment.CreateTime");
			deployment.HandlerId = _ctx.StringValue("GetDeployment.Data.Deployment.HandlerId");
			deployment.CreatorId = _ctx.StringValue("GetDeployment.Data.Deployment.CreatorId");
			deployment.ExecuteTime = _ctx.LongValue("GetDeployment.Data.Deployment.ExecuteTime");
			deployment.Name = _ctx.StringValue("GetDeployment.Data.Deployment.Name");
			data.Deployment = deployment;
			getDeploymentResponse.Data = data;
        
			return getDeploymentResponse;
        }
    }
}
