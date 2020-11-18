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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeUserInfoInChannelResponseUnmarshaller
    {
        public static DescribeUserInfoInChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserInfoInChannelResponse describeUserInfoInChannelResponse = new DescribeUserInfoInChannelResponse();

			describeUserInfoInChannelResponse.HttpResponse = _ctx.HttpResponse;
			describeUserInfoInChannelResponse.RequestId = _ctx.StringValue("DescribeUserInfoInChannel.RequestId");
			describeUserInfoInChannelResponse.Timestamp = _ctx.IntegerValue("DescribeUserInfoInChannel.Timestamp");
			describeUserInfoInChannelResponse.IsChannelExist = _ctx.BooleanValue("DescribeUserInfoInChannel.IsChannelExist");
			describeUserInfoInChannelResponse.IsInChannel = _ctx.BooleanValue("DescribeUserInfoInChannel.IsInChannel");

			List<DescribeUserInfoInChannelResponse.DescribeUserInfoInChannel_PropertyItem> describeUserInfoInChannelResponse_property = new List<DescribeUserInfoInChannelResponse.DescribeUserInfoInChannel_PropertyItem>();
			for (int i = 0; i < _ctx.Length("DescribeUserInfoInChannel.Property.Length"); i++) {
				DescribeUserInfoInChannelResponse.DescribeUserInfoInChannel_PropertyItem propertyItem = new DescribeUserInfoInChannelResponse.DescribeUserInfoInChannel_PropertyItem();
				propertyItem.Session = _ctx.StringValue("DescribeUserInfoInChannel.Property["+ i +"].Session");
				propertyItem.Join = _ctx.IntegerValue("DescribeUserInfoInChannel.Property["+ i +"].Join");
				propertyItem.Role = _ctx.IntegerValue("DescribeUserInfoInChannel.Property["+ i +"].Role");

				describeUserInfoInChannelResponse_property.Add(propertyItem);
			}
			describeUserInfoInChannelResponse.Property = describeUserInfoInChannelResponse_property;
        
			return describeUserInfoInChannelResponse;
        }
    }
}
