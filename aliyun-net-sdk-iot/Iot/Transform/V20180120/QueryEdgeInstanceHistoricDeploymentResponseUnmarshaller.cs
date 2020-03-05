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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryEdgeInstanceHistoricDeploymentResponseUnmarshaller
    {
        public static QueryEdgeInstanceHistoricDeploymentResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeInstanceHistoricDeploymentResponse queryEdgeInstanceHistoricDeploymentResponse = new QueryEdgeInstanceHistoricDeploymentResponse();

			queryEdgeInstanceHistoricDeploymentResponse.HttpResponse = context.HttpResponse;
			queryEdgeInstanceHistoricDeploymentResponse.RequestId = context.StringValue("QueryEdgeInstanceHistoricDeployment.RequestId");
			queryEdgeInstanceHistoricDeploymentResponse.Success = context.BooleanValue("QueryEdgeInstanceHistoricDeployment.Success");
			queryEdgeInstanceHistoricDeploymentResponse.Code = context.StringValue("QueryEdgeInstanceHistoricDeployment.Code");
			queryEdgeInstanceHistoricDeploymentResponse.ErrorMessage = context.StringValue("QueryEdgeInstanceHistoricDeployment.ErrorMessage");

			QueryEdgeInstanceHistoricDeploymentResponse.QueryEdgeInstanceHistoricDeployment_Data data = new QueryEdgeInstanceHistoricDeploymentResponse.QueryEdgeInstanceHistoricDeployment_Data();
			data.Total = context.IntegerValue("QueryEdgeInstanceHistoricDeployment.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeInstanceHistoricDeployment.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeInstanceHistoricDeployment.Data.CurrentPage");

			List<QueryEdgeInstanceHistoricDeploymentResponse.QueryEdgeInstanceHistoricDeployment_Data.QueryEdgeInstanceHistoricDeployment_Deployment> data_deploymentList = new List<QueryEdgeInstanceHistoricDeploymentResponse.QueryEdgeInstanceHistoricDeployment_Data.QueryEdgeInstanceHistoricDeployment_Deployment>();
			for (int i = 0; i < context.Length("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList.Length"); i++) {
				QueryEdgeInstanceHistoricDeploymentResponse.QueryEdgeInstanceHistoricDeployment_Data.QueryEdgeInstanceHistoricDeployment_Deployment deployment = new QueryEdgeInstanceHistoricDeploymentResponse.QueryEdgeInstanceHistoricDeployment_Data.QueryEdgeInstanceHistoricDeployment_Deployment();
				deployment.GmtCreate = context.StringValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].GmtCreate");
				deployment.GmtModified = context.StringValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].GmtModified");
				deployment.GmtCompleted = context.StringValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].GmtCompleted");
				deployment.DeploymentId = context.StringValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].DeploymentId");
				deployment.Description = context.StringValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].Description");
				deployment.Status = context.IntegerValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].Status");
				deployment.Type = context.StringValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].Type");
				deployment.GmtCreateTimestamp = context.LongValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].GmtCreateTimestamp");
				deployment.GmtModifiedTimestamp = context.LongValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].GmtModifiedTimestamp");
				deployment.GmtCompletedTimestamp = context.LongValue("QueryEdgeInstanceHistoricDeployment.Data.DeploymentList["+ i +"].GmtCompletedTimestamp");

				data_deploymentList.Add(deployment);
			}
			data.DeploymentList = data_deploymentList;
			queryEdgeInstanceHistoricDeploymentResponse.Data = data;
        
			return queryEdgeInstanceHistoricDeploymentResponse;
        }
    }
}
