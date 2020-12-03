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
    public class BindRoleToEdgeInstanceResponseUnmarshaller
    {
        public static BindRoleToEdgeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindRoleToEdgeInstanceResponse bindRoleToEdgeInstanceResponse = new BindRoleToEdgeInstanceResponse();

			bindRoleToEdgeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			bindRoleToEdgeInstanceResponse.RequestId = _ctx.StringValue("BindRoleToEdgeInstance.RequestId");
			bindRoleToEdgeInstanceResponse.Success = _ctx.BooleanValue("BindRoleToEdgeInstance.Success");
			bindRoleToEdgeInstanceResponse.Code = _ctx.StringValue("BindRoleToEdgeInstance.Code");
			bindRoleToEdgeInstanceResponse.ErrorMessage = _ctx.StringValue("BindRoleToEdgeInstance.ErrorMessage");
        
			return bindRoleToEdgeInstanceResponse;
        }
    }
}
