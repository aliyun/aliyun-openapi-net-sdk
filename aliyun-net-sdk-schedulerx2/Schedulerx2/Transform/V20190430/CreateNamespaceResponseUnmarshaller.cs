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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class CreateNamespaceResponseUnmarshaller
    {
        public static CreateNamespaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNamespaceResponse createNamespaceResponse = new CreateNamespaceResponse();

			createNamespaceResponse.HttpResponse = _ctx.HttpResponse;
			createNamespaceResponse.RequestId = _ctx.StringValue("CreateNamespace.RequestId");
			createNamespaceResponse.Code = _ctx.IntegerValue("CreateNamespace.Code");
			createNamespaceResponse.Message = _ctx.StringValue("CreateNamespace.Message");
			createNamespaceResponse.Success = _ctx.BooleanValue("CreateNamespace.Success");

			CreateNamespaceResponse.CreateNamespace_Data data = new CreateNamespaceResponse.CreateNamespace_Data();
			data.NamespaceUid = _ctx.StringValue("CreateNamespace.Data.NamespaceUid");
			createNamespaceResponse.Data = data;
        
			return createNamespaceResponse;
        }
    }
}
