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
using Aliyun.Acs.nis.Model.V20211216;

namespace Aliyun.Acs.nis.Transform.V20211216
{
    public class GetTransitRouterFlowTopNResponseUnmarshaller
    {
        public static GetTransitRouterFlowTopNResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTransitRouterFlowTopNResponse getTransitRouterFlowTopNResponse = new GetTransitRouterFlowTopNResponse();

			getTransitRouterFlowTopNResponse.HttpResponse = _ctx.HttpResponse;
			getTransitRouterFlowTopNResponse.RequestId = _ctx.StringValue("GetTransitRouterFlowTopN.RequestId");

			List<GetTransitRouterFlowTopNResponse.GetTransitRouterFlowTopN_TrFlowlogTopN> getTransitRouterFlowTopNResponse_transitRouterFlowTopN = new List<GetTransitRouterFlowTopNResponse.GetTransitRouterFlowTopN_TrFlowlogTopN>();
			for (int i = 0; i < _ctx.Length("GetTransitRouterFlowTopN.TransitRouterFlowTopN.Length"); i++) {
				GetTransitRouterFlowTopNResponse.GetTransitRouterFlowTopN_TrFlowlogTopN trFlowlogTopN = new GetTransitRouterFlowTopNResponse.GetTransitRouterFlowTopN_TrFlowlogTopN();
				trFlowlogTopN.AccountId = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].AccountId");
				trFlowlogTopN.CenId = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].CenId");
				trFlowlogTopN.ThisRegion = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].ThisRegion");
				trFlowlogTopN.ThisIp = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].ThisIp");
				trFlowlogTopN.ThisPort = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].ThisPort");
				trFlowlogTopN.OtherRegion = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].OtherRegion");
				trFlowlogTopN.OtherIp = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].OtherIp");
				trFlowlogTopN.OtherPort = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].OtherPort");
				trFlowlogTopN.Protocol = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].Protocol");
				trFlowlogTopN.StartTime = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].StartTime");
				trFlowlogTopN.EndTime = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].EndTime");
				trFlowlogTopN.Packets = _ctx.DoubleValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].Packets");
				trFlowlogTopN.Bytes = _ctx.DoubleValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].Bytes");
				trFlowlogTopN.BandwithPackageId = _ctx.StringValue("GetTransitRouterFlowTopN.TransitRouterFlowTopN["+ i +"].BandwithPackageId");

				getTransitRouterFlowTopNResponse_transitRouterFlowTopN.Add(trFlowlogTopN);
			}
			getTransitRouterFlowTopNResponse.TransitRouterFlowTopN = getTransitRouterFlowTopNResponse_transitRouterFlowTopN;
        
			return getTransitRouterFlowTopNResponse;
        }
    }
}
