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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetNodeOnBaselineResponseUnmarshaller
    {
        public static GetNodeOnBaselineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeOnBaselineResponse getNodeOnBaselineResponse = new GetNodeOnBaselineResponse();

			getNodeOnBaselineResponse.HttpResponse = _ctx.HttpResponse;
			getNodeOnBaselineResponse.Success = _ctx.StringValue("GetNodeOnBaseline.Success");
			getNodeOnBaselineResponse.ErrorCode = _ctx.StringValue("GetNodeOnBaseline.ErrorCode");
			getNodeOnBaselineResponse.ErrorMessage = _ctx.StringValue("GetNodeOnBaseline.ErrorMessage");
			getNodeOnBaselineResponse.HttpStatusCode = _ctx.IntegerValue("GetNodeOnBaseline.HttpStatusCode");
			getNodeOnBaselineResponse.RequestId = _ctx.StringValue("GetNodeOnBaseline.RequestId");

			List<GetNodeOnBaselineResponse.GetNodeOnBaseline_DataItem> getNodeOnBaselineResponse_data = new List<GetNodeOnBaselineResponse.GetNodeOnBaseline_DataItem>();
			for (int i = 0; i < _ctx.Length("GetNodeOnBaseline.Data.Length"); i++) {
				GetNodeOnBaselineResponse.GetNodeOnBaseline_DataItem dataItem = new GetNodeOnBaselineResponse.GetNodeOnBaseline_DataItem();
				dataItem.NodeId = _ctx.LongValue("GetNodeOnBaseline.Data["+ i +"].NodeId");
				dataItem.NodeName = _ctx.StringValue("GetNodeOnBaseline.Data["+ i +"].NodeName");
				dataItem.Owner = _ctx.StringValue("GetNodeOnBaseline.Data["+ i +"].Owner");
				dataItem.ProjectId = _ctx.LongValue("GetNodeOnBaseline.Data["+ i +"].ProjectId");

				getNodeOnBaselineResponse_data.Add(dataItem);
			}
			getNodeOnBaselineResponse.Data = getNodeOnBaselineResponse_data;
        
			return getNodeOnBaselineResponse;
        }
    }
}
