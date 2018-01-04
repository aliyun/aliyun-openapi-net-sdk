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
using Aliyun.Acs.TeslaMaxCompute.Model.V20180104;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Transform.V20180104
{
    public class GetUserInstanceResponseUnmarshaller
    {
        public static GetUserInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserInstanceResponse getUserInstanceResponse = new GetUserInstanceResponse();

			getUserInstanceResponse.HttpResponse = context.HttpResponse;
			getUserInstanceResponse.Code = context.IntegerValue("GetUserInstance.Code");
			getUserInstanceResponse.Message = context.StringValue("GetUserInstance.Message");
			getUserInstanceResponse.RequestId = context.StringValue("GetUserInstance.RequestId");

			GetUserInstanceResponse.GetUserInstance_Data data = new GetUserInstanceResponse.GetUserInstance_Data();
			data.Total = context.IntegerValue("GetUserInstance.Data.Total");

			List<GetUserInstanceResponse.GetUserInstance_Data.GetUserInstance_Instance> data_detail = new List<GetUserInstanceResponse.GetUserInstance_Data.GetUserInstance_Instance>();
			for (int i = 0; i < context.Length("GetUserInstance.Data.Detail.Length"); i++) {
				GetUserInstanceResponse.GetUserInstance_Data.GetUserInstance_Instance instance = new GetUserInstanceResponse.GetUserInstance_Data.GetUserInstance_Instance();
				instance.Project = context.StringValue("GetUserInstance.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetUserInstance.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetUserInstance.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetUserInstance.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetUserInstance.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetUserInstance.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetUserInstance.Data.Detail["+ i +"].RunTime");
				instance.CpuUsed = context.LongValue("GetUserInstance.Data.Detail["+ i +"].CpuUsed");
				instance.CpuRequest = context.LongValue("GetUserInstance.Data.Detail["+ i +"].CpuRequest");
				instance.CpuUsedTotal = context.LongValue("GetUserInstance.Data.Detail["+ i +"].CpuUsedTotal");
				instance.CpuUsedRatioMax = context.FloatValue("GetUserInstance.Data.Detail["+ i +"].CpuUsedRatioMax");
				instance.CpuUsedRatioMin = context.FloatValue("GetUserInstance.Data.Detail["+ i +"].CpuUsedRatioMin");
				instance.MemUsed = context.LongValue("GetUserInstance.Data.Detail["+ i +"].MemUsed");
				instance.MemRequest = context.LongValue("GetUserInstance.Data.Detail["+ i +"].MemRequest");
				instance.MemUsedTotal = context.LongValue("GetUserInstance.Data.Detail["+ i +"].MemUsedTotal");
				instance.MemUsedRatioMax = context.FloatValue("GetUserInstance.Data.Detail["+ i +"].MemUsedRatioMax");
				instance.MemUsedRatioMin = context.FloatValue("GetUserInstance.Data.Detail["+ i +"].MemUsedRatioMin");
				instance.TaskType = context.StringValue("GetUserInstance.Data.Detail["+ i +"].TaskType");
				instance.SkynetId = context.StringValue("GetUserInstance.Data.Detail["+ i +"].SkynetId");
				instance.QuotaName = context.StringValue("GetUserInstance.Data.Detail["+ i +"].QuotaName");
				instance.QuotaId = context.IntegerValue("GetUserInstance.Data.Detail["+ i +"].QuotaId");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getUserInstanceResponse.Data = data;
        
			return getUserInstanceResponse;
        }
    }
}