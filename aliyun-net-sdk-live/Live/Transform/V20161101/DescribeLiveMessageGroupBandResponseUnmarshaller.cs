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
    public class DescribeLiveMessageGroupBandResponseUnmarshaller
    {
        public static DescribeLiveMessageGroupBandResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveMessageGroupBandResponse describeLiveMessageGroupBandResponse = new DescribeLiveMessageGroupBandResponse();

			describeLiveMessageGroupBandResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveMessageGroupBandResponse.RequestId = _ctx.StringValue("DescribeLiveMessageGroupBand.RequestId");
			describeLiveMessageGroupBandResponse.GroupId = _ctx.StringValue("DescribeLiveMessageGroupBand.GroupId");
			describeLiveMessageGroupBandResponse.IsbannedAll = _ctx.BooleanValue("DescribeLiveMessageGroupBand.IsbannedAll");

			List<string> describeLiveMessageGroupBandResponse_bannedUserList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLiveMessageGroupBand.BannedUserList.Length"); i++) {
				describeLiveMessageGroupBandResponse_bannedUserList.Add(_ctx.StringValue("DescribeLiveMessageGroupBand.BannedUserList["+ i +"]"));
			}
			describeLiveMessageGroupBandResponse.BannedUserList = describeLiveMessageGroupBandResponse_bannedUserList;

			List<string> describeLiveMessageGroupBandResponse_unbannedUserList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLiveMessageGroupBand.UnbannedUserList.Length"); i++) {
				describeLiveMessageGroupBandResponse_unbannedUserList.Add(_ctx.StringValue("DescribeLiveMessageGroupBand.UnbannedUserList["+ i +"]"));
			}
			describeLiveMessageGroupBandResponse.UnbannedUserList = describeLiveMessageGroupBandResponse_unbannedUserList;
        
			return describeLiveMessageGroupBandResponse;
        }
    }
}
