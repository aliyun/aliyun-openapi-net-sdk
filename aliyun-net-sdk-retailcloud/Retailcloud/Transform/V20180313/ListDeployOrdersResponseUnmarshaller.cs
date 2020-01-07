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
    public class ListDeployOrdersResponseUnmarshaller
    {
        public static ListDeployOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListDeployOrdersResponse listDeployOrdersResponse = new ListDeployOrdersResponse();

			listDeployOrdersResponse.HttpResponse = context.HttpResponse;
			listDeployOrdersResponse.Code = context.IntegerValue("ListDeployOrders.Code");
			listDeployOrdersResponse.ErrorMsg = context.StringValue("ListDeployOrders.ErrorMsg");
			listDeployOrdersResponse.PageNumber = context.IntegerValue("ListDeployOrders.PageNumber");
			listDeployOrdersResponse.PageSize = context.IntegerValue("ListDeployOrders.PageSize");
			listDeployOrdersResponse.RequestId = context.StringValue("ListDeployOrders.RequestId");
			listDeployOrdersResponse.TotalCount = context.LongValue("ListDeployOrders.TotalCount");

			List<ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance> listDeployOrdersResponse_data = new List<ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance>();
			for (int i = 0; i < context.Length("ListDeployOrders.Data.Length"); i++) {
				ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance deployOrderInstance = new ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance();
				deployOrderInstance.AppInstanceType = context.StringValue("ListDeployOrders.Data["+ i +"].AppInstanceType");
				deployOrderInstance.CurrentPartitionNum = context.IntegerValue("ListDeployOrders.Data["+ i +"].CurrentPartitionNum");
				deployOrderInstance.DeployOrderId = context.LongValue("ListDeployOrders.Data["+ i +"].DeployOrderId");
				deployOrderInstance.DeployPauseType = context.StringValue("ListDeployOrders.Data["+ i +"].DeployPauseType");
				deployOrderInstance.DeployPauseTypeName = context.StringValue("ListDeployOrders.Data["+ i +"].DeployPauseTypeName");
				deployOrderInstance.DeployType = context.StringValue("ListDeployOrders.Data["+ i +"].DeployType");
				deployOrderInstance.DeployTypeName = context.StringValue("ListDeployOrders.Data["+ i +"].DeployTypeName");
				deployOrderInstance.Description = context.StringValue("ListDeployOrders.Data["+ i +"].Description");
				deployOrderInstance.ElapsedTime = context.IntegerValue("ListDeployOrders.Data["+ i +"].ElapsedTime");
				deployOrderInstance.EndTime = context.StringValue("ListDeployOrders.Data["+ i +"].EndTime");
				deployOrderInstance.EnvId = context.LongValue("ListDeployOrders.Data["+ i +"].EnvId");
				deployOrderInstance.EnvType = context.StringValue("ListDeployOrders.Data["+ i +"].EnvType");
				deployOrderInstance.FailureRate = context.StringValue("ListDeployOrders.Data["+ i +"].FailureRate");
				deployOrderInstance.FinishAppInstanceCt = context.IntegerValue("ListDeployOrders.Data["+ i +"].FinishAppInstanceCt");
				deployOrderInstance.Name = context.StringValue("ListDeployOrders.Data["+ i +"].Name");
				deployOrderInstance.PartitionType = context.StringValue("ListDeployOrders.Data["+ i +"].PartitionType");
				deployOrderInstance.PartitionTypeName = context.StringValue("ListDeployOrders.Data["+ i +"].PartitionTypeName");
				deployOrderInstance.Result = context.IntegerValue("ListDeployOrders.Data["+ i +"].Result");
				deployOrderInstance.ResultName = context.StringValue("ListDeployOrders.Data["+ i +"].ResultName");
				deployOrderInstance.SchemaId = context.LongValue("ListDeployOrders.Data["+ i +"].SchemaId");
				deployOrderInstance.StartTime = context.StringValue("ListDeployOrders.Data["+ i +"].StartTime");
				deployOrderInstance.Status = context.IntegerValue("ListDeployOrders.Data["+ i +"].Status");
				deployOrderInstance.StatusName = context.StringValue("ListDeployOrders.Data["+ i +"].StatusName");
				deployOrderInstance.TotalAppInstanceCt = context.IntegerValue("ListDeployOrders.Data["+ i +"].TotalAppInstanceCt");
				deployOrderInstance.TotalPartitions = context.IntegerValue("ListDeployOrders.Data["+ i +"].TotalPartitions");
				deployOrderInstance.UserId = context.StringValue("ListDeployOrders.Data["+ i +"].UserId");
				deployOrderInstance.UserNick = context.StringValue("ListDeployOrders.Data["+ i +"].UserNick");

				listDeployOrdersResponse_data.Add(deployOrderInstance);
			}
			listDeployOrdersResponse.Data = listDeployOrdersResponse_data;
        
			return listDeployOrdersResponse;
        }
    }
}
