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
    public class UpdateResourceShareResponseUnmarshaller
    {
        public static UpdateResourceShareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateResourceShareResponse updateResourceShareResponse = new UpdateResourceShareResponse();

			updateResourceShareResponse.HttpResponse = _ctx.HttpResponse;
			updateResourceShareResponse.RequestId = _ctx.StringValue("UpdateResourceShare.RequestId");

			UpdateResourceShareResponse.UpdateResourceShare_ResourceShare resourceShare = new UpdateResourceShareResponse.UpdateResourceShare_ResourceShare();
			resourceShare.UpdateTime = _ctx.StringValue("UpdateResourceShare.ResourceShare.UpdateTime");
			resourceShare.ResourceShareName = _ctx.StringValue("UpdateResourceShare.ResourceShare.ResourceShareName");
			resourceShare.ResourceShareOwner = _ctx.StringValue("UpdateResourceShare.ResourceShare.ResourceShareOwner");
			resourceShare.CreateTime = _ctx.StringValue("UpdateResourceShare.ResourceShare.CreateTime");
			resourceShare.ResourceShareId = _ctx.StringValue("UpdateResourceShare.ResourceShare.ResourceShareId");
			resourceShare.ResourceShareStatus = _ctx.StringValue("UpdateResourceShare.ResourceShare.ResourceShareStatus");
			resourceShare.AllowExternalTargets = _ctx.BooleanValue("UpdateResourceShare.ResourceShare.AllowExternalTargets");
			updateResourceShareResponse.ResourceShare = resourceShare;
        
			return updateResourceShareResponse;
        }
    }
}
