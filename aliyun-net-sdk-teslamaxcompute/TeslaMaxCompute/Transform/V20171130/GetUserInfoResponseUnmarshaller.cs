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
    public class GetUserInfoResponseUnmarshaller
    {
        public static GetUserInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserInfoResponse getUserInfoResponse = new GetUserInfoResponse();

			getUserInfoResponse.HttpResponse = context.HttpResponse;
			getUserInfoResponse.Code = context.IntegerValue("GetUserInfo.Code");
			getUserInfoResponse.Message = context.StringValue("GetUserInfo.Message");
			getUserInfoResponse.RequestId = context.StringValue("GetUserInfo.RequestId");

			GetUserInfoResponse.GetUserInfo_Data data = new GetUserInfoResponse.GetUserInfo_Data();
			data.Total = context.IntegerValue("GetUserInfo.Data.Total");

			List<GetUserInfoResponse.GetUserInfo_Data.GetUserInfo_Instance> data_detail = new List<GetUserInfoResponse.GetUserInfo_Data.GetUserInfo_Instance>();
			for (int i = 0; i < context.Length("GetUserInfo.Data.Detail.Length"); i++) {
				GetUserInfoResponse.GetUserInfo_Data.GetUserInfo_Instance instance = new GetUserInfoResponse.GetUserInfo_Data.GetUserInfo_Instance();
				instance.Project = context.StringValue("GetUserInfo.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetUserInfo.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetUserInfo.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetUserInfo.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetUserInfo.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetUserInfo.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetUserInfo.Data.Detail["+ i +"].RunTime");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getUserInfoResponse.Data = data;
        
			return getUserInfoResponse;
        }
    }
}