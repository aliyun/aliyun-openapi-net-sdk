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
    public class GetQuotaInfoResponseUnmarshaller
    {
        public static GetQuotaInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetQuotaInfoResponse getQuotaInfoResponse = new GetQuotaInfoResponse();

			getQuotaInfoResponse.HttpResponse = context.HttpResponse;
			getQuotaInfoResponse.Code = context.IntegerValue("GetQuotaInfo.Code");
			getQuotaInfoResponse.Message = context.StringValue("GetQuotaInfo.Message");
			getQuotaInfoResponse.Request_id = context.StringValue("GetQuotaInfo.Request_id");

			GetQuotaInfoResponse.GetQuotaInfo_Data data = new GetQuotaInfoResponse.GetQuotaInfo_Data();
			data.Total = context.IntegerValue("GetQuotaInfo.Data.Total");

			List<GetQuotaInfoResponse.GetQuotaInfo_Data.GetQuotaInfo_Instance> data_detail = new List<GetQuotaInfoResponse.GetQuotaInfo_Data.GetQuotaInfo_Instance>();
			for (int i = 0; i < context.Length("GetQuotaInfo.Data.Detail.Length"); i++) {
				GetQuotaInfoResponse.GetQuotaInfo_Data.GetQuotaInfo_Instance instance = new GetQuotaInfoResponse.GetQuotaInfo_Data.GetQuotaInfo_Instance();
				instance.Project = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].Project");
				instance.Instanceid = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].Instanceid");
				instance.Status = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].UserAccount");
				instance.ChName = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].ChName");
				instance.Cluster = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetQuotaInfo.Data.Detail["+ i +"].RunTime");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getQuotaInfoResponse.Data = data;
        
			return getQuotaInfoResponse;
        }
    }
}