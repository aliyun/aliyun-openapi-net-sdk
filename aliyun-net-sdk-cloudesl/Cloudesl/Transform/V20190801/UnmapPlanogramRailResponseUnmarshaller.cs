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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class UnmapPlanogramRailResponseUnmarshaller
    {
        public static UnmapPlanogramRailResponse Unmarshall(UnmarshallerContext context)
        {
			UnmapPlanogramRailResponse unmapPlanogramRailResponse = new UnmapPlanogramRailResponse();

			unmapPlanogramRailResponse.HttpResponse = context.HttpResponse;
			unmapPlanogramRailResponse.ErrorMessage = context.StringValue("UnmapPlanogramRail.ErrorMessage");
			unmapPlanogramRailResponse.ErrorCode = context.StringValue("UnmapPlanogramRail.ErrorCode");
			unmapPlanogramRailResponse.Message = context.StringValue("UnmapPlanogramRail.Message");
			unmapPlanogramRailResponse.DynamicCode = context.StringValue("UnmapPlanogramRail.DynamicCode");
			unmapPlanogramRailResponse.Code = context.StringValue("UnmapPlanogramRail.Code");
			unmapPlanogramRailResponse.DynamicMessage = context.StringValue("UnmapPlanogramRail.DynamicMessage");
			unmapPlanogramRailResponse.RequestId = context.StringValue("UnmapPlanogramRail.RequestId");
			unmapPlanogramRailResponse.Success = context.BooleanValue("UnmapPlanogramRail.Success");
        
			return unmapPlanogramRailResponse;
        }
    }
}
