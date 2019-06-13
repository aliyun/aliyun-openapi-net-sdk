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
using Aliyun.Acs.Netana.Model.V20181018;

namespace Aliyun.Acs.Netana.Transform.V20181018
{
    public class CreateNetworkDiagnosticResponseUnmarshaller
    {
        public static CreateNetworkDiagnosticResponse Unmarshall(UnmarshallerContext context)
        {
			CreateNetworkDiagnosticResponse createNetworkDiagnosticResponse = new CreateNetworkDiagnosticResponse();

			createNetworkDiagnosticResponse.HttpResponse = context.HttpResponse;
			createNetworkDiagnosticResponse.RequestId = context.StringValue("CreateNetworkDiagnostic.RequestId");
			createNetworkDiagnosticResponse.Status = context.StringValue("CreateNetworkDiagnostic.Status");
			createNetworkDiagnosticResponse.Tpl = context.StringValue("CreateNetworkDiagnostic.Tpl");
			createNetworkDiagnosticResponse._Params = context.StringValue("CreateNetworkDiagnostic.Params");
        
			return createNetworkDiagnosticResponse;
        }
    }
}
