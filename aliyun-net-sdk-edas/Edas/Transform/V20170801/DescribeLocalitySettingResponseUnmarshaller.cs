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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class DescribeLocalitySettingResponseUnmarshaller
    {
        public static DescribeLocalitySettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLocalitySettingResponse describeLocalitySettingResponse = new DescribeLocalitySettingResponse();

			describeLocalitySettingResponse.HttpResponse = _ctx.HttpResponse;
			describeLocalitySettingResponse.RequestId = _ctx.StringValue("DescribeLocalitySetting.RequestId");
			describeLocalitySettingResponse.Message = _ctx.StringValue("DescribeLocalitySetting.Message");
			describeLocalitySettingResponse.HttpStatusCode = _ctx.IntegerValue("DescribeLocalitySetting.HttpStatusCode");
			describeLocalitySettingResponse.Code = _ctx.IntegerValue("DescribeLocalitySetting.Code");
			describeLocalitySettingResponse.Success = _ctx.BooleanValue("DescribeLocalitySetting.Success");

			DescribeLocalitySettingResponse.DescribeLocalitySetting_Data data = new DescribeLocalitySettingResponse.DescribeLocalitySetting_Data();
			data.Enabled = _ctx.BooleanValue("DescribeLocalitySetting.Data.Enabled");
			data.Threshold = _ctx.FloatValue("DescribeLocalitySetting.Data.Threshold");
			describeLocalitySettingResponse.Data = data;
        
			return describeLocalitySettingResponse;
        }
    }
}
