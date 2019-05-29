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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class SmartAccessGatewayFillRestrictionsResponseUnmarshaller
    {
        public static SmartAccessGatewayFillRestrictionsResponse Unmarshall(UnmarshallerContext context)
        {
			SmartAccessGatewayFillRestrictionsResponse smartAccessGatewayFillRestrictionsResponse = new SmartAccessGatewayFillRestrictionsResponse();

			smartAccessGatewayFillRestrictionsResponse.HttpResponse = context.HttpResponse;
			smartAccessGatewayFillRestrictionsResponse.RequestId = context.StringValue("SmartAccessGatewayFillRestrictions.RequestId");
			smartAccessGatewayFillRestrictionsResponse.Data = context.StringValue("SmartAccessGatewayFillRestrictions.Data");
			smartAccessGatewayFillRestrictionsResponse.Code = context.StringValue("SmartAccessGatewayFillRestrictions.Code");
			smartAccessGatewayFillRestrictionsResponse.Success = context.BooleanValue("SmartAccessGatewayFillRestrictions.Success");
			smartAccessGatewayFillRestrictionsResponse.Message = context.StringValue("SmartAccessGatewayFillRestrictions.Message");
        
			return smartAccessGatewayFillRestrictionsResponse;
        }
    }
}
