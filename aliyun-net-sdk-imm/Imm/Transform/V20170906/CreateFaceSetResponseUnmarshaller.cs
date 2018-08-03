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
    public class CreateFaceSetResponseUnmarshaller
    {
        public static CreateFaceSetResponse Unmarshall(UnmarshallerContext context)
        {
			CreateFaceSetResponse createFaceSetResponse = new CreateFaceSetResponse();

			createFaceSetResponse.HttpResponse = context.HttpResponse;
			createFaceSetResponse.RequestId = context.StringValue("CreateFaceSet.RequestId");
			createFaceSetResponse.SetId = context.StringValue("CreateFaceSet.SetId");
			createFaceSetResponse.Status = context.StringValue("CreateFaceSet.Status");
			createFaceSetResponse.Photos = context.LongValue("CreateFaceSet.Photos");
			createFaceSetResponse.CreateTime = context.StringValue("CreateFaceSet.CreateTime");
			createFaceSetResponse.ModifyTime = context.StringValue("CreateFaceSet.ModifyTime");
        
			return createFaceSetResponse;
        }
    }
}