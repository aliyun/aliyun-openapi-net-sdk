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
    public class UpdateNamespaceResponseUnmarshaller
    {
        public static UpdateNamespaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateNamespaceResponse updateNamespaceResponse = new UpdateNamespaceResponse();

			updateNamespaceResponse.HttpResponse = _ctx.HttpResponse;
			updateNamespaceResponse.RequestId = _ctx.StringValue("UpdateNamespace.RequestId");
			updateNamespaceResponse.Code = _ctx.StringValue("UpdateNamespace.Code");
			updateNamespaceResponse.ErrorCode = _ctx.StringValue("UpdateNamespace.ErrorCode");
			updateNamespaceResponse.Message = _ctx.StringValue("UpdateNamespace.Message");
			updateNamespaceResponse.Success = _ctx.BooleanValue("UpdateNamespace.Success");
			updateNamespaceResponse.TraceId = _ctx.StringValue("UpdateNamespace.TraceId");

			UpdateNamespaceResponse.UpdateNamespace_Data data = new UpdateNamespaceResponse.UpdateNamespace_Data();
			data.RegionId = _ctx.StringValue("UpdateNamespace.Data.RegionId");
			data.NamespaceId = _ctx.StringValue("UpdateNamespace.Data.NamespaceId");
			data.NamespaceName = _ctx.StringValue("UpdateNamespace.Data.NamespaceName");
			data.NamespaceDescription = _ctx.StringValue("UpdateNamespace.Data.NamespaceDescription");
			updateNamespaceResponse.Data = data;
        
			return updateNamespaceResponse;
        }
    }
}
