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
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.Success = _ctx.BooleanValue("ListInstances.Success");
			listInstancesResponse.HttpStatusCode = _ctx.IntegerValue("ListInstances.HttpStatusCode");
			listInstancesResponse.ErrorCode = _ctx.StringValue("ListInstances.ErrorCode");
			listInstancesResponse.ErrorMessage = _ctx.StringValue("ListInstances.ErrorMessage");
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");

			ListInstancesResponse.ListInstances_Data data = new ListInstancesResponse.ListInstances_Data();
			data.PageNumber = _ctx.IntegerValue("ListInstances.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListInstances.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListInstances.Data.TotalCount");

			List<ListInstancesResponse.ListInstances_Data.ListInstances_Instance> data_instances = new List<ListInstancesResponse.ListInstances_Data.ListInstances_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstances.Data.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Data.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Data.ListInstances_Instance();
				instance.NodeId = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].NodeId");
				instance.InstanceId = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].InstanceId");
				instance.DagId = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].DagId");
				instance.DagType = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].DagType");
				instance.Status = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].Status");
				instance.Bizdate = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].Bizdate");
				instance.CycTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].CycTime");
				instance.CreateTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].CreateTime");
				instance.ModifyTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].ModifyTime");
				instance.NodeName = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].NodeName");
				instance.BeginWaitTimeTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].BeginWaitTimeTime");
				instance.BeginWaitResTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].BeginWaitResTime");
				instance.BeginRunningTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].BeginRunningTime");
				instance.ParamValues = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].ParamValues");
				instance.FinishTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].FinishTime");
				instance.Priority = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].Priority");
				instance.BaselineId = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].BaselineId");
				instance.Repeatability = _ctx.BooleanValue("ListInstances.Data.Instances["+ i +"].Repeatability");
				instance.RepeatInterval = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].RepeatInterval");
				instance.Connection = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].Connection");
				instance.DqcType = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].DqcType");
				instance.DqcDescription = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].DqcDescription");
				instance.ErrorMessage = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].ErrorMessage");
				instance.RelatedFlowId = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].RelatedFlowId");
				instance.TaskType = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].TaskType");
				instance.TaskRerunTime = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].TaskRerunTime");

				data_instances.Add(instance);
			}
			data.Instances = data_instances;
			listInstancesResponse.Data = data;
        
			return listInstancesResponse;
        }
    }
}
