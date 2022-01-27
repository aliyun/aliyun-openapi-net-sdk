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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class CreateActivationResponseUnmarshaller
    {
        public static CreateActivationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateActivationResponse createActivationResponse = new CreateActivationResponse();

			createActivationResponse.HttpResponse = _ctx.HttpResponse;
			createActivationResponse.RequestId = _ctx.StringValue("CreateActivation.RequestId");
			createActivationResponse.ActivationCode = _ctx.StringValue("CreateActivation.ActivationCode");
			createActivationResponse.ActivationId = _ctx.StringValue("CreateActivation.ActivationId");
        
			return createActivationResponse;
        }
    }
}
