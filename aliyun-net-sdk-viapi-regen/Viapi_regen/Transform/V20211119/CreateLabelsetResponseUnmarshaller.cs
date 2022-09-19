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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class CreateLabelsetResponseUnmarshaller
    {
        public static CreateLabelsetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLabelsetResponse createLabelsetResponse = new CreateLabelsetResponse();

			createLabelsetResponse.HttpResponse = _ctx.HttpResponse;
			createLabelsetResponse.Message = _ctx.StringValue("CreateLabelset.Message");
			createLabelsetResponse.RequestId = _ctx.StringValue("CreateLabelset.RequestId");
			createLabelsetResponse.Code = _ctx.StringValue("CreateLabelset.Code");

			CreateLabelsetResponse.CreateLabelset_Data data = new CreateLabelsetResponse.CreateLabelset_Data();
			data.Id = _ctx.LongValue("CreateLabelset.Data.Id");
			data.GmtCreate = _ctx.LongValue("CreateLabelset.Data.GmtCreate");
			data.Name = _ctx.StringValue("CreateLabelset.Data.Name");
			data.Description = _ctx.StringValue("CreateLabelset.Data.Description");
			data.LabelType = _ctx.StringValue("CreateLabelset.Data.LabelType");
			data.Status = _ctx.StringValue("CreateLabelset.Data.Status");
			createLabelsetResponse.Data = data;
        
			return createLabelsetResponse;
        }
    }
}
