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
    public class UnbindRoleFromEdgeInstanceResponseUnmarshaller
    {
        public static UnbindRoleFromEdgeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			UnbindRoleFromEdgeInstanceResponse unbindRoleFromEdgeInstanceResponse = new UnbindRoleFromEdgeInstanceResponse();

			unbindRoleFromEdgeInstanceResponse.HttpResponse = context.HttpResponse;
			unbindRoleFromEdgeInstanceResponse.RequestId = context.StringValue("UnbindRoleFromEdgeInstance.RequestId");
			unbindRoleFromEdgeInstanceResponse.Success = context.BooleanValue("UnbindRoleFromEdgeInstance.Success");
			unbindRoleFromEdgeInstanceResponse.Code = context.StringValue("UnbindRoleFromEdgeInstance.Code");
			unbindRoleFromEdgeInstanceResponse.ErrorMessage = context.StringValue("UnbindRoleFromEdgeInstance.ErrorMessage");
        
			return unbindRoleFromEdgeInstanceResponse;
        }
    }
}
