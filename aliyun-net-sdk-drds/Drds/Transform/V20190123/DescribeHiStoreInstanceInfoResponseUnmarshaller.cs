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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeHiStoreInstanceInfoResponseUnmarshaller
    {
        public static DescribeHiStoreInstanceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHiStoreInstanceInfoResponse describeHiStoreInstanceInfoResponse = new DescribeHiStoreInstanceInfoResponse();

			describeHiStoreInstanceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeHiStoreInstanceInfoResponse.RequestId = _ctx.StringValue("DescribeHiStoreInstanceInfo.RequestId");
			describeHiStoreInstanceInfoResponse.Success = _ctx.BooleanValue("DescribeHiStoreInstanceInfo.Success");

			DescribeHiStoreInstanceInfoResponse.DescribeHiStoreInstanceInfo_HiStoreInstanceInfo hiStoreInstanceInfo = new DescribeHiStoreInstanceInfoResponse.DescribeHiStoreInstanceInfo_HiStoreInstanceInfo();
			hiStoreInstanceInfo.HistoreInstanceId = _ctx.StringValue("DescribeHiStoreInstanceInfo.HiStoreInstanceInfo.HistoreInstanceId");
			hiStoreInstanceInfo.GmtCreate = _ctx.LongValue("DescribeHiStoreInstanceInfo.HiStoreInstanceInfo.GmtCreate");
			hiStoreInstanceInfo.RpmVersion = _ctx.StringValue("DescribeHiStoreInstanceInfo.HiStoreInstanceInfo.RpmVersion");
			hiStoreInstanceInfo.DiskSize = _ctx.IntegerValue("DescribeHiStoreInstanceInfo.HiStoreInstanceInfo.DiskSize");
			hiStoreInstanceInfo.MachineSpec = _ctx.StringValue("DescribeHiStoreInstanceInfo.HiStoreInstanceInfo.MachineSpec");
			describeHiStoreInstanceInfoResponse.HiStoreInstanceInfo = hiStoreInstanceInfo;
        
			return describeHiStoreInstanceInfoResponse;
        }
    }
}
