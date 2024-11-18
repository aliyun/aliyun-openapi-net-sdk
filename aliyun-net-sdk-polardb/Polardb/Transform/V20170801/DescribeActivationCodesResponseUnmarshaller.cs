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
    public class DescribeActivationCodesResponseUnmarshaller
    {
        public static DescribeActivationCodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActivationCodesResponse describeActivationCodesResponse = new DescribeActivationCodesResponse();

			describeActivationCodesResponse.HttpResponse = _ctx.HttpResponse;
			describeActivationCodesResponse.PageNumber = _ctx.IntegerValue("DescribeActivationCodes.PageNumber");
			describeActivationCodesResponse.PageRecordCount = _ctx.IntegerValue("DescribeActivationCodes.PageRecordCount");
			describeActivationCodesResponse.RequestId = _ctx.StringValue("DescribeActivationCodes.RequestId");
			describeActivationCodesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeActivationCodes.TotalRecordCount");

			List<DescribeActivationCodesResponse.DescribeActivationCodes_ActivationCodes> describeActivationCodesResponse_items = new List<DescribeActivationCodesResponse.DescribeActivationCodes_ActivationCodes>();
			for (int i = 0; i < _ctx.Length("DescribeActivationCodes.Items.Length"); i++) {
				DescribeActivationCodesResponse.DescribeActivationCodes_ActivationCodes activationCodes = new DescribeActivationCodesResponse.DescribeActivationCodes_ActivationCodes();
				activationCodes.ActivateAt = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].ActivateAt");
				activationCodes.Description = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].Description");
				activationCodes.ExpireAt = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].ExpireAt");
				activationCodes.GmtCreated = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].GmtCreated");
				activationCodes.GmtModified = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].GmtModified");
				activationCodes.Id = _ctx.IntegerValue("DescribeActivationCodes.Items["+ i +"].Id");
				activationCodes.MacAddress = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].MacAddress");
				activationCodes.Name = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].Name");
				activationCodes.SystemIdentifier = _ctx.StringValue("DescribeActivationCodes.Items["+ i +"].SystemIdentifier");

				describeActivationCodesResponse_items.Add(activationCodes);
			}
			describeActivationCodesResponse.Items = describeActivationCodesResponse_items;
        
			return describeActivationCodesResponse;
        }
    }
}
