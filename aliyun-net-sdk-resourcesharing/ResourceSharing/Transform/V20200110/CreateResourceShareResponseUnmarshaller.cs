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
using Aliyun.Acs.ResourceSharing.Model.V20200110;

namespace Aliyun.Acs.ResourceSharing.Transform.V20200110
{
    public class CreateResourceShareResponseUnmarshaller
    {
        public static CreateResourceShareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateResourceShareResponse createResourceShareResponse = new CreateResourceShareResponse();

			createResourceShareResponse.HttpResponse = _ctx.HttpResponse;
			createResourceShareResponse.RequestId = _ctx.StringValue("CreateResourceShare.RequestId");

			CreateResourceShareResponse.CreateResourceShare_ResourceShare resourceShare = new CreateResourceShareResponse.CreateResourceShare_ResourceShare();
			resourceShare.UpdateTime = _ctx.StringValue("CreateResourceShare.ResourceShare.UpdateTime");
			resourceShare.ResourceShareName = _ctx.StringValue("CreateResourceShare.ResourceShare.ResourceShareName");
			resourceShare.ResourceShareOwner = _ctx.StringValue("CreateResourceShare.ResourceShare.ResourceShareOwner");
			resourceShare.CreateTime = _ctx.StringValue("CreateResourceShare.ResourceShare.CreateTime");
			resourceShare.ResourceShareId = _ctx.StringValue("CreateResourceShare.ResourceShare.ResourceShareId");
			resourceShare.ResourceShareStatus = _ctx.StringValue("CreateResourceShare.ResourceShare.ResourceShareStatus");
			resourceShare.AllowExternalTargets = _ctx.BooleanValue("CreateResourceShare.ResourceShare.AllowExternalTargets");
			createResourceShareResponse.ResourceShare = resourceShare;
        
			return createResourceShareResponse;
        }
    }
}
