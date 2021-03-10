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
    public class GetManualDagInstancesResponseUnmarshaller
    {
        public static GetManualDagInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetManualDagInstancesResponse getManualDagInstancesResponse = new GetManualDagInstancesResponse();

			getManualDagInstancesResponse.HttpResponse = _ctx.HttpResponse;
			getManualDagInstancesResponse.RequestId = _ctx.StringValue("GetManualDagInstances.RequestId");

			List<GetManualDagInstancesResponse.GetManualDagInstances_InstancesItem> getManualDagInstancesResponse_instances = new List<GetManualDagInstancesResponse.GetManualDagInstances_InstancesItem>();
			for (int i = 0; i < _ctx.Length("GetManualDagInstances.Instances.Length"); i++) {
				GetManualDagInstancesResponse.GetManualDagInstances_InstancesItem instancesItem = new GetManualDagInstancesResponse.GetManualDagInstances_InstancesItem();
				instancesItem.NodeId = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].NodeId");
				instancesItem.InstanceId = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].InstanceId");
				instancesItem.DagId = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].DagId");
				instancesItem.DagType = _ctx.StringValue("GetManualDagInstances.Instances["+ i +"].DagType");
				instancesItem.Status = _ctx.StringValue("GetManualDagInstances.Instances["+ i +"].Status");
				instancesItem.BizDate = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].BizDate");
				instancesItem.CycTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].CycTime");
				instancesItem.CreateTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].CreateTime");
				instancesItem.ModifyTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].ModifyTime");
				instancesItem.NodeName = _ctx.StringValue("GetManualDagInstances.Instances["+ i +"].NodeName");
				instancesItem.BeginWaitTimeTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].BeginWaitTimeTime");
				instancesItem.BeginWaitResTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].BeginWaitResTime");
				instancesItem.BeginRunningTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].BeginRunningTime");
				instancesItem.ParamValues = _ctx.StringValue("GetManualDagInstances.Instances["+ i +"].ParamValues");
				instancesItem.FinishTime = _ctx.LongValue("GetManualDagInstances.Instances["+ i +"].FinishTime");
				instancesItem.TaskType = _ctx.StringValue("GetManualDagInstances.Instances["+ i +"].TaskType");

				getManualDagInstancesResponse_instances.Add(instancesItem);
			}
			getManualDagInstancesResponse.Instances = getManualDagInstancesResponse_instances;
        
			return getManualDagInstancesResponse;
        }
    }
}
