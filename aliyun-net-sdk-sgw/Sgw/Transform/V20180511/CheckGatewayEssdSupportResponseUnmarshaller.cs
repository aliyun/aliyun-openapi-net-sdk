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
    public class CheckGatewayEssdSupportResponseUnmarshaller
    {
        public static CheckGatewayEssdSupportResponse Unmarshall(UnmarshallerContext context)
        {
			CheckGatewayEssdSupportResponse checkGatewayEssdSupportResponse = new CheckGatewayEssdSupportResponse();

			checkGatewayEssdSupportResponse.HttpResponse = context.HttpResponse;
			checkGatewayEssdSupportResponse.RequestId = context.StringValue("CheckGatewayEssdSupport.RequestId");
			checkGatewayEssdSupportResponse.Success = context.BooleanValue("CheckGatewayEssdSupport.Success");
			checkGatewayEssdSupportResponse.Code = context.StringValue("CheckGatewayEssdSupport.Code");
			checkGatewayEssdSupportResponse.Message = context.StringValue("CheckGatewayEssdSupport.Message");
			checkGatewayEssdSupportResponse.IsSupportEssd = context.BooleanValue("CheckGatewayEssdSupport.IsSupportEssd");
			checkGatewayEssdSupportResponse.IsServiceAffect = context.BooleanValue("CheckGatewayEssdSupport.IsServiceAffect");
        
			return checkGatewayEssdSupportResponse;
        }
    }
}
