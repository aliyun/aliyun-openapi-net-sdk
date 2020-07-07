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

			List<ListInstancesResponse.ListInstances_Data.ListInstances_Instance> data_instances = new List<ListInstancesResponse.ListInstances_Data.ListInstances_Instance>();
			for (int i = 0; i < context.Length("ListInstances.Data.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Data.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Data.ListInstances_Instance();
				instance.NodeId = context.IntegerValue("ListInstances.Data.Instances["+ i +"].NodeId");
				instance.InstanceId = context.LongValue("ListInstances.Data.Instances["+ i +"].InstanceId");
				instance.DagId = context.IntegerValue("ListInstances.Data.Instances["+ i +"].DagId");
				instance.DagType = context.StringValue("ListInstances.Data.Instances["+ i +"].DagType");
				instance.Status = context.StringValue("ListInstances.Data.Instances["+ i +"].Status");
				instance.Bizdate = context.LongValue("ListInstances.Data.Instances["+ i +"].Bizdate");
				instance.CycTime = context.LongValue("ListInstances.Data.Instances["+ i +"].CycTime");
				instance.CreateTime = context.LongValue("ListInstances.Data.Instances["+ i +"].CreateTime");
				instance.ModifyTime = context.LongValue("ListInstances.Data.Instances["+ i +"].ModifyTime");
				instance.NodeName = context.StringValue("ListInstances.Data.Instances["+ i +"].NodeName");
				instance.BeginWaitTimeTime = context.LongValue("ListInstances.Data.Instances["+ i +"].BeginWaitTimeTime");
				instance.BeginWaitResTime = context.LongValue("ListInstances.Data.Instances["+ i +"].BeginWaitResTime");
				instance.BeginRunningTime = context.LongValue("ListInstances.Data.Instances["+ i +"].BeginRunningTime");
				instance.ParamValues = context.StringValue("ListInstances.Data.Instances["+ i +"].ParamValues");
				instance.FinishTime = context.LongValue("ListInstances.Data.Instances["+ i +"].FinishTime");

				data_instances.Add(instance);
			}
			data.Instances = data_instances;
			listInstancesResponse.Data = data;
        
			return listInstancesResponse;
        }
    }
}
