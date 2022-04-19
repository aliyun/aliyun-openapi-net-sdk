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
    public class DescribeInstallCodesResponseUnmarshaller
    {
        public static DescribeInstallCodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstallCodesResponse describeInstallCodesResponse = new DescribeInstallCodesResponse();

			describeInstallCodesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstallCodesResponse.RequestId = _ctx.StringValue("DescribeInstallCodes.RequestId");

			List<DescribeInstallCodesResponse.DescribeInstallCodes_InstallCode> describeInstallCodesResponse_installCodes = new List<DescribeInstallCodesResponse.DescribeInstallCodes_InstallCode>();
			for (int i = 0; i < _ctx.Length("DescribeInstallCodes.InstallCodes.Length"); i++) {
				DescribeInstallCodesResponse.DescribeInstallCodes_InstallCode installCode = new DescribeInstallCodesResponse.DescribeInstallCodes_InstallCode();
				installCode.OnlyImage = _ctx.BooleanValue("DescribeInstallCodes.InstallCodes["+ i +"].OnlyImage");
				installCode.CaptchaCode = _ctx.StringValue("DescribeInstallCodes.InstallCodes["+ i +"].CaptchaCode");
				installCode.GroupId = _ctx.LongValue("DescribeInstallCodes.InstallCodes["+ i +"].GroupId");
				installCode.GroupName = _ctx.StringValue("DescribeInstallCodes.InstallCodes["+ i +"].GroupName");
				installCode.ExpiredDate = _ctx.LongValue("DescribeInstallCodes.InstallCodes["+ i +"].ExpiredDate");
				installCode.VendorName = _ctx.StringValue("DescribeInstallCodes.InstallCodes["+ i +"].VendorName");
				installCode.Os = _ctx.StringValue("DescribeInstallCodes.InstallCodes["+ i +"].Os");
				installCode.Tag = _ctx.StringValue("DescribeInstallCodes.InstallCodes["+ i +"].Tag");
				installCode.Vendor = _ctx.IntegerValue("DescribeInstallCodes.InstallCodes["+ i +"].Vendor");

				describeInstallCodesResponse_installCodes.Add(installCode);
			}
			describeInstallCodesResponse.InstallCodes = describeInstallCodesResponse_installCodes;
        
			return describeInstallCodesResponse;
        }
    }
}
