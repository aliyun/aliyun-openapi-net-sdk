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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class CreateClusterV2ResponseUnmarshaller
    {
        public static CreateClusterV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			CreateClusterV2Response createClusterV2Response = new CreateClusterV2Response();

			createClusterV2Response.HttpResponse = _ctx.HttpResponse;
			createClusterV2Response.RequestId = _ctx.StringValue("CreateClusterV2.RequestId");
			createClusterV2Response.ClusterId = _ctx.StringValue("CreateClusterV2.ClusterId");
			createClusterV2Response.EmrOrderId = _ctx.StringValue("CreateClusterV2.EmrOrderId");
			createClusterV2Response.MasterOrderId = _ctx.StringValue("CreateClusterV2.MasterOrderId");
			createClusterV2Response.CoreOrderId = _ctx.StringValue("CreateClusterV2.CoreOrderId");
        
			return createClusterV2Response;
        }
    }
}
