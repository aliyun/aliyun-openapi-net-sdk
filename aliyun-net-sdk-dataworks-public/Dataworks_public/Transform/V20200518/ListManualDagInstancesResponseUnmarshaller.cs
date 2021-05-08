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
    public class ListManualDagInstancesResponseUnmarshaller
    {
        public static ListManualDagInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListManualDagInstancesResponse listManualDagInstancesResponse = new ListManualDagInstancesResponse();

			listManualDagInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listManualDagInstancesResponse.RequestId = _ctx.StringValue("ListManualDagInstances.RequestId");

			List<ListManualDagInstancesResponse.ListManualDagInstances_InstancesItem> listManualDagInstancesResponse_instances = new List<ListManualDagInstancesResponse.ListManualDagInstances_InstancesItem>();
			for (int i = 0; i < _ctx.Length("ListManualDagInstances.Instances.Length"); i++) {
				ListManualDagInstancesResponse.ListManualDagInstances_InstancesItem instancesItem = new ListManualDagInstancesResponse.ListManualDagInstances_InstancesItem();
				instancesItem.NodeId = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].NodeId");
				instancesItem.InstanceId = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].InstanceId");
				instancesItem.DagId = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].DagId");
				instancesItem.DagType = _ctx.StringValue("ListManualDagInstances.Instances["+ i +"].DagType");
				instancesItem.Status = _ctx.StringValue("ListManualDagInstances.Instances["+ i +"].Status");
				instancesItem.BizDate = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].BizDate");
				instancesItem.CycTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].CycTime");
				instancesItem.CreateTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].CreateTime");
				instancesItem.ModifyTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].ModifyTime");
				instancesItem.NodeName = _ctx.StringValue("ListManualDagInstances.Instances["+ i +"].NodeName");
				instancesItem.BeginWaitTimeTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].BeginWaitTimeTime");
				instancesItem.BeginWaitResTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].BeginWaitResTime");
				instancesItem.BeginRunningTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].BeginRunningTime");
				instancesItem.ParamValues = _ctx.StringValue("ListManualDagInstances.Instances["+ i +"].ParamValues");
				instancesItem.FinishTime = _ctx.LongValue("ListManualDagInstances.Instances["+ i +"].FinishTime");
				instancesItem.TaskType = _ctx.StringValue("ListManualDagInstances.Instances["+ i +"].TaskType");

				listManualDagInstancesResponse_instances.Add(instancesItem);
			}
			listManualDagInstancesResponse.Instances = listManualDagInstancesResponse_instances;
        
			return listManualDagInstancesResponse;
        }
    }
}
