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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class IndexImageResponseUnmarshaller
    {
        public static IndexImageResponse Unmarshall(UnmarshallerContext context)
        {
			IndexImageResponse indexImageResponse = new IndexImageResponse();

			indexImageResponse.HttpResponse = context.HttpResponse;
			indexImageResponse.RequestId = context.StringValue("IndexImage.RequestId");
			indexImageResponse.SetId = context.StringValue("IndexImage.SetId");
			indexImageResponse.ImageUri = context.StringValue("IndexImage.ImageUri");
			indexImageResponse.RemarksA = context.StringValue("IndexImage.RemarksA");
			indexImageResponse.RemarksB = context.StringValue("IndexImage.RemarksB");
			indexImageResponse.CreateTime = context.StringValue("IndexImage.CreateTime");
			indexImageResponse.ModifyTime = context.StringValue("IndexImage.ModifyTime");
			indexImageResponse.RemarksC = context.StringValue("IndexImage.RemarksC");
			indexImageResponse.RemarksD = context.StringValue("IndexImage.RemarksD");
			indexImageResponse.ExternalId = context.StringValue("IndexImage.ExternalId");
        
			return indexImageResponse;
        }
    }
}