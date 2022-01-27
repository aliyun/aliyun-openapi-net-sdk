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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryThingModelExtendConfigPublishedResponseUnmarshaller
    {
        public static QueryThingModelExtendConfigPublishedResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryThingModelExtendConfigPublishedResponse queryThingModelExtendConfigPublishedResponse = new QueryThingModelExtendConfigPublishedResponse();

			queryThingModelExtendConfigPublishedResponse.HttpResponse = _ctx.HttpResponse;
			queryThingModelExtendConfigPublishedResponse.RequestId = _ctx.StringValue("QueryThingModelExtendConfigPublished.RequestId");
			queryThingModelExtendConfigPublishedResponse.Success = _ctx.BooleanValue("QueryThingModelExtendConfigPublished.Success");
			queryThingModelExtendConfigPublishedResponse.Code = _ctx.StringValue("QueryThingModelExtendConfigPublished.Code");
			queryThingModelExtendConfigPublishedResponse.ErrorMessage = _ctx.StringValue("QueryThingModelExtendConfigPublished.ErrorMessage");

			QueryThingModelExtendConfigPublishedResponse.QueryThingModelExtendConfigPublished_Data data = new QueryThingModelExtendConfigPublishedResponse.QueryThingModelExtendConfigPublished_Data();
			data.Configuration = _ctx.StringValue("QueryThingModelExtendConfigPublished.Data.Configuration");
			queryThingModelExtendConfigPublishedResponse.Data = data;
        
			return queryThingModelExtendConfigPublishedResponse;
        }
    }
}
