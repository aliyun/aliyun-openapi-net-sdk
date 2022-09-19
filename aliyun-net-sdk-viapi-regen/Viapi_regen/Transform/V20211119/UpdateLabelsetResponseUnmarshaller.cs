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
    public class UpdateLabelsetResponseUnmarshaller
    {
        public static UpdateLabelsetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateLabelsetResponse updateLabelsetResponse = new UpdateLabelsetResponse();

			updateLabelsetResponse.HttpResponse = _ctx.HttpResponse;
			updateLabelsetResponse.Message = _ctx.StringValue("UpdateLabelset.Message");
			updateLabelsetResponse.RequestId = _ctx.StringValue("UpdateLabelset.RequestId");
			updateLabelsetResponse.Code = _ctx.StringValue("UpdateLabelset.Code");

			UpdateLabelsetResponse.UpdateLabelset_Data data = new UpdateLabelsetResponse.UpdateLabelset_Data();
			data.Id = _ctx.LongValue("UpdateLabelset.Data.Id");
			data.GmtCreate = _ctx.LongValue("UpdateLabelset.Data.GmtCreate");
			data.Name = _ctx.LongValue("UpdateLabelset.Data.Name");
			data.Description = _ctx.LongValue("UpdateLabelset.Data.Description");
			updateLabelsetResponse.Data = data;
        
			return updateLabelsetResponse;
        }
    }
}
