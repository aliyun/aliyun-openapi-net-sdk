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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeTagKeysForExpressConnectResponseUnmarshaller
    {
        public static DescribeTagKeysForExpressConnectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagKeysForExpressConnectResponse describeTagKeysForExpressConnectResponse = new DescribeTagKeysForExpressConnectResponse();

			describeTagKeysForExpressConnectResponse.HttpResponse = _ctx.HttpResponse;
			describeTagKeysForExpressConnectResponse.NextToken = _ctx.StringValue("DescribeTagKeysForExpressConnect.NextToken");
			describeTagKeysForExpressConnectResponse.RequestId = _ctx.StringValue("DescribeTagKeysForExpressConnect.RequestId");

			List<DescribeTagKeysForExpressConnectResponse.DescribeTagKeysForExpressConnect_TagKey> describeTagKeysForExpressConnectResponse_tagKeys = new List<DescribeTagKeysForExpressConnectResponse.DescribeTagKeysForExpressConnect_TagKey>();
			for (int i = 0; i < _ctx.Length("DescribeTagKeysForExpressConnect.TagKeys.Length"); i++) {
				DescribeTagKeysForExpressConnectResponse.DescribeTagKeysForExpressConnect_TagKey tagKey = new DescribeTagKeysForExpressConnectResponse.DescribeTagKeysForExpressConnect_TagKey();
				tagKey.Type = _ctx.StringValue("DescribeTagKeysForExpressConnect.TagKeys["+ i +"].Type");
				tagKey.TagKey = _ctx.StringValue("DescribeTagKeysForExpressConnect.TagKeys["+ i +"].TagKey");

				describeTagKeysForExpressConnectResponse_tagKeys.Add(tagKey);
			}
			describeTagKeysForExpressConnectResponse.TagKeys = describeTagKeysForExpressConnectResponse_tagKeys;
        
			return describeTagKeysForExpressConnectResponse;
        }
    }
}
