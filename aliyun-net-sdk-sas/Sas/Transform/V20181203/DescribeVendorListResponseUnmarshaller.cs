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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeVendorListResponseUnmarshaller
    {
        public static DescribeVendorListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVendorListResponse describeVendorListResponse = new DescribeVendorListResponse();

			describeVendorListResponse.HttpResponse = _ctx.HttpResponse;
			describeVendorListResponse.RequestId = _ctx.StringValue("DescribeVendorList.RequestId");

			List<string> describeVendorListResponse_vendorNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeVendorList.VendorNameList.Length"); i++) {
				describeVendorListResponse_vendorNameList.Add(_ctx.StringValue("DescribeVendorList.VendorNameList["+ i +"]"));
			}
			describeVendorListResponse.VendorNameList = describeVendorListResponse_vendorNameList;
        
			return describeVendorListResponse;
        }
    }
}
