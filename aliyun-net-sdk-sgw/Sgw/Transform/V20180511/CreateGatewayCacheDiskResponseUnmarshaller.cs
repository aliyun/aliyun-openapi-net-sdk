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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class CreateGatewayCacheDiskResponseUnmarshaller
    {
        public static CreateGatewayCacheDiskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGatewayCacheDiskResponse createGatewayCacheDiskResponse = new CreateGatewayCacheDiskResponse();

			createGatewayCacheDiskResponse.HttpResponse = _ctx.HttpResponse;
			createGatewayCacheDiskResponse.BuyURL = _ctx.StringValue("CreateGatewayCacheDisk.BuyURL");
			createGatewayCacheDiskResponse.TaskId = _ctx.StringValue("CreateGatewayCacheDisk.TaskId");
			createGatewayCacheDiskResponse.RequestId = _ctx.StringValue("CreateGatewayCacheDisk.RequestId");
			createGatewayCacheDiskResponse.Message = _ctx.StringValue("CreateGatewayCacheDisk.Message");
			createGatewayCacheDiskResponse.Code = _ctx.StringValue("CreateGatewayCacheDisk.Code");
			createGatewayCacheDiskResponse.Success = _ctx.BooleanValue("CreateGatewayCacheDisk.Success");
        
			return createGatewayCacheDiskResponse;
        }
    }
}
