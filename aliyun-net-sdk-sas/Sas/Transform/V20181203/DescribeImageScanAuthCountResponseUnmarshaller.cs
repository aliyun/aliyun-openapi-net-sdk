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
    public class DescribeImageScanAuthCountResponseUnmarshaller
    {
        public static DescribeImageScanAuthCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageScanAuthCountResponse describeImageScanAuthCountResponse = new DescribeImageScanAuthCountResponse();

			describeImageScanAuthCountResponse.HttpResponse = _ctx.HttpResponse;
			describeImageScanAuthCountResponse.RequestId = _ctx.StringValue("DescribeImageScanAuthCount.RequestId");

			DescribeImageScanAuthCountResponse.DescribeImageScanAuthCount_ImageScan imageScan = new DescribeImageScanAuthCountResponse.DescribeImageScanAuthCount_ImageScan();
			imageScan.InstanceId = _ctx.StringValue("DescribeImageScanAuthCount.ImageScan.InstanceId");
			imageScan.ImageScanCapacity = _ctx.LongValue("DescribeImageScanAuthCount.ImageScan.ImageScanCapacity");
			imageScan.ScanCount = _ctx.LongValue("DescribeImageScanAuthCount.ImageScan.ScanCount");
			describeImageScanAuthCountResponse.ImageScan = imageScan;
        
			return describeImageScanAuthCountResponse;
        }
    }
}
