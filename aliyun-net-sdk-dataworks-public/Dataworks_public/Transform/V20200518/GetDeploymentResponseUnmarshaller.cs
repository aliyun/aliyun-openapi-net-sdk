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
        public static GetDeploymentResponse Unmarshall(UnmarshallerContext context)
        {
			GetDeploymentResponse getDeploymentResponse = new GetDeploymentResponse();

			getDeploymentResponse.HttpResponse = context.HttpResponse;
			getDeploymentResponse.RequestId = context.StringValue("GetDeployment.RequestId");
			getDeploymentResponse.Success = context.BooleanValue("GetDeployment.Success");
			getDeploymentResponse.ErrorCode = context.StringValue("GetDeployment.ErrorCode");
			getDeploymentResponse.ErrorMessage = context.StringValue("GetDeployment.ErrorMessage");
			getDeploymentResponse.HttpStatusCode = context.IntegerValue("GetDeployment.HttpStatusCode");

			GetDeploymentResponse.GetDeployment_Data data = new GetDeploymentResponse.GetDeployment_Data();

			GetDeploymentResponse.GetDeployment_Data.GetDeployment_Deployment deployment = new GetDeploymentResponse.GetDeployment_Data.GetDeployment_Deployment();
			deployment.Name = context.StringValue("GetDeployment.Data.Deployment.Name");
			deployment.CreatorId = context.StringValue("GetDeployment.Data.Deployment.CreatorId");
			deployment.HandlerId = context.StringValue("GetDeployment.Data.Deployment.HandlerId");
			deployment.CreateTime = context.LongValue("GetDeployment.Data.Deployment.CreateTime");
			deployment.ExecuteTime = context.LongValue("GetDeployment.Data.Deployment.ExecuteTime");
			deployment.Status = context.IntegerValue("GetDeployment.Data.Deployment.Status");
			deployment.FromEnvironment = context.IntegerValue("GetDeployment.Data.Deployment.FromEnvironment");
			deployment.ToEnvironment = context.IntegerValue("GetDeployment.Data.Deployment.ToEnvironment");
			deployment.ErrorMessage = context.StringValue("GetDeployment.Data.Deployment.ErrorMessage");
			data.Deployment = deployment;
			getDeploymentResponse.Data = data;
        
			return getDeploymentResponse;
        }
    }
}
