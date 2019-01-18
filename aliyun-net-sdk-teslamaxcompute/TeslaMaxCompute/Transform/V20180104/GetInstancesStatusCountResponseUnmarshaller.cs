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
    public class GetInstancesStatusCountResponseUnmarshaller
    {
        public static GetInstancesStatusCountResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstancesStatusCountResponse getInstancesStatusCountResponse = new GetInstancesStatusCountResponse();

			getInstancesStatusCountResponse.HttpResponse = context.HttpResponse;
			getInstancesStatusCountResponse.Code = context.IntegerValue("GetInstancesStatusCount.Code");
			getInstancesStatusCountResponse.Message = context.StringValue("GetInstancesStatusCount.Message");
			getInstancesStatusCountResponse.RequestId = context.StringValue("GetInstancesStatusCount.RequestId");

			List<GetInstancesStatusCountResponse.GetInstancesStatusCount_DataItem> getInstancesStatusCountResponse_data = new List<GetInstancesStatusCountResponse.GetInstancesStatusCount_DataItem>();
			for (int i = 0; i < context.Length("GetInstancesStatusCount.Data.Length"); i++) {
				GetInstancesStatusCountResponse.GetInstancesStatusCount_DataItem dataItem = new GetInstancesStatusCountResponse.GetInstancesStatusCount_DataItem();
				dataItem.Status = context.StringValue("GetInstancesStatusCount.Data["+ i +"].Status");
				dataItem.Size = context.IntegerValue("GetInstancesStatusCount.Data["+ i +"].Size");

				getInstancesStatusCountResponse_data.Add(dataItem);
			}
			getInstancesStatusCountResponse.Data = getInstancesStatusCountResponse_data;
        
			return getInstancesStatusCountResponse;
        }
    }
}