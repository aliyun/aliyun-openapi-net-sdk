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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class GetNamespaceResponseUnmarshaller
    {
        public static GetNamespaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNamespaceResponse getNamespaceResponse = new GetNamespaceResponse();

			getNamespaceResponse.HttpResponse = _ctx.HttpResponse;
			getNamespaceResponse.RequestId = _ctx.StringValue("GetNamespace.RequestId");

			GetNamespaceResponse.GetNamespace_Data data = new GetNamespaceResponse.GetNamespace_Data();
			data.Description = _ctx.StringValue("GetNamespace.Data.Description");
			data.PromptCount = _ctx.IntegerValue("GetNamespace.Data.PromptCount");
			data.CreatedTime = _ctx.StringValue("GetNamespace.Data.CreatedTime");
			data.SkillCount = _ctx.IntegerValue("GetNamespace.Data.SkillCount");
			data.Source = _ctx.StringValue("GetNamespace.Data.Source");
			data.Name = _ctx.StringValue("GetNamespace.Data.Name");
			data.PublicDomain = _ctx.StringValue("GetNamespace.Data.PublicDomain");
			data.SourceIndex = _ctx.IntegerValue("GetNamespace.Data.SourceIndex");
			data.IpWhitelist = _ctx.StringValue("GetNamespace.Data.IpWhitelist");
			data.ScanPolicy = _ctx.StringValue("GetNamespace.Data.ScanPolicy");
			data.PublicAccessEnabled = _ctx.BooleanValue("GetNamespace.Data.PublicAccessEnabled");
			data.NamespaceId = _ctx.StringValue("GetNamespace.Data.NamespaceId");
			data.Tags = _ctx.StringValue("GetNamespace.Data.Tags");
			getNamespaceResponse.Data = data;
        
			return getNamespaceResponse;
        }
    }
}
