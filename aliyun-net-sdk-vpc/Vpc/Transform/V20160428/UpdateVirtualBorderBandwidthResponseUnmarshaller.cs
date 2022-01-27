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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class UpdateVirtualBorderBandwidthResponseUnmarshaller
    {
        public static UpdateVirtualBorderBandwidthResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateVirtualBorderBandwidthResponse updateVirtualBorderBandwidthResponse = new UpdateVirtualBorderBandwidthResponse();

			updateVirtualBorderBandwidthResponse.HttpResponse = _ctx.HttpResponse;
			updateVirtualBorderBandwidthResponse.RequestId = _ctx.StringValue("UpdateVirtualBorderBandwidth.RequestId");
			updateVirtualBorderBandwidthResponse.Success = _ctx.BooleanValue("UpdateVirtualBorderBandwidth.Success");
			updateVirtualBorderBandwidthResponse.HttpStatusCode = _ctx.StringValue("UpdateVirtualBorderBandwidth.HttpStatusCode");
			updateVirtualBorderBandwidthResponse.Message = _ctx.StringValue("UpdateVirtualBorderBandwidth.Message");
			updateVirtualBorderBandwidthResponse.Code = _ctx.StringValue("UpdateVirtualBorderBandwidth.Code");
        
			return updateVirtualBorderBandwidthResponse;
        }
    }
}
