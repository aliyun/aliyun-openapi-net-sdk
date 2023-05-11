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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryRecordUrlResponseUnmarshaller
    {
        public static QueryRecordUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordUrlResponse queryRecordUrlResponse = new QueryRecordUrlResponse();

			queryRecordUrlResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordUrlResponse.Code = _ctx.StringValue("QueryRecordUrl.Code");
			queryRecordUrlResponse.Data = _ctx.StringValue("QueryRecordUrl.Data");
			queryRecordUrlResponse.ErrorMessage = _ctx.StringValue("QueryRecordUrl.ErrorMessage");
			queryRecordUrlResponse.RequestId = _ctx.StringValue("QueryRecordUrl.RequestId");
			queryRecordUrlResponse.Success = _ctx.BooleanValue("QueryRecordUrl.Success");
        
			return queryRecordUrlResponse;
        }
    }
}
