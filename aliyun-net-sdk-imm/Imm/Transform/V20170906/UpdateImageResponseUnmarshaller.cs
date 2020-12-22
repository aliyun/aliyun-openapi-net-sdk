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
    public class UpdateImageResponseUnmarshaller
    {
        public static UpdateImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateImageResponse updateImageResponse = new UpdateImageResponse();

			updateImageResponse.HttpResponse = _ctx.HttpResponse;
			updateImageResponse.RequestId = _ctx.StringValue("UpdateImage.RequestId");
			updateImageResponse.SetId = _ctx.StringValue("UpdateImage.SetId");
			updateImageResponse.ImageUri = _ctx.StringValue("UpdateImage.ImageUri");
			updateImageResponse.RemarksA = _ctx.StringValue("UpdateImage.RemarksA");
			updateImageResponse.RemarksB = _ctx.StringValue("UpdateImage.RemarksB");
			updateImageResponse.CreateTime = _ctx.StringValue("UpdateImage.CreateTime");
			updateImageResponse.ModifyTime = _ctx.StringValue("UpdateImage.ModifyTime");
			updateImageResponse.RemarksC = _ctx.StringValue("UpdateImage.RemarksC");
			updateImageResponse.RemarksD = _ctx.StringValue("UpdateImage.RemarksD");
			updateImageResponse.ExternalId = _ctx.StringValue("UpdateImage.ExternalId");
			updateImageResponse.RemarksArrayA = _ctx.StringValue("UpdateImage.RemarksArrayA");
			updateImageResponse.RemarksArrayB = _ctx.StringValue("UpdateImage.RemarksArrayB");
        
			return updateImageResponse;
        }
    }
}
