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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class OpreateConstantsResponseUnmarshaller
    {
        public static OpreateConstantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OpreateConstantsResponse opreateConstantsResponse = new OpreateConstantsResponse();

			opreateConstantsResponse.HttpResponse = _ctx.HttpResponse;
			opreateConstantsResponse.TotalCount = _ctx.LongValue("OpreateConstants.TotalCount");
			opreateConstantsResponse.MasterData = _ctx.StringValue("OpreateConstants.MasterData");
			opreateConstantsResponse.PageSize = _ctx.LongValue("OpreateConstants.PageSize");
			opreateConstantsResponse.ZoneData = _ctx.StringValue("OpreateConstants.ZoneData");
			opreateConstantsResponse.RequestId = _ctx.StringValue("OpreateConstants.RequestId");
			opreateConstantsResponse.PageNumber = _ctx.LongValue("OpreateConstants.PageNumber");
			opreateConstantsResponse.AccessData = _ctx.StringValue("OpreateConstants.AccessData");
			opreateConstantsResponse.ProductCodeData = _ctx.StringValue("OpreateConstants.ProductCodeData");
			opreateConstantsResponse.OsversionData = _ctx.StringValue("OpreateConstants.OsversionData");
			opreateConstantsResponse.Data = _ctx.StringValue("OpreateConstants.Data");
			opreateConstantsResponse.RegionData = _ctx.StringValue("OpreateConstants.RegionData");
			opreateConstantsResponse.EndpointData = _ctx.StringValue("OpreateConstants.EndpointData");
        
			return opreateConstantsResponse;
        }
    }
}
