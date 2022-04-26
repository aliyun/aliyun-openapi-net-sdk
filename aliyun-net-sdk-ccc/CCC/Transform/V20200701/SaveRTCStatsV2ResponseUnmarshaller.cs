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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class SaveRTCStatsV2ResponseUnmarshaller
    {
        public static SaveRTCStatsV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			SaveRTCStatsV2Response saveRTCStatsV2Response = new SaveRTCStatsV2Response();

			saveRTCStatsV2Response.HttpResponse = _ctx.HttpResponse;
			saveRTCStatsV2Response.HttpStatusCode = _ctx.LongValue("SaveRTCStatsV2.HttpStatusCode");
			saveRTCStatsV2Response.RequestId = _ctx.StringValue("SaveRTCStatsV2.RequestId");
			saveRTCStatsV2Response.Success = _ctx.BooleanValue("SaveRTCStatsV2.Success");
			saveRTCStatsV2Response.Code = _ctx.StringValue("SaveRTCStatsV2.Code");
			saveRTCStatsV2Response.Message = _ctx.StringValue("SaveRTCStatsV2.Message");
			saveRTCStatsV2Response.TimeStamp = _ctx.LongValue("SaveRTCStatsV2.TimeStamp");
			saveRTCStatsV2Response.RowCount = _ctx.LongValue("SaveRTCStatsV2.RowCount");
        
			return saveRTCStatsV2Response;
        }
    }
}
