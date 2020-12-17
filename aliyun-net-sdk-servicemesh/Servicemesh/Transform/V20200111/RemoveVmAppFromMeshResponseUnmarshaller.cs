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
using Aliyun.Acs.servicemesh.Model.V20200111;

namespace Aliyun.Acs.servicemesh.Transform.V20200111
{
    public class RemoveVmAppFromMeshResponseUnmarshaller
    {
        public static RemoveVmAppFromMeshResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveVmAppFromMeshResponse removeVmAppFromMeshResponse = new RemoveVmAppFromMeshResponse();

			removeVmAppFromMeshResponse.HttpResponse = _ctx.HttpResponse;
			removeVmAppFromMeshResponse.RequestId = _ctx.StringValue("RemoveVmAppFromMesh.RequestId");
			removeVmAppFromMeshResponse.Data = _ctx.StringValue("RemoveVmAppFromMesh.Data");
        
			return removeVmAppFromMeshResponse;
        }
    }
}
