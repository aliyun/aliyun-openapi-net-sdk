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
    public class DescribePropertyCountResponseUnmarshaller
    {
        public static DescribePropertyCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyCountResponse describePropertyCountResponse = new DescribePropertyCountResponse();

			describePropertyCountResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyCountResponse.Process = _ctx.IntegerValue("DescribePropertyCount.Process");
			describePropertyCountResponse.RequestId = _ctx.StringValue("DescribePropertyCount.RequestId");
			describePropertyCountResponse.User = _ctx.IntegerValue("DescribePropertyCount.User");
			describePropertyCountResponse.Software = _ctx.IntegerValue("DescribePropertyCount.Software");
			describePropertyCountResponse.Cron = _ctx.IntegerValue("DescribePropertyCount.Cron");
			describePropertyCountResponse.Port = _ctx.IntegerValue("DescribePropertyCount.Port");
			describePropertyCountResponse.Sca = _ctx.IntegerValue("DescribePropertyCount.Sca");
			describePropertyCountResponse.Web = _ctx.IntegerValue("DescribePropertyCount.Web");
			describePropertyCountResponse.Database = _ctx.IntegerValue("DescribePropertyCount.Database");
			describePropertyCountResponse.Lkm = _ctx.IntegerValue("DescribePropertyCount.Lkm");
			describePropertyCountResponse.Autorun = _ctx.IntegerValue("DescribePropertyCount.Autorun");
			describePropertyCountResponse.Webserver = _ctx.IntegerValue("DescribePropertyCount.Webserver");
        
			return describePropertyCountResponse;
        }
    }
}
