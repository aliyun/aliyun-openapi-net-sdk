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
    public class ComposePlanogramPositionsResponseUnmarshaller
    {
        public static ComposePlanogramPositionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ComposePlanogramPositionsResponse composePlanogramPositionsResponse = new ComposePlanogramPositionsResponse();

			composePlanogramPositionsResponse.HttpResponse = _ctx.HttpResponse;
			composePlanogramPositionsResponse.ErrorMessage = _ctx.StringValue("ComposePlanogramPositions.ErrorMessage");
			composePlanogramPositionsResponse.ErrorCode = _ctx.StringValue("ComposePlanogramPositions.ErrorCode");
			composePlanogramPositionsResponse.Message = _ctx.StringValue("ComposePlanogramPositions.Message");
			composePlanogramPositionsResponse.DynamicCode = _ctx.StringValue("ComposePlanogramPositions.DynamicCode");
			composePlanogramPositionsResponse.Code = _ctx.StringValue("ComposePlanogramPositions.Code");
			composePlanogramPositionsResponse.DynamicMessage = _ctx.StringValue("ComposePlanogramPositions.DynamicMessage");
			composePlanogramPositionsResponse.RequestId = _ctx.StringValue("ComposePlanogramPositions.RequestId");
			composePlanogramPositionsResponse.Success = _ctx.BooleanValue("ComposePlanogramPositions.Success");
        
			return composePlanogramPositionsResponse;
        }
    }
}
