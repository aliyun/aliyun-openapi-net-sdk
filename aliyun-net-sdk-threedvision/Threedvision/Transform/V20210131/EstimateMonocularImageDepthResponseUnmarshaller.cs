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
    public class EstimateMonocularImageDepthResponseUnmarshaller
    {
        public static EstimateMonocularImageDepthResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EstimateMonocularImageDepthResponse estimateMonocularImageDepthResponse = new EstimateMonocularImageDepthResponse();

			estimateMonocularImageDepthResponse.HttpResponse = _ctx.HttpResponse;
			estimateMonocularImageDepthResponse.RequestId = _ctx.StringValue("EstimateMonocularImageDepth.RequestId");
			estimateMonocularImageDepthResponse.Code = _ctx.StringValue("EstimateMonocularImageDepth.Code");
			estimateMonocularImageDepthResponse.Message = _ctx.StringValue("EstimateMonocularImageDepth.Message");

			EstimateMonocularImageDepthResponse.EstimateMonocularImageDepth_Data data = new EstimateMonocularImageDepthResponse.EstimateMonocularImageDepth_Data();
			data.DepthMapUrl = _ctx.StringValue("EstimateMonocularImageDepth.Data.DepthMapUrl");
			data.DepthToColorUrl = _ctx.StringValue("EstimateMonocularImageDepth.Data.DepthToColorUrl");
			estimateMonocularImageDepthResponse.Data = data;
        
			return estimateMonocularImageDepthResponse;
        }
    }
}
