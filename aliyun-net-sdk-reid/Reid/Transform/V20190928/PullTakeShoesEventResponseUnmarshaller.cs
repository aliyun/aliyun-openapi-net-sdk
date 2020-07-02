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
    public class PullTakeShoesEventResponseUnmarshaller
    {
        public static PullTakeShoesEventResponse Unmarshall(UnmarshallerContext context)
        {
			PullTakeShoesEventResponse pullTakeShoesEventResponse = new PullTakeShoesEventResponse();

			pullTakeShoesEventResponse.HttpResponse = context.HttpResponse;
			pullTakeShoesEventResponse.StartTime = context.LongValue("PullTakeShoesEvent.StartTime");
			pullTakeShoesEventResponse.ErrorCode = context.StringValue("PullTakeShoesEvent.ErrorCode");
			pullTakeShoesEventResponse.ErrorMessage = context.StringValue("PullTakeShoesEvent.ErrorMessage");
			pullTakeShoesEventResponse.StoreId = context.LongValue("PullTakeShoesEvent.StoreId");
			pullTakeShoesEventResponse.SkuId = context.StringValue("PullTakeShoesEvent.SkuId");
			pullTakeShoesEventResponse.TakeShoesEventCount = context.IntegerValue("PullTakeShoesEvent.TakeShoesEventCount");
			pullTakeShoesEventResponse.Message = context.StringValue("PullTakeShoesEvent.Message");
			pullTakeShoesEventResponse.Code = context.StringValue("PullTakeShoesEvent.Code");
			pullTakeShoesEventResponse.DynamicCode = context.StringValue("PullTakeShoesEvent.DynamicCode");
			pullTakeShoesEventResponse.RequestId = context.StringValue("PullTakeShoesEvent.RequestId");
			pullTakeShoesEventResponse.Success = context.BooleanValue("PullTakeShoesEvent.Success");
			pullTakeShoesEventResponse.DynamicMessage = context.StringValue("PullTakeShoesEvent.DynamicMessage");
        
			return pullTakeShoesEventResponse;
        }
    }
}
