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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DissociatePlanogramRailResponseUnmarshaller
    {
        public static DissociatePlanogramRailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DissociatePlanogramRailResponse dissociatePlanogramRailResponse = new DissociatePlanogramRailResponse();

			dissociatePlanogramRailResponse.HttpResponse = _ctx.HttpResponse;
			dissociatePlanogramRailResponse.ErrorMessage = _ctx.StringValue("DissociatePlanogramRail.ErrorMessage");
			dissociatePlanogramRailResponse.ErrorCode = _ctx.StringValue("DissociatePlanogramRail.ErrorCode");
			dissociatePlanogramRailResponse.Message = _ctx.StringValue("DissociatePlanogramRail.Message");
			dissociatePlanogramRailResponse.DynamicCode = _ctx.StringValue("DissociatePlanogramRail.DynamicCode");
			dissociatePlanogramRailResponse.Code = _ctx.StringValue("DissociatePlanogramRail.Code");
			dissociatePlanogramRailResponse.DynamicMessage = _ctx.StringValue("DissociatePlanogramRail.DynamicMessage");
			dissociatePlanogramRailResponse.RequestId = _ctx.StringValue("DissociatePlanogramRail.RequestId");
			dissociatePlanogramRailResponse.Success = _ctx.BooleanValue("DissociatePlanogramRail.Success");
        
			return dissociatePlanogramRailResponse;
        }
    }
}
