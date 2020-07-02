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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class GetFootwearPositionResponseUnmarshaller
    {
        public static GetFootwearPositionResponse Unmarshall(UnmarshallerContext context)
        {
			GetFootwearPositionResponse getFootwearPositionResponse = new GetFootwearPositionResponse();

			getFootwearPositionResponse.HttpResponse = context.HttpResponse;
			getFootwearPositionResponse.ErrorCode = context.StringValue("GetFootwearPosition.ErrorCode");
			getFootwearPositionResponse.ErrorMessage = context.StringValue("GetFootwearPosition.ErrorMessage");
			getFootwearPositionResponse.Message = context.StringValue("GetFootwearPosition.Message");
			getFootwearPositionResponse.StartTime = context.LongValue("GetFootwearPosition.StartTime");
			getFootwearPositionResponse.Code = context.StringValue("GetFootwearPosition.Code");
			getFootwearPositionResponse.PositionNumber = context.IntegerValue("GetFootwearPosition.PositionNumber");
			getFootwearPositionResponse.DynamicCode = context.StringValue("GetFootwearPosition.DynamicCode");
			getFootwearPositionResponse.SkuId = context.StringValue("GetFootwearPosition.SkuId");
			getFootwearPositionResponse.RequestId = context.StringValue("GetFootwearPosition.RequestId");
			getFootwearPositionResponse.Success = context.BooleanValue("GetFootwearPosition.Success");
			getFootwearPositionResponse.StoreId = context.LongValue("GetFootwearPosition.StoreId");
			getFootwearPositionResponse.DynamicMessage = context.StringValue("GetFootwearPosition.DynamicMessage");
        
			return getFootwearPositionResponse;
        }
    }
}
