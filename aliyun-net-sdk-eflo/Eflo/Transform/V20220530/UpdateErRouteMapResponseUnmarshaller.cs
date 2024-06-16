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
    public class UpdateErRouteMapResponseUnmarshaller
    {
        public static UpdateErRouteMapResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateErRouteMapResponse updateErRouteMapResponse = new UpdateErRouteMapResponse();

			updateErRouteMapResponse.HttpResponse = _ctx.HttpResponse;
			updateErRouteMapResponse.Code = _ctx.IntegerValue("UpdateErRouteMap.Code");
			updateErRouteMapResponse.Message = _ctx.StringValue("UpdateErRouteMap.Message");
			updateErRouteMapResponse.RequestId = _ctx.StringValue("UpdateErRouteMap.RequestId");
			updateErRouteMapResponse.Content = _ctx.StringValue("UpdateErRouteMap.Content");
        
			return updateErRouteMapResponse;
        }
    }
}
