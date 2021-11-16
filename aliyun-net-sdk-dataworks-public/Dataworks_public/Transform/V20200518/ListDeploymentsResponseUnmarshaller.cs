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
    public class ListDeploymentsResponseUnmarshaller
    {
        public static ListDeploymentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeploymentsResponse listDeploymentsResponse = new ListDeploymentsResponse();

			listDeploymentsResponse.HttpResponse = _ctx.HttpResponse;
			listDeploymentsResponse.RequestId = _ctx.StringValue("ListDeployments.RequestId");

			ListDeploymentsResponse.ListDeployments_Data data = new ListDeploymentsResponse.ListDeployments_Data();
			data.PageNumber = _ctx.LongValue("ListDeployments.Data.PageNumber");
			data.PageSize = _ctx.LongValue("ListDeployments.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListDeployments.Data.TotalCount");

			List<ListDeploymentsResponse.ListDeployments_Data.ListDeployments_Deployment> data_deployments = new List<ListDeploymentsResponse.ListDeployments_Data.ListDeployments_Deployment>();
			for (int i = 0; i < _ctx.Length("ListDeployments.Data.Deployments.Length"); i++) {
				ListDeploymentsResponse.ListDeployments_Data.ListDeployments_Deployment deployment = new ListDeploymentsResponse.ListDeployments_Data.ListDeployments_Deployment();
				deployment.Status = _ctx.IntegerValue("ListDeployments.Data.Deployments["+ i +"].Status");
				deployment.ErrorMessage = _ctx.StringValue("ListDeployments.Data.Deployments["+ i +"].ErrorMessage");
				deployment.CreateTime = _ctx.LongValue("ListDeployments.Data.Deployments["+ i +"].CreateTime");
				deployment.Executor = _ctx.StringValue("ListDeployments.Data.Deployments["+ i +"].Executor");
				deployment.Creator = _ctx.StringValue("ListDeployments.Data.Deployments["+ i +"].Creator");
				deployment.ExecuteTime = _ctx.LongValue("ListDeployments.Data.Deployments["+ i +"].ExecuteTime");
				deployment.Name = _ctx.StringValue("ListDeployments.Data.Deployments["+ i +"].Name");
				deployment.Id = _ctx.LongValue("ListDeployments.Data.Deployments["+ i +"].Id");

				data_deployments.Add(deployment);
			}
			data.Deployments = data_deployments;
			listDeploymentsResponse.Data = data;
        
			return listDeploymentsResponse;
        }
    }
}
