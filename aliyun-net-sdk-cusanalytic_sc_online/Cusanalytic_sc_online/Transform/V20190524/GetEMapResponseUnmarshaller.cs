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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetEMapResponseUnmarshaller
    {
        public static GetEMapResponse Unmarshall(UnmarshallerContext context)
        {
			GetEMapResponse getEMapResponse = new GetEMapResponse();

			getEMapResponse.HttpResponse = context.HttpResponse;
			getEMapResponse.StoreId = context.LongValue("GetEMap.StoreId");
			getEMapResponse.Name = context.StringValue("GetEMap.Name");
			getEMapResponse.Scale = context.FloatValue("GetEMap.Scale");
			getEMapResponse.LocationId = context.LongValue("GetEMap.LocationId");
			getEMapResponse.EMapId = context.LongValue("GetEMap.EMapId");
			getEMapResponse.ImageUrl = context.StringValue("GetEMap.ImageUrl");
        
			return getEMapResponse;
        }
    }
}
