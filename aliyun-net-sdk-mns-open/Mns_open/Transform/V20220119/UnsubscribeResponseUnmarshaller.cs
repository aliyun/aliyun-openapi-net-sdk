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
using Aliyun.Acs.Mns_open.Model.V20220119;

namespace Aliyun.Acs.Mns_open.Transform.V20220119
{
    public class UnsubscribeResponseUnmarshaller
    {
        public static UnsubscribeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnsubscribeResponse unsubscribeResponse = new UnsubscribeResponse();

			unsubscribeResponse.HttpResponse = _ctx.HttpResponse;
			unsubscribeResponse.RequestId = _ctx.StringValue("Unsubscribe.RequestId");
			unsubscribeResponse.Code = _ctx.LongValue("Unsubscribe.Code");
			unsubscribeResponse.Status = _ctx.StringValue("Unsubscribe.Status");
			unsubscribeResponse.Message = _ctx.StringValue("Unsubscribe.Message");
			unsubscribeResponse.Success = _ctx.BooleanValue("Unsubscribe.Success");

			UnsubscribeResponse.Unsubscribe_Data data = new UnsubscribeResponse.Unsubscribe_Data();
			data.Code = _ctx.LongValue("Unsubscribe.Data.Code");
			data.Message = _ctx.StringValue("Unsubscribe.Data.Message");
			data.Success = _ctx.BooleanValue("Unsubscribe.Data.Success");
			unsubscribeResponse.Data = data;
        
			return unsubscribeResponse;
        }
    }
}
