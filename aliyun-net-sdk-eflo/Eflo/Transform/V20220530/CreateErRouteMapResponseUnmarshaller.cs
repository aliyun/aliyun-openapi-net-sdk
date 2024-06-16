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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class CreateErRouteMapResponseUnmarshaller
    {
        public static CreateErRouteMapResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateErRouteMapResponse createErRouteMapResponse = new CreateErRouteMapResponse();

			createErRouteMapResponse.HttpResponse = _ctx.HttpResponse;
			createErRouteMapResponse.Code = _ctx.IntegerValue("CreateErRouteMap.Code");
			createErRouteMapResponse.Message = _ctx.StringValue("CreateErRouteMap.Message");
			createErRouteMapResponse.RequestId = _ctx.StringValue("CreateErRouteMap.RequestId");

			CreateErRouteMapResponse.CreateErRouteMap_Content content = new CreateErRouteMapResponse.CreateErRouteMap_Content();
			content.ErRouteMapId = _ctx.StringValue("CreateErRouteMap.Content.ErRouteMapId");
			createErRouteMapResponse.Content = content;
        
			return createErRouteMapResponse;
        }
    }
}
