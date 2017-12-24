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
    public class GetQuotaInstanceResponseUnmarshaller
    {
        public static GetQuotaInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetQuotaInstanceResponse getQuotaInstanceResponse = new GetQuotaInstanceResponse();

			getQuotaInstanceResponse.HttpResponse = context.HttpResponse;
			getQuotaInstanceResponse.Code = context.IntegerValue("GetQuotaInstance.Code");
			getQuotaInstanceResponse.Message = context.StringValue("GetQuotaInstance.Message");
			getQuotaInstanceResponse.RequestId = context.StringValue("GetQuotaInstance.RequestId");

			GetQuotaInstanceResponse.GetQuotaInstance_Data data = new GetQuotaInstanceResponse.GetQuotaInstance_Data();
			data.Total = context.IntegerValue("GetQuotaInstance.Data.Total");

			List<GetQuotaInstanceResponse.GetQuotaInstance_Data.GetQuotaInstance_Instance> data_detail = new List<GetQuotaInstanceResponse.GetQuotaInstance_Data.GetQuotaInstance_Instance>();
			for (int i = 0; i < context.Length("GetQuotaInstance.Data.Detail.Length"); i++) {
				GetQuotaInstanceResponse.GetQuotaInstance_Data.GetQuotaInstance_Instance instance = new GetQuotaInstanceResponse.GetQuotaInstance_Data.GetQuotaInstance_Instance();
				instance.Project = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].RunTime");
				instance.CpuUsed = context.IntegerValue("GetQuotaInstance.Data.Detail["+ i +"].CpuUsed");
				instance.CpuRequest = context.IntegerValue("GetQuotaInstance.Data.Detail["+ i +"].CpuRequest");
				instance.CpuUsedTotal = context.IntegerValue("GetQuotaInstance.Data.Detail["+ i +"].CpuUsedTotal");
				instance.CpuUsedRatioMax = context.FloatValue("GetQuotaInstance.Data.Detail["+ i +"].CpuUsedRatioMax");
				instance.CpuUsedRatioMin = context.FloatValue("GetQuotaInstance.Data.Detail["+ i +"].CpuUsedRatioMin");
				instance.MemUsed = context.IntegerValue("GetQuotaInstance.Data.Detail["+ i +"].MemUsed");
				instance.MemRequest = context.IntegerValue("GetQuotaInstance.Data.Detail["+ i +"].MemRequest");
				instance.MemUsedTotal = context.IntegerValue("GetQuotaInstance.Data.Detail["+ i +"].MemUsedTotal");
				instance.MemUsedRatioMax = context.FloatValue("GetQuotaInstance.Data.Detail["+ i +"].MemUsedRatioMax");
				instance.MemUsedRatioMin = context.FloatValue("GetQuotaInstance.Data.Detail["+ i +"].MemUsedRatioMin");
				instance.TaskType = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].TaskType");
				instance.SkynetId = context.StringValue("GetQuotaInstance.Data.Detail["+ i +"].SkynetId");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getQuotaInstanceResponse.Data = data;
        
			return getQuotaInstanceResponse;
        }
    }
}