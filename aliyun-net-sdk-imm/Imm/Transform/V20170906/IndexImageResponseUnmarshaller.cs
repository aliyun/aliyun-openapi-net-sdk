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
    public class IndexImageResponseUnmarshaller
    {
        public static IndexImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			IndexImageResponse indexImageResponse = new IndexImageResponse();

			indexImageResponse.HttpResponse = _ctx.HttpResponse;
			indexImageResponse.RemarksArrayB = _ctx.StringValue("IndexImage.RemarksArrayB");
			indexImageResponse.ModifyTime = _ctx.StringValue("IndexImage.ModifyTime");
			indexImageResponse.RemarksC = _ctx.StringValue("IndexImage.RemarksC");
			indexImageResponse.RemarksD = _ctx.StringValue("IndexImage.RemarksD");
			indexImageResponse.RequestId = _ctx.StringValue("IndexImage.RequestId");
			indexImageResponse.RemarksArrayA = _ctx.StringValue("IndexImage.RemarksArrayA");
			indexImageResponse.ExternalId = _ctx.StringValue("IndexImage.ExternalId");
			indexImageResponse.CreateTime = _ctx.StringValue("IndexImage.CreateTime");
			indexImageResponse.SetId = _ctx.StringValue("IndexImage.SetId");
			indexImageResponse.ImageUri = _ctx.StringValue("IndexImage.ImageUri");
			indexImageResponse.RemarksA = _ctx.StringValue("IndexImage.RemarksA");
			indexImageResponse.RemarksB = _ctx.StringValue("IndexImage.RemarksB");
        
			return indexImageResponse;
        }
    }
}
