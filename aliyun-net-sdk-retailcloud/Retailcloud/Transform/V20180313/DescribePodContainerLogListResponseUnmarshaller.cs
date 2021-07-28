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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribePodContainerLogListResponseUnmarshaller
    {
        public static DescribePodContainerLogListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePodContainerLogListResponse describePodContainerLogListResponse = new DescribePodContainerLogListResponse();

			describePodContainerLogListResponse.HttpResponse = _ctx.HttpResponse;
			describePodContainerLogListResponse.Code = _ctx.IntegerValue("DescribePodContainerLogList.Code");
			describePodContainerLogListResponse.ErrMsg = _ctx.StringValue("DescribePodContainerLogList.ErrMsg");
			describePodContainerLogListResponse.RequestId = _ctx.StringValue("DescribePodContainerLogList.RequestId");
			describePodContainerLogListResponse.Success = _ctx.BooleanValue("DescribePodContainerLogList.Success");

			DescribePodContainerLogListResponse.DescribePodContainerLogList_Result result = new DescribePodContainerLogListResponse.DescribePodContainerLogList_Result();

			List<DescribePodContainerLogListResponse.DescribePodContainerLogList_Result.DescribePodContainerLogList_PodContainerLog> result_containerLogList = new List<DescribePodContainerLogListResponse.DescribePodContainerLogList_Result.DescribePodContainerLogList_PodContainerLog>();
			for (int i = 0; i < _ctx.Length("DescribePodContainerLogList.Result.ContainerLogList.Length"); i++) {
				DescribePodContainerLogListResponse.DescribePodContainerLogList_Result.DescribePodContainerLogList_PodContainerLog podContainerLog = new DescribePodContainerLogListResponse.DescribePodContainerLogList_Result.DescribePodContainerLogList_PodContainerLog();
				podContainerLog.ContainerName = _ctx.StringValue("DescribePodContainerLogList.Result.ContainerLogList["+ i +"].ContainerName");
				podContainerLog.Content = _ctx.StringValue("DescribePodContainerLogList.Result.ContainerLogList["+ i +"].Content");
				podContainerLog.PodName = _ctx.StringValue("DescribePodContainerLogList.Result.ContainerLogList["+ i +"].PodName");

				result_containerLogList.Add(podContainerLog);
			}
			result.ContainerLogList = result_containerLogList;
			describePodContainerLogListResponse.Result = result;
        
			return describePodContainerLogListResponse;
        }
    }
}
