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
    public class GetClusterInfoResponseUnmarshaller
    {
        public static GetClusterInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetClusterInfoResponse getClusterInfoResponse = new GetClusterInfoResponse();

			getClusterInfoResponse.HttpResponse = context.HttpResponse;
			getClusterInfoResponse.Code = context.IntegerValue("GetClusterInfo.Code");
			getClusterInfoResponse.Message = context.StringValue("GetClusterInfo.Message");
			getClusterInfoResponse.RequestId = context.StringValue("GetClusterInfo.RequestId");

			GetClusterInfoResponse.GetClusterInfo_Data data = new GetClusterInfoResponse.GetClusterInfo_Data();
			data.Total = context.IntegerValue("GetClusterInfo.Data.Total");

			List<GetClusterInfoResponse.GetClusterInfo_Data.GetClusterInfo_Instance> data_detail = new List<GetClusterInfoResponse.GetClusterInfo_Data.GetClusterInfo_Instance>();
			for (int i = 0; i < context.Length("GetClusterInfo.Data.Detail.Length"); i++) {
				GetClusterInfoResponse.GetClusterInfo_Data.GetClusterInfo_Instance instance = new GetClusterInfoResponse.GetClusterInfo_Data.GetClusterInfo_Instance();
				instance.Project = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetClusterInfo.Data.Detail["+ i +"].RunTime");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getClusterInfoResponse.Data = data;
        
			return getClusterInfoResponse;
        }
    }
}