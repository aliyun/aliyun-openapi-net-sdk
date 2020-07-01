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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class GetMetadataAmountResponseUnmarshaller
    {
        public static GetMetadataAmountResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetadataAmountResponse getMetadataAmountResponse = new GetMetadataAmountResponse();

			getMetadataAmountResponse.HttpResponse = context.HttpResponse;
			getMetadataAmountResponse.RequestId = context.StringValue("GetMetadataAmount.RequestId");

			GetMetadataAmountResponse.GetMetadataAmount_Data data = new GetMetadataAmountResponse.GetMetadataAmount_Data();
			data.CurrentVirtualHosts = context.IntegerValue("GetMetadataAmount.Data.CurrentVirtualHosts");
			data.MaxVirtualHosts = context.IntegerValue("GetMetadataAmount.Data.MaxVirtualHosts");
			data.CurrentExchanges = context.IntegerValue("GetMetadataAmount.Data.CurrentExchanges");
			data.MaxExchanges = context.IntegerValue("GetMetadataAmount.Data.MaxExchanges");
			data.CurrentQueues = context.IntegerValue("GetMetadataAmount.Data.CurrentQueues");
			data.MaxQueues = context.IntegerValue("GetMetadataAmount.Data.MaxQueues");
			getMetadataAmountResponse.Data = data;
        
			return getMetadataAmountResponse;
        }
    }
}
