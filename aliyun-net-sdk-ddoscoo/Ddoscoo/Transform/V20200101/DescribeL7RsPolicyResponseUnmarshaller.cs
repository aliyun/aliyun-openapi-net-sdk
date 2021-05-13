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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeL7RsPolicyResponseUnmarshaller
    {
        public static DescribeL7RsPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeL7RsPolicyResponse describeL7RsPolicyResponse = new DescribeL7RsPolicyResponse();

			describeL7RsPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeL7RsPolicyResponse.RequestId = _ctx.StringValue("DescribeL7RsPolicy.RequestId");
			describeL7RsPolicyResponse.ProxyMode = _ctx.StringValue("DescribeL7RsPolicy.ProxyMode");

			List<DescribeL7RsPolicyResponse.DescribeL7RsPolicy_AttributeItem> describeL7RsPolicyResponse_attributes = new List<DescribeL7RsPolicyResponse.DescribeL7RsPolicy_AttributeItem>();
			for (int i = 0; i < _ctx.Length("DescribeL7RsPolicy.Attributes.Length"); i++) {
				DescribeL7RsPolicyResponse.DescribeL7RsPolicy_AttributeItem attributeItem = new DescribeL7RsPolicyResponse.DescribeL7RsPolicy_AttributeItem();
				attributeItem.RsType = _ctx.IntegerValue("DescribeL7RsPolicy.Attributes["+ i +"].RsType");
				attributeItem.RealServer = _ctx.StringValue("DescribeL7RsPolicy.Attributes["+ i +"].RealServer");

				DescribeL7RsPolicyResponse.DescribeL7RsPolicy_AttributeItem.DescribeL7RsPolicy_Attribute attribute = new DescribeL7RsPolicyResponse.DescribeL7RsPolicy_AttributeItem.DescribeL7RsPolicy_Attribute();
				attribute.Weight = _ctx.IntegerValue("DescribeL7RsPolicy.Attributes["+ i +"].Attribute.Weight");
				attributeItem.Attribute = attribute;

				describeL7RsPolicyResponse_attributes.Add(attributeItem);
			}
			describeL7RsPolicyResponse.Attributes = describeL7RsPolicyResponse_attributes;
        
			return describeL7RsPolicyResponse;
        }
    }
}
