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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetDocIndexResponseUnmarshaller
    {
        public static GetDocIndexResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDocIndexResponse getDocIndexResponse = new GetDocIndexResponse();

			getDocIndexResponse.HttpResponse = _ctx.HttpResponse;
			getDocIndexResponse.RequestId = _ctx.StringValue("GetDocIndex.RequestId");
			getDocIndexResponse.IndexCreatedTime = _ctx.StringValue("GetDocIndex.IndexCreatedTime");
			getDocIndexResponse.IndexModifiedTime = _ctx.StringValue("GetDocIndex.IndexModifiedTime");
			getDocIndexResponse.UniqueId = _ctx.StringValue("GetDocIndex.UniqueId");
			getDocIndexResponse.SrcUri = _ctx.StringValue("GetDocIndex.SrcUri");
			getDocIndexResponse.Name = _ctx.StringValue("GetDocIndex.Name");
			getDocIndexResponse.ContentType = _ctx.StringValue("GetDocIndex.ContentType");
			getDocIndexResponse.LastModified = _ctx.StringValue("GetDocIndex.LastModified");
			getDocIndexResponse.Size = _ctx.LongValue("GetDocIndex.Size");
			getDocIndexResponse.PageNum = _ctx.LongValue("GetDocIndex.PageNum");
			getDocIndexResponse.CustomKey1 = _ctx.StringValue("GetDocIndex.CustomKey1");
			getDocIndexResponse.CustomKey2 = _ctx.StringValue("GetDocIndex.CustomKey2");
			getDocIndexResponse.CustomKey3 = _ctx.StringValue("GetDocIndex.CustomKey3");
			getDocIndexResponse.CustomKey4 = _ctx.StringValue("GetDocIndex.CustomKey4");
			getDocIndexResponse.CustomKey5 = _ctx.StringValue("GetDocIndex.CustomKey5");
			getDocIndexResponse.CustomKey6 = _ctx.StringValue("GetDocIndex.CustomKey6");
        
			return getDocIndexResponse;
        }
    }
}
