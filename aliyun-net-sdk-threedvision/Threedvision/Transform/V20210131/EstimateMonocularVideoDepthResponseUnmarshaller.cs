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
using Aliyun.Acs.threedvision.Model.V20210131;

namespace Aliyun.Acs.threedvision.Transform.V20210131
{
    public class EstimateMonocularVideoDepthResponseUnmarshaller
    {
        public static EstimateMonocularVideoDepthResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EstimateMonocularVideoDepthResponse estimateMonocularVideoDepthResponse = new EstimateMonocularVideoDepthResponse();

			estimateMonocularVideoDepthResponse.HttpResponse = _ctx.HttpResponse;
			estimateMonocularVideoDepthResponse.RequestId = _ctx.StringValue("EstimateMonocularVideoDepth.RequestId");
			estimateMonocularVideoDepthResponse.Code = _ctx.StringValue("EstimateMonocularVideoDepth.Code");
			estimateMonocularVideoDepthResponse.Message = _ctx.StringValue("EstimateMonocularVideoDepth.Message");

			EstimateMonocularVideoDepthResponse.EstimateMonocularVideoDepth_Data data = new EstimateMonocularVideoDepthResponse.EstimateMonocularVideoDepth_Data();
			data.DepthUrl = _ctx.StringValue("EstimateMonocularVideoDepth.Data.DepthUrl");
			data.DepthVisUrl = _ctx.StringValue("EstimateMonocularVideoDepth.Data.DepthVisUrl");
			estimateMonocularVideoDepthResponse.Data = data;
        
			return estimateMonocularVideoDepthResponse;
        }
    }
}
