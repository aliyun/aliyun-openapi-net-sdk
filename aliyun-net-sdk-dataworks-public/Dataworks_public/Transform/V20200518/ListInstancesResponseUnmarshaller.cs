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
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = context.HttpResponse;
			listInstancesResponse.Success = context.BooleanValue("ListInstances.Success");
			listInstancesResponse.HttpStatusCode = context.IntegerValue("ListInstances.HttpStatusCode");
			listInstancesResponse.ErrorCode = context.StringValue("ListInstances.ErrorCode");
			listInstancesResponse.ErrorMessage = context.StringValue("ListInstances.ErrorMessage");
			listInstancesResponse.RequestId = context.StringValue("ListInstances.RequestId");

			ListInstancesResponse.ListInstances_Data data = new ListInstancesResponse.ListInstances_Data();
			data.PageNumber = context.IntegerValue("ListInstances.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListInstances.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListInstances.Data.TotalCount");

			List<ListInstancesResponse.ListInstances_Data.ListInstances_InstancesItem> data_instances = new List<ListInstancesResponse.ListInstances_Data.ListInstances_InstancesItem>();
			for (int i = 0; i < context.Length("ListInstances.Data.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Data.ListInstances_InstancesItem instancesItem = new ListInstancesResponse.ListInstances_Data.ListInstances_InstancesItem();
				instancesItem.NodeId = context.IntegerValue("ListInstances.Data.Instances["+ i +"].NodeId");
				instancesItem.InstanceId = context.LongValue("ListInstances.Data.Instances["+ i +"].InstanceId");
				instancesItem.DagId = context.IntegerValue("ListInstances.Data.Instances["+ i +"].DagId");
				instancesItem.DagType = context.StringValue("ListInstances.Data.Instances["+ i +"].DagType");
				instancesItem.Status = context.StringValue("ListInstances.Data.Instances["+ i +"].Status");
				instancesItem.Bizdate = context.LongValue("ListInstances.Data.Instances["+ i +"].Bizdate");
				instancesItem.CycTime = context.LongValue("ListInstances.Data.Instances["+ i +"].CycTime");
				instancesItem.CreateTime = context.LongValue("ListInstances.Data.Instances["+ i +"].CreateTime");
				instancesItem.ModifyTime = context.LongValue("ListInstances.Data.Instances["+ i +"].ModifyTime");
				instancesItem.NodeName = context.StringValue("ListInstances.Data.Instances["+ i +"].NodeName");
				instancesItem.BeginWaitTimeTime = context.LongValue("ListInstances.Data.Instances["+ i +"].BeginWaitTimeTime");
				instancesItem.BeginWaitResTime = context.LongValue("ListInstances.Data.Instances["+ i +"].BeginWaitResTime");
				instancesItem.BeginRunningTime = context.LongValue("ListInstances.Data.Instances["+ i +"].BeginRunningTime");
				instancesItem.ParamValues = context.StringValue("ListInstances.Data.Instances["+ i +"].ParamValues");
				instancesItem.FinishTime = context.LongValue("ListInstances.Data.Instances["+ i +"].FinishTime");

				data_instances.Add(instancesItem);
			}
			data.Instances = data_instances;
			listInstancesResponse.Data = data;
        
			return listInstancesResponse;
        }
    }
}
