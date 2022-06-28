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
    public class DescribePhoneNumberOperatorAttributeResponseUnmarshaller
    {
        public static DescribePhoneNumberOperatorAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePhoneNumberOperatorAttributeResponse describePhoneNumberOperatorAttributeResponse = new DescribePhoneNumberOperatorAttributeResponse();

			describePhoneNumberOperatorAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describePhoneNumberOperatorAttributeResponse.Code = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.Code");
			describePhoneNumberOperatorAttributeResponse.Message = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.Message");
			describePhoneNumberOperatorAttributeResponse.RequestId = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.RequestId");

			DescribePhoneNumberOperatorAttributeResponse.DescribePhoneNumberOperatorAttribute_Data data = new DescribePhoneNumberOperatorAttributeResponse.DescribePhoneNumberOperatorAttribute_Data();
			data.BasicCarrier = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.Data.BasicCarrier");
			data.Carrier = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.Data.Carrier");
			data.IsNumberPortability = _ctx.BooleanValue("DescribePhoneNumberOperatorAttribute.Data.IsNumberPortability");
			data.NumberSegment = _ctx.LongValue("DescribePhoneNumberOperatorAttribute.Data.NumberSegment");
			data.City = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.Data.City");
			data.Province = _ctx.StringValue("DescribePhoneNumberOperatorAttribute.Data.Province");
			describePhoneNumberOperatorAttributeResponse.Data = data;
        
			return describePhoneNumberOperatorAttributeResponse;
        }
    }
}
