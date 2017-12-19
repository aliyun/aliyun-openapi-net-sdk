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
    public class GetProjectInfoResponseUnmarshaller
    {
        public static GetProjectInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectInfoResponse getProjectInfoResponse = new GetProjectInfoResponse();

			getProjectInfoResponse.HttpResponse = context.HttpResponse;
			getProjectInfoResponse.Code = context.IntegerValue("GetProjectInfo.Code");
			getProjectInfoResponse.Message = context.StringValue("GetProjectInfo.Message");
			getProjectInfoResponse.RequestId = context.StringValue("GetProjectInfo.RequestId");

			GetProjectInfoResponse.GetProjectInfo_Data data = new GetProjectInfoResponse.GetProjectInfo_Data();
			data.Total = context.IntegerValue("GetProjectInfo.Data.Total");

			List<GetProjectInfoResponse.GetProjectInfo_Data.GetProjectInfo_Instance> data_detail = new List<GetProjectInfoResponse.GetProjectInfo_Data.GetProjectInfo_Instance>();
			for (int i = 0; i < context.Length("GetProjectInfo.Data.Detail.Length"); i++) {
				GetProjectInfoResponse.GetProjectInfo_Data.GetProjectInfo_Instance instance = new GetProjectInfoResponse.GetProjectInfo_Data.GetProjectInfo_Instance();
				instance.Project = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].Project");
				instance.InstanceId = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].InstanceId");
				instance.Status = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].Status");
				instance.UserAccount = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].UserAccount");
				instance.NickName = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].NickName");
				instance.Cluster = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].Cluster");
				instance.RunTime = context.StringValue("GetProjectInfo.Data.Detail["+ i +"].RunTime");

				data_detail.Add(instance);
			}
			data.Detail = data_detail;
			getProjectInfoResponse.Data = data;
        
			return getProjectInfoResponse;
        }
    }
}