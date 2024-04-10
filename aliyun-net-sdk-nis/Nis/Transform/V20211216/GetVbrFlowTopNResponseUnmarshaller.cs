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
    public class GetVbrFlowTopNResponseUnmarshaller
    {
        public static GetVbrFlowTopNResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVbrFlowTopNResponse getVbrFlowTopNResponse = new GetVbrFlowTopNResponse();

			getVbrFlowTopNResponse.HttpResponse = _ctx.HttpResponse;
			getVbrFlowTopNResponse.RequestId = _ctx.StringValue("GetVbrFlowTopN.RequestId");

			List<GetVbrFlowTopNResponse.GetVbrFlowTopN_VbrFlowlogTopN> getVbrFlowTopNResponse_virtualBorderRouterFlowlogTopN = new List<GetVbrFlowTopNResponse.GetVbrFlowTopN_VbrFlowlogTopN>();
			for (int i = 0; i < _ctx.Length("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN.Length"); i++) {
				GetVbrFlowTopNResponse.GetVbrFlowTopN_VbrFlowlogTopN vbrFlowlogTopN = new GetVbrFlowTopNResponse.GetVbrFlowTopN_VbrFlowlogTopN();
				vbrFlowlogTopN.CloudRegion = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].CloudRegion");
				vbrFlowlogTopN.CloudIp = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].CloudIp");
				vbrFlowlogTopN.OtherIp = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].OtherIp");
				vbrFlowlogTopN.CloudPort = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].CloudPort");
				vbrFlowlogTopN.OtherPort = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].OtherPort");
				vbrFlowlogTopN.Protocol = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].Protocol");
				vbrFlowlogTopN.AttachmentId = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].AttachmentId");
				vbrFlowlogTopN.VirtualBorderRouterId = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].VirtualBorderRouterId");
				vbrFlowlogTopN.Bytes = _ctx.DoubleValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].Bytes");
				vbrFlowlogTopN.Packets = _ctx.DoubleValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].Packets");
				vbrFlowlogTopN.AccountId = _ctx.StringValue("GetVbrFlowTopN.VirtualBorderRouterFlowlogTopN["+ i +"].AccountId");

				getVbrFlowTopNResponse_virtualBorderRouterFlowlogTopN.Add(vbrFlowlogTopN);
			}
			getVbrFlowTopNResponse.VirtualBorderRouterFlowlogTopN = getVbrFlowTopNResponse_virtualBorderRouterFlowlogTopN;
        
			return getVbrFlowTopNResponse;
        }
    }
}
