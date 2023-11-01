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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class SaveQuickQueryResponseUnmarshaller
    {
        public static SaveQuickQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveQuickQueryResponse saveQuickQueryResponse = new SaveQuickQueryResponse();

			saveQuickQueryResponse.HttpResponse = _ctx.HttpResponse;
			saveQuickQueryResponse.Data = _ctx.BooleanValue("SaveQuickQuery.Data");
			saveQuickQueryResponse.Success = _ctx.BooleanValue("SaveQuickQuery.Success");
			saveQuickQueryResponse.Code = _ctx.IntegerValue("SaveQuickQuery.Code");
			saveQuickQueryResponse.Message = _ctx.StringValue("SaveQuickQuery.Message");
			saveQuickQueryResponse.ErrCode = _ctx.StringValue("SaveQuickQuery.ErrCode");
			saveQuickQueryResponse.RequestId = _ctx.StringValue("SaveQuickQuery.RequestId");
			saveQuickQueryResponse.DyCode = _ctx.StringValue("SaveQuickQuery.DyCode");
			saveQuickQueryResponse.DyMessage = _ctx.StringValue("SaveQuickQuery.DyMessage");
        
			return saveQuickQueryResponse;
        }
    }
}
