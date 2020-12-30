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
        public static ListDeployOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeployOrdersResponse listDeployOrdersResponse = new ListDeployOrdersResponse();

			listDeployOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listDeployOrdersResponse.Code = _ctx.IntegerValue("ListDeployOrders.Code");
			listDeployOrdersResponse.ErrorMsg = _ctx.StringValue("ListDeployOrders.ErrorMsg");
			listDeployOrdersResponse.PageNumber = _ctx.IntegerValue("ListDeployOrders.PageNumber");
			listDeployOrdersResponse.PageSize = _ctx.IntegerValue("ListDeployOrders.PageSize");
			listDeployOrdersResponse.RequestId = _ctx.StringValue("ListDeployOrders.RequestId");
			listDeployOrdersResponse.TotalCount = _ctx.LongValue("ListDeployOrders.TotalCount");

			List<ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance> listDeployOrdersResponse_data = new List<ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance>();
			for (int i = 0; i < _ctx.Length("ListDeployOrders.Data.Length"); i++) {
				ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance deployOrderInstance = new ListDeployOrdersResponse.ListDeployOrders_DeployOrderInstance();
				deployOrderInstance.AppInstanceType = _ctx.StringValue("ListDeployOrders.Data["+ i +"].AppInstanceType");
				deployOrderInstance.CurrentPartitionNum = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].CurrentPartitionNum");
				deployOrderInstance.DeployOrderId = _ctx.LongValue("ListDeployOrders.Data["+ i +"].DeployOrderId");
				deployOrderInstance.DeployPauseType = _ctx.StringValue("ListDeployOrders.Data["+ i +"].DeployPauseType");
				deployOrderInstance.DeployPauseTypeName = _ctx.StringValue("ListDeployOrders.Data["+ i +"].DeployPauseTypeName");
				deployOrderInstance.DeployType = _ctx.StringValue("ListDeployOrders.Data["+ i +"].DeployType");
				deployOrderInstance.DeployTypeName = _ctx.StringValue("ListDeployOrders.Data["+ i +"].DeployTypeName");
				deployOrderInstance.Description = _ctx.StringValue("ListDeployOrders.Data["+ i +"].Description");
				deployOrderInstance.ElapsedTime = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].ElapsedTime");
				deployOrderInstance.EndTime = _ctx.StringValue("ListDeployOrders.Data["+ i +"].EndTime");
				deployOrderInstance.EnvId = _ctx.LongValue("ListDeployOrders.Data["+ i +"].EnvId");
				deployOrderInstance.EnvType = _ctx.StringValue("ListDeployOrders.Data["+ i +"].EnvType");
				deployOrderInstance.FailureRate = _ctx.StringValue("ListDeployOrders.Data["+ i +"].FailureRate");
				deployOrderInstance.FinishAppInstanceCt = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].FinishAppInstanceCt");
				deployOrderInstance.Name = _ctx.StringValue("ListDeployOrders.Data["+ i +"].Name");
				deployOrderInstance.PartitionType = _ctx.StringValue("ListDeployOrders.Data["+ i +"].PartitionType");
				deployOrderInstance.PartitionTypeName = _ctx.StringValue("ListDeployOrders.Data["+ i +"].PartitionTypeName");
				deployOrderInstance.Result = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].Result");
				deployOrderInstance.ResultName = _ctx.StringValue("ListDeployOrders.Data["+ i +"].ResultName");
				deployOrderInstance.SchemaId = _ctx.LongValue("ListDeployOrders.Data["+ i +"].SchemaId");
				deployOrderInstance.StartTime = _ctx.StringValue("ListDeployOrders.Data["+ i +"].StartTime");
				deployOrderInstance.Status = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].Status");
				deployOrderInstance.StatusName = _ctx.StringValue("ListDeployOrders.Data["+ i +"].StatusName");
				deployOrderInstance.TotalAppInstanceCt = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].TotalAppInstanceCt");
				deployOrderInstance.TotalPartitions = _ctx.IntegerValue("ListDeployOrders.Data["+ i +"].TotalPartitions");
				deployOrderInstance.UserId = _ctx.StringValue("ListDeployOrders.Data["+ i +"].UserId");
				deployOrderInstance.UserNick = _ctx.StringValue("ListDeployOrders.Data["+ i +"].UserNick");

				listDeployOrdersResponse_data.Add(deployOrderInstance);
			}
			listDeployOrdersResponse.Data = listDeployOrdersResponse_data;
        
			return listDeployOrdersResponse;
        }
    }
}
