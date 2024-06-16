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
    public class DescribeLiveCenterTransferResponseUnmarshaller
    {
        public static DescribeLiveCenterTransferResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveCenterTransferResponse describeLiveCenterTransferResponse = new DescribeLiveCenterTransferResponse();

			describeLiveCenterTransferResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveCenterTransferResponse.RequestId = _ctx.StringValue("DescribeLiveCenterTransfer.RequestId");

			List<DescribeLiveCenterTransferResponse.DescribeLiveCenterTransfer_LiveCenterTransferInfo> describeLiveCenterTransferResponse_liveCenterTransferInfoList = new List<DescribeLiveCenterTransferResponse.DescribeLiveCenterTransfer_LiveCenterTransferInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveCenterTransfer.LiveCenterTransferInfoList.Length"); i++) {
				DescribeLiveCenterTransferResponse.DescribeLiveCenterTransfer_LiveCenterTransferInfo liveCenterTransferInfo = new DescribeLiveCenterTransferResponse.DescribeLiveCenterTransfer_LiveCenterTransferInfo();
				liveCenterTransferInfo.AppName = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].AppName");
				liveCenterTransferInfo.DomainName = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].DomainName");
				liveCenterTransferInfo.DstUrl = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].DstUrl");
				liveCenterTransferInfo.EndTime = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].EndTime");
				liveCenterTransferInfo.StartTime = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].StartTime");
				liveCenterTransferInfo.StreamName = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].StreamName");
				liveCenterTransferInfo.TransferArgs = _ctx.StringValue("DescribeLiveCenterTransfer.LiveCenterTransferInfoList["+ i +"].TransferArgs");

				describeLiveCenterTransferResponse_liveCenterTransferInfoList.Add(liveCenterTransferInfo);
			}
			describeLiveCenterTransferResponse.LiveCenterTransferInfoList = describeLiveCenterTransferResponse_liveCenterTransferInfoList;
        
			return describeLiveCenterTransferResponse;
        }
    }
}
