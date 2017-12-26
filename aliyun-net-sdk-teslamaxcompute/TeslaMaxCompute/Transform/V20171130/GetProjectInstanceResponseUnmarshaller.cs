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
    public class GetProjectInstanceResponseUnmarshaller
    {
        public static GetProjectInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectInstanceResponse getProjectInstanceResponse = new GetProjectInstanceResponse();

			getProjectInstanceResponse.HttpResponse = context.HttpResponse;
			getProjectInstanceResponse.Code = context.IntegerValue("GetProjectInstance.Code");
			getProjectInstanceResponse.Message = context.StringValue("GetProjectInstance.Message");
			getProjectInstanceResponse.RequestId = context.StringValue("GetProjectInstance.RequestId");

			GetProjectInstanceResponse.GetProjectInstance_Data data = new GetProjectInstanceResponse.GetProjectInstance_Data();
			data.Total = context.IntegerValue("GetProjectInstance.Data.Total");

			List<GetProjectInstanceResponse.GetProjectInstance_Data.GetProjectInstance_Instance> data_detail = new List<GetProjectInstanceResponse.GetProjectInstance_Data.GetProjectInstance_Instance>();
			for (int i = 0; i < context.Length("GetProjectInstance.Data.Detail.Length"); i++) {
				GetProjectInstanceResponse.GetProjectInstance_Data.GetProjectInstance_Instance instance = new GetProjectInstanceResponse.GetProjectInstance_Data.GetProjectInstance_Instance();
				instance.Project = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].RunTime");
				instance.CpuUsed = context.LongValue("GetProjectInstance.Data.Detail["+ i +"].CpuUsed");
				instance.CpuRequest = context.LongValue("GetProjectInstance.Data.Detail["+ i +"].CpuRequest");
				instance.CpuUsedTotal = context.LongValue("GetProjectInstance.Data.Detail["+ i +"].CpuUsedTotal");
				instance.CpuUsedRatioMax = context.FloatValue("GetProjectInstance.Data.Detail["+ i +"].CpuUsedRatioMax");
				instance.CpuUsedRatioMin = context.FloatValue("GetProjectInstance.Data.Detail["+ i +"].CpuUsedRatioMin");
				instance.MemUsed = context.LongValue("GetProjectInstance.Data.Detail["+ i +"].MemUsed");
				instance.MemRequest = context.LongValue("GetProjectInstance.Data.Detail["+ i +"].MemRequest");
				instance.MemUsedTotal = context.LongValue("GetProjectInstance.Data.Detail["+ i +"].MemUsedTotal");
				instance.MemUsedRatioMax = context.FloatValue("GetProjectInstance.Data.Detail["+ i +"].MemUsedRatioMax");
				instance.MemUsedRatioMin = context.FloatValue("GetProjectInstance.Data.Detail["+ i +"].MemUsedRatioMin");
				instance.TaskType = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].TaskType");
				instance.SkynetId = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].SkynetId");
				instance.QuotaName = context.StringValue("GetProjectInstance.Data.Detail["+ i +"].QuotaName");
				instance.QuotaId = context.IntegerValue("GetProjectInstance.Data.Detail["+ i +"].QuotaId");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getProjectInstanceResponse.Data = data;
        
			return getProjectInstanceResponse;
        }
    }
}