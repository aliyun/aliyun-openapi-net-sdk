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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ChangeDeployGroupResponseUnmarshaller
    {
        public static ChangeDeployGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChangeDeployGroupResponse changeDeployGroupResponse = new ChangeDeployGroupResponse();

			changeDeployGroupResponse.HttpResponse = _ctx.HttpResponse;
			changeDeployGroupResponse.Code = _ctx.IntegerValue("ChangeDeployGroup.Code");
			changeDeployGroupResponse.Message = _ctx.StringValue("ChangeDeployGroup.Message");
			changeDeployGroupResponse.ChangeOrderId = _ctx.StringValue("ChangeDeployGroup.ChangeOrderId");
			changeDeployGroupResponse.RequestId = _ctx.StringValue("ChangeDeployGroup.RequestId");
        
			return changeDeployGroupResponse;
        }
    }
}
