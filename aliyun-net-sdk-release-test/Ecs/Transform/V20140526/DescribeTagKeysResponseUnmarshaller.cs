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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeTagKeysResponseUnmarshaller
    {
        public static DescribeTagKeysResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTagKeysResponse describeTagKeysResponse = new DescribeTagKeysResponse();

			describeTagKeysResponse.HttpResponse = context.HttpResponse;
			describeTagKeysResponse.RequestId = context.StringValue("DescribeTagKeys.RequestId");
			describeTagKeysResponse.PageSize = context.IntegerValue("DescribeTagKeys.PageSize");
			describeTagKeysResponse.PageNumber = context.IntegerValue("DescribeTagKeys.PageNumber");
			describeTagKeysResponse.TotalCount = context.IntegerValue("DescribeTagKeys.TotalCount");

			List<string> describeTagKeysResponse_tagKeys = new List<string>();
			for (int i = 0; i < context.Length("DescribeTagKeys.TagKeys.Length"); i++) {
				describeTagKeysResponse_tagKeys.Add(context.StringValue("DescribeTagKeys.TagKeys["+ i +"]"));
			}
			describeTagKeysResponse.TagKeys = describeTagKeysResponse_tagKeys;
        
			return describeTagKeysResponse;
        }
    }
}