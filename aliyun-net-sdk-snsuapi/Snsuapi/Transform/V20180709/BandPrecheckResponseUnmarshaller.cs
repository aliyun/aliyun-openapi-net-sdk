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
using Aliyun.Acs.Snsuapi.Model.V20180709;

namespace Aliyun.Acs.Snsuapi.Transform.V20180709
{
    public class BandPrecheckResponseUnmarshaller
    {
        public static BandPrecheckResponse Unmarshall(UnmarshallerContext context)
        {
			BandPrecheckResponse bandPrecheckResponse = new BandPrecheckResponse();

			bandPrecheckResponse.HttpResponse = context.HttpResponse;
			bandPrecheckResponse.RequestId = context.StringValue("BandPrecheck.RequestId");
			bandPrecheckResponse.ResultCode = context.StringValue("BandPrecheck.ResultCode");
			bandPrecheckResponse.ResultMessage = context.StringValue("BandPrecheck.ResultMessage");

			BandPrecheckResponse.BandPrecheck_ResultModule resultModule = new BandPrecheckResponse.BandPrecheck_ResultModule();
			resultModule.BandId = context.LongValue("BandPrecheck.ResultModule.BandId");
			resultModule.UploadBandwidth = context.IntegerValue("BandPrecheck.ResultModule.UploadBandwidth");
			resultModule.DownloadBandwidth = context.IntegerValue("BandPrecheck.ResultModule.DownloadBandwidth");

			List<BandPrecheckResponse.BandPrecheck_ResultModule.BandPrecheck_BandOfferListItem> resultModule_bandOfferList = new List<BandPrecheckResponse.BandPrecheck_ResultModule.BandPrecheck_BandOfferListItem>();
			for (int i = 0; i < context.Length("BandPrecheck.ResultModule.BandOfferList.Length"); i++) {
				BandPrecheckResponse.BandPrecheck_ResultModule.BandPrecheck_BandOfferListItem bandOfferListItem = new BandPrecheckResponse.BandPrecheck_ResultModule.BandPrecheck_BandOfferListItem();
				bandOfferListItem.OfferId = context.LongValue("BandPrecheck.ResultModule.BandOfferList["+ i +"].OfferId");
				bandOfferListItem.Bandwidth = context.IntegerValue("BandPrecheck.ResultModule.BandOfferList["+ i +"].Bandwidth");
				bandOfferListItem.Duration = context.LongValue("BandPrecheck.ResultModule.BandOfferList["+ i +"].Duration");
				bandOfferListItem.Direction = context.StringValue("BandPrecheck.ResultModule.BandOfferList["+ i +"].Direction");

				resultModule_bandOfferList.Add(bandOfferListItem);
			}
			resultModule.BandOfferList = resultModule_bandOfferList;
			bandPrecheckResponse.ResultModule = resultModule;
        
			return bandPrecheckResponse;
        }
    }
}
