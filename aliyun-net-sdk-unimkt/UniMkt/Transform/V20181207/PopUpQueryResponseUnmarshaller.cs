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
using Aliyun.Acs.UniMkt.Model.V20181207;

namespace Aliyun.Acs.UniMkt.Transform.V20181207
{
    public class PopUpQueryResponseUnmarshaller
    {
        public static PopUpQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PopUpQueryResponse popUpQueryResponse = new PopUpQueryResponse();

			popUpQueryResponse.HttpResponse = _ctx.HttpResponse;
			popUpQueryResponse.Status = _ctx.BooleanValue("PopUpQuery.Status");
			popUpQueryResponse.Msg = _ctx.StringValue("PopUpQuery.Msg");
			popUpQueryResponse.ErrorCode = _ctx.StringValue("PopUpQuery.ErrorCode");
			popUpQueryResponse.RequestId = _ctx.StringValue("PopUpQuery.RequestId");
			popUpQueryResponse.Url = _ctx.StringValue("PopUpQuery.Url");
			popUpQueryResponse.UnionAmount = _ctx.StringValue("PopUpQuery.UnionAmount");
        
			return popUpQueryResponse;
        }
    }
}
