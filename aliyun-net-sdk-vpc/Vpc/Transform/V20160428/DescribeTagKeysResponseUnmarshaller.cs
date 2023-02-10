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
    public class DescribeTagKeysResponseUnmarshaller
    {
        public static DescribeTagKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagKeysResponse describeTagKeysResponse = new DescribeTagKeysResponse();

			describeTagKeysResponse.HttpResponse = _ctx.HttpResponse;
			describeTagKeysResponse.NextToken = _ctx.StringValue("DescribeTagKeys.NextToken");
			describeTagKeysResponse.RequestId = _ctx.StringValue("DescribeTagKeys.RequestId");

			List<DescribeTagKeysResponse.DescribeTagKeys_TagKey> describeTagKeysResponse_tagKeys = new List<DescribeTagKeysResponse.DescribeTagKeys_TagKey>();
			for (int i = 0; i < _ctx.Length("DescribeTagKeys.TagKeys.Length"); i++) {
				DescribeTagKeysResponse.DescribeTagKeys_TagKey tagKey = new DescribeTagKeysResponse.DescribeTagKeys_TagKey();
				tagKey.Type = _ctx.StringValue("DescribeTagKeys.TagKeys["+ i +"].Type");
				tagKey.TagKey = _ctx.StringValue("DescribeTagKeys.TagKeys["+ i +"].TagKey");

				describeTagKeysResponse_tagKeys.Add(tagKey);
			}
			describeTagKeysResponse.TagKeys = describeTagKeysResponse_tagKeys;
        
			return describeTagKeysResponse;
        }
    }
}
