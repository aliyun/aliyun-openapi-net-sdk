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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeEslDeviceResponseUnmarshaller
    {
        public static DescribeEslDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEslDeviceResponse describeEslDeviceResponse = new DescribeEslDeviceResponse();

			describeEslDeviceResponse.HttpResponse = _ctx.HttpResponse;
			describeEslDeviceResponse.TotalCount = _ctx.LongValue("DescribeEslDevice.TotalCount");
			describeEslDeviceResponse.PageSize = _ctx.LongValue("DescribeEslDevice.PageSize");
			describeEslDeviceResponse.RequestId = _ctx.StringValue("DescribeEslDevice.RequestId");
			describeEslDeviceResponse.PageNumber = _ctx.LongValue("DescribeEslDevice.PageNumber");
			describeEslDeviceResponse.Success = _ctx.BooleanValue("DescribeEslDevice.Success");

			List<DescribeEslDeviceResponse.DescribeEslDevice_EslDetailsItem> describeEslDeviceResponse_eslDetails = new List<DescribeEslDeviceResponse.DescribeEslDevice_EslDetailsItem>();
			for (int i = 0; i < _ctx.Length("DescribeEslDevice.EslDetails.Length"); i++) {
				DescribeEslDeviceResponse.DescribeEslDevice_EslDetailsItem eslDetailsItem = new DescribeEslDeviceResponse.DescribeEslDevice_EslDetailsItem();
				eslDetailsItem.EslBarCode = _ctx.StringValue("DescribeEslDevice.EslDetails["+ i +"].EslBarCode");
				eslDetailsItem.LastUpdateTime = _ctx.StringValue("DescribeEslDevice.EslDetails["+ i +"].LastUpdateTime");
				eslDetailsItem.ItemBarCode = _ctx.LongValue("DescribeEslDevice.EslDetails["+ i +"].ItemBarCode");
				eslDetailsItem.ItemId = _ctx.LongValue("DescribeEslDevice.EslDetails["+ i +"].ItemId");
				eslDetailsItem.ItemShortTitle = _ctx.StringValue("DescribeEslDevice.EslDetails["+ i +"].ItemShortTitle");
				eslDetailsItem.Status = _ctx.StringValue("DescribeEslDevice.EslDetails["+ i +"].Status");
				eslDetailsItem.StoreId = _ctx.StringValue("DescribeEslDevice.EslDetails["+ i +"].StoreId");

				describeEslDeviceResponse_eslDetails.Add(eslDetailsItem);
			}
			describeEslDeviceResponse.EslDetails = describeEslDeviceResponse_eslDetails;
        
			return describeEslDeviceResponse;
        }
    }
}
