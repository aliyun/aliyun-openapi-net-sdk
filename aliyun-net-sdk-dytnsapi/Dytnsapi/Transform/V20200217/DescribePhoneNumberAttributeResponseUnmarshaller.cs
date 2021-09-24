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
using Aliyun.Acs.Dytnsapi.Model.V20200217;

namespace Aliyun.Acs.Dytnsapi.Transform.V20200217
{
    public class DescribePhoneNumberAttributeResponseUnmarshaller
    {
        public static DescribePhoneNumberAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePhoneNumberAttributeResponse describePhoneNumberAttributeResponse = new DescribePhoneNumberAttributeResponse();

			describePhoneNumberAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describePhoneNumberAttributeResponse.Code = _ctx.StringValue("DescribePhoneNumberAttribute.Code");
			describePhoneNumberAttributeResponse.Message = _ctx.StringValue("DescribePhoneNumberAttribute.Message");
			describePhoneNumberAttributeResponse.RequestId = _ctx.StringValue("DescribePhoneNumberAttribute.RequestId");

			DescribePhoneNumberAttributeResponse.DescribePhoneNumberAttribute_PhoneNumberAttribute phoneNumberAttribute = new DescribePhoneNumberAttributeResponse.DescribePhoneNumberAttribute_PhoneNumberAttribute();
			phoneNumberAttribute.BasicCarrier = _ctx.StringValue("DescribePhoneNumberAttribute.PhoneNumberAttribute.BasicCarrier");
			phoneNumberAttribute.Carrier = _ctx.StringValue("DescribePhoneNumberAttribute.PhoneNumberAttribute.Carrier");
			phoneNumberAttribute.IsNumberPortability = _ctx.BooleanValue("DescribePhoneNumberAttribute.PhoneNumberAttribute.IsNumberPortability");
			phoneNumberAttribute.NumberSegment = _ctx.LongValue("DescribePhoneNumberAttribute.PhoneNumberAttribute.NumberSegment");
			phoneNumberAttribute.City = _ctx.StringValue("DescribePhoneNumberAttribute.PhoneNumberAttribute.City");
			phoneNumberAttribute.Province = _ctx.StringValue("DescribePhoneNumberAttribute.PhoneNumberAttribute.Province");
			describePhoneNumberAttributeResponse.PhoneNumberAttribute = phoneNumberAttribute;
        
			return describePhoneNumberAttributeResponse;
        }
    }
}
