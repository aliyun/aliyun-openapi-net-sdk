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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeActivationCodeDetailsResponseUnmarshaller
    {
        public static DescribeActivationCodeDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActivationCodeDetailsResponse describeActivationCodeDetailsResponse = new DescribeActivationCodeDetailsResponse();

			describeActivationCodeDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeActivationCodeDetailsResponse.ActivateAt = _ctx.StringValue("DescribeActivationCodeDetails.ActivateAt");
			describeActivationCodeDetailsResponse.CertContentB64 = _ctx.StringValue("DescribeActivationCodeDetails.CertContentB64");
			describeActivationCodeDetailsResponse.Description = _ctx.StringValue("DescribeActivationCodeDetails.Description");
			describeActivationCodeDetailsResponse.ExpireAt = _ctx.StringValue("DescribeActivationCodeDetails.ExpireAt");
			describeActivationCodeDetailsResponse.GmtCreated = _ctx.StringValue("DescribeActivationCodeDetails.GmtCreated");
			describeActivationCodeDetailsResponse.GmtModified = _ctx.StringValue("DescribeActivationCodeDetails.GmtModified");
			describeActivationCodeDetailsResponse.Id = _ctx.IntegerValue("DescribeActivationCodeDetails.Id");
			describeActivationCodeDetailsResponse.MacAddress = _ctx.StringValue("DescribeActivationCodeDetails.MacAddress");
			describeActivationCodeDetailsResponse.Name = _ctx.StringValue("DescribeActivationCodeDetails.Name");
			describeActivationCodeDetailsResponse.RequestId = _ctx.StringValue("DescribeActivationCodeDetails.RequestId");
			describeActivationCodeDetailsResponse.SystemIdentifier = _ctx.StringValue("DescribeActivationCodeDetails.SystemIdentifier");
        
			return describeActivationCodeDetailsResponse;
        }
    }
}
