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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeEIURangeResponseUnmarshaller
    {
        public static DescribeEIURangeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEIURangeResponse describeEIURangeResponse = new DescribeEIURangeResponse();

			describeEIURangeResponse.HttpResponse = _ctx.HttpResponse;
			describeEIURangeResponse.RequestId = _ctx.StringValue("DescribeEIURange.RequestId");

			DescribeEIURangeResponse.DescribeEIURange_EIUInfo eIUInfo = new DescribeEIURangeResponse.DescribeEIURange_EIUInfo();
			eIUInfo.DefaultValue = _ctx.StringValue("DescribeEIURange.EIUInfo.DefaultValue");

			List<string> eIUInfo_eIURange = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeEIURange.EIUInfo.EIURange.Length"); i++) {
				eIUInfo_eIURange.Add(_ctx.StringValue("DescribeEIURange.EIUInfo.EIURange["+ i +"]"));
			}
			eIUInfo.EIURange = eIUInfo_eIURange;

			List<string> eIUInfo_storageResourceRange = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeEIURange.EIUInfo.StorageResourceRange.Length"); i++) {
				eIUInfo_storageResourceRange.Add(_ctx.StringValue("DescribeEIURange.EIUInfo.StorageResourceRange["+ i +"]"));
			}
			eIUInfo.StorageResourceRange = eIUInfo_storageResourceRange;
			describeEIURangeResponse.EIUInfo = eIUInfo;
        
			return describeEIURangeResponse;
        }
    }
}
