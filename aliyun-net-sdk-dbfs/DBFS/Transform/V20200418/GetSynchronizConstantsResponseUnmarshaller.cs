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
    public class GetSynchronizConstantsResponseUnmarshaller
    {
        public static GetSynchronizConstantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSynchronizConstantsResponse getSynchronizConstantsResponse = new GetSynchronizConstantsResponse();

			getSynchronizConstantsResponse.HttpResponse = _ctx.HttpResponse;
			getSynchronizConstantsResponse.RequestId = _ctx.StringValue("GetSynchronizConstants.RequestId");
			getSynchronizConstantsResponse.Data = _ctx.StringValue("GetSynchronizConstants.Data");
			getSynchronizConstantsResponse.PageSize = _ctx.LongValue("GetSynchronizConstants.PageSize");
			getSynchronizConstantsResponse.TotalCount = _ctx.LongValue("GetSynchronizConstants.TotalCount");
			getSynchronizConstantsResponse.PageNumber = _ctx.LongValue("GetSynchronizConstants.PageNumber");
			getSynchronizConstantsResponse.RegionData = _ctx.StringValue("GetSynchronizConstants.RegionData");
			getSynchronizConstantsResponse.ZoneData = _ctx.StringValue("GetSynchronizConstants.ZoneData");
			getSynchronizConstantsResponse.OsversionData = _ctx.StringValue("GetSynchronizConstants.OsversionData");
			getSynchronizConstantsResponse.ProductCodeData = _ctx.StringValue("GetSynchronizConstants.ProductCodeData");
			getSynchronizConstantsResponse.MasterData = _ctx.StringValue("GetSynchronizConstants.MasterData");
			getSynchronizConstantsResponse.EndpointData = _ctx.StringValue("GetSynchronizConstants.EndpointData");
			getSynchronizConstantsResponse.AccessData = _ctx.StringValue("GetSynchronizConstants.AccessData");
        
			return getSynchronizConstantsResponse;
        }
    }
}
