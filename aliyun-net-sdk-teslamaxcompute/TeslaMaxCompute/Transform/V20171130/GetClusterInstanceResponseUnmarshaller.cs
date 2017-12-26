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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.TeslaMaxCompute.Model.V20171130;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Transform.V20171130
{
    public class GetClusterInstanceResponseUnmarshaller
    {
        public static GetClusterInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetClusterInstanceResponse getClusterInstanceResponse = new GetClusterInstanceResponse();

			getClusterInstanceResponse.HttpResponse = context.HttpResponse;
			getClusterInstanceResponse.Code = context.IntegerValue("GetClusterInstance.Code");
			getClusterInstanceResponse.Message = context.StringValue("GetClusterInstance.Message");
			getClusterInstanceResponse.RequestId = context.StringValue("GetClusterInstance.RequestId");

			GetClusterInstanceResponse.GetClusterInstance_Data data = new GetClusterInstanceResponse.GetClusterInstance_Data();
			data.Total = context.IntegerValue("GetClusterInstance.Data.Total");

			List<GetClusterInstanceResponse.GetClusterInstance_Data.GetClusterInstance_Instance> data_detail = new List<GetClusterInstanceResponse.GetClusterInstance_Data.GetClusterInstance_Instance>();
			for (int i = 0; i < context.Length("GetClusterInstance.Data.Detail.Length"); i++) {
				GetClusterInstanceResponse.GetClusterInstance_Data.GetClusterInstance_Instance instance = new GetClusterInstanceResponse.GetClusterInstance_Data.GetClusterInstance_Instance();
				instance.Project = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].RunTime");
				instance.CpuUsed = context.LongValue("GetClusterInstance.Data.Detail["+ i +"].CpuUsed");
				instance.CpuRequest = context.LongValue("GetClusterInstance.Data.Detail["+ i +"].CpuRequest");
				instance.CpuUsedTotal = context.LongValue("GetClusterInstance.Data.Detail["+ i +"].CpuUsedTotal");
				instance.CpuUsedRatioMax = context.FloatValue("GetClusterInstance.Data.Detail["+ i +"].CpuUsedRatioMax");
				instance.CpuUsedRatioMin = context.FloatValue("GetClusterInstance.Data.Detail["+ i +"].CpuUsedRatioMin");
				instance.MemUsed = context.LongValue("GetClusterInstance.Data.Detail["+ i +"].MemUsed");
				instance.MemRequest = context.LongValue("GetClusterInstance.Data.Detail["+ i +"].MemRequest");
				instance.MemUsedTotal = context.LongValue("GetClusterInstance.Data.Detail["+ i +"].MemUsedTotal");
				instance.MemUsedRatioMax = context.FloatValue("GetClusterInstance.Data.Detail["+ i +"].MemUsedRatioMax");
				instance.MemUsedRatioMin = context.FloatValue("GetClusterInstance.Data.Detail["+ i +"].MemUsedRatioMin");
				instance.TaskType = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].TaskType");
				instance.SkynetId = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].SkynetId");
				instance.QuotaName = context.StringValue("GetClusterInstance.Data.Detail["+ i +"].QuotaName");
				instance.QuotaId = context.IntegerValue("GetClusterInstance.Data.Detail["+ i +"].QuotaId");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getClusterInstanceResponse.Data = data;
        
			return getClusterInstanceResponse;
        }
    }
}