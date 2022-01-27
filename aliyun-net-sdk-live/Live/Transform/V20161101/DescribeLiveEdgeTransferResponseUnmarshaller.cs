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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveEdgeTransferResponseUnmarshaller
    {
        public static DescribeLiveEdgeTransferResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveEdgeTransferResponse describeLiveEdgeTransferResponse = new DescribeLiveEdgeTransferResponse();

			describeLiveEdgeTransferResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveEdgeTransferResponse.RequestId = _ctx.StringValue("DescribeLiveEdgeTransfer.RequestId");
			describeLiveEdgeTransferResponse.DomainName = _ctx.StringValue("DescribeLiveEdgeTransfer.DomainName");
			describeLiveEdgeTransferResponse.AppName = _ctx.StringValue("DescribeLiveEdgeTransfer.AppName");
			describeLiveEdgeTransferResponse.StreamName = _ctx.StringValue("DescribeLiveEdgeTransfer.StreamName");
			describeLiveEdgeTransferResponse.TargetDomainList = _ctx.StringValue("DescribeLiveEdgeTransfer.TargetDomainList");
			describeLiveEdgeTransferResponse.TransferArgs = _ctx.StringValue("DescribeLiveEdgeTransfer.TransferArgs");
			describeLiveEdgeTransferResponse.HttpDns = _ctx.StringValue("DescribeLiveEdgeTransfer.HttpDns");
        
			return describeLiveEdgeTransferResponse;
        }
    }
}
