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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeKeyPairsResponseUnmarshaller
    {
        public static DescribeKeyPairsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeKeyPairsResponse describeKeyPairsResponse = new DescribeKeyPairsResponse();

			describeKeyPairsResponse.HttpResponse = context.HttpResponse;
			describeKeyPairsResponse.RequestId = context.StringValue("DescribeKeyPairs.RequestId");
			describeKeyPairsResponse.TotalCount = context.IntegerValue("DescribeKeyPairs.TotalCount");
			describeKeyPairsResponse.PageNumber = context.IntegerValue("DescribeKeyPairs.PageNumber");
			describeKeyPairsResponse.PageSize = context.IntegerValue("DescribeKeyPairs.PageSize");

			List<DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair> describeKeyPairsResponse_keyPairs = new List<DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair>();
			for (int i = 0; i < context.Length("DescribeKeyPairs.KeyPairs.Length"); i++) {
				DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair keyPair = new DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair();
				keyPair.KeyPairName = context.StringValue("DescribeKeyPairs.KeyPairs["+ i +"].KeyPairName");
				keyPair.KeyPairFingerPrint = context.StringValue("DescribeKeyPairs.KeyPairs["+ i +"].KeyPairFingerPrint");
				keyPair.CreationTime = context.StringValue("DescribeKeyPairs.KeyPairs["+ i +"].CreationTime");
				keyPair.ResourceGroupId = context.StringValue("DescribeKeyPairs.KeyPairs["+ i +"].ResourceGroupId");

				List<DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair.DescribeKeyPairs_Tag> keyPair_tags = new List<DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair.DescribeKeyPairs_Tag>();
				for (int j = 0; j < context.Length("DescribeKeyPairs.KeyPairs["+ i +"].Tags.Length"); j++) {
					DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair.DescribeKeyPairs_Tag tag = new DescribeKeyPairsResponse.DescribeKeyPairs_KeyPair.DescribeKeyPairs_Tag();
					tag.TagKey = context.StringValue("DescribeKeyPairs.KeyPairs["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeKeyPairs.KeyPairs["+ i +"].Tags["+ j +"].TagValue");

					keyPair_tags.Add(tag);
				}
				keyPair.Tags = keyPair_tags;

				describeKeyPairsResponse_keyPairs.Add(keyPair);
			}
			describeKeyPairsResponse.KeyPairs = describeKeyPairsResponse_keyPairs;
        
			return describeKeyPairsResponse;
        }
    }
}
