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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class CountNodesByNodeGroupIdResponseUnmarshaller
    {
        public static CountNodesByNodeGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CountNodesByNodeGroupIdResponse countNodesByNodeGroupIdResponse = new CountNodesByNodeGroupIdResponse();

			countNodesByNodeGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			countNodesByNodeGroupIdResponse.RequestId = _ctx.StringValue("CountNodesByNodeGroupId.RequestId");
			countNodesByNodeGroupIdResponse.Success = _ctx.BooleanValue("CountNodesByNodeGroupId.Success");
			countNodesByNodeGroupIdResponse.Data = _ctx.LongValue("CountNodesByNodeGroupId.Data");
        
			return countNodesByNodeGroupIdResponse;
        }
    }
}
