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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class BindSceneRuleToEdgeInstanceResponseUnmarshaller
    {
        public static BindSceneRuleToEdgeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindSceneRuleToEdgeInstanceResponse bindSceneRuleToEdgeInstanceResponse = new BindSceneRuleToEdgeInstanceResponse();

			bindSceneRuleToEdgeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			bindSceneRuleToEdgeInstanceResponse.RequestId = _ctx.StringValue("BindSceneRuleToEdgeInstance.RequestId");
			bindSceneRuleToEdgeInstanceResponse.Success = _ctx.BooleanValue("BindSceneRuleToEdgeInstance.Success");
			bindSceneRuleToEdgeInstanceResponse.ErrorMessage = _ctx.StringValue("BindSceneRuleToEdgeInstance.ErrorMessage");
			bindSceneRuleToEdgeInstanceResponse.Code = _ctx.StringValue("BindSceneRuleToEdgeInstance.Code");
        
			return bindSceneRuleToEdgeInstanceResponse;
        }
    }
}
