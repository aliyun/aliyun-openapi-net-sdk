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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class CreateNamespaceResponseUnmarshaller
    {
        public static CreateNamespaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNamespaceResponse createNamespaceResponse = new CreateNamespaceResponse();

			createNamespaceResponse.HttpResponse = _ctx.HttpResponse;
			createNamespaceResponse.RequestId = _ctx.StringValue("CreateNamespace.RequestId");
			createNamespaceResponse.Code = _ctx.StringValue("CreateNamespace.Code");
			createNamespaceResponse.ErrorCode = _ctx.StringValue("CreateNamespace.ErrorCode");
			createNamespaceResponse.Message = _ctx.StringValue("CreateNamespace.Message");
			createNamespaceResponse.Success = _ctx.BooleanValue("CreateNamespace.Success");
			createNamespaceResponse.TraceId = _ctx.StringValue("CreateNamespace.TraceId");

			CreateNamespaceResponse.CreateNamespace_Data data = new CreateNamespaceResponse.CreateNamespace_Data();
			data.RegionId = _ctx.StringValue("CreateNamespace.Data.RegionId");
			data.NamespaceId = _ctx.StringValue("CreateNamespace.Data.NamespaceId");
			data.NamespaceName = _ctx.StringValue("CreateNamespace.Data.NamespaceName");
			data.NamespaceDescription = _ctx.StringValue("CreateNamespace.Data.NamespaceDescription");
			createNamespaceResponse.Data = data;
        
			return createNamespaceResponse;
        }
    }
}
