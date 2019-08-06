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
        public static GetDocIndexResponse Unmarshall(UnmarshallerContext context)
        {
			GetDocIndexResponse getDocIndexResponse = new GetDocIndexResponse();

			getDocIndexResponse.HttpResponse = context.HttpResponse;
			getDocIndexResponse.RequestId = context.StringValue("GetDocIndex.RequestId");
			getDocIndexResponse.IndexCreatedTime = context.StringValue("GetDocIndex.IndexCreatedTime");
			getDocIndexResponse.IndexModifiedTime = context.StringValue("GetDocIndex.IndexModifiedTime");
			getDocIndexResponse.UniqueId = context.StringValue("GetDocIndex.UniqueId");
			getDocIndexResponse.SrcUri = context.StringValue("GetDocIndex.SrcUri");
			getDocIndexResponse.Name = context.StringValue("GetDocIndex.Name");
			getDocIndexResponse.ContentType = context.StringValue("GetDocIndex.ContentType");
			getDocIndexResponse.LastModified = context.StringValue("GetDocIndex.LastModified");
			getDocIndexResponse.Size = context.LongValue("GetDocIndex.Size");
			getDocIndexResponse.PageNum = context.LongValue("GetDocIndex.PageNum");
			getDocIndexResponse.CustomKey1 = context.StringValue("GetDocIndex.CustomKey1");
			getDocIndexResponse.CustomKey2 = context.StringValue("GetDocIndex.CustomKey2");
			getDocIndexResponse.CustomKey3 = context.StringValue("GetDocIndex.CustomKey3");
			getDocIndexResponse.CustomKey4 = context.StringValue("GetDocIndex.CustomKey4");
			getDocIndexResponse.CustomKey5 = context.StringValue("GetDocIndex.CustomKey5");
			getDocIndexResponse.CustomKey6 = context.StringValue("GetDocIndex.CustomKey6");
        
			return getDocIndexResponse;
        }
    }
}
