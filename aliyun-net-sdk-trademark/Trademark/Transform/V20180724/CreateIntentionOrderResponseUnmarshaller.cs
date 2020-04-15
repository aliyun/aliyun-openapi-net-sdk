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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class CreateIntentionOrderResponseUnmarshaller
    {
        public static CreateIntentionOrderResponse Unmarshall(UnmarshallerContext context)
        {
			CreateIntentionOrderResponse createIntentionOrderResponse = new CreateIntentionOrderResponse();

			createIntentionOrderResponse.HttpResponse = context.HttpResponse;
			createIntentionOrderResponse.RequestId = context.StringValue("CreateIntentionOrder.RequestId");
			createIntentionOrderResponse.Success = context.BooleanValue("CreateIntentionOrder.Success");
			createIntentionOrderResponse.ErrorMsg = context.StringValue("CreateIntentionOrder.ErrorMsg");

			List<string> createIntentionOrderResponse_data = new List<string>();
			for (int i = 0; i < context.Length("CreateIntentionOrder.Data.Length"); i++) {
				createIntentionOrderResponse_data.Add(context.StringValue("CreateIntentionOrder.Data["+ i +"]"));
			}
			createIntentionOrderResponse.Data = createIntentionOrderResponse_data;
        
			return createIntentionOrderResponse;
        }
    }
}
